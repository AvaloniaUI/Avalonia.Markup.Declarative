using Avalonia.Platform;
using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveSample.ViewModels;

public partial class PageViewModel : ReactiveObject, IRoutableViewModel
{
    [Reactive]
    public partial string MyProperty { get; set; }

    public IScreen HostScreen { get; }

    public string? UrlPathSegment => "page";

    public PageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}