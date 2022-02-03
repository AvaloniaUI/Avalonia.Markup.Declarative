namespace Avalonia.Markup.Declarative;

/// <summary>
/// IReloadable interfece is used by HotReloadManager to reload controls after net6 updating assemblies on runtime
/// </summary>
public interface IReloadable
{
    /// <summary>
    /// Force control to be reloaded
    /// </summary>
    void Reload();
}