namespace AvaloniaExtensionGenerator.Generators;

public static class TypeFormatExtensions
{
    public static string GetTypeDeclarationSourceCode(this Type valueType)
    {
        var result = valueType.Name;
        if (valueType.IsGenericType)
        {
            result = result.Split('`')[0];
            var genericArguments = valueType
                .GetGenericArguments()
                .Select(GetTypeDeclarationSourceCode);

            var args = string.Join(",", genericArguments);
            result += $"<{args}>";
        }

        if (!string.IsNullOrWhiteSpace(valueType.Namespace))
        {
            result = valueType.Namespace + "." + result;
        }

        return result;
    }

}