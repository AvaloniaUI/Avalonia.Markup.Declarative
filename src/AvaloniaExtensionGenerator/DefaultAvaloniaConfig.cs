namespace AvaloniaExtensionGenerator;

/// <summary>
/// Default config to generate extension for Avalonia framework built-in controls
/// </summary>
/// <param name="basePath">Path where generated classes will be put</param>
public class DefaultAvaloniaConfig(string basePath) : IConfig
{
    public Type[] TypesToProcess => AppDomain.CurrentDomain
        .GetAssemblies()
        .SelectMany(s => s.GetTypes()).ToArray();

    /// <summary>
    /// This namespaces will be added to each generated file
    /// </summary>
    public string[] InitialNamespaces { get; } =
    [
        "Avalonia.Data",
        "Avalonia.Data.Converters",
        "System",
        "System.Numerics",
        "System.Linq.Expressions",
        "System.Runtime.CompilerServices"
    ];

    /// <summary>
    /// Defines types that must be excluded from processing
    /// </summary>
    public Type[] Exclude { get; } = [];

    public string BasePath { get; set; } = basePath;
}
