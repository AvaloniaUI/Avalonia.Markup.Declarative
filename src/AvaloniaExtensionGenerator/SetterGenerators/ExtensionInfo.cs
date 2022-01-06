using System;
using System.Linq;
using System.Reflection;

namespace AvaloniaExtensionGenerator
{
    public class ExtensionInfo
    {
        public FieldInfo FieldInfo { get; }
        public Type ControlType { get; }
        public object ControlTypeName { get; }
        public string ExtensionName { get; }
        public string PropertyName { get; }
        public Type ValueType { get; }
        public object ValueTypeSource { get; }

        public ExtensionInfo(FieldInfo field, Func<Type,string> TypeDeclarationFunc)
        {
            FieldInfo = field;
            ControlType = field.DeclaringType;
            ExtensionName = field.Name.Replace("Property", "");
            PropertyName = field.Name.Replace("Property", "");
            ValueType = field.FieldType.GetGenericArguments().Last();
            ControlTypeName = TypeDeclarationFunc(ControlType);
            ValueTypeSource = TypeDeclarationFunc(ValueType);
        }
    }
}