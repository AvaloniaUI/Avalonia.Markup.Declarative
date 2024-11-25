using AvaloniaExtensionGenerator.Generators;
using Microsoft.CodeAnalysis;
using System.Reflection;

namespace AvaloniaExtensionGenerator.ExtensionInfos;

public class AttachedPropertyExtensionInfo : PropertyExtensionInfo
{
    public string? AttachedPropertyHostTypeName { get; set; }

    public AttachedPropertyExtensionInfo(IFieldSymbol field) : base(field)
    {
        ExtensionName = $"{ControlType.Name}_{ExtensionName}";
        var declaredType = field.Type;

        var method = declaredType.GetMembers().FirstOrDefault(x => x.Name == $"Set{MemberName}");

        if (method == null) return;

        //var par = method.GetParameters().FirstOrDefault();
        //if (par != null)
        //{
        //    AttachedPropertyHostTypeName = par.ParameterType.GetTypeDeclarationSourceCode();
        //}
    }
}