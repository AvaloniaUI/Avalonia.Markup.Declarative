using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators;

internal abstract class ExtensionGeneratorBase<TMemberExtensionInfo> : ExtensionGeneratorBase
{
    protected abstract string? GetExtension(TMemberExtensionInfo info);

    public override string? GetExtension(IMemberExtensionInfo info) => GetExtension((TMemberExtensionInfo)info);
}

internal abstract class ExtensionGeneratorBase
{
    public abstract string? GetExtension(IMemberExtensionInfo info);
}
