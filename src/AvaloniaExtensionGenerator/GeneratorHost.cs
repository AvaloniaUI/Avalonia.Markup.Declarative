using Avalonia;
using AvaloniaExtensionGenerator.Generators;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;
using AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

namespace AvaloniaExtensionGenerator;

public class GeneratorHost
{
    private readonly IConfig _config;

    public GeneratorHost(IConfig config)
    {
        _config = config;
    }

    public void GenerateExtensions()
    {
        if (!Directory.Exists(_config.BasePath))
        {
            Directory.CreateDirectory(_config.BasePath);
        }

        new EventsExtensionGenerator(_config, $@"{_config.BasePath}\ControlEventExtensions.g.cs",
            new ActionToEventGenerator()
            ).Generate();

        new PropertyExtensionsGenerator(_config, $@"{_config.BasePath}\ControlPropertyExtensions.g.cs",
            // new ValueSetterGenerator(),
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new MagicalSetterGenerator(),
            new MagicalSetterWithConverterGenerator(),
            new ValueOverloadsSetterGenerator()
            ).Generate();

        new StylePropertyExtensionsGenerator(_config, $@"{_config.BasePath}\StylePropertyExtensions.g.cs",
            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
            ).Generate();

    }

    public static void RunDefaultAvaloniaFrameworkGenerators()
    {
        //use directory info to get absolute path
        var basePath = new DirectoryInfo(GetBasePath(AppDomain.CurrentDomain.BaseDirectory)).FullName;
        basePath = Path.Combine(basePath, "ControlExtensions.Generated");
        var config = new DefaultAvaloniaConfig(basePath);
        Console.WriteLine($"Using output path: {basePath}");

        var host = new GeneratorHost(config);
        host.GenerateExtensions();
    }

    private static string GetBasePath(string path)
    {
        while (true)
        {
            var directories = Directory.EnumerateDirectories(path);
            foreach (var dir in directories)
                if (dir.EndsWith("Avalonia.Markup.Declarative"))
                    return dir;

            path = Path.Combine(path, "..");
        }
    }

    internal static void RunControlTypeGenerators(IReadOnlyList<Type> types, Type[] skipTypesFromProcess, string projectDirPath)
    {
        var outputPath = Path.Combine(projectDirPath, "ControlExtensions.Generated");
        var config = new ExtensionGeneratorConfig(outputPath)
        {
            TypesToProcess = types.ToArray(),
            //don't generate avalonia default extensions
            Exclude = skipTypesFromProcess,
            //BaseTypes = defaultAvaloniaConfig.BaseTypes,
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
    }
}