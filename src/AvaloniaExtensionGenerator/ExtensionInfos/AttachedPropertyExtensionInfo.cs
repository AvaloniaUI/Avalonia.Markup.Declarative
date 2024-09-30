using AvaloniaExtensionGenerator.Generators;
using System.Reflection;

namespace AvaloniaExtensionGenerator.ExtensionInfos;

public class AttachedPropertyExtensionInfo : PropertyExtensionInfo
{
    public string? AttachedPropertyHostTypeName { get; set; }

    public AttachedPropertyExtensionInfo(FieldInfo field) : base(field)
    {
        ExtensionName = $"{ControlType.Name}_{ExtensionName}";
        var declaredType = field.DeclaringType;

        var method = declaredType.GetMethod($"Set{MemberName}");

        if (method == null) return;

        var par = method.GetParameters().FirstOrDefault();
        if (par != null)
        {
            AttachedPropertyHostTypeName = par.ParameterType.GetTypeDeclarationSourceCode();
        }
    }
}