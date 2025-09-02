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

        // Build the nested-qualified name (e.g., Outer.Inner for a nested class) so we can reference nested types.
        static string GetNestedQualifiedName(ClassDeclarationSyntax cls)
        {
            var names = new System.Collections.Generic.List<string>();
            SyntaxNode? node = cls;
            while (node is ClassDeclarationSyntax cds)
            {
                names.Insert(0, cds.Identifier.ToString());
                node = node.Parent;
            }
            return string.Join(".", names);
        }

        // The name to use in method signatures (within the containing namespace scope via using above)
        var nestedQualifiedTypeName = GetNestedQualifiedName(classDecl);

        // Create a unique and valid extension class/file name that includes namespace and nesting
        var fullTypePathForId = (string.IsNullOrWhiteSpace(typeNamespace) ? string.Empty : typeNamespace + ".") + nestedQualifiedTypeName;
        var safeId = fullTypePathForId
            .Replace('.', '_')
            .Replace('+', '_'); // just in case

        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine($"public static partial class {safeId}EventExtensions");
        sb.AppendLine("{");

        var processedMembersCount = 0;
        foreach (var member in classDecl.Members)
        {
            if (member is not EventFieldDeclarationSyntax @event)
                continue;

            var extensionString = GetEventExtension(nestedQualifiedTypeName, @event);
            if (string.IsNullOrWhiteSpace(extensionString))
                continue;

            sb.AppendLine(extensionString);
            processedMembersCount++;
        }

        sb.AppendLine("}");

        if (processedMembersCount > 0)
        {
            context.AddSource($"{safeId}EventExtensions.g.cs", SourceText.From(sb.ToString(), Encoding.UTF8));
        }
    }

    // Rewritten for clarity: separates logic for EventHandler, EventHandler<T>, Action, and Action<T>.
    private static string GetEventExtension(string controlTypeName, EventFieldDeclarationSyntax @event)
    {
        // Get the event type as string (e.g., EventHandler, EventHandler<T>, Action, Action<T>)
        var eventTypeSyntax = @event.Declaration.Type;
        var eventTypeString = eventTypeSyntax.ToString();

        // Get the event name (e.g., Click)
        var eventName = @event.Declaration.Variables[0].ToString();
        var extensionName = $"On{eventName}";

        // Try to get the generic type arguments if present
        var genericName = eventTypeSyntax.DescendantNodesAndSelf().OfType<GenericNameSyntax>().FirstOrDefault();
        var typeArguments = genericName?.TypeArgumentList.Arguments.Select(arg => arg.ToString()).ToArray();

        // Determine the extension method signature and lambda body
        string parameterList;
        string lambdaParameters;
        string lambdaBody;
        bool isEventHandler = eventTypeString.StartsWith("EventHandler");
        bool isAction = eventTypeString.StartsWith("Action");

        if (isEventHandler && typeArguments is { Length: 1 })
        {
            // EventHandler<TEventArgs>
            parameterList = $"Action<{typeArguments[0]}> action";
            lambdaParameters = "_, args";
            lambdaBody = "action(args)";
        }
        else if (isEventHandler)
        {
            // EventHandler (no generic args)
            parameterList = "Action<EventArgs> action";
            lambdaParameters = "_, args";
            lambdaBody = "action(args)";
        }
        else if (isAction && typeArguments is { Length: 1 })
        {
            // Action<T>
            parameterList = $"Action<{typeArguments[0]}> action";
            lambdaParameters = "args";
            lambdaBody = "action(args)";
        }
        else if (isAction)
        {
            // Action (no args)
            parameterList = "Action action";
            lambdaParameters = "";
            lambdaBody = "action()";
        }
        else
        {
            // Fallback: treat as Action (no args)
            parameterList = "Action action";
            lambdaParameters = "";
            lambdaBody = "action()";
        }

        // Compose the extension method
        var extensionText =
            $"    public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {parameterList}) =>\n"
            + $"        control._setEvent(({eventTypeString})(({lambdaParameters}) => {lambdaBody}), h => control.{eventName} += h);";

        return extensionText;
    }
}