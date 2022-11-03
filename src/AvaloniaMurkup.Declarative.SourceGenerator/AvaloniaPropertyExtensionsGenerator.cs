using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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

        var views = GetGenerateExtensionsViews(comp);

        var sb = new StringBuilder();
        var extensions = new List<string>();
        foreach (var type in views)
        {
            var root = type.SyntaxTree
                .GetRoot();

            var ns = root
                .DescendantNodes()
                .FirstOrDefault(x=>x is BaseNamespaceDeclarationSyntax);

            var typeNamespace = "";

            if (ns is BaseNamespaceDeclarationSyntax nbs)
            {
                typeNamespace = nbs.Name.ToString();
            }

            sb.Clear();

            sb.AppendLine("// Auto-generated code");
            sb.AppendLine("using System;");
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

            foreach (var member in members)
            {
                //PROCESS COMMON PROPERTIES
                if (member is PropertyDeclarationSyntax property
                    && HasPublicSetter(property) 
                    && IsCommonProperty(property, members))
                {
                    var extensionString = GetCommonPropertySetterExtension(typeName, property);
                    if (!string.IsNullOrWhiteSpace(extensionString))
                    {
                        //extensions.Add(extensionString);
                        sb.AppendLine(extensionString);
                    }
                }

                //PROCESS AVALONIA PROPERTIES
                if (member is FieldDeclarationSyntax field)
                {
                    if (field.Declaration.Type is GenericNameSyntax
                        {
                            Identifier.ValueText: ("DirectProperty" or "StyledProperty" or "AttachedProperty")
                        })
                    {
                        if (!HasAvaloniaPropertyPublicSetter(field, members))
                            continue;

                        var extensionString = GetPropertySetterExtension(typeName, field);
                        if (!string.IsNullOrWhiteSpace(extensionString))
                        {
                            //extensions.Add(extensionString);
                            sb.AppendLine(extensionString);
                        }
                    }
                }
            }

            sb.AppendLine("}");
            // Add the source code to the compilation
            context.AddSource($"{typeName}.g.cs", sb.ToString());
        }

    }

    private bool IsCommonProperty(PropertyDeclarationSyntax property, SyntaxList<MemberDeclarationSyntax> members)
    {
        var avaloniaPropertyName = property.Identifier + "Property";
        return members.OfType<FieldDeclarationSyntax>().All(field => field.Declaration.Variables[0].Identifier.ToString() != avaloniaPropertyName);
    }

    private bool HasAvaloniaPropertyPublicSetter(FieldDeclarationSyntax field, SyntaxList<MemberDeclarationSyntax> members)
    {
        var backingPropertyName = field.Declaration.Variables[0].Identifier.ToString().Replace("Property", "");

        var property = members
            .OfType<PropertyDeclarationSyntax>()
            .FirstOrDefault(x => x.Identifier.ValueText == backingPropertyName);

        return HasPublicSetter(property);
    }

    private bool HasPublicSetter(PropertyDeclarationSyntax property)
    {
        if (property != null)
        {
            var setter = property.AccessorList?.Accessors.FirstOrDefault(x => x.IsKind(SyntaxKind.SetAccessorDeclaration));
            if(setter?.Modifiers.Any() == false)
                return true;
        }

        return false;
    }

    private static ImmutableArray<ClassDeclarationSyntax> GetGenerateExtensionsViews(Compilation compilation)
    {
        IEnumerable<SyntaxNode> allNodes = compilation.SyntaxTrees.SelectMany(s => s.GetRoot().DescendantNodes());
        IEnumerable<ClassDeclarationSyntax> allClasses = allNodes
            .Where(d => d.IsKind(SyntaxKind.ClassDeclaration))
            .OfType<ClassDeclarationSyntax>();

        return allClasses
            .Where(type => IsGenerateExtensionsView(compilation, type))
            .ToImmutableArray();
    }

    private static bool IsGenerateExtensionsView(Compilation compilation, ClassDeclarationSyntax component)
    {
        var sModel = compilation.GetSemanticModel(component.SyntaxTree);
        var classSymbol = sModel.GetDeclaredSymbol(component);

        if (classSymbol?.AllInterfaces.Any(x => x.Name.ToString() == "IDeclarativeViewBase") == true)
            return true;

        return component.AttributeLists
            .SelectMany(x => x.Attributes)
            .Any(attr => attr.Name.ToString() == "GenerateMarkupExtensions");
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

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null,"
                         + $" [CallerArgumentExpression(\"value\")] string ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=> control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private string GetCommonPropertySetterExtension(string controlTypeName, PropertyDeclarationSyntax property)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = property.Type.ToString();

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null,"
                         + $" [CallerArgumentExpression(\"value\")] string ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=> control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private string GetCommonPropertyBindingSetterExtension(string controlTypeName, PropertyDeclarationSyntax property)
    {
        var extensionName = property.Identifier.ToString();

        var valueTypeSource = property.Type.ToString();

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null,"
                         + $" [CallerArgumentExpression(\"value\")] string ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=> control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }
}