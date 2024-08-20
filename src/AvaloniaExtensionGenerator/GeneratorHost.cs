using System.Collections.Immutable;
using System.Data.Common;
using System.Reflection;
using System.Text;
using AvaloniaExtensionGenerator.Generators;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;
using AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

namespace AvaloniaExtensionGenerator;

public class GeneratorHost(ExtensionGeneratorConfig config)
{
    public static string RunControlTypeGenerators(IReadOnlyList<Type> types, string outputPath)
    {
        if (Directory.Exists(outputPath))
            Directory.Delete(outputPath, true);

        var config = new ExtensionGeneratorConfig(outputPath)
        {
            TypesToProcess = types.Where(IsAcceptableControlType).Distinct().ToArray(),
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

        static bool IsAcceptableControlType(Type controlType) =>
            controlType is { IsPublic: true, IsGenericType: false } &&
            controlType.GetCustomAttribute<ObsoleteAttribute>() == null;
    }

    private void GenerateExtensions()
    {
        if (!Directory.Exists(config.OutputPath)) 
            Directory.CreateDirectory(config.OutputPath);

        List<IExtensionGroupGenerator> groupGenerators =
        [
            new ExtensionGroupGenerator<FieldInfo>("Properties", t => t.GetFields().Where(IsAcceptableField),
                new BindFromExpressionSetterGenerator(),
                new MagicalSetterGenerator(),
                new ValueOverloadsSetterGenerator(),

                //obsolete candidates
                new BindSetterGenerator(),
                new AvaloniaPropertyBindSetterGenerator(),
                new MagicalSetterWithConverterGenerator()
            ),

            new ExtensionGroupGenerator<EventInfo>("Events", t => t.GetEvents().Where(x => x.DeclaringType == t),
                new ActionToEventGenerator()),

            new ExtensionGroupGenerator<FieldInfo>("Styles",
                t => !IsStyledElement(t) ? [] : t.GetFields().Where(IsAcceptableStyledField),
                new ValueStyleSetterGenerator(),
                new BindingStyleSetterGenerator(),
                new ValueOverloadsStyleSetterGenerator()
            )
        ];
        
        foreach (var controlType in config.TypesToProcess)
        {
            var totalGenerated = 0;
            var extensionGroups = groupGenerators.Select(x =>
            {
                var extensions = x.Generate(controlType, out var generationsCount);
                totalGenerated += generationsCount;
                return (x.GroupName, extensions, amount: generationsCount);
            }).ToImmutableList();

            //skip types without extensions
            if(extensionGroups.All(x=>x.amount == 0))
                continue;

            Console.WriteLine($"{controlType.Name} : generated {totalGenerated} extensions");

            var sb = new StringBuilder();
            sb.AppendLine("#nullable enable");

            foreach (var ns in config.InitialNamespaces.OrderBy(x => x))
                sb.AppendLine($"using {ns};");

            sb.AppendLine();
            sb.AppendLine("namespace Avalonia.Markup.Declarative;");

            sb.AppendLine($"public static partial class {controlType.Name}_MarkupExtensions");
            sb.AppendLine("{");

            foreach (var group in extensionGroups)
            {
                sb.AppendLine($"//================= {group.GroupName} ======================//");
                sb.AppendLine(group.extensions);
            }

            sb.AppendLine("}");

            var outputPath = Path.Combine(config.OutputPath, $"{controlType.Name}_MarkupExtensions.g.cs");
            File.WriteAllText(outputPath, sb.ToString());
        }
    }

    private static bool IsAcceptableField(FieldInfo field)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;

        //if (field.FieldType.Name.StartsWith("AttachedProperty"))
        //{
        //    Console.ForegroundColor = ConsoleColor.Magenta;
        //    Console.WriteLine($"{field.Name} is Attached Property.");
        //    Console.ForegroundColor = ConsoleColor.Gray;
        //    return true;
        //}

        if (field.FieldType.Name.StartsWith("DirectProperty") ||
            field.FieldType.Name.StartsWith("StyledProperty") ||
            field.FieldType.Name.StartsWith("AvaloniaProperty"))
        {
            var isReadOnly = IsReadOnlyField(field);
            if (isReadOnly)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine($"{field.Name} is read only - skipped.");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            return !isReadOnly;
        }

        return false;
    }

    private static bool IsAcceptableStyledField(FieldInfo field)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            return false;

        if (field.FieldType.Name.StartsWith("StyledProperty") ||
            field.FieldType.Name.StartsWith("AttachedProperty"))
            return !IsReadOnlyField(field);

        return false;
    }

    private static bool IsReadOnlyField(FieldInfo field)
    {
        try
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
        catch (Exception e)
        {
            Console.WriteLine(e);
            Console.WriteLine("skipped");
        }

        return false;
    }

    private static Type? _styledElementType;


    public static bool IsStyledElement(Type controlType)
    {
        _styledElementType ??= AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.ExportedTypes)
            .FirstOrDefault(x => x.FullName == "Avalonia.StyledElement");

        if (_styledElementType == null)
            throw new NullReferenceException("Styled element Type can't be loaded");

        return _styledElementType?.IsAssignableFrom(controlType) ?? false;
    }

}