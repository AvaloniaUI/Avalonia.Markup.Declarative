using Avalonia;
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Input;
using Avalonia.Layout;

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
    /// Set types that will be written into generated extensions with full qualified namespace 
    /// </summary>
    public Type[] UseFullNamespace { get; }=
    [
        typeof(Avalonia.Controls.Calendar),
        typeof(ContextMenu),
        typeof(Animation),
        typeof(Dock)
    ];

    /// <summary>
    /// Defines types that must be excluded from processing
    /// </summary>
    public Type[] Exclude { get; } = [];

    /// <summary>
    /// Those types will be generated as Generic extension methods instead of using direct control type
    /// </summary>
    public List<Type> BaseTypes { get; } =
    [
        typeof(Control),
        typeof(FlyoutBase),
        typeof(PopupFlyoutBase),
        typeof(Layoutable),
        typeof(Panel),
        typeof(Visual),
        typeof(TemplatedControl),
        typeof(ItemsControl),
        typeof(InputElement),
        typeof(ContentControl),
        typeof(SelectingItemsControl),
        typeof(HeaderedSelectingItemsControl)
    ];

    public string BasePath { get; set; } = basePath;
}
