namespace AvaloniaExtensionGenerator.Generators.SetterGenerators;

public abstract class SetterGeneratorBase : IMemberExtensionGenerator
{
    public abstract bool CanGenerateOverride(PropertyExtensionInfo info);
    public abstract string GetPropertySetterExtensionOverride(PropertyExtensionInfo info);
    
    public virtual bool CanGenerate(IMemberExtensionInfo info) => 
        info is PropertyExtensionInfo extensionInfo && CanGenerateOverride(extensionInfo);
    public string? GetExtension(IMemberExtensionInfo info) => 
        GetPropertySetterExtensionOverride((PropertyExtensionInfo)info);
}