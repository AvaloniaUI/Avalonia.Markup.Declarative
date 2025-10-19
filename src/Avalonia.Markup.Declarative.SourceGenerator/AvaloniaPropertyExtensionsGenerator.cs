using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using static Avalonia.Markup.Declarative.SourceGenerator.MarkupTypeHelpers;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaPropertyExtensionsGenerator : IIncrementalGenerator
{

    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif
        Debug.WriteLine("Initialize AvaloniaPropertyExtensionsGenerator code generator");

        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => s is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx))
            .Where(static c => c is not null);

        context.RegisterSourceOutput(classDeclarations,
            static (spc, data) => GenerateSource(spc, data.Value.Syntax, data.Value.Model));
    }

    private static (ClassDeclarationSyntax Syntax, SemanticModel Model)? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);
        
        // Check if this class or any of its base types implements IDeclarativeViewBase
        return symbol is INamedTypeSymbol typeSymbol &&
               ImplementsIDeclarativeViewBase(typeSymbol)
            ? (classDecl, context.SemanticModel)
            : null;
    }

    private static bool ImplementsIDeclarativeViewBase(INamedTypeSymbol typeSymbol)
    {
        // Check direct interfaces
        if (typeSymbol.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase"))
            return true;

        // Check base types (for inheritance)
        var current = typeSymbol.BaseType;
        while (current != null)
        {
            if (current.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase"))
                return true;
            current = current.BaseType;
        }

        return false;
    }

    private static void GenerateSource(SourceProductionContext context, ClassDeclarationSyntax type, SemanticModel semanticModel)
    {
        var root = type.SyntaxTree.GetRoot();
        var ns = root.DescendantNodes()
            .FirstOrDefault(x => x is BaseNamespaceDeclarationSyntax) as BaseNamespaceDeclarationSyntax;

        var typeNamespace = ns?.Name.ToString() ?? string.Empty;
        var sb = new StringBuilder();

        sb.AppendLine("#nullable enable");
        sb.AppendLine($"// Auto-generated code {DateTime.Now:g}");
        sb.AppendLine("using System;");
        sb.AppendLine("using Avalonia.Data;");
        sb.AppendLine("using Avalonia.Data.Converters;");
        sb.AppendLine("using System.Runtime.CompilerServices;");

        if (root is CompilationUnitSyntax compilationUnit)
        {
            foreach (var usingDirective in compilationUnit.Usings)
            {
                sb.AppendLine(usingDirective.ToString());
            }
        }

        if (!string.IsNullOrWhiteSpace(typeNamespace))
            sb.AppendLine($"using {typeNamespace};");

        // Get the type symbol to build proper qualified names
        var typeSymbol = semanticModel.GetDeclaredSymbol(type) as INamedTypeSymbol;
        
        // Build the extension class name - handle nested classes properly
        var extensionClassName = BuildExtensionClassName(typeSymbol);
        
        // Fully qualified control type name including namespace, containing types and type parameters
        var controlTypeQualified = typeSymbol?.ToDisplayString(
            SymbolDisplayFormat.FullyQualifiedFormat
                .WithGenericsOptions(SymbolDisplayGenericsOptions.IncludeTypeParameters | SymbolDisplayGenericsOptions.IncludeVariance)
                .WithMiscellaneousOptions(SymbolDisplayMiscellaneousOptions.UseSpecialTypes | SymbolDisplayMiscellaneousOptions.ExpandNullable)
        ) ?? type.Identifier.ToString();

        // Build method generic parameters for all containing type parameters (outermost -> innermost)
        string allTypeParamsForMethods = BuildAllTypeParameters(type);

        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine($"public static partial class {extensionClassName}Extensions");
        sb.AppendLine("{");

        var members = type.Members;
        var processedFields = new List<string>();

        // PROCESS AVALONIA PROPERTIES
        foreach (var field in members.OfType<FieldDeclarationSyntax>())
        {
            if (field.Declaration.Type is GenericNameSyntax { Identifier.ValueText: "DirectProperty" or "StyledProperty" or "AttachedProperty" }
                && HasAvaloniaPropertyPublicSetter(field, members))
            {
                sb.AppendLine($"// avalonia properties\n");
                AppendIfNotNull(sb, GetPropertySetterExtension(controlTypeQualified, allTypeParamsForMethods, field));
                AppendIfNotNull(sb, GetExpressionBindingSetterExtension(controlTypeQualified, allTypeParamsForMethods, field));
                processedFields.Add(field.Declaration.Variables[0].Identifier.ValueText);
            }
        }

        // PROCESS COMMON PROPERTIES
        foreach (var property in members.OfType<PropertyDeclarationSyntax>())
        {
            var propertyName = property.Identifier.ToString();
            if (!processedFields.Contains(propertyName + "Property")
                && IsPublic(property)
                && HasPublicSetter(property)
                && IsCommonInstanceProperty(property, members))
            {
                sb.AppendLine($"// common properties\n");

                AppendIfNotNull(sb, GetCommonPropertySetterExtension(controlTypeQualified, property, semanticModel));
                AppendIfNotNull(sb, GetCommonPropertyBindingSetterExtension(controlTypeQualified, property, semanticModel));
                AppendIfNotNull(sb, GetCommonPropertyExpressionBindingSetterExtension(controlTypeQualified, property, semanticModel));

                processedFields.Add(propertyName);
            }
        }

        sb.AppendLine("}");

        if (processedFields.Count > 0)
        {
            var fileName = RemoveIllegalFileNameCharacters(extensionClassName) + "Extensions.g.cs";
            context.AddSource(fileName, SourceText.From(sb.ToString(), Encoding.UTF8));
        }
    }

    private static string BuildExtensionClassName(INamedTypeSymbol? typeSymbol)
    {
        if (typeSymbol == null)
            return "Unknown";

        var parts = new List<string>();
        
        // Build from innermost to outermost
        var current = typeSymbol;
        while (current != null)
        {
            var name = current.Name;
            if (current.TypeParameters.Length > 0)
            {
                name += $"`{current.TypeParameters.Length}";
            }
            parts.Insert(0, name);
            
            current = current.ContainingType;
        }
        
        return CleanIdentifier(string.Join("_", parts));
    }

    private static string BuildAllTypeParameters(ClassDeclarationSyntax type)
    {
        var stack = new Stack<string>();
        SyntaxNode? current = type;
        while (current is ClassDeclarationSyntax cds)
        {
            if (cds.TypeParameterList is { Parameters.Count: > 0 })
            {
                // Push in reverse so that when we read Stack.ToArray() we keep original order per containing type
                foreach (var p in cds.TypeParameterList.Parameters.Reverse())
                {
                    stack.Push(p.Identifier.Text);
                }
            }
            current = current.Parent;
            if (current is BaseNamespaceDeclarationSyntax)
                break;
        }

        if (stack.Count == 0)
            return string.Empty;

        var arr = stack.ToArray(); // outermost -> innermost order
        return $"<{string.Join(", ", arr)}>";
    }

    public static string RemoveIllegalFileNameCharacters(string fileName)
    {
        if (string.IsNullOrEmpty(fileName))
            throw new ArgumentException("File name cannot be null or empty", nameof(fileName));

        // Remove invalid characters from the input
        string sanitizedFileName = new([.. fileName.Where(c => !Path.GetInvalidFileNameChars().Contains(c))]);

        return sanitizedFileName;
    }

    private static string CleanIdentifier(string name, bool @namespace = false)
    {
        // trim off leading and trailing whitespace
        name = name.Trim();

        if (string.IsNullOrEmpty(name))
        {
            return null;
        }

        var sb = new StringBuilder();
        if (!SyntaxFacts.IsIdentifierStartCharacter(name[0]))
        {
            // the first characters
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

        if (@namespace)
        {
            var newResult = string.Empty;
            foreach (var chunk in result.Split('.'))
            {
                if (!string.IsNullOrEmpty(newResult))
                {
                    newResult += '.';
                }

                if (SyntaxFacts.GetKeywordKind(chunk) != SyntaxKind.None)
                {
                    newResult += '@' + chunk;
                }
                else
                {
                    newResult += chunk;
                }
            }

            return newResult;
        }

        return result;
    }

    private static void AppendIfNotNull(StringBuilder sb, string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sb.AppendLine(value);
    }

    public static string GetPropertySetterExtension(string controlTypeName, string genericParamsAll, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var valueName = valueTypeSource is NullableTypeSyntax nullableTypeSyntax
            ? nullableTypeSyntax.ElementType.ToString()
            : valueTypeSource.ToString();

        // Get Class constraints
        var classConstraint = "";
        if (field.Parent is ClassDeclarationSyntax classDecleration)
        {
            foreach (TypeParameterConstraintClauseSyntax constraintClause in classDecleration.ConstraintClauses)
            {
                if (constraintClause.Name.ToString() == valueName)
                {
                    classConstraint = " " + constraintClause.ToString();
                }
            }
        }

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}{genericParamsAll}" +
            $"(this {controlTypeName} control, {argsString}){classConstraint}{NewLine}" +
            $"   => control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private static string GetCommonPropertySetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}" +
            $"(this {controlTypeName} control, {argsString})" +
            $"=>{NewLine} control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private static string GetCommonPropertyBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var extensionText =
            $"#pragma warning disable CS8601{NewLine}" +
            $"[Obsolete] public static {controlTypeName} {extensionName}" +
            $"(this {controlTypeName} control, IBinding binding)" +
            $"=>{NewLine} control._setCommonBindingEx(({valueTypeSource}? v) => control.{extensionName} = v ?? default({valueTypeSource}), binding);{NewLine}" +
            $"#pragma warning restore CS8601";

        return extensionText;
    }
    public static string GetExpressionBindingSetterExtension(string controlTypeName, string genericParamsAll, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var valueName = valueTypeSource is NullableTypeSyntax nullableTypeSyntax
            ? nullableTypeSyntax.ElementType.ToString()
            : valueTypeSource.ToString();

        // Get Class constraints
        var classConstraint = "";
        if (field.Parent is ClassDeclarationSyntax classDecleration)
        {
            foreach (TypeParameterConstraintClauseSyntax constraintClause in classDecleration.ConstraintClauses)
            {
                if (constraintClause.Name.ToString() == valueName)
                {
                    classConstraint = " " + constraintClause.ToString();
                }
            }
        }

        var extensionText =
            $"public static {controlTypeName} {extensionName}{genericParamsAll}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){classConstraint}{NewLine}" +
            $"   => control._set({controlTypeName}.{extensionName}Property, func, onChanged, expression);";

        return extensionText;
    }

    private static string GetCommonPropertyExpressionBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var extensionText =
            $"//Generated by GetCommonPropertyExpressionBindingSetterExtension{NewLine}" +
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){NewLine}" +
            $"   => control._set((v) => control.{extensionName} = v, func, onChanged, expression);";


        return extensionText;
    }
}