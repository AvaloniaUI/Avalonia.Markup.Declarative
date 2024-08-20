namespace AvaloniaExtensionGenerator.Generators;

public interface IExtensionGroupGenerator
{
    string? Generate(Type avaloniaControlType, out int generationsCount);
    string GroupName { get; }
}