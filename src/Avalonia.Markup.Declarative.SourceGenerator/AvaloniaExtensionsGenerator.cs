using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using AvaloniaExtensionGenerator;
using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaExtensionsGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            Debugger.Launch();
        }
#endif
        Debug.WriteLine("Execute AvaloniaExtensionsGenerator code generator");

        var comp = context.Compilation;
        var sb = new StringBuilder();
        var generator = new GeneratorHost();

        var typeByMetadataName = comp.GetTypeByMetadataName("Avalonia.Markup.Declarative.GenerateMarkupForAssemblyAttribute");
        var assemblies = ImmutableArray.CreateBuilder<IAssemblySymbol>();

        assemblies.Add(context.Compilation.Assembly);

        foreach (AttributeData attributeData in comp.Assembly.GetAttributes())
        {
            var attributeClass = attributeData.AttributeClass;
            if ((attributeClass != null ? (!attributeClass.Equals(typeByMetadataName, SymbolEqualityComparer.Default) ? 1 : 0) : 1) == 0)
            {
                var constructorArgument = attributeData.ConstructorArguments[0];

                if (constructorArgument.Value is INamedTypeSymbol iNamedTypeSymbol)
                    assemblies.Add(iNamedTypeSymbol.ContainingAssembly);
            }
        }

        foreach (IAssemblySymbol assembly in assemblies)
        {
            foreach (INamedTypeSymbol publicClass in assembly.GlobalNamespace.GetPublicClasses())
            {
                var code = generator.GenerateExtensions(publicClass);

                if (code != null)
                {
                    context.AddSource($"{publicClass}.g.cs".TrimStart('.'), code);
                }
            }
        }

        return;
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        Debug.WriteLine("Initialize code generator");
        // No initialization required for this one
    }
}