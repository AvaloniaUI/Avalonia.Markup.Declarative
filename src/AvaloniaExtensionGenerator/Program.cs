using AvaloniaExtensionGenerator;

var config = new Config();

new EventsExtensionGenerator(config, "..\\Avalonia.Markup.Declarative\\ControlEventExtensions.Generated.cs",
    new ActionToEventGenerator()
    ).Generate();

new PropertyExtensionsGenerator(config, "..\\Avalonia.Markup.Declarative\\ControlPropertyExtensions.Generated.cs",
    // new ValueSetterGenerator(),
    new BindSetterGenerator(),
    new MagicalSetterGenerator(),
    new ValueOverloadsSetterGenerator()
    ).Generate();