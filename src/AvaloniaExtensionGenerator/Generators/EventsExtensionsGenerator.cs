using System.Text;
using static AvaloniaExtensionGenerator.AvaloniaTypeHelper;

namespace AvaloniaExtensionGenerator.Generators;

public class EventsExtensionGenerator
{
    public string OutputPath { get; set; }

    public IConfig Config { get; set; }

    public IEventExtensionGenerator[] Generators { get; private set; }

    public EventsExtensionGenerator(IConfig config, string outputPath, params IEventExtensionGenerator[] generators)
    {
        Config = config;
        OutputPath = outputPath;
        Generators = generators;

        foreach (var generator in Generators)
            generator.Config = Config;
    }


    public void Generate()
    {
        var controlTypes = GetControlTypes(Config);

        var nameSpaces = new HashSet<string>(Config.InitialNamespaces);
        var extensionClassesString = GetExtensionClasses(controlTypes, ref nameSpaces);

        var sb = new StringBuilder();
        foreach (var ns in nameSpaces.OrderBy(x => x))
            sb.AppendLine($"using {ns};");

        sb.AppendLine();
        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine(extensionClassesString);

        File.WriteAllText(OutputPath, sb.ToString());
    }


    private string GetExtensionClasses(IEnumerable<Type> controlTypes, ref HashSet<string> namespaces)
    {
        var sb = new StringBuilder();
        var i = 0;

        foreach (var controlType in controlTypes)
        {
            if (Config.Exclude.Contains(controlType))
                continue;

            var events = controlType.GetEvents().Where(x=>x.DeclaringType == controlType).ToArray();

            if (!events.Any())
                continue;
               
            Console.WriteLine(controlType.Name);

            sb.AppendLine($"public static partial class {controlType.Name}EventsExtensions");
            sb.AppendLine("{");

            foreach (var eventInfo in events)
            {
                Console.WriteLine($"\t{i++} - {eventInfo.Name} : {eventInfo.EventHandlerType}");

                foreach (var generator in Generators)
                {
                    var setterExtension = generator.GetEventExtension(eventInfo, out var usedNamespaces);
                    if (string.IsNullOrWhiteSpace(setterExtension))
                        continue;

                    AddUsedNamespaces(usedNamespaces, ref namespaces);

                    sb.AppendLine(setterExtension);
                }
            }
                
            sb.AppendLine("}");
        }
        return sb.ToString();
    }
}