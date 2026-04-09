#nullable enable

using Microsoft.CodeAnalysis;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

internal sealed class AttachedPropertyExtensionInfo : PropertyExtensionInfo
{
    public string? AttachedPropertyHostTypeName { get; }

    public AttachedPropertyExtensionInfo(IFieldSymbol field)
        : base(field)
    {
        ExtensionName = $"{field.ContainingType.Name.Split('`')[0]}_{ExtensionName}";

        if (field.ContainingType.GetMembers($"Set{MemberName}").FirstOrDefault() is IMethodSymbol setter &&
            setter.Parameters.Length > 0)
        {
            AttachedPropertyHostTypeName = setter.Parameters[0].Type.GetFullTypeName();
            ReturnType = "T";
            GenericConstraint = $"where T : {AttachedPropertyHostTypeName}";
            GenericArg = "<T>";
        }
    }
}
