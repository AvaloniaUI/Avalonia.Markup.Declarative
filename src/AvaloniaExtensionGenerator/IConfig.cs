namespace AvaloniaExtensionGenerator;

public interface IConfig
{
    /// <summary>
    /// List of types that must be processed by generators
    /// </summary>
    Type[] TypesToProcess { get; }
    
    /// <summary>
    /// This namespaces will be added to each generated file
    /// </summary>
    string[] InitialNamespaces { get; }

    /// <summary>
    /// Defines types that must be excluded from processing
    /// </summary>
    Type[] Exclude { get; }

    /// <summary>
    /// Those types will be generated as Generic extension methods instead of using direct control type
    /// </summary>
    //List<Type> BaseTypes { get; }

    string BasePath { get; }
}