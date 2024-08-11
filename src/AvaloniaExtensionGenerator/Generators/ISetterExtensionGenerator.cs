using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators;

public interface ISetterExtensionGenerator
{
    ExtensionGeneratorConfig Config { set; }
    string? GetSetterExtension(FieldInfo field, out IEnumerable<string> usedNamespaces);
}