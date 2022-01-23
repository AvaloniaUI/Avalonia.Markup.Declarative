using System.Reflection;

namespace AvaloniaExtensionGenerator;

public interface IEventExtensionGenerator
{
    Config Config { set; }
    string? GetEventExtension(EventInfo @event, out IEnumerable<string> usedNamespaces);
}