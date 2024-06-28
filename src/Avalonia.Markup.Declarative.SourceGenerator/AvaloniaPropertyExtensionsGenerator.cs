using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using static Avalonia.Markup.Declarative.SourceGenerator.MarkupTypeHelpers;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaPropertyExtensionsGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif 
        Debug.WriteLine("Execute AvaloniaPropertyExtensionsGenerator code generator");

        var comp = context.Compilation;

        var views = FindAvaloniaMarkupViews(comp);

        var sb = new StringBuilder();
        foreach (var type in views)
        {
            var root = type.SyntaxTree
                .GetRoot();

            var ns = root
                .DescendantNodes()
                .FirstOrDefault(x => x is BaseNamespaceDeclarationSyntax);

            var typeNamespace = "";

            if (ns is BaseNamespaceDeclarationSyntax nbs)
            {
                typeNamespace = nbs.Name.ToString();
            }

            sb.Clear();

            sb.AppendLine("#nullable enable");
            sb.AppendLine("// Auto-generated code " + DateTime.Now.ToString("g"));
            sb.AppendLine("using System;");
            sb.AppendLine("using Avalonia.Data;");
            sb.AppendLine("using Avalonia.Data.Converters;");
            sb.AppendLine("using System.Runtime.CompilerServices;");

            if (root is CompilationUnitSyntax compilationUnitSyntax)
            {
                foreach (var usingDirectiveSyntax in compilationUnitSyntax.Usings)
                {
                    sb.AppendLine(usingDirectiveSyntax.ToString());
                }
            }

            if (!string.IsNullOrWhiteSpace(typeNamespace))
                sb.AppendLine($"using {typeNamespace};");

            var typeName = type.Identifier.ToString();

            sb.AppendLine("namespace Avalonia.Markup.Declarative;");

            sb.AppendLine($"public static partial class {typeName}Extensions");
            sb.AppendLine("{");

            var members = type.Members;

            List<string> processedFields = [];
            //PROCESS AVALONIA PROPERTIES
            foreach (var field in members.OfType<FieldDeclarationSyntax>())
            {
                if (field.Declaration.Type is GenericNameSyntax
                    {
                        Identifier.ValueText: ("DirectProperty" or "StyledProperty" or "AttachedProperty")
                    } && HasAvaloniaPropertyPublicSetter(field, members))
                {
                    sb.AppendLine($"//avalonia properties{Environment.NewLine}");

                    AppendIfNotNull(sb, GetPropertySetterExtension(typeName, field));
                    AppendIfNotNull(sb, GetExpressionBindingSetterExtension(typeName, field));

                    var name = field.Declaration.Variables[0].Identifier.ValueText;
                    processedFields.Add(name);
                }
            }

            //PROCESS COMMON PROPERTIES
            foreach (var property in members.OfType<PropertyDeclarationSyntax>())
            {
                //skip properties that already processed as Avalonia properties
                if (!processedFields.Contains(property.Identifier + "Property")
                    && IsPublic(property) && HasPublicSetter(property) &&
                    IsCommonInstanceProperty(property, members))
                {
                    sb.AppendLine($"//common properties{Environment.NewLine}");

                    AppendIfNotNull(sb, GetCommonPropertySetterExtension(typeName, property, comp));
                    AppendIfNotNull(sb, GetCommonPropertyBindingSetterExtension(typeName, property, comp));
                    AppendIfNotNull(sb, GetCommonPropertyExpressionBindingSetterExtension(typeName, property, comp));

                    processedFields.Add(property.Identifier.ToString());
                }
            }

            sb.AppendLine("}");
            // Add the source code to the compilation

            if (processedFields.Count > 0)
                context.AddSource($"{typeName}.g.cs", sb.ToString());
        }

    }

    private static void AppendIfNotNull(StringBuilder sb, string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sb.AppendLine(value);
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        Debug.WriteLine("Initalize code generator");
        // No initialization required for this one
    }

    public string GetPropertySetterExtension(string controlTypeName, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(\"value\")] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{Environment.NewLine} control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private string GetCommonPropertySetterExtension(string controlTypeName, PropertyDeclarationSyntax property,
        Compilation compilation)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = GetPropertyTypeName(property, compilation);

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(\"value\")] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{Environment.NewLine} control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private string GetCommonPropertyBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property,
        Compilation compilation)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, compilation);

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, IBinding binding)"
            + $"=>{Environment.NewLine} control._setCommonBindingEx(({valueTypeSource} value) => control.{extensionName} = value, binding);";

        return extensionText;
    }
    public string GetExpressionBindingSetterExtension(string controlTypeName, FieldDeclarationSyntax field)
    {
        var extensionName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var genericName = field.Declaration.Type as GenericNameSyntax;

        var valueTypeSource = genericName.TypeArgumentList.Arguments.Last();

        var extensionText =
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(\"func\")] string? expression = null){Environment.NewLine}" +
            $"   => control._set({controlTypeName}.{extensionName}Property, func, onChanged, expression);";

        return extensionText;
    }

    private string GetCommonPropertyExpressionBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property, Compilation compilation)
    {
        var extensionName = property.Identifier.ToString();
        var valueTypeSource = GetPropertyTypeName(property, compilation);

        var extensionText =
            $"//Generated by GetCommonPropertyExpressionBindingSetterExtension{Environment.NewLine}" +
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(\"func\")] string? expression = null){Environment.NewLine}" +
            $"   => control._set((v) => control.{extensionName} = v, func, onChanged, expression);";


        return extensionText;
    }
}