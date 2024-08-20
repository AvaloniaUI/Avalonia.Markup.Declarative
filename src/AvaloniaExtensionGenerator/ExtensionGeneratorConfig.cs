namespace AvaloniaExtensionGenerator;

public class ExtensionGeneratorConfig(string outputPath)
{
    public required Type[] TypesToProcess { get; init; }

    /// <summary>
    /// This namespaces will be added to each generated file
    /// </summary>
    public string[] InitialNamespaces { get; init; } = [];

    public string OutputPath { get; set; } = outputPath;
}