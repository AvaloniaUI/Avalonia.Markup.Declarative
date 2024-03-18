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
public class AvaloniaEventExtensionsGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif 
        Debug.WriteLine("Execute AvaloniaEventExtensionsGenerator code generator");

        var comp = context.Compilation;

        var views = FindAvaloniaMarkupViews(comp);

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

            sb.AppendLine("#nullable enable");
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

            sb.AppendLine($"public static partial class {typeName}EventExtensions");
            sb.AppendLine("{");

            foreach (var member in type.Members)
            {
                if (member is not EventFieldDeclarationSyntax @event)
                    continue;

                var extensionString = GetEventExtension(typeName, @event);
                if (!string.IsNullOrWhiteSpace(extensionString))
                {
                    sb.AppendLine(extensionString);
                }

            }

            sb.AppendLine("}");
            // Add the source code to the compilation
            context.AddSource($"{typeName}.g.cs", sb.ToString());
        }

    }

    public void Initialize(GeneratorInitializationContext context)
    {
            Debug.WriteLine("Initalize code generator");
            // No initialization required for this one
        }

    public string GetEventExtension(string controlTypeName, EventFieldDeclarationSyntax @event)
    {
            var eventHandler = @event.Declaration.Type.ToString();

            var eventArgsType = string.Join(",",@event.Declaration.Type.DescendantNodes().OfType<IdentifierNameSyntax>().Select(x=>x.ToString()).ToArray());

            var argsString = $"Action<{eventArgsType}> action";

            var actionCallStr = "action(args)";

            if (string.IsNullOrWhiteSpace(eventArgsType))
            {
                argsString = $"Action action";
                actionCallStr = "action()";
            }

            var eventName = @event.Declaration.Variables[0].ToString();
            var extensionName = "On" + eventName;

            var extensionText =
                $"    public static {controlTypeName} {extensionName}"
                + $"(this {controlTypeName} control, {argsString}) => {Environment.NewLine}"
                + $"        control._setEvent(({eventHandler}) ((_, args) => {actionCallStr}), h => control.{eventName} += h);";


            return extensionText;
        }

}