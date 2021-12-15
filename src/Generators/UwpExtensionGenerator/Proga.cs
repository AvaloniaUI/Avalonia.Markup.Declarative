using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Shapes;

public class Proga
{

    Type[] ignoreTypes = new Type[] {
            typeof(MapControl),
        };

    Type[] useFullNamespace = new Type[] {
            typeof(Shape),
            typeof(HandwritingView),
            typeof(Windows.Globalization.DayOfWeek),
            typeof(AutoSuggestBox)
        };

    Type[] baseTypes = new[] {
            //typeof(Layoutable),
            //typeof(Visual),
            //typeof(TemplatedControl),
            typeof(FrameworkElement),
            typeof(Control),
            //typeof(Panel),
            typeof(ItemsControl),
            typeof(Shape)
        };

    public async void Generate()
    {

        var type = typeof(FrameworkElement);
        var controlTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(s => s.GetTypes())
            .Where(p => type.IsAssignableFrom(p) && !ignoreTypes.Contains(p))
            .ToList();

        controlTypes.AddRange(baseTypes);

        controlTypes = controlTypes.Distinct().ToList();

        var nssb = new StringBuilder();

        var sb = new StringBuilder();
        var NameSpaces = new HashSet<string>()
        {
            "Windows.UI.Xaml.Data"
        };
        
        var i = 0;
        foreach (var controlType in controlTypes)
        {
            if (controlType.IsGenericType)
                continue;
            if (controlType.GetCustomAttribute<ObsoleteAttribute>() != null)
                continue;

            Console.WriteLine(controlType.Name);

            var props = controlType.GetProperties();

            foreach (var property in props)
            {
                if (property.GetCustomAttribute<ObsoleteAttribute>() != null)
                    continue;

                if (property.PropertyType.Name.StartsWith("DependencyProperty"))
                {
                    if (IsReadOnly(property))
                        continue;

                    Console.WriteLine($"\t{i++} - {property.Name} : {property.PropertyType}");

                    var setterExtension = GetPropertySetterExtension(property, NameSpaces);
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
            //"namespace Avalonia;" + Environment.NewLine +
            "public static class ControlExtensions" + Environment.NewLine +
            "{" + Environment.NewLine +
            sb.ToString() + Environment.NewLine +
            "}";



        var savePicker = new Windows.Storage.Pickers.FileSavePicker();
        savePicker.SuggestedStartLocation =
            Windows.Storage.Pickers.PickerLocationId.DocumentsLibrary;
        // Dropdown of file types the user can save the file as
        savePicker.FileTypeChoices.Add("FrameworkElementExtensions", new List<string>() { ".cs" });
        // Default file name if the user does not type one in or select a file to replace
        savePicker.SuggestedFileName = "New Document";

        var file = await savePicker.PickSaveFileAsync();

        await Windows.Storage.FileIO.WriteTextAsync(file, result);
        //File.WriteAllText(file.Path, result);


        string GetPropertySetterExtension(PropertyInfo property, HashSet<string> namespaces)
        {
            var controlType = property.DeclaringType;
            var controlTypeName = GetSourceCode(controlType, namespaces);
            var extensionName = property.Name.Replace("Property", "");
            var propertyName = property.Name.Replace("Property", "");

            if (!string.IsNullOrWhiteSpace(controlType.Namespace))
                namespaces.Add(controlType.Namespace);

            var directPropertyInfo = controlType.GetProperty(propertyName);
            var valueType = directPropertyInfo.PropertyType;

            var valueTypeSource = GetSourceCode(valueType, namespaces);
            //BindingBase
            //direct type access
            var extensionText =
                $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, {valueTypeSource} value){Environment.NewLine}" +
                $"   => control._set(() => control.{propertyName} = value);" + Environment.NewLine +
                //binding support
                $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, BindingBase binding){Environment.NewLine}" +
                $"   => control._set(() => control.SetBinding({controlTypeName}.{property.Name}, binding));";

            //base type generic acess
            if (baseTypes.Contains(controlType))
            {
                extensionText =
                    $"public static T {extensionName}<T>(this T control, {valueTypeSource} value) where T : {controlTypeName}{Environment.NewLine}" +
                    $"   => control._set(() => control.{propertyName} = value);" + Environment.NewLine +

                    //binding support
                    $"public static T {extensionName}<T>(this T control, BindingBase binding) where T : {controlTypeName}{Environment.NewLine}" +
                    $"   => control._set(() => control.SetBinding({controlTypeName}.{property.Name}, binding));";
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
            "public static Brush ToBrush(this Color color) => new SolidColorBrush(color);";

        sb.AppendLine(extra);
    }

    bool IsReadOnly(PropertyInfo field)
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

}