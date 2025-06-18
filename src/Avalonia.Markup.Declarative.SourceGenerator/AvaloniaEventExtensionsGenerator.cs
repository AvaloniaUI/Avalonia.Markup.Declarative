#nullable enable
using System;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using static Avalonia.Markup.Declarative.SourceGenerator.MarkupTypeHelpers;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaEventExtensionsGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif
        Debug.WriteLine("Initialize AvaloniaEventExtensionsGenerator code generator");

        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (s, _) => s is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx))
            .Where(static c => c is not null);

        context.RegisterSourceOutput(classDeclarations,
            static (spc, classDecl) => GenerateSource(spc, classDecl!));
    }

    private static ClassDeclarationSyntax? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);
        if (symbol is INamedTypeSymbol typeSymbol && IsAvaloniaMarkupView(typeSymbol))
        {
            return classDecl;
        }
        return null;
    }

    private static void GenerateSource(SourceProductionContext context, ClassDeclarationSyntax classDecl)
    {
        var root = classDecl.SyntaxTree.GetRoot();

        var ns = root
            .DescendantNodes()
            .FirstOrDefault(x => x is BaseNamespaceDeclarationSyntax) as BaseNamespaceDeclarationSyntax;

        var typeNamespace = ns?.Name.ToString() ?? string.Empty;

        var sb = new StringBuilder();

        sb.AppendLine("#nullable enable");
        sb.AppendLine("// Auto-generated code");
        sb.AppendLine("using System;");
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

        var typeName = classDecl.Identifier.ToString();

        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine($"public static partial class {typeName}EventExtensions");
        sb.AppendLine("{");

        var processedMembersCount = 0;
        foreach (var member in classDecl.Members)
        {
            if (member is not EventFieldDeclarationSyntax @event)
                continue;

            var extensionString = GetEventExtension(typeName, @event);
            if (string.IsNullOrWhiteSpace(extensionString))
                continue;

            sb.AppendLine(extensionString);
            processedMembersCount++;
        }

        sb.AppendLine("}");

        if (processedMembersCount > 0)
        {
            context.AddSource($"{typeName}EventExtensions.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
        }
    }

    private static string GetEventExtension(string controlTypeName, EventFieldDeclarationSyntax @event)
    {
        var eventHandler = @event.Declaration.Type.ToString();

        //var eventArgsType = string.Join(",", @event.Declaration.Type.DescendantNodes().OfType<IdentifierNameSyntax>().Select(x => x.ToString()));

        string eventArgsType = string.Empty; // Initialize as empty

        var eventType = @event.Declaration.Type;
        if (eventType is GenericNameSyntax genericName)
        {
            eventArgsType = string.Join(",", genericName.TypeArgumentList.Arguments.Select(arg => arg.ToString()));
        }

        var argsString = $"Action<{eventArgsType}> action";
        var actionCallStr = "action(args)";

        if (string.IsNullOrWhiteSpace(eventArgsType))
        {
            argsString = "Action action";
            actionCallStr = "action()";
        }

        var eventName = @event.Declaration.Variables[0].ToString();
        var extensionName = "On" + eventName;

        var extensionText =
            $"    public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString}) =>\n"
            + $"        control._setEvent(({eventHandler})((_, args) => {actionCallStr}), h => control.{eventName} += h);";

        return extensionText;
    }
}