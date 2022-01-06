using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Avalonia.Markup.Declarative.SourceGenerator
{
    [Generator]
    public class AvaloniaPropertyExtensionsGenerator : ISourceGenerator
    {
        public void Execute(GeneratorExecutionContext context)
        {
#if DEBUG
           if (!Debugger.IsAttached)
           {
            //    Debugger.Launch();
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

                foreach (var member in type.Members)
                {
                    if (member is not FieldDeclarationSyntax field)
                        continue;

                    if (field.Declaration.Type is GenericNameSyntax
                        {
                            Identifier.ValueText: ("DirectProperty" or "StyledProperty" or "AttachedProperty")
                        })
                    {
                        var extensionString = GetPropertySetterExtension(typeName, field);
                        if (!string.IsNullOrWhiteSpace(extensionString))
                        {
                            //extensions.Add(extensionString);
                            sb.AppendLine(extensionString);
                        }
                    }
                }

                sb.AppendLine("}");
                // Add the source code to the compilation
                context.AddSource($"{typeName}.g.cs", sb.ToString());
            }

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

            var valueTypeSource = genericName.TypeArgumentList.Arguments[1];

            var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter converter = null, object bindingSource = null,"
                             + $" [CallerArgumentExpression(\"value\")] string ps = null)";

            var extensionText =
                $"public static {controlTypeName} {extensionName}"
                + $"(this {controlTypeName} control, {argsString}"
                + getSetterBody();

            string getSetterBody() => $"=> control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

            return extensionText;
        }

    }
}