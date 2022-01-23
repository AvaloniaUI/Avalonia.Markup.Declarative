using System.Collections.Generic;
using System.Reflection;

namespace AvaloniaExtensionGenerator;

public interface ISetterExtensionGenerator
{
    Config Config { set; }
    string? GetSetterExtension(FieldInfo field, out IEnumerable<string> usedNamespaces);
}