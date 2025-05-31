using ReactiveUI;

namespace ReactiveSample.Views;

public abstract class ReactiveViewBase<TViewModel> : ViewBase, IViewFor<TViewModel> where TViewModel : class
{
    [System.Diagnostics.CodeAnalysis.SuppressMessage("AvaloniaProperty", "AVP1002", Justification = "Generic avalonia property is expected here.")]
    public static readonly StyledProperty<TViewModel?> ViewModelProperty = AvaloniaProperty.Register<ReactiveViewBase<TViewModel>, TViewModel?>(nameof(ViewModel));

    public TViewModel? ViewModel
    {
        get { return GetValue(ViewModelProperty); }
        set { SetValue(ViewModelProperty, value); }
    }

    object? IViewFor.ViewModel { get; set; }

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

    protected abstract object Build(TViewModel vm);

    protected override object Build() => Build((TViewModel)DataContext!);

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);

        if (change.Property == DataContextProperty)
        {
            if (ReferenceEquals(change.OldValue, ViewModel) && change.NewValue is null or TViewModel)
            {
                SetCurrentValue(ViewModelProperty, change.NewValue);
            }
        }
        else if (change.Property == ViewModelProperty)
        {
            if (ReferenceEquals(change.OldValue, DataContext))
            {
                SetCurrentValue(DataContextProperty, change.NewValue);
            }
        }
    }
}
