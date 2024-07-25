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
        new EventsExtensionGenerator(_config, $@"{_config.BasePath}\ControlEventExtensions.Generated.cs",
            new ActionToEventGenerator()
            ).Generate();

        new PropertyExtensionsGenerator(_config, $@"{_config.BasePath}\ControlPropertyExtensions.Generated.cs",
            // new ValueSetterGenerator(),
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new MagicalSetterGenerator(),
            new MagicalSetterWithConverterGenerator(),
            new ValueOverloadsSetterGenerator()
            ).Generate();

        new StylePropertyExtensionsGenerator(_config, $@"{_config.BasePath}\StylePropertyExtensions.Generated.cs",
            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
            ).Generate();

    }

    public static void RunDefaultAvaloniaFrameworkGenerators()
    {
        var basePath = new DirectoryInfo(GetBasePath(AppDomain.CurrentDomain.BaseDirectory)).FullName;
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
}