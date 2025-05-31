using ReactiveUI;
using ReactiveUI.SourceGenerators;
using System.Diagnostics.Metrics;
using System.Reactive;

namespace ReactiveSample.ViewModels;

public partial class MainViewModel : ReactiveObject, IScreen
{
    // The Router associated with this Screen.
    // Required by the IScreen interface.
    [Reactive]
    private RoutingState _router = new();

    // The command that navigates a user to first view model.
    public ReactiveCommand<Unit, IRoutableViewModel> GoNext { get; }

    // The command that navigates a user back.
    public ReactiveCommand<Unit, IRoutableViewModel> GoBack => Router.NavigateBack;

    public MainViewModel()
    {
        // Manage the routing state. Use the Router.Navigate.Execute
        // command to navigate to different view models.
        //
        // Note, that the Navigate.Execute method accepts an instance
        // of a view model, this allows you to pass parameters to
        // your view models, or to reuse existing view models.
        //
        GoNext = ReactiveCommand.CreateFromObservable(
            () => Router.Navigate.Execute(new PageViewModel(this))
        );

        this.ObservableForProperty(t => t.Router)
            .Subscribe(t =>
        {
            //Logic using previous and new value for Bar
        });
    }
}