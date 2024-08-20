using System.Reflection;
using System.Reflection.Emit;
using System.Text;

namespace AvaloniaExtensionGenerator.Generators;

public class ExtensionGroupGenerator<TMember>(
    string groupName,
    Func<Type, IEnumerable<TMember>> membersQuery,
    params IMemberExtensionGenerator<TMember>[] generators)
    : IExtensionGroupGenerator
    where TMember : MemberInfo
{
    public string GroupName { get; } = groupName;

    public string? Generate(Type avaloniaControlType, out int generationsCount)
    {
        generationsCount = 0;

        var members = membersQuery(avaloniaControlType).ToArray();
        if (!members.Any())
            return null;

        var sb = new StringBuilder();
        var i = 0;
        foreach (var info in members)
        {
            sb.AppendLine($" // {info.Name}");

            foreach (var generator in generators)
            {
                var setterExtension = generator.GetExtension(info, out var usedNamespaces);
                if (!string.IsNullOrWhiteSpace(setterExtension))
                {
                    sb.AppendLine();
                    sb.AppendLine($"/*{generator.GetType().Name}*/");
                    sb.AppendLine(setterExtension);
                    generationsCount++;
                }
            }

            sb.AppendLine();
            sb.AppendLine();
        }

        return sb.ToString();
    }
}