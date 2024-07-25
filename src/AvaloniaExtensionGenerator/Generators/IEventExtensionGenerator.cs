using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators;

public interface IEventExtensionGenerator
{
    IConfig Config { set; }
    string? GetEventExtension(EventInfo @event, out IEnumerable<string> usedNamespaces);
}