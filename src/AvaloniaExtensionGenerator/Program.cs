using AvaloniaExtensionGenerator;
using AvaloniaExtensionGenerator.EventGenerators;
using AvaloniaExtensionGenerator.SetterGenerators;
using AvaloniaExtensionGenerator.StyleSetterGenerators;

var config = new Config();

new EventsExtensionGenerator(config, "..\\Avalonia.Markup.Declarative\\ControlEventExtensions.Generated.cs",
    new ActionToEventGenerator()
    ).Generate();

new PropertyExtensionsGenerator(config, "..\\Avalonia.Markup.Declarative\\ControlPropertyExtensions.Generated.cs",
    // new ValueSetterGenerator(),
    new BindSetterGenerator(),
    new AvaloniaPropertyBindSetterGenerator(),
    new BindFromExpressionSetterGenerator(),
    new MagicalSetterGenerator(),
    new MagicalSetterWithConverterGenerator(),
    new ValueOverloadsSetterGenerator()
    ).Generate();

new StylePropertyExtensionsGenerator(config, "..\\Avalonia.Markup.Declarative\\StylePropertyExtensions.Generated.cs",
    new ValueStyleSetterGenerator(),
    new BindingStyleSetterGenerator()
    ).Generate();