using Avalonia.Markup.Declarative.SourceGenerator;
using AvaloniaExtensionGenerator.ExtensionInfos;
using Microsoft.CodeAnalysis;

namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public class ValueOverloadsSetterGenerator : ExtensionGeneratorBase<PropertyExtensionInfo>
{
    protected override string GetExtension(PropertyExtensionInfo info)
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
                var argDefs = string.Join(", ", ps.Select(x => $"{x.Type} {x.Name} = default"));
                var argVals = string.Join(", ", ps.Select(x => x.Name)); ;

                extensionText += Environment.NewLine +
                                 $"public static {info.ReturnType} {info.ExtensionName}{info.GenericArg}(this {info.ReturnType} control, {argDefs}) {info.GenericConstraint} {Environment.NewLine}" +
                                 $"   => control._set(() => control.{info.MemberName} = new {info.ValueTypeSource}({argVals}));";
            }
        }
        return extensionText;
    }
}