using AvaloniaExtensionGenerator;
using AvaloniaExtensionGenerator.EventGenerators;
using AvaloniaExtensionGenerator.SetterGenerators;
using AvaloniaExtensionGenerator.StyleSetterGenerators;

var config = new Config();

var basePath = new DirectoryInfo(GetBasePath(AppDomain.CurrentDomain.BaseDirectory)).FullName;

Console.WriteLine($"Using output path: {basePath}");

new EventsExtensionGenerator(config, $@"{basePath}\ControlEventExtensions.Generated.cs",
    new ActionToEventGenerator()
    ).Generate();

new PropertyExtensionsGenerator(config, $@"{basePath}\ControlPropertyExtensions.Generated.cs",
    // new ValueSetterGenerator(),
    new BindSetterGenerator(),
    new AvaloniaPropertyBindSetterGenerator(),
    new BindFromExpressionSetterGenerator(),
    new MagicalSetterGenerator(),
    new MagicalSetterWithConverterGenerator(),
    new ValueOverloadsSetterGenerator()
    ).Generate();

new StylePropertyExtensionsGenerator(config, $@"{basePath}\StylePropertyExtensions.Generated.cs",
    new ValueStyleSetterGenerator(),
    new BindingStyleSetterGenerator(),
    new ValueOverloadsStyleSetterGenerator()
    ).Generate();

return;

string GetBasePath(string path)
{
    while (true)
    {
        var directories = Directory.EnumerateDirectories(path);
        foreach (var dir in directories)
        {
            if (dir.EndsWith("Avalonia.Markup.Declarative"))
            {
                return dir;
            }
        }

        path = Path.Combine(path, "..");
    }
}