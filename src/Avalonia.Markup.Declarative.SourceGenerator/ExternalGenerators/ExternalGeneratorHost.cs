using System.Collections.Immutable;
using System.Text;
using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;
using Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.AttachedPropertySetterGenerator;
using Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.EventGenerators;
using Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.SetterGenerators;
using Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.StyleSetterGenerators;
using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators;

internal sealed class ExternalGeneratorHost
{
    private readonly ExtensionGroupGenerator[] _groupGenerators =
    [
        new("Properties",
            static t => GetPropertyInfos(t),

            new ValueSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new ValueOverloadsSetterGenerator()
        ),

        new("Attached Properties",
            static t => GetAttachedPropertyInfos(t),

            new AttachedPropertyValueSetterGenerator(),
            new AttachedPropertyBindFromExpressionSetterGenerator()
        ),

        new("Events",
            static t => GetEventInfos(t),

            new ActionToEventGenerator()
        ),

        new("Styles",
            static t => GetStyleInfos(t),

            new ValueStyleSetterGenerator(),
            new BindFromExpressionStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
        )
    ];

    internal static IEnumerable<PropertyExtensionInfo> GetPropertyInfos(INamedTypeSymbol type) =>
        type.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(static x => x.IsAvaloniaPropertyField() && !x.HasUnsupportedExternalValueType())
            .Select(static x => new PropertyExtensionInfo(x));

    internal static IEnumerable<AttachedPropertyExtensionInfo> GetAttachedPropertyInfos(INamedTypeSymbol type) =>
        type.GetMembers()
            .OfType<IFieldSymbol>()
            .Where(static x => x.IsAttachedPropertyField())
            .Select(static x => new AttachedPropertyExtensionInfo(x))
            .Where(static x => !string.IsNullOrWhiteSpace(x.AttachedPropertyHostTypeName));

    internal static IEnumerable<EventExtensionInfo> GetEventInfos(INamedTypeSymbol type) =>
        type.GetMembers()
            .OfType<IEventSymbol>()
            .Where(x => x.DeclaredAccessibility == Accessibility.Public && SymbolEqualityComparer.Default.Equals(x.ContainingType, type))
            .Select(static x => new EventExtensionInfo(x));

    internal static IEnumerable<PropertyExtensionInfo> GetStyleInfos(INamedTypeSymbol type) =>
        !type.IsStyledElement()
            ? []
            : GetStyledFields(type)
                .Where(static x => !x.HasUnsupportedExternalValueType())
                .Select(static x => new PropertyExtensionInfo(x));

    internal static IEnumerable<IFieldSymbol> GetStyledFields(INamedTypeSymbol type)
    {
        var fields = type.GetMembers().OfType<IFieldSymbol>();

        if (type.GetFullTypeName() == "global::Avalonia.StyledElement")
        {
            fields = fields.Concat(type.GetAllMembers()
                .OfType<IFieldSymbol>()
                .Where(x => x.ContainingType is not null &&
                            !SymbolEqualityComparer.Default.Equals(x.ContainingType, type) &&
                            !x.ContainingType.IsOrInheritsFrom("Avalonia.StyledElement")));
        }

        return fields.Where(static x => x.IsAcceptableStyledField());
    }

    public string? GenerateExtensions(INamedTypeSymbol controlType)
    {
        List<(string GroupName, string Extensions)>? generatedGroups = null;

        foreach (var groupGenerator in _groupGenerators)
        {
            var extensions = groupGenerator.Generate(controlType, out var generatedCount);
            if (generatedCount == 0 || string.IsNullOrWhiteSpace(extensions))
            {
                continue;
            }

            generatedGroups ??= [];
            generatedGroups.Add((groupGenerator.GroupName, extensions!));
        }

        if (generatedGroups is null)
        {
            return null;
        }

        var sb = new StringBuilder(4096);
        sb.AppendLine("#nullable enable");
        sb.AppendLine("using Avalonia;");
        sb.AppendLine("using Avalonia.Data;");
        sb.AppendLine("using Avalonia.Data.Converters;");
        sb.AppendLine("using System;");
        sb.AppendLine("using System.Linq.Expressions;");
        sb.AppendLine("using System.Runtime.CompilerServices;");
        sb.AppendLine();
        sb.AppendLine("namespace Avalonia.Markup.Declarative;");
        sb.AppendLine("[global::System.CodeDom.Compiler.GeneratedCode(\"Avalonia.Markup.Declarative.SourceGenerator\", \"1.0.0.0\")]");
        sb.AppendLine("[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]");
        sb.AppendLine($"internal static partial class {SymbolUtilities.BuildExtensionClassName(controlType)}");
        sb.AppendLine("{");

        foreach (var group in generatedGroups)
        {
            sb.AppendLine($"//================= {group.GroupName} ======================//");
            sb.Append(group.Extensions);
        }

        sb.AppendLine("}");
        return sb.ToString();
    }
}
