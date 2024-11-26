using System.Collections.Immutable;
using System.Text;
using Avalonia.Markup.Declarative.SourceGenerator;
using AvaloniaExtensionGenerator.ExtensionInfos;
using AvaloniaExtensionGenerator.Generators;
using AvaloniaExtensionGenerator.Generators.AttachedPropertySetterGenerator;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;
using Microsoft.CodeAnalysis;

namespace AvaloniaExtensionGenerator;

public class GeneratorHost()
{
    readonly List<ExtensionGroupGenerator> groupGenerators =
    [
        new("Properties",
            t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(IsAvaloniaPropertyField)
                .Select(x => new PropertyExtensionInfo(x)),

            new BindFromExpressionSetterGenerator(),
            new MagicalSetterGenerator(),
            new ValueOverloadsSetterGenerator(),

            //obsolete candidates
            new BindSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new MagicalSetterWithConverterGenerator()
        ),

        new("Attached Properties",
            t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(IsAttachedPropertyField)
                .Select(x => new AttachedPropertyExtensionInfo(x)),

            new AttachedPropertyMagicalSetterGenerator(),
            new AttachedPropertyBindFromExpressionSetterGenerator()
        ),

        new("Events",
            t => t.GetMembers()
                .OfType<IEventSymbol>()
                .Where(x => x.ContainingType == t)
                .Select(x => new EventExtensionInfo(x)),

            new ActionToEventGenerator()),

        //new("Styles",
        //    t => !IsStyledElement(t) ? [] : t
        //        .GetFields()
        //        .Where(IsAcceptableStyledField)
        //        .Select(x => new PropertyExtensionInfo(x)),

        //    new ValueStyleSetterGenerator(),
        //    new BindingStyleSetterGenerator(),
        //    new ValueOverloadsStyleSetterGenerator()
        //)
    ];

    public string? GenerateExtensions(INamedTypeSymbol controlType)
    {
        var extensionGroups = groupGenerators.Select(x =>
        {
            var extensions = x.Generate(controlType, out var generationsCount);
            return (x.GroupName, extensions, amount: generationsCount);
        }).ToImmutableList();

        //skip types without extensions
        if (extensionGroups.All(x => x.amount == 0))
            return null;

        var sb = new StringBuilder();
        sb.AppendLine("#nullable enable");
        sb.AppendLine($"using Avalonia.Data;");
        sb.AppendLine($"using Avalonia.Data.Converters;");
        sb.AppendLine($"using System;");
        sb.AppendLine($"using System.Numerics;");
        sb.AppendLine($"using System.Linq.Expressions;");
        sb.AppendLine($"using System.Runtime.CompilerServices;");
        sb.AppendLine();
        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine();
        sb.AppendLine($"public static partial class {controlType.Name}_MarkupExtensions");
        sb.AppendLine("{");

        foreach (var group in extensionGroups.Where(x => x.extensions != null))
        {
            sb.AppendLine($"//================= {group.GroupName} ======================//");
            sb.AppendLine(group.extensions);
        }

        sb.AppendLine("}");

        return sb.ToString();
    }

    private static bool IsAvaloniaPropertyField(IFieldSymbol field)
    {
        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (field.Type.Name.StartsWith("DirectProperty") ||
            field.Type.Name.StartsWith("StyledProperty") ||
            //some attached properties Mapped to properties of controls, i.e. TextBlock.TextWrapping
            //so we need to add direct Extensions for them, additionally to AttachedProperty extensions
            field.Type.Name.StartsWith("AttachedProperty") ||
            field.Type.Name.StartsWith("AvaloniaProperty"))
        {
            return !IsReadOnlyField(field);
        }

        return false;
    }

    private static bool IsAttachedPropertyField(IFieldSymbol field)
    {
        if (field.GetAttributes().Any(x => x.AttributeClass?.Name == "ObsoleteAttribute"))
            return false;

        if (field.Type.Name.StartsWith("AttachedProperty"))
        {
            //Console.ForegroundColor = ConsoleColor.Magenta;
            //Console.WriteLine($"{field.Name} is Attached Property.");

            var isReadOnly = IsReadOnlyAttachedField(field);
            if (isReadOnly)
            {
                //Console.ForegroundColor = ConsoleColor.Cyan;
                //Console.WriteLine($"{field.Name} is read only - skipped.");
                //Console.ForegroundColor = ConsoleColor.Gray;
                return false;
            }

            //Console.ForegroundColor = ConsoleColor.Gray;
            return true;
        }
        return false;
    }

    //private static bool IsAcceptableStyledField(IFieldSymbol field)
    //{
    //    if (field.GetCustomAttribute<ObsoleteAttribute>() != null)
    //        return false;

    //    if (field.FieldType.Name.StartsWith("StyledProperty") ||
    //        field.FieldType.Name.StartsWith("AttachedProperty"))
    //        return !IsReadOnlyField(field);

    //    return false;
    //}

    private static bool IsReadOnlyField(IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var propertyName = field.Name.Replace("Property", "");

        var symbol = controlType?.GetMembers(propertyName).FirstOrDefault();

        if (symbol is IPropertySymbol prop)
        {
            return !prop.HasPublicSetter();
        }

        return false;
    }

    private static bool IsReadOnlyAttachedField(IFieldSymbol field)
    {
        var controlType = field.ContainingType;
        var setterMethodName = "Set" + field.Name.Replace("Property", "");

        var methodInfo = controlType?.GetMembers(setterMethodName).FirstOrDefault();

        if (methodInfo is IMethodSymbol method)
        {
            return method.DeclaredAccessibility == Accessibility.Public && method.IsStatic;
        }

        return false;
    }

    //private static Type? _styledElementType;

    //public static bool IsStyledElement(Type controlType)
    //{
    //    _styledElementType ??= AppDomain.CurrentDomain.GetAssemblies().SelectMany(x => x.ExportedTypes)
    //        .FirstOrDefault(x => x.FullName == "Avalonia.StyledElement");

    //    if (_styledElementType == null)
    //        throw new NullReferenceException("Styled element Type can't be loaded");

    //    return _styledElementType?.IsAssignableFrom(controlType) ?? false;
    //}
}