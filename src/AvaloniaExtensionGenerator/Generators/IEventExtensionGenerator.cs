namespace AvaloniaExtensionGenerator.Generators;

public interface IMemberExtensionGenerator
{
    bool CanGenerate(IMemberExtensionInfo info);

    string? GetExtension(IMemberExtensionInfo info);
}