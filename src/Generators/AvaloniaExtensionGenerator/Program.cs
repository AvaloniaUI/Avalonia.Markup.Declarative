using AvaloniaExtensionGenerator;

var config = new Config();
var generator = new ExtensionGenerator(config,
    // new ValueSetterGenerator(),
    new BindSetterGenerator(),
    new MagicalSetterGenerator(),
    new ValueOverloadsSetterGenerator()
    );
generator.Generate();