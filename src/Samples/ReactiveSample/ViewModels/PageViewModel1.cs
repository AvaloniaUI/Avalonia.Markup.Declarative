using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveSample.ViewModels;

public partial class PageViewModel1 : ReactiveObject, IRoutableViewModel
{
    [Reactive]
    public partial string MyProperty { get; set; } = "Page View1";

    public IScreen HostScreen { get; }

    public string? UrlPathSegment => "page";

    public PageViewModel1(IScreen screen)
    {
        HostScreen = screen;
    }
}