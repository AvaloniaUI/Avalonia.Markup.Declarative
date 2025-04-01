using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        return symbol is INamedTypeSymbol typeSymbol &&
               typeSymbol.AllInterfaces.Any(x => x.Name == "IDeclarativeViewBase")
            ? (classDecl, context.SemanticModel)
            : null;
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

        var typeName = type.Identifier.ToString();
        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine($"public static partial class {typeName}Extensions");
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
                AppendIfNotNull(sb, GetPropertySetterExtension(typeName, field));
                AppendIfNotNull(sb, GetExpressionBindingSetterExtension(typeName, field));
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

                AppendIfNotNull(sb, GetCommonPropertySetterExtension(typeName, property, semanticModel));
                AppendIfNotNull(sb, GetCommonPropertyBindingSetterExtension(typeName, property, semanticModel));
                AppendIfNotNull(sb, GetCommonPropertyExpressionBindingSetterExtension(typeName, property, semanticModel));

                processedFields.Add(propertyName);
            }
        }

        sb.AppendLine("}");

        if (processedFields.Count > 0)
        {
            context.AddSource($"{typeName}Extensions.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
        }
    }

    private static void AppendIfNotNull(StringBuilder sb, string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sb.AppendLine(value);
    }

    public static string GetPropertySetterExtension(string controlTypeName, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{NewLine} control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private static string GetCommonPropertySetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{NewLine} control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private static string GetCommonPropertyBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, SemanticModel semanticModel)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, semanticModel);

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, IBinding binding)"
            + $"=>{NewLine} control._setCommonBindingEx(({valueTypeSource} value) => control.{extensionName} = value, binding);";

        return extensionText;
    }
    public static string GetExpressionBindingSetterExtension(string controlTypeName, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var extensionText =
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){NewLine}" +
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