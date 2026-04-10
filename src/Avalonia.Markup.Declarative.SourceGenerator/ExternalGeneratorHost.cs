using System.Collections.Immutable;
using System.Text;
using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;
using Avalonia.Markup.Declarative.SourceGenerator.Generators;
using Avalonia.Markup.Declarative.SourceGenerator.Generators.AttachedPropertySetterGenerator;
using Avalonia.Markup.Declarative.SourceGenerator.Generators.EventGenerators;
using Avalonia.Markup.Declarative.SourceGenerator.Generators.SetterGenerators;
using Avalonia.Markup.Declarative.SourceGenerator.Generators.StyleSetterGenerators;
using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator;

internal sealed class ExternalGeneratorHost
{
    private readonly List<ExtensionGroupGenerator> _groupGenerators =
    [
        new("Properties",
            static t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(static x => x.IsAvaloniaPropertyField() && !x.HasUnsupportedExternalValueType())
                .Select(static x => new PropertyExtensionInfo(x)),

            new ValueSetterGenerator(),
            new BindFromExpressionSetterGenerator(),
            new AvaloniaPropertyBindSetterGenerator(),
            new ValueOverloadsSetterGenerator()
        ),

        new("Attached Properties",
            static t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(static x => x.IsAttachedPropertyField())
                .Select(static x => new AttachedPropertyExtensionInfo(x))
                .Where(static x => !string.IsNullOrWhiteSpace(x.AttachedPropertyHostTypeName)),

            new AttachedPropertyValueSetterGenerator(),
            new AttachedPropertyBindFromExpressionSetterGenerator()
        ),

        new("Events",
            static t => t.GetMembers()
                .OfType<IEventSymbol>()
                .Where(x => x.DeclaredAccessibility == Accessibility.Public && SymbolEqualityComparer.Default.Equals(x.ContainingType, t))
                .Select(static x => new EventExtensionInfo(x)),

            new ActionToEventGenerator()
        ),

        new("Styles",
            static t => !t.IsStyledElement() ? [] : GetStyledFields(t)
                .Where(static x => !x.HasUnsupportedExternalValueType())
                .Select(static x => new PropertyExtensionInfo(x)),

            new ValueStyleSetterGenerator(),
            new BindFromExpressionStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
        )
    ];

    private static IEnumerable<IFieldSymbol> GetStyledFields(INamedTypeSymbol type)
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
        var extensionGroups = _groupGenerators
            .Select(x =>
            {
                var extensions = x.Generate(controlType, out var generatedCount);
                return (x.GroupName, extensions, generatedCount);
            })
            .ToImmutableArray();

        if (extensionGroups.All(static x => x.generatedCount == 0))
        {
            return null;
        }

        var sb = new StringBuilder();
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
        sb.AppendLine($"public static partial class {SymbolUtilities.BuildExtensionClassName(controlType)}");
        sb.AppendLine("{");

        foreach (var group in extensionGroups.Where(static x => x.extensions != null))
        {
            sb.AppendLine($"//================= {group.GroupName} ======================//");
            sb.Append(group.extensions);
        }

        sb.AppendLine("}");
        return sb.ToString();
    }
}
