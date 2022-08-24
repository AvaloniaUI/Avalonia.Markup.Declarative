using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;

namespace AvaloniaExtensionGenerator
{
    public abstract class SetterGeneratorBase : ISetterExtensionGenerator
    {
        public Config Config { get; set; } = null!;

        public string? GetSetterExtension(FieldInfo field, out IEnumerable<string> usedNamespaces)
        {
            var namespaces = new HashSet<string>();
            var info = new PropertyExtensionInfo(field, t => GetTypeDeclarationSourceCode(t, namespaces));
            if (!string.IsNullOrWhiteSpace(info.ControlType.Namespace))
                namespaces.Add(info.ControlType.Namespace);

            usedNamespaces = namespaces;
            return GetPropertySetterExtensionOverride(info);
        }

        public abstract string GetPropertySetterExtensionOverride(PropertyExtensionInfo info);

        public string GetTypeDeclarationSourceCode(Type valueType, HashSet<string> namespaces)
        {
            if (!string.IsNullOrWhiteSpace(valueType.Namespace))
                namespaces.Add(valueType.Namespace);

            var result = valueType.Name;

            if (valueType.IsGenericType)
            {
                result = result.Split('`')[0];
                var genericArguments = valueType.GetGenericArguments();
                var args = string.Join(",", genericArguments.Select(x => GetTypeDeclarationSourceCode(x, namespaces)));
                result += $"<{args}>";
            }

            if (Config.UseFullNamespace.Contains(valueType))
            {
                result = valueType.Namespace + "." + result;
            }

            return result;
        }

    }
}