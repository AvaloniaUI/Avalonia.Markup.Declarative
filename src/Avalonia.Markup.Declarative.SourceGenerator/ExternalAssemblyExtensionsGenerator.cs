using System.Text;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.Text;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public sealed class ExternalAssemblyExtensionsGenerator : IIncrementalGenerator
{
    public void Initialize(IncrementalGeneratorInitializationContext context)
    {
        var selectedAssemblies = context.CompilationProvider
            .Select(static (compilation, _) => SymbolUtilities.GetTargetAssemblies(compilation));

        context.RegisterSourceOutput(selectedAssemblies, static (spc, assemblies) =>
        {
            var generatorHost = new ExternalGeneratorHost();

            foreach (var assembly in assemblies)
            {
                foreach (var publicClass in SymbolUtilities.GetPublicClasses(assembly.GlobalNamespace))
                {
                    if (!publicClass.IsOrInheritsFrom("Avalonia.AvaloniaObject"))
                    {
                        continue;
                    }

                    var code = generatorHost.GenerateExtensions(publicClass);
                    if (string.IsNullOrWhiteSpace(code))
                    {
                        continue;
                    }

                    var hintName = $"External_{SymbolUtilities.RemoveIllegalFileNameCharacters(publicClass.ToDisplayString())}.g.cs";
                    spc.AddSource(hintName, SourceText.From(code!, Encoding.UTF8));
                }
            }
        });
    }
}
