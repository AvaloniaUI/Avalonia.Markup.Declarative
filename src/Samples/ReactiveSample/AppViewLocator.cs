using ReactiveSample.ViewModels;
using ReactiveSample.Views;
using ReactiveUI;

namespace ReactiveSample;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T? viewModel, string? contract = null) => viewModel switch
    {
        PageViewModel context => new PageView { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}