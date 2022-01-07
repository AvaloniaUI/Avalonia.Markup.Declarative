using System.Reflection;
using System.Text;
using Avalonia.Controls;

namespace AvaloniaExtensionGenerator
{
    public class ExtensionGenerator
    {
        public string OutputPath { get; set; } = "..\\Avalonia.Markup.Declarative\\ControlExtensions.Generated.cs";

        public Config Config { get; set; }

        public ISetterExtensionGenerator[] Generators { get; private set; }

        public ExtensionGenerator(Config config, params ISetterExtensionGenerator[] generators)
        {
            Config = config;
            Generators = generators;

            foreach (var generator in Generators)
                generator.Config = Config;
        }


        public void Generate()
        {
            var controlTypes = GetControlTypes();

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

        private IEnumerable<Type> GetControlTypes()
        {
            var baseControlType = typeof(Control);
            var controlTypes = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(s => s.GetTypes())
                .Where(p => IsAccepatbleControlType(p) && baseControlType.IsAssignableFrom(p))
                .ToList();

            controlTypes.AddRange(Config.BaseTypes);

            return controlTypes.Distinct();
        }
        private static bool IsAccepatbleControlType(Type controlType)
        {
            if (controlType.IsGenericType)
                return false;
            if (controlType.GetCustomAttribute<ObsoleteAttribute>() != null)
                return false;
            return true;
        }

        private string GetExtensionClasses(IEnumerable<Type> controlTypes, ref HashSet<string> namespaces)
        {
            var sb = new StringBuilder();
            var i = 0;

            foreach (var controlType in controlTypes)
            {
                Console.WriteLine(controlType.Name);

                sb.AppendLine($"public static partial class {controlType.Name}Extensions");
                sb.AppendLine("{");

                foreach (var field in controlType.GetFields().Where(IsAcceptableField))
                {
                    Console.WriteLine($"\t{i++} - {field.Name} : {field.FieldType}");

                    foreach (var generator in Generators)
                    {
                        var setterExtension = generator.GetPropertySetterExtension(field, out var usedNamespaces);
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

        private void AddUsedNamespaces(IEnumerable<string> usedNamespaces, ref HashSet<string> namespaces)
        {
            foreach (var ns in usedNamespaces)
                namespaces.Add(ns);
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
}