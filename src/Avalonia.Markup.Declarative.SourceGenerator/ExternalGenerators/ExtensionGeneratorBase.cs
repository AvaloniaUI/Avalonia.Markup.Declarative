using Avalonia.Markup.Declarative.SourceGenerator.ExtensionInfos;

namespace Avalonia.Markup.Declarative.SourceGenerator.ExternalGenerators;

internal abstract class ExtensionGeneratorBase<TMemberExtensionInfo> : ExtensionGeneratorBase
{
    protected abstract string? GetExtension(TMemberExtensionInfo info);

    public override string? GetExtension(IMemberExtensionInfo info) => GetExtension((TMemberExtensionInfo)info);
}

internal abstract class ExtensionGeneratorBase
{
    protected static string CallerInfoParameters => ", [CallerFilePath] string? _callerFile = null, [CallerLineNumber] int _callerLine = 0";

    protected static string CallerInfoArguments => ", _callerFile, _callerLine";

    protected static string PrefixDocumentation(string xmlDoc, string extensionCode) =>
        string.IsNullOrEmpty(xmlDoc) ? extensionCode : xmlDoc + extensionCode;

    public abstract string? GetExtension(IMemberExtensionInfo info);
}
