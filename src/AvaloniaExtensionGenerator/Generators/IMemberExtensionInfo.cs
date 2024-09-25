namespace AvaloniaExtensionGenerator.Generators;

public interface IMemberExtensionInfo
{
    bool IsObsolete { get; }
    string ObsoleteMessage { get; }
}