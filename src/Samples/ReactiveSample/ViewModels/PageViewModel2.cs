using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveSample.ViewModels;

public partial class PageViewModel2 : ReactiveObject, IRoutableViewModel
{
    [Reactive]
    public string _myProperty = "Page View2";

    public IScreen HostScreen { get; }

    public string? UrlPathSegment => "page";

    public PageViewModel2(IScreen screen)
    {
        HostScreen = screen;
    }
}