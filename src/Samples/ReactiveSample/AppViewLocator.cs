using ReactiveSample.ViewModels;
using ReactiveSample.Views;
using ReactiveUI;

namespace ReactiveSample;

public class AppViewLocator : IViewLocator
{
    public IViewFor ResolveView<T>(T? viewModel, string? contract = null) => viewModel switch
    {
        PageViewModel1 context => new PageView1 { DataContext = context },
        PageViewModel2 context => new PageView2 { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(viewModel))
    };
}