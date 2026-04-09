using CSharpUI.Avalonia.SourceGenerator.ExtensionInfos;
using CSharpUI.Avalonia.SourceGenerator.Generators;
using CSharpUI.Avalonia.SourceGenerator.Generators.AttachedPropertySetterGenerator;
using CSharpUI.Avalonia.SourceGenerator.Generators.EventGenerators;
using CSharpUI.Avalonia.SourceGenerator.Generators.SetterGenerators;
using CSharpUI.Avalonia.SourceGenerator.Generators.StyleSetterGenerators;
using Microsoft.CodeAnalysis;
using System.Collections.Immutable;
using System.Text;

namespace CSharpUI.Avalonia.SourceGenerator;

public class GeneratorHost()
{
    readonly List<ExtensionGroupGenerator> groupGenerators =
    [
        new("Properties",
            t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(x => x.IsAvaloniaPropertyField())
                .Select(x => new PropertyExtensionInfo(x)),

            new ValueSetterGenerator(),
            new ValueOverloadsSetterGenerator()
            //new AvaloniaPropertyBindSetterGenerator()
        ),

        new("Attached Properties",
            t => t.GetMembers()
                .OfType<IFieldSymbol>()
                .Where(x => x.IsAttachedPropertyField())
                .Select(x => new AttachedPropertyExtensionInfo(x))
                .Where(x => {

                    var props = t.GetMembers().OfType<IMethodSymbol>();

                    var found = props.FirstOrDefault(y => y.Name.RemoveTrailingProperty() == "Set" + x.MemberName.RemoveTrailingProperty());

                    if (found != null){
                    var paramType = found.Parameters[0].Type;

                    var tName = t.IsOrInheritsFrom(paramType);

                        return tName;
                    }
                    return false;
                }),

            new AttachedPropertyBindFromExpressionSetterGenerator()
        ),

        new("Common Properties",
            t => t.GetMembers()
                .OfType<IPropertySymbol>()
                .Where(x => !x.IsAvaloniaProperty()
                            && x.IsCommonProperty())
                .Select(x => new PropertyExtensionInfo(x)),

            new ValueSetterGenerator()
        ),

        new("Events",
            t => t.GetAllMembers()
                .OfType<IEventSymbol>()
                .Where(x => x.DeclaredAccessibility == Accessibility.Public
                        && SymbolEqualityComparer.Default.Equals(x.ContainingType, t))
                .Select(x => new EventExtensionInfo(x)),

            new ActionToEventGenerator()),

        new("Styles",
            t => !t.IsStyledElement() ? [] : t
                .GetMembers()
                .OfType<IFieldSymbol>()
                .Where(x => x.IsAcceptableStyledField())
                .Select(x => new PropertyExtensionInfo(x)),

            new ValueStyleSetterGenerator(),
            new BindingStyleSetterGenerator(),
            new ValueOverloadsStyleSetterGenerator()
        )
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
        sb.Append("#nullable enable" + Extensions.NewLine);
        sb.Append(Extensions.NewLine);
        sb.Append("namespace CSharpUI.Avalonia.Extensions;" + Extensions.NewLine);
        sb.Append(Extensions.NewLine);
        sb.Append($"public static partial class {Extensions.CleanIdentifier(controlType.Name)}Extensions" + Extensions.NewLine);
        sb.Append("{" + Extensions.NewLine);

        foreach (var group in extensionGroups.Where(x => x.extensions != null))
        {
            sb.Append($"    //================= {group.GroupName} ======================//" + Extensions.NewLine);
            sb.Append(group.extensions + Extensions.NewLine);
        }

        sb.Append("}");

        return sb.ToString();
    }
}