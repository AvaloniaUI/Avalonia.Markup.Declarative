using System.Reflection;
using System.Text;
using AvaloniaExtensionGenerator.Generators.EventGenerators;
using AvaloniaExtensionGenerator.Generators.SetterGenerators;

namespace AvaloniaExtensionGenerator.Generators;

public class ExtensionGroupGenerator<TMember>(
    string groupName,
    Func<Type, IEnumerable<MemberInfo>> membersQuery,
    params IMemberExtensionGenerator[] generators)
    : IExtensionGroupGenerator
    where TMember : IMemberExtensionInfo
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
        foreach (var memberInfo in members)
        {
            sb.AppendLine($" // {memberInfo.Name}");

            var extensionInfo = GetExtensionInfo(memberInfo);
            foreach (var generator in generators.Where(x=>x.CanGenerate(extensionInfo)))
            {
                var extensionCode = generator.GetExtension(extensionInfo);
                if (!string.IsNullOrWhiteSpace(extensionCode))
                {
                    sb.AppendLine();
                    sb.AppendLine($"/*{generator.GetType().Name}*/");
                    
                    if(extensionInfo.IsObsolete)
                        sb.AppendLine($"\t[Obsolete(\"{extensionInfo.ObsoleteMessage}\")]");
                    
                    sb.AppendLine(extensionCode);
                    generationsCount++;
                }
            }

            sb.AppendLine();
            sb.AppendLine();
        }

        return sb.ToString();
    }

    private static IMemberExtensionInfo GetExtensionInfo(MemberInfo info)
    {
        if (info is FieldInfo fi)
            return new PropertyExtensionInfo(fi);

        if (info is EventInfo ei)
            return new EventExtensionInfo(ei);

        throw new ArgumentException($"{info.GetType().Name} is not valid member info");
    }
}