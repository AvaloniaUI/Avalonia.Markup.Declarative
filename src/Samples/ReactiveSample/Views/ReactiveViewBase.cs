using ReactiveUI;

namespace ReactiveSample.Views;

public abstract class ReactiveViewBase<TViewModel> : ViewBase, IViewFor<TViewModel> where TViewModel : class
{
    TViewModel? IViewFor<TViewModel>.ViewModel
    {
        get => (TViewModel?)DataContext;
        set => DataContext = value;
    }

    object? IViewFor.ViewModel
    {
        get => (TViewModel?)DataContext;
        set => DataContext = value;
    }

    protected override void OnDataContextChanged(EventArgs e)
    {
        base.OnDataContextChanged(e);

        if (DataContext != null)
        {
            OnCreatedCore();
            Initialize();
        }
    }

    protected ReactiveViewBase() : base(deferredLoading: true)
    {
    }

    protected abstract object Build(TViewModel? vm);

    protected override object Build() => Build((TViewModel)DataContext);
}
