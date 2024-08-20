using System.Reflection;

namespace AvaloniaExtensionGenerator.Generators;

public interface IMemberExtensionGenerator<in TMember> where TMember : MemberInfo
{
    string? GetExtension(TMember info, out IEnumerable<string> usedNamespaces);
}