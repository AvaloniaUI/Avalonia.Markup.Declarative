using AvaloniaExtensionGenerator.Generators;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;
using AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

namespace AvaloniaExtensionGenerator;

public class GeneratorHost(ExtensionGeneratorConfig config)
{
    public void GenerateExtensions()
    {
        if (!Directory.Exists(config.OutputPath))
        {
            Directory.CreateDirectory(config.OutputPath);
        }

        new EventsExtensionGenerator(config,
            new ActionToEventGenerator()
            ).Generate();

        new PropertyExtensionsGenerator(config,
            // new ValueSetterGenerator(),
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new MagicalSetterGenerator(),
            new MagicalSetterWithConverterGenerator(),
            new ValueOverloadsSetterGenerator()
            ).Generate();

        new StylePropertyExtensionsGenerator(config,
            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
            ).Generate();

    }
    
    internal static string RunControlTypeGenerators(IReadOnlyList<Type> types, string outputPath)
    {
        if(Directory.Exists(outputPath))
            Directory.Delete(outputPath, true);

        var config = new ExtensionGeneratorConfig(outputPath)
        {
            TypesToProcess = types.ToArray(),
            InitialNamespaces =
            [
                "Avalonia.Data",
                "Avalonia.Data.Converters",
                "System",
                "System.Numerics",
                "System.Linq.Expressions",
                "System.Runtime.CompilerServices"

            ]
        };

        Console.WriteLine($"Using output path: {outputPath}");

        var host = new GeneratorHost(config);
        host.GenerateExtensions();

        return outputPath;
    }
}