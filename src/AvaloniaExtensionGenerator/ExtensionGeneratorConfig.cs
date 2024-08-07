namespace AvaloniaExtensionGenerator;

public class ExtensionGeneratorConfig(string basePath) : IConfig
{
    required public Type[] TypesToProcess { get; init; }

    /// <summary>
    /// This namespaces will be added to each generated file
    /// </summary>
    public string[] InitialNamespaces { get; init; } = [];

    /// <summary>
    /// Set types that will be written into generated extensions with full qualified namespace 
    /// </summary>
    public Type[] UseFullNamespace { get; init; } = [];

    /// <summary>
    /// Defines types that must be excluded from processing
    /// </summary>
    public Type[] Exclude { get; init; } = [];

    /// <summary>
    /// Those types will be generated as Generic extension methods instead of using direct control type
    /// </summary>
    public List<Type> BaseTypes { get; init; } = [];

    public string BasePath { get; set; } = basePath;
}