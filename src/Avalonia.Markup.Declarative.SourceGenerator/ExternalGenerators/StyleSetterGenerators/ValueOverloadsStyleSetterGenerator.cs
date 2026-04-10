using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators.StyleSetterGenerators;

internal sealed class ValueOverloadsStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
    {
        var extensionText = string.Empty;

        if (!info.ValueType.ContainingNamespace.ToDisplayString().StartsWith("System", StringComparison.Ordinal) &&
            info.ValueType.IsValueType)
        {
            foreach (var constructor in info.ValueType.GetMembers().OfType<IMethodSymbol>().Where(static m => m.MethodKind == MethodKind.Constructor))
            {
                var ps = constructor.Parameters;
                if (ps.Length == 0)
                {
                    continue;
                }

                var argDefs = string.Join(", ", ps.Select(static x => $"{x.Type.GetFullTypeName()} {x.Name}"));
                var argVals = string.Join(", ", ps.Select(static x => x.Name));

                extensionText += $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {argDefs}) {info.StyleGenericConstraint} {SymbolUtilities.NewLine}" +
                                 $"   => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, new {info.ValueTypeSource}({argVals}));";
            }
        }

        return extensionText;
    }
}
