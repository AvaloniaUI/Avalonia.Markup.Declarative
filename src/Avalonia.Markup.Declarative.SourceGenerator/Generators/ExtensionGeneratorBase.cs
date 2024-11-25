namespace AvaloniaExtensionGenerator.Generators;

public abstract class ExtensionGeneratorBase<TMemberExtensionInfo> : ExtensionGeneratorBase
{
    protected abstract string? GetExtension(TMemberExtensionInfo info);
    public override string? GetExtension(IMemberExtensionInfo info) => GetExtension((TMemberExtensionInfo)info);

}
public abstract class ExtensionGeneratorBase
{
    public abstract string? GetExtension(IMemberExtensionInfo info);
}