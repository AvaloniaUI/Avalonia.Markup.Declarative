using System.Reflection;
using System.Text;
using static AvaloniaExtensionGenerator.AvaloniaTypeHelper;

namespace AvaloniaExtensionGenerator;

public class PropertyExtensionsGenerator
{
    public string OutputPath { get; set; }

    public Config Config { get; set; }

    public ISetterExtensionGenerator[] Generators { get; private set; }

    public PropertyExtensionsGenerator(Config config, string outputPath, params ISetterExtensionGenerator[] generators)
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
        
        sb.AppendLine("#nullable enable");
        
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
        var objIndex = 0;
        var i = 0;

        foreach (var controlType in controlTypes)
        {
            objIndex++;

            if (Config.Exclude.Contains(controlType))
                continue;

            var fields = controlType.GetFields().Where(IsAcceptableField).ToArray();

            if (!fields.Any())
                continue;
           
            Console.WriteLine($"{objIndex:N} {controlType.Name}");

            sb.AppendLine($"public static partial class {controlType.Name}Extensions");
            sb.AppendLine("{");

            foreach (var field in fields)
            {
                Console.WriteLine($"\t{i++} - {field.Name} : {field.FieldType}");

                foreach (var generator in Generators)
                {
                    var setterExtension = generator.GetSetterExtension(field, out var usedNamespaces);
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

    private static bool IsAcceptableField(FieldInfo field)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;

        if (field.FieldType.Name.StartsWith("DirectProperty") ||
            field.FieldType.Name.StartsWith("StyledProperty") ||
            field.FieldType.Name.StartsWith("AttachedProperty"))
        {
            return !IsReadOnlyField(field);
        }
        return false;
    }

    public static bool IsReadOnlyField(FieldInfo field)
    {
        var controlType = field.DeclaringType;
        var extensionName = field.Name.Replace("Property", "");
        var propertyName = field.Name.Replace("Property", "");

        var propInfo = controlType?.GetProperty(propertyName);
        if (propInfo != null)
        {
            return propInfo.GetSetMethod() == null && propInfo.CanRead;
        }
        return true;
    }
}