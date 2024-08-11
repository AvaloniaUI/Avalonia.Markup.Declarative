using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators;

public interface IEventExtensionGenerator
{
    ExtensionGeneratorConfig Config { set; }
    string? GetEventExtension(EventInfo @event, out IEnumerable<string> usedNamespaces);
}