using Microsoft.CodeAnalysis;
using System.Text;

namespace CSharpUI.Avalonia.SourceGenerator.Generators;

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
            sb.Append($"    // {extensionInfo.MemberName}{Extensions.NewLine}");

            foreach (var generator in generators)
            {
                var extensionCode = generator.GetExtension(extensionInfo);
                if (!string.IsNullOrWhiteSpace(extensionCode))
                {
                    sb.Append(Extensions.NewLine);
                    sb.Append($"    /*{generator.GetType().Name}*/{Extensions.NewLine}");
                    sb.Append(extensionCode + Extensions.NewLine);
                    generationsCount++;
                }
            }

            sb.Append(Extensions.NewLine);
            sb.Append(Extensions.NewLine);
        }

        return generationsCount == 0 ? null : sb.ToString();
    }
}