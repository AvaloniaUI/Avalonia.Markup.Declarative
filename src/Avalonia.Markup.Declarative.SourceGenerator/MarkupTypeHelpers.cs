#nullable enable

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Avalonia.Markup.Declarative.SourceGenerator;

internal static class MarkupTypeHelpers
{
    internal const string NewLine = "\n";

    internal static bool IsAvaloniaMarkupView(INamedTypeSymbol typeSymbol)
    {
        return typeSymbol.AllInterfaces
               .Any(x => x.Name == "IDeclarativeViewBase");
    }

    internal static ImmutableArray<ClassDeclarationSyntax> FindAvaloniaMarkupViews(Compilation compilation)
    {
        IEnumerable<SyntaxNode> allNodes = compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
        IEnumerable<ClassDeclarationSyntax> allClasses = allNodes
            .Where(d => d.IsKind(SyntaxKind.ClassDeclaration))
            .OfType<ClassDeclarationSyntax>();

    //    return allClasses
    //        .Where(type => IsGenerateExtensionsView(compilation, type))
    //        .ToImmutableArray();
    //}

    //private static bool IsGenerateExtensionsView(Compilation compilation, ClassDeclarationSyntax component)
    //{
    //    var sModel = compilation.GetSemanticModel(component.SyntaxTree);
    //    var classSymbol = ModelExtensions.GetDeclaredSymbol(sModel, component);

    //    return classSymbol is INamedTypeSymbol cs && cs.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase");
    //}

    /// <summary>
    /// Determines if property also has Avalonia property backend or not
    /// </summary>
    /// <param name="property">target property</param>
    /// <param name="members"></param>
    /// <returns></returns>
    //internal static bool IsCommonInstanceProperty(IPropertySymbol property, ImmutableArray<ISymbol> members)
    //{
    //    if(property.IsStatic)
    //        return false;

    //    var avaloniaPropertyName = property.Name + "Property";
    //    return members.OfType<IFieldSymbol>().All(field => field.Name != avaloniaPropertyName);
    //}

    //internal static bool HasAvaloniaPropertyPublicSetter(ISymbol field, ImmutableArray<ISymbol> members)
    //{
    //    var property = members
    //        .FirstOrDefault(x => x.DeclaredAccessibility == Accessibility.Public && x.Name == field.Name.Replace("Property", ""));

    //    return HasPublicSetter(property as IPropertySymbol);
    //}

    internal static bool HasPublicSetter(this IPropertySymbol? property)
    {
        return property?.SetMethod != null && property.SetMethod.DeclaredAccessibility == Accessibility.Public;
    }

    internal static bool IsPublic(ISymbol? property)
    {
        return property != null && property.DeclaredAccessibility == Accessibility.Public;
    }

    internal static IEnumerable<INamedTypeSymbol> GetPublicClasses(this INamespaceSymbol sym)
    {
        foreach (INamedTypeSymbol typeMember in sym.GetTypeMembers())
        {
            if (typeMember.DeclaredAccessibility == Accessibility.Public && typeMember.TypeKind == TypeKind.Class)
                yield return typeMember;
        }
        foreach (INamespaceSymbol namespaceMember in sym.GetNamespaceMembers())
        {
            foreach (INamedTypeSymbol publicClass in GetPublicClasses(namespaceMember))
            {
                if (publicClass.DeclaredAccessibility == Accessibility.Public && publicClass.TypeKind == TypeKind.Class)
                    yield return publicClass;
            }
        }
    }

    internal static string GetPropertyTypeName(PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var typeInfo = semanticModel.GetTypeInfo(property.Type);
        return typeInfo.Type?.ToDisplayString() ?? property.Type.ToString();
    }

    internal static string GetNullableLambdaParameterTypeName(PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var typeInfo = semanticModel.GetTypeInfo(property.Type);
        var typeSymbol = typeInfo.Type;

        if (typeSymbol == null)
            return property.Type + "?";

        var nullableTypeSymbol = typeSymbol.WithNullableAnnotation(NullableAnnotation.Annotated);

        return nullableTypeSymbol.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat);
    }
}