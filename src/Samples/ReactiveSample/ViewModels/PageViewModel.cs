using ReactiveUI;
using ReactiveUI.SourceGenerators;

namespace ReactiveSample.ViewModels;

public partial class PageViewModel : ReactiveObject, IRoutableViewModel
{
    [Reactive]
    public string _myProperty = "Page View";

    public IScreen HostScreen { get; }

    public string? UrlPathSegment => "page";

    public PageViewModel(IScreen screen)
    {
        HostScreen = screen;
    }
}