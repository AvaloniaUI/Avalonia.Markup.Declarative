using Avalonia.Controls.Primitives;

public class MyCustomTemplatedControl : TemplatedControl
{
    #region NewValue Styled Avalonia Property
    public string? NewValue
    {
        get { return GetValue(NewValueProperty); }
        set { SetValue(NewValueProperty, value); }
    }

    public static readonly StyledProperty<string?> NewValueProperty =
        AvaloniaProperty.Register<MyCustomTemplatedControl, string?>
        (
            nameof(NewValue)
        );
    #endregion NewValue Styled Avalonia Property


    #region SavedValue Styled Avalonia Property
    public string? SavedValue
    {
        get { return GetValue(SavedValueProperty); }
        set { SetValue(SavedValueProperty, value); }
    }

    public static readonly StyledProperty<string?> SavedValueProperty =
        AvaloniaProperty.Register<MyCustomTemplatedControl, string?>
        (
            nameof(SavedValue)
        );
    #endregion SavedValue Styled Avalonia Property


    #region CanSave Direct Avalonia Property
    private bool _canSave = default;

    public static readonly DirectProperty<MyCustomTemplatedControl, bool> CanSaveProperty =
        AvaloniaProperty.RegisterDirect<MyCustomTemplatedControl, bool>
        (
            nameof(CanSave),
            o => o.CanSave
        );

    public bool CanSave
    {
        get => _canSave;
        private set
        {
            SetAndRaise(CanSaveProperty, ref _canSave, value);
        }
    }

    #endregion CanSave Direct Avalonia Property

    // CanSave is set to true when SavedValue is not the same as NewView
    // false otherwise
    private void SetCanSave(object? _)
    {
        CanSave = SavedValue != NewValue;
    }

    public MyCustomTemplatedControl()
    {
        this.GetObservable(NewValueProperty).Subscribe(SetCanSave);
        this.GetObservable(SavedValueProperty).Subscribe(SetCanSave);
    }

    public void Save()
    {
        SavedValue = NewValue;
    }

    public void Cancel()
    {
        NewValue = SavedValue;
    }

}