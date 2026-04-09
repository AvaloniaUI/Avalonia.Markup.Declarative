using CSharpUI.Avalonia.SourceGenerator.Generators;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;

namespace CSharpUI.Avalonia.SourceGenerator;

[Generator]
public class Generator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            //Debugger.Launch();
        }
#endif

        // Local Classes
        var classDeclarations = context.SyntaxProvider
            .CreateSyntaxProvider(
                predicate: static (syntaxNode, _) => syntaxNode is ClassDeclarationSyntax,
                transform: static (ctx, _) => GetSemanticTarget(ctx)
            )
            .Where(static c => c is not null);

        context.RegisterSourceOutput(classDeclarations,
            static (spc, data) =>
            {
                var generator = new GeneratorHost();

                var code = generator.GenerateExtensions(data!);

                if (!string.IsNullOrEmpty(code))
                {
                    spc.AddSource($"{Extensions.RemoveIllegalFileNameCharacters(data!.ToString())}.g.cs", code!);
                }
            });

        // External Classes
        var attribute = context.SyntaxProvider
                         .ForAttributeWithMetadataName("CSharpUI.Avalonia.GenerateExtensionsForAssemblyAttribute",
                                                       static (s, _) => true,
                                                       static (ctx, _) => GetSemanticTarget(ctx))
                         .SelectMany((assemblies, _) => assemblies)
                         .Collect()
                         .Select((assemblies, _) => assemblies.Distinct<IAssemblySymbol>(SymbolEqualityComparer.Default)
                                                              .ToImmutableArray());

        context.RegisterSourceOutput(attribute,
            static (spc, assemblies) =>
            {
                foreach (var assembly in assemblies)
                {
                    GetClasses(spc, assembly);
                }
            });

        context.RegisterPostInitializationOutput(pi =>
        {
            pi.AddSource("GlobalUsings.g.cs", SourceText.From(
                                                              $"global using CSharpUI.Avalonia.CommonExtensions;{Extensions.NewLine}" +
                                                              $"global using CSharpUI.Avalonia.Extensions;{Extensions.NewLine}" +
                                                              $"global using CSharpUI.Avalonia.Styles;{Extensions.NewLine}" +
                                                              $"global using CSharpUI.Avalonia;{Extensions.NewLine}"
                                                              , Encoding.UTF8));
        });
    }

    private static INamedTypeSymbol? GetSemanticTarget(GeneratorSyntaxContext context)
    {
        var classDecl = (ClassDeclarationSyntax)context.Node;
        var symbol = context.SemanticModel.GetDeclaredSymbol(classDecl);

        if (symbol != null && Extensions.InheritsFrom(symbol, "Avalonia.Visual"))
        {
            return symbol!;
        }

        return null;
    }

    private static ImmutableArray<IAssemblySymbol> GetSemanticTarget(GeneratorAttributeSyntaxContext context)
    {
        var assemblies = new HashSet<IAssemblySymbol>(SymbolEqualityComparer.Default);

        foreach (var attribute in context.Attributes)
        {
            if (attribute?.AttributeClass?.Name == "GenerateExtensionsForAssemblyAttribute" &&
                attribute.ConstructorArguments.Length > 0 &&
                attribute.ConstructorArguments[0].Value is INamedTypeSymbol iNamedTypeSymbol)
            {
                assemblies.Add(iNamedTypeSymbol.ContainingAssembly);
            }
        }

        return [.. assemblies];
    }

    private static void GetClasses(SourceProductionContext spc, IAssemblySymbol symbol)
    {
        var generator = new GeneratorHost();

        foreach (var publicClass in Extensions.GetPublicClasses(symbol.GlobalNamespace))
        {
            if (Extensions.InheritsFrom(publicClass, "Avalonia.Visual"))
            {
                var code = generator.GenerateExtensions(publicClass);

                if (code != null)
                {
                    spc.AddSource($"{Extensions.RemoveIllegalFileNameCharacters(publicClass.ToString())}.g.cs", code);
                }
            }
        }
    }
}