using ReactiveSample.ViewModels;
using ReactiveSample.Views;
using ReactiveUI;

namespace ReactiveSample;

public class AppViewLocator : IViewLocator
{
    public IViewFor<TViewModel>? ResolveView<TViewModel>(string? contract = null) where TViewModel : class
    {
        throw new NotImplementedException();
    }

    public IViewFor? ResolveView(object? instance, string? contract = null) => instance switch
    {
        PageViewModel1 context => new PageView1 { DataContext = context },
        PageViewModel2 context => new PageView2 { DataContext = context },
        _ => throw new ArgumentOutOfRangeException(nameof(instance))
    };
}