// See https://aka.ms/new-console-template for more information

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Layout;
using System.Reflection;
using System.Text;

var useFullNamespace = new[] { 
    typeof(Calendar),
    typeof(ContextMenu),
};

var baseTypes = new[] {
    typeof(Layoutable),
    typeof(Visual),
    typeof(TemplatedControl),
    typeof(ItemsControl)
};

var type = typeof(Control);
var controlTypes = AppDomain.CurrentDomain.GetAssemblies()
    .SelectMany(s => s.GetTypes())
    .Where(p => type.IsAssignableFrom(p))
    .ToList();

controlTypes.AddRange(baseTypes);

controlTypes = controlTypes.Distinct().ToList();

var nssb = new StringBuilder();

var sb = new StringBuilder();
var NameSpaces = new HashSet<string>()
{
    "Avalonia.Data"
};

var i = 0;
foreach (var controlType in controlTypes)
{
    if (controlType.IsGenericType)
        continue;
    if (controlType.GetCustomAttribute<ObsoleteAttribute>() != null)
        continue;

    Console.WriteLine(controlType.Name);

    var props = controlType.GetFields();

    foreach (var field in props)
    {
        if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
            continue;

        if (field.FieldType.Name.StartsWith("DirectProperty") ||
            field.FieldType.Name.StartsWith("StyledProperty") ||
            field.FieldType.Name.StartsWith("AttachedProperty"))
        {
            if (IsReadOnly(field))
                continue;

            Console.WriteLine($"\t{i++} - {field.Name} : {field.FieldType}");

            var setterExtension = GetPropertySetterExtension(field, NameSpaces);
            //Console.WriteLine($"\n{setterExtension}");
            sb.AppendLine(setterExtension);
            sb.AppendLine();
        }
    }

}

AddExtraCode(sb);

foreach (var ns in NameSpaces.OrderBy(x => x))
    nssb.AppendLine($"using {ns};");

nssb.AppendLine();

var result =
    nssb.ToString() + Environment.NewLine +
    "namespace Avalonia;" + Environment.NewLine +
    "public static class ControlExtensions" + Environment.NewLine +
    "{" + Environment.NewLine +
    sb.ToString() + Environment.NewLine +
    "}";

File.WriteAllText("AvaloniaControlExtensions.cs", result);

string GetPropertySetterExtension(FieldInfo field, HashSet<string> namespaces)
{
    var controlType = field.DeclaringType;
    var controlTypeName = GetSourceCode(controlType, namespaces);
    var extensionName = field.Name.Replace("Property", "");
    var propertyName = field.Name.Replace("Property", "");

    if (!string.IsNullOrWhiteSpace(controlType.Namespace))
        namespaces.Add(controlType.Namespace);

    var valueType = field.FieldType.GetGenericArguments().Last();

    var valueTypeSource = GetSourceCode(valueType, namespaces);

    //direct type access
    var extensionText =
        $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, {valueTypeSource} value){Environment.NewLine}" +
        $"   => control._set(() => control.{propertyName} = value);" + Environment.NewLine +
        //binding support
        $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, IBinding binding){Environment.NewLine}" +
        $"   => control._set(() => control[!{controlTypeName}.{field.Name}] = binding);";

    //base type generic acess
    if (baseTypes.Contains(controlType))
    {
        extensionText =
            $"public static T {extensionName}<T>(this T control, {valueTypeSource} value) where T : {controlTypeName}{Environment.NewLine}" +
            $"   => control._set(() => control.{propertyName} = value);" + Environment.NewLine +

            //binding support
            $"public static T {extensionName}<T>(this T control, IBinding binding) where T : {controlTypeName}{Environment.NewLine}" +
            $"   => control._set(() => control[!{controlTypeName}.{field.Name}] = binding);";
    }

    if (!valueType.Module.ScopeName.StartsWith("System")
        && valueType.IsValueType
        && valueType.GetConstructors().Length > 1)
    {
        foreach (var constructor in valueType.GetConstructors())
        {
            var ps = constructor.GetParameters();
            var argDefs = string.Join(", ", ps.Select(x => $"{x.ParameterType.Name} {x.Name}"));
            var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

            if (baseTypes.Contains(controlType))
            {
                extensionText += Environment.NewLine +
                    $"public static T {extensionName}<T>(this T control, {argDefs}) where T : {controlTypeName}{Environment.NewLine}" +
                    $"   => control._set(() => control.{propertyName} = new {valueTypeSource}({argVals}));";
            }
            else
            {
                extensionText += Environment.NewLine +
                    $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, {argDefs}){Environment.NewLine}" +
                    $"   => control._set(() => control.{propertyName} = new {valueTypeSource}({argVals}));";
            }
        }
    }

    return extensionText;
}

string GetSourceCode(Type valueType, HashSet<string> namespaces)
{
    if (!string.IsNullOrWhiteSpace(valueType.Namespace))
        namespaces.Add(valueType.Namespace);

    var result = valueType.Name;

    if (valueType.IsGenericType)
    {
        result = result.Split('`')[0];
        var genericArguments = valueType.GetGenericArguments();
        var args = string.Join(',', genericArguments.Select(x => GetSourceCode(x, namespaces)));
        result += $"<{args}>";
    }

    if (useFullNamespace.Contains(valueType))
    {
        result = valueType.Namespace + "." + result;
    }

    return result;
}

void AddExtraCode(StringBuilder sb)
{
    var extra =
        "private static TControl _set<TControl>(this TControl control, Action setAction)" + Environment.NewLine +
        "{" + Environment.NewLine +
        "    setAction();" + Environment.NewLine +
        "    return control;" + Environment.NewLine +
        "}" + Environment.NewLine +
        "public static IBrush ToBrush(this Color color) => new SolidColorBrush(color);";

    sb.AppendLine(extra);
}

bool IsReadOnly(FieldInfo field)
{
    var controlType = field.DeclaringType;
    var extensionName = field.Name.Replace("Property", "");
    var propertyName = field.Name.Replace("Property", "");

    var propInfo = controlType.GetProperty(propertyName);
    if (propInfo != null)
    {
        return propInfo.GetSetMethod() == null && propInfo.CanRead;
    }
    return true;
}
