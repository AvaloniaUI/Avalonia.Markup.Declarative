using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using AvaloniaExtensionGenerator;
using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator;

[Generator]
public class AvaloniaExtensionsGenerator : ISourceGenerator
{
    public void Execute(GeneratorExecutionContext context)
    {
#if DEBUG
        if (!Debugger.IsAttached)
        {
            Debugger.Launch();
        }
#endif
        Debug.WriteLine("Execute AvaloniaExtensionsGenerator code generator");

        var comp = context.Compilation;
        var sb = new StringBuilder();
        var generator = new GeneratorHost();

        var typeByMetadataName = comp.GetTypeByMetadataName("Avalonia.Markup.Declarative.GenerateMarkupForAssemblyAttribute");
        var assemblies = ImmutableArray.CreateBuilder<IAssemblySymbol>();

        assemblies.Add(context.Compilation.Assembly);

        foreach (AttributeData attributeData in comp.Assembly.GetAttributes())
        {
            var attributeClass = attributeData.AttributeClass;
            if ((attributeClass != null ? (!attributeClass.Equals(typeByMetadataName, SymbolEqualityComparer.Default) ? 1 : 0) : 1) == 0)
            {
                var constructorArgument = attributeData.ConstructorArguments[0];

                if (constructorArgument.Value is INamedTypeSymbol iNamedTypeSymbol)
                    assemblies.Add(iNamedTypeSymbol.ContainingAssembly);
            }
        }

        foreach (IAssemblySymbol assembly in assemblies)
        {
            foreach (INamedTypeSymbol publicClass in assembly.GlobalNamespace.GetPublicClasses())
            {
                if (publicClass.Name == "CartesianChart")
                {

                }

                var code = generator.GenerateExtensions(publicClass);

                if (code != null)
                {
                    context.AddSource($"{publicClass.GetFullName()}.g.cs".TrimStart('.'), code);
                }
            }
        }

        return;
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        Debug.WriteLine("Initialize code generator");
        // No initialization required for this one
    }

    //public string GetPropertySetterExtension(string controlTypeName, IFieldSymbol field)
    //{
    //    var extensionName = field.Name.Replace("Property", "");

    //    var type = (field.Type as INamedTypeSymbol).TypeArguments[0];

    //    var valueTypeSource = $"{(string.IsNullOrEmpty(type.ContainingNamespace.Name) ? "" : type.ContainingNamespace)}.{type.Name}".TrimStart('.');

    //    var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
    //                     + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

    //    var extensionText =
    //        $"public static {controlTypeName} {extensionName}"
    //        + $"(this {controlTypeName} control, {argsString})"
    //        + $"=>{Environment.NewLine} control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

    //    return extensionText;
    //}

    //public string GetExpressionBindingSetterExtension(string controlTypeName, IFieldSymbol field)
    //{
    //    var extensionName = field.Name.Replace("Property", "");

    //    var type = (field.Type as INamedTypeSymbol).TypeArguments[0];

    //    var valueTypeSource = $"{(string.IsNullOrEmpty(type.ContainingNamespace.Name) ? "" : type.ContainingNamespace)}.{type.Name}".TrimStart('.');

    //    var extensionText =
    //        $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){Environment.NewLine}" +
    //        $"   => control._set({controlTypeName}.{extensionName}Property, func, onChanged, expression);";

    //    return extensionText;
    //}

    //private string GetBindFromExpressionSetterGenerator(string controlTypeName, IFieldSymbol field)
    //{
    //    var extensionName = field.Name.Replace("Property", "");

    //    var type = (field.Type as INamedTypeSymbol).TypeArguments[0];

    //    var valueTypeSource = $"{(string.IsNullOrEmpty(type.ContainingNamespace.Name) ? "" : type.ContainingNamespace)}.{type.Name}".TrimStart('.');

    //    return
    //    $"public static {field} {info.ExtensionName}2<{info.GenericArg}>(this {info.ReturnType} control, Func<{info.ValueTypeSource}> func, Action<{info.ValueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) {info.GenericConstraint} {Environment.NewLine}" +
    //    $"   => control._set({controlTypeName}.{info.FieldInfo.Name}, func, onChanged, expression);";
    //}

    //private string GetCommonPropertySetterExtension(string controlTypeName, IPropertySymbol property)
    //{
    //    var extensionName = property.Name;

    //    var valueTypeSource = GetPropertyTypeName(property);

    //    var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
    //                     + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

    //    var extensionText =
    //        $"public static {controlTypeName} {extensionName}"
    //        + $"(this {controlTypeName} control, {argsString})"
    //        + $"=>{Environment.NewLine} control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

    //    return extensionText;
    //}

    //private string GetCommonPropertyBindingSetterExtension(string controlTypeName, IPropertySymbol property)
    //{
    //    var extensionName = property.Name;
    //    var valueTypeSource = GetPropertyTypeName(property);

    //    var extensionText =
    //        $"public static {controlTypeName} {extensionName}"
    //        + $"(this {controlTypeName} control, IBinding binding)"
    //        + $"=>{Environment.NewLine} control._setCommonBindingEx(({valueTypeSource} value) => control.{extensionName} = value, binding);";

    //    return extensionText;
    //}

    //private string GetCommonPropertyExpressionBindingSetterExtension(string controlTypeName, IPropertySymbol property)
    //{
    //    var extensionName = property.Name;
    //    var valueTypeSource = GetPropertyTypeName(property);

    //    var extensionText =
    //        $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){Environment.NewLine}" +
    //        $"   => control._set((v) => control.{extensionName} = v, func, onChanged, expression);";

    //    return extensionText;
    //}

    //private string GetMagicalSetterGeneratorExtension(string controlTypeName, IFieldSymbol property)
    //{
    //    return
    //    $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}"
    //    + $"(this {info.ReturnType} control,"
    //    + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
    //    + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Environment.NewLine}"
    //    + $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.MemberName} = value, bindingMode, converter, bindingSource);";
    //}



    //public string GetEventExtension(string controlTypeName, IEventSymbol @event)
    //{
    //    var eventHandler = @event.Type.ToString();

    //    //todo
    //    var eventArgsType = ""; // string.Join(",", @event.Declaration.Type.DescendantNodes().OfType<IdentifierNameSyntax>().Select(x => x.ToString()).ToArray());

    //    var argsString = $"Action<{eventArgsType}> action";

    //    var actionCallStr = "action(args)";

    //    if (string.IsNullOrWhiteSpace(eventArgsType))
    //    {
    //        argsString = $"Action action";
    //        actionCallStr = "action()";
    //    }

    //    //todo
    //    var eventName = @event.Name; // @event.Declaration.Variables[0].ToString();
    //    var extensionName = "On" + eventName;

    //    var extensionText =
    //        $"    public static {controlTypeName} {extensionName}"
    //        + $"(this {controlTypeName} control, {argsString}) => {Environment.NewLine}"
    //        + $"        control._setEvent(({eventHandler}) ((_, args) => {actionCallStr}), h => control.{eventName} += h);";


    //    return extensionText;
    //}
}