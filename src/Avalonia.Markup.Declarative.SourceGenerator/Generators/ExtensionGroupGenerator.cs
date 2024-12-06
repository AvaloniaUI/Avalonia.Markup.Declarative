using Microsoft.CodeAnalysis;
using System.Text;

namespace AvaloniaExtensionGenerator.Generators;

public class ExtensionGroupGenerator(
    string groupName,
    Func<INamedTypeSymbol, IEnumerable<IMemberExtensionInfo>> membersQuery,
    params ExtensionGeneratorBase[] generators)
{
    public string GroupName { get; } = groupName;

    public string? Generate(INamedTypeSymbol avaloniaControlType, out int generationsCount)
    {
        generationsCount = 0;

        var sb = new StringBuilder();
        foreach (var extensionInfo in membersQuery(avaloniaControlType))
        {
            sb.AppendLine($" // {extensionInfo.MemberName}");

            foreach (var generator in generators)
            {
                var extensionCode = generator.GetExtension(extensionInfo);
                if (!string.IsNullOrWhiteSpace(extensionCode))
                {
                    sb.AppendLine();
                    sb.AppendLine($"/*{generator.GetType().Name}*/");
                    sb.AppendLine(extensionCode);
                    generationsCount++;
                }
            }

            sb.AppendLine();
            sb.AppendLine();
        }

        return generationsCount == 0 ? null : sb.ToString();
    }
}