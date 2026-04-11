using System.Collections.Immutable;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;

namespace Avalonia.Markup.Declarative.SourceGenerator;

internal static class SymbolUtilities
{
    internal const string NewLine = "\n";

    private static readonly HashSet<string> AutoFrameworkAssemblies =
    [
        "Avalonia.Base",
        "Avalonia.Controls",
        "Avalonia.Markup",
        "Avalonia.Themes.Fluent",
    ];

    private static readonly SymbolDisplayFormat FullyQualifiedGlobalFormat =
        new(
            globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.Included,
            typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces,
            genericsOptions:
                SymbolDisplayGenericsOptions.IncludeTypeParameters |
                SymbolDisplayGenericsOptions.IncludeVariance,
            miscellaneousOptions:
                SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                SymbolDisplayMiscellaneousOptions.IncludeNullableReferenceTypeModifier
        );

    internal static ImmutableArray<IAssemblySymbol> GetTargetAssemblies(Compilation compilation)
    {
        var result = new HashSet<IAssemblySymbol>(SymbolEqualityComparer.Default);

        foreach (var reference in compilation.References)
        {
            if (compilation.GetAssemblyOrModuleSymbol(reference) is IAssemblySymbol assembly &&
                AutoFrameworkAssemblies.Contains(assembly.Name))
            {
                result.Add(assembly);
            }
        }

        foreach (var attribute in compilation.Assembly.GetAttributes())
        {
            if (attribute.AttributeClass?.ToDisplayString() != "Avalonia.Markup.Declarative.GenerateMarkupExtensionsForAssemblyAttribute")
            {
                continue;
            }

            if (attribute.ConstructorArguments.Length == 0)
            {
                continue;
            }

            if (attribute.ConstructorArguments[0].Value is INamedTypeSymbol anchorType)
            {
                result.Add(anchorType.ContainingAssembly);
            }
        }

        return [.. result.OrderBy(static x => x.Name)];
    }

    internal static IEnumerable<INamedTypeSymbol> GetPublicClasses(INamespaceSymbol sym)
    {
        foreach (var typeMember in sym.GetTypeMembers())
        {
            if (typeMember.DeclaredAccessibility == Accessibility.Public &&
                typeMember.TypeKind == TypeKind.Class &&
                !typeMember.IsGenericType)
            {
                yield return typeMember;
            }
        }

        foreach (var namespaceMember in sym.GetNamespaceMembers())
        {
            foreach (var publicClass in GetPublicClasses(namespaceMember))
            {
                yield return publicClass;
            }
        }
    }

    internal static IEnumerable<ISymbol> GetAllMembers(this INamedTypeSymbol type)
    {
        var seen = new HashSet<string>();
        var stack = new Stack<INamedTypeSymbol>();
        stack.Push(type);

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            foreach (var member in current.GetMembers())
            {
                if (seen.Add(member.ToDisplayString()))
                {
                    yield return member;
                }
            }

            if (current.BaseType != null)
            {
                stack.Push(current.BaseType);
            }

            foreach (var iface in current.Interfaces)
            {
                stack.Push(iface);
            }
        }
    }

    internal static bool IsOrInheritsFrom(this ITypeSymbol? symbol, string metadataName)
    {
        while (symbol != null)
        {
            if (GetMetadataName(symbol) == metadataName)
            {
                return true;
            }

            symbol = symbol.BaseType;
        }

        return false;
    }

    internal static bool IsStyledElement(this INamedTypeSymbol controlType) =>
        controlType.IsOrInheritsFrom("Avalonia.StyledElement");

    internal static string GetStyleConstraintTypeName(this ITypeSymbol controlType) =>
        controlType.IsOrInheritsFrom("Avalonia.StyledElement")
            ? controlType.GetFullTypeName()
            : "global::Avalonia.StyledElement";

    internal static bool HasPublicSetter(this IPropertySymbol? property) =>
        property?.SetMethod != null && property.SetMethod.DeclaredAccessibility == Accessibility.Public;

    internal static bool HasAccessibleParameterlessConstructor(this INamedTypeSymbol type)
    {
        foreach (var constructor in type.InstanceConstructors)
        {
            if (constructor.Parameters.Length != 0)
            {
                continue;
            }

            if (constructor.DeclaredAccessibility is Accessibility.Public or Accessibility.Internal or Accessibility.ProtectedOrInternal)
            {
                return true;
            }
        }

        return false;
    }

    internal static bool IsAccessibleFromGeneratedCode(this INamedTypeSymbol type)
    {
        INamedTypeSymbol? current = type;
        while (current != null)
        {
            if (current.DeclaredAccessibility is not (Accessibility.Public or Accessibility.Internal or Accessibility.ProtectedOrInternal))
            {
                return false;
            }

            current = current.ContainingType;
        }

        return true;
    }

    internal static bool IsAvaloniaPropertyField(this IFieldSymbol field)
    {
        if (field.IsObsolete())
        {
            return false;
        }

        if (field.Type.Name.StartsWith("DirectProperty") ||
            field.Type.Name.StartsWith("StyledProperty") ||
            field.Type.Name.StartsWith("AttachedProperty") ||
            field.Type.Name.StartsWith("AvaloniaProperty"))
        {
            return !field.IsReadOnlyField();
        }

        return false;
    }

    internal static bool IsAttachedPropertyField(this IFieldSymbol field)
    {
        if (field.IsObsolete())
        {
            return false;
        }

        return field.Type.Name.StartsWith("AttachedProperty") && !field.IsReadOnlyAttachedField();
    }

    internal static bool IsAcceptableStyledField(this IFieldSymbol field)
    {
        if (field.IsObsolete())
        {
            return false;
        }

        if (field.Type.Name.StartsWith("StyledProperty") || field.Type.Name.StartsWith("AttachedProperty"))
        {
            return !field.IsReadOnlyField();
        }

        return false;
    }

    internal static bool HasUnsupportedExternalValueType(this IFieldSymbol field)
    {
        var valueTypeName = field.Type.GetLastGenericArgument().GetFullTypeName();
        return valueTypeName is "global::Avalonia.Data.IBinding" or "global::Avalonia.Data.IBinding?";
    }

    internal static bool IsReadOnlyField(this IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var propertyName = field.GetMemberName();
        var symbol = controlType?.GetMembers(propertyName).FirstOrDefault();

        return symbol is not IPropertySymbol property || !property.HasPublicSetter();
    }

    internal static bool IsReadOnlyAttachedField(this IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var setterMethodName = "Set" + field.GetMemberName();
        var symbol = controlType?.GetMembers(setterMethodName).FirstOrDefault();

        return symbol is not IMethodSymbol method ||
               method.DeclaredAccessibility != Accessibility.Public ||
               !method.IsStatic;
    }

    internal static bool IsObsolete(this ISymbol symbol) =>
        symbol.GetAttributes().Any(static x => x.AttributeClass?.Name == nameof(ObsoleteAttribute));

    internal static string GetMemberName(this IFieldSymbol field)
    {
        if (field.AssociatedSymbol != null)
        {
            return RemoveTrailingProperty(field.AssociatedSymbol.Name);
        }

        return RemoveTrailingProperty(field.Name);
    }

    internal static string RemoveTrailingProperty(string source) =>
        source.EndsWith("Property") ? source.Substring(0, source.Length - "Property".Length) : source;

    internal static string GetFullTypeName(this ITypeSymbol symbol)
    {
        var fullName = symbol.ToDisplayString(FullyQualifiedGlobalFormat);

        if (!fullName.EndsWith("?") && symbol.NullableAnnotation == NullableAnnotation.Annotated)
        {
            fullName += "?";
        }

        return fullName;
    }

    internal static ITypeSymbol GetLastGenericArgument(this ITypeSymbol type)
    {
        if (type is INamedTypeSymbol namedType && namedType.TypeArguments.Length > 0)
        {
            return namedType.TypeArguments.Last();
        }

        return type;
    }

    internal static string RemoveIllegalFileNameCharacters(string fileName)
    {
        var invalidChars = new HashSet<char>(['<', '>', ':', '"', '/', '\\', '|', '?', '*']);
        return string.Concat(fileName.Select(c => invalidChars.Contains(c) || char.IsControl(c) ? '_' : c));
    }

    internal static string? CleanIdentifier(string name, bool @namespace = false)
    {
        name = name.Trim();

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder();
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            sb.Append('_');
        }

        foreach (var ch in name)
        {
            if (SyntaxFacts.IsIdentifierPartCharacter(ch) || (@namespace && ch == '.'))
            {
                sb.Append(ch);
            }
        }

        var result = sb.ToString();
        if (SyntaxFacts.GetKeywordKind(result) != SyntaxKind.None)
        {
            result = '@' + result;
        }

        if (!@namespace)
        {
            return result;
        }

        var parts = result.Split('.');
        for (var i = 0; i < parts.Length; i++)
        {
            if (SyntaxFacts.GetKeywordKind(parts[i]) != SyntaxKind.None)
            {
                parts[i] = '@' + parts[i];
            }
        }

        return string.Join(".", parts);
    }

    internal static string BuildExtensionClassName(INamedTypeSymbol typeSymbol)
    {
        return $"{BuildTypeIdentifier(typeSymbol)}_MarkupExtensions";
    }

    internal static string BuildTypeIdentifier(INamedTypeSymbol typeSymbol)
    {
        var parts = new List<string>();

        if (typeSymbol.ContainingNamespace is { IsGlobalNamespace: false } containingNamespace)
        {
            parts.AddRange(containingNamespace.ToDisplayString().Split('.'));
        }

        var typeParts = new Stack<string>();
        INamedTypeSymbol? current = typeSymbol;
        while (current != null)
        {
            typeParts.Push(current.Name.Split('`')[0]);
            current = current.ContainingType;
        }

        parts.AddRange(typeParts);

        return CleanIdentifier(string.Join("_", parts)) ?? "Unknown";
    }

    private static string GetMetadataName(ISymbol symbol)
    {
        var ns = symbol.ContainingNamespace?.ToDisplayString();
        return string.IsNullOrWhiteSpace(ns) ? symbol.Name : $"{ns}.{symbol.Name}";
    }
}
