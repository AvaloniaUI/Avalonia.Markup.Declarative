using AvaloniaExtensionGenerator.Generators;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;
using AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

namespace AvaloniaExtensionGenerator;

public class GeneratorHost(ExtensionGeneratorConfig config)
{
    public void GenerateExtensions()
    {
        if (!Directory.Exists(config.BasePath))
        {
            Directory.CreateDirectory(config.BasePath);
        }

        new EventsExtensionGenerator(config, $@"{config.BasePath}\ControlEventExtensions.g.cs",
            new ActionToEventGenerator()
            ).Generate();

        new PropertyExtensionsGenerator(config, $@"{config.BasePath}\ControlPropertyExtensions.g.cs",
            // new ValueSetterGenerator(),
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new MagicalSetterGenerator(),
            new MagicalSetterWithConverterGenerator(),
            new ValueOverloadsSetterGenerator()
            ).Generate();

        new StylePropertyExtensionsGenerator(config, $@"{config.BasePath}\StylePropertyExtensions.g.cs",
            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
            ).Generate();

    }
    
    internal static string RunControlTypeGenerators(IReadOnlyList<Type> types, string projectDirPath)
    {
        var outputPath = Path.Combine(projectDirPath, "ControlExtensions.Generated");

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