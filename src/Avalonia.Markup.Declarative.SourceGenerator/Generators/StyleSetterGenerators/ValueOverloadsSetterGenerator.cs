using Avalonia.Markup.Declarative.SourceGenerator;
using AvaloniaExtensionGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;

namespace AvaloniaExtensionGenerator.Generators.StyleSetterGenerators;

public class ValueOverloadsStyleSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string? GetExtension(PropertyExtensionInfo info)
    {
        var extensionText = "";
        // overloads for primitive types like margin
        if (!info.ValueType.ContainingNamespace.GetFullNamespace().StartsWith("System")
            && info.ValueType.IsValueType
            && info.ValueType.GetMembers().OfType<IMethodSymbol>().Where(m => m.MethodKind == MethodKind.Constructor).Count() > 1)
        {
            foreach (var constructor in info.ValueType.GetMembers().OfType<IMethodSymbol>().Where(m => m.MethodKind == MethodKind.Constructor))
            {
                var ps = constructor.Parameters;
                var argDefs = string.Join(", ", ps.Select(x => $"{x.Type.GetFullName()} {x.Name}"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                extensionText += $"public static Style<{info.ReturnType}> {info.ExtensionName}{info.GenericArg}(this Style<{info.ReturnType}> style, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                 $"   => style._addSetter({info.ControlTypeName}.{info.MemberName}Property, new {info.ValueTypeSource}({argVals}));";
            }
        }
        return extensionText;
    }
}
