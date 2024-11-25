using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using Microsoft.CodeAnalysis;
using static Avalonia.Markup.Declarative.SourceGenerator.MarkupTypeHelpers;

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

        INamedTypeSymbol typeByMetadataName = comp.GetTypeByMetadataName("Avalonia.Markup.Declarative.GenerateMarkupForAssemblyAttribute");
        ImmutableArray<IAssemblySymbol>.Builder builder = ImmutableArray.CreateBuilder<IAssemblySymbol>();

        builder.Add(context.Compilation.Assembly);

        foreach (AttributeData attributeData in comp.Assembly.GetAttributes())
        {
            INamedTypeSymbol attributeClass = attributeData.AttributeClass;
            if ((attributeClass != null ? (!attributeClass.Equals(typeByMetadataName, SymbolEqualityComparer.Default) ? 1 : 0) : 1) == 0)
            {
                TypedConstant constructorArgument = attributeData.ConstructorArguments[0];

                if (constructorArgument.Value is INamedTypeSymbol iNamedTypeSymbol)
                    builder.Add(iNamedTypeSymbol.ContainingAssembly);
            }
        }

        foreach (IAssemblySymbol assembly in builder)
        {
            foreach (INamedTypeSymbol publicClass in GetPublicClasses(assembly.GlobalNamespace))
            {
                var members = publicClass.GetMembers();

                sb.Clear();

                sb.AppendLine("#nullable enable");
                sb.AppendLine("// Auto-generated code " + DateTime.Now.ToString("g"));
                sb.AppendLine("using System;");
                sb.AppendLine("using Avalonia.Data;");
                sb.AppendLine("using Avalonia.Data.Converters;");
                sb.AppendLine("using System.Runtime.CompilerServices;");
                if (!string.IsNullOrEmpty(publicClass.ContainingNamespace.Name))
                {
                    sb.AppendLine($"using {publicClass.ContainingNamespace};");
                }

                var typeName = publicClass.Name;

                sb.AppendLine("namespace Avalonia.Markup.Declarative;");

                sb.AppendLine($"public static partial class {typeName}Extensions");
                sb.AppendLine("{");

                List<string> processedFields = [];

                //PROCESS AVALONIA FIELDS
                foreach (var member in members)
                {
                    if (member is IFieldSymbol field)
                    {
                        if ((field.Type.Name == "DirectProperty" ||
                            field.Type.Name == "StyledProperty" ||
                            field.Type.Name == "AttachedProperty" ||
                            field.Type.Name == "AvaloniaProperty") &&
                            HasAvaloniaPropertyPublicSetter(field, members)
                            )
                        {
                            sb.AppendLine($"//Avalonia Properties{Environment.NewLine}");

                            AppendIfNotNull(sb, GetPropertySetterExtension(typeName, field));
                            AppendIfNotNull(sb, GetExpressionBindingSetterExtension(typeName, field));

                            processedFields.Add(field.Name);
                        }
                    }
                }

                //PROCESS COMMON PROPERTIES
                foreach (var member in members)
                {
                    if (member is IPropertySymbol property)
                    {
                        //skip properties that already processed as Avalonia properties
                        if (!processedFields.Contains(property.Name + "Property")
                        && IsPublic(property) && HasPublicSetter(property) &&
                        IsCommonInstanceProperty(property, members))
                        {
                            sb.AppendLine($"//Common Properties{Environment.NewLine}");

                            AppendIfNotNull(sb, GetCommonPropertySetterExtension(typeName, property));
                            AppendIfNotNull(sb, GetCommonPropertyBindingSetterExtension(typeName, property));
                            AppendIfNotNull(sb, GetCommonPropertyExpressionBindingSetterExtension(typeName, property));

                            processedFields.Add(property.Name);
                        }
                    }
                }

                //PROCESS Events
                foreach (var member in members)
                {
                    if (member is IEventSymbol @event)
                    {
                        sb.AppendLine($"//Events{Environment.NewLine}");

                        AppendIfNotNull(sb, GetEventExtension(typeName, @event));

                        processedFields.Add(@event.Name);
                    }
                }

                sb.AppendLine("}");
                // Add the source code to the compilation
                try
                {
                    if (processedFields.Count > 0)
                        context.AddSource($"{typeName}.g.cs", sb.ToString());
                }
                catch (Exception ex)
                {
                    //throw;
                }

            }
        }

        return;
    }

    public IEnumerable<INamedTypeSymbol> GetPublicClasses(INamespaceSymbol sym)
    {
        foreach (INamedTypeSymbol typeMember in sym.GetTypeMembers())
        {
            if (typeMember.DeclaredAccessibility == Accessibility.Public && typeMember.TypeKind == TypeKind.Class)
                yield return typeMember;
        }
        foreach (INamespaceSymbol namespaceMember in sym.GetNamespaceMembers())
        {
            foreach (INamedTypeSymbol publicClass in GetPublicClasses(namespaceMember))
            {
                if (publicClass.DeclaredAccessibility == Accessibility.Public && publicClass.TypeKind == TypeKind.Class)
                    yield return publicClass;
            }
        }
    }

    private static void AppendIfNotNull(StringBuilder sb, string value)
    {
        if (string.IsNullOrWhiteSpace(value)) return;
        sb.AppendLine(value);
    }

    public void Initialize(GeneratorInitializationContext context)
    {
        Debug.WriteLine("Initalize code generator");
        // No initialization required for this one
    }

    public string GetPropertySetterExtension(string controlTypeName, IFieldSymbol field)
    {
        var extensionName = field.Name.Replace("Property", "");

        var type = (field.Type as INamedTypeSymbol).TypeArguments[0];

        var valueTypeSource = $"{(string.IsNullOrEmpty(type.ContainingNamespace.Name) ? "" : type.ContainingNamespace)}.{type.Name}".TrimStart('.');

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{Environment.NewLine} control._setEx({controlTypeName}.{extensionName}Property, ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    public string GetExpressionBindingSetterExtension(string controlTypeName, IFieldSymbol field)
    {
        var extensionName = field.Name.Replace("Property", "");

        var type = (field.Type as INamedTypeSymbol).TypeArguments[0];

        var valueTypeSource = $"{(string.IsNullOrEmpty(type.ContainingNamespace.Name) ? "" : type.ContainingNamespace)}.{type.Name}".TrimStart('.');

        var extensionText =
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){Environment.NewLine}" +
            $"   => control._set({controlTypeName}.{extensionName}Property, func, onChanged, expression);";

        return extensionText;
    }

    private string GetCommonPropertySetterExtension(string controlTypeName, IPropertySymbol property)
    {
        var extensionName = property.Name;

        var valueTypeSource = GetPropertyTypeName(property);

        var argsString = $"{valueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
                         + $" [CallerArgumentExpression(nameof(value))] string? ps = null";

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString})"
            + $"=>{Environment.NewLine} control._setCommonEx(ps, () => control.{extensionName} = value, bindingMode, converter, bindingSource);";

        return extensionText;
    }

    private string GetCommonPropertyBindingSetterExtension(string controlTypeName, IPropertySymbol property)
    {
        var extensionName = property.Name;
        var valueTypeSource = GetPropertyTypeName(property);

        var extensionText =
            $"public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, IBinding binding)"
            + $"=>{Environment.NewLine} control._setCommonBindingEx(({valueTypeSource} value) => control.{extensionName} = value, binding);";

        return extensionText;
    }

    private string GetCommonPropertyExpressionBindingSetterExtension(string controlTypeName, IPropertySymbol property)
    {
        var extensionName = property.Name;
        var valueTypeSource = GetPropertyTypeName(property);

        var extensionText =
            $"public static {controlTypeName} {extensionName}(this {controlTypeName} control, Func<{valueTypeSource}> func, Action<{valueTypeSource}>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null){Environment.NewLine}" +
            $"   => control._set((v) => control.{extensionName} = v, func, onChanged, expression);";

        return extensionText;
    }

    //private string GetMagicalSetterGeneratorExtension(string controlTypeName, IPropertySymbol property)
    //{
    //    return
    //    $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}"
    //    + $"(this {info.ReturnType} control,"
    //    + $"{info.ValueTypeSource} value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null,"
    //    + $" [CallerArgumentExpression(nameof(value))] string? ps = null) {info.GenericConstraint} {Environment.NewLine}"
    //    + $"=> control._setEx({info.ControlTypeName}.{info.FieldInfo.Name}, ps, () => control.{info.MemberName} = value, bindingMode, converter, bindingSource);";
    //}
    public string GetEventExtension(string controlTypeName, IEventSymbol @event)
    {
        var eventHandler = @event.Type.ToString();

        //todo
        var eventArgsType = ""; // string.Join(",", @event.Declaration.Type.DescendantNodes().OfType<IdentifierNameSyntax>().Select(x => x.ToString()).ToArray());

        var argsString = $"Action<{eventArgsType}> action";

        var actionCallStr = "action(args)";

        if (string.IsNullOrWhiteSpace(eventArgsType))
        {
            argsString = $"Action action";
            actionCallStr = "action()";
        }

        //todo
        var eventName = @event.Name; // @event.Declaration.Variables[0].ToString();
        var extensionName = "On" + eventName;

        var extensionText =
            $"    public static {controlTypeName} {extensionName}"
            + $"(this {controlTypeName} control, {argsString}) => {Environment.NewLine}"
            + $"        control._setEvent(({eventHandler}) ((_, args) => {actionCallStr}), h => control.{eventName} += h);";


        return extensionText;
    }
}