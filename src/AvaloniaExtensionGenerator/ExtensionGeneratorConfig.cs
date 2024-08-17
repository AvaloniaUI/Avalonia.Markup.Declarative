namespace AvaloniaExtensionGenerator;

public class ExtensionGeneratorConfig(string outputPath)
{
    public required Type[] TypesToProcess { get; init; }

    /// <summary>
    /// This namespaces will be added to each generated file
    /// </summary>
    public string[] InitialNamespaces { get; init; } = [];

    /// <summary>
    /// Defines types that must be excluded from processing
    /// </summary>
    public Type[] Exclude { get; init; } = [];

    public string OutputPath { get; set; } = outputPath;
}