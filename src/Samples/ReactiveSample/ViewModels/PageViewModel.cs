using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveSample.ViewModels;

public partial class PageViewModel : ReactiveObject, IRoutableViewModel
{
    [Reactive]
    private string _myProperty = "This is a page view";

    public IScreen HostScreen { get; }

    public string? UrlPathSegment => "page";

    public PageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}