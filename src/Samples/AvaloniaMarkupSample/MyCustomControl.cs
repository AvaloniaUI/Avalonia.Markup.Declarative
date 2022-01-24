public class MyCustomControl : ViewBase
{
    #region NewValue Styled Avalonia Property
    public string? NewValue
    {
        get { return GetValue(NewValueProperty); }
        set { SetValue(NewValueProperty, value); }
    }

    public static readonly StyledProperty<string?> NewValueProperty =
        AvaloniaProperty.Register<MyCustomControl, string?>
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
        AvaloniaProperty.Register<MyCustomControl, string?>
        (
            nameof(SavedValue)
        );
    #endregion SavedValue Styled Avalonia Property


    #region CanSave Direct Avalonia Property
    private bool _canSave = default;

    public static readonly DirectProperty<MyCustomControl, bool> CanSaveProperty =
        AvaloniaProperty.RegisterDirect<MyCustomControl, bool>
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

    public MyCustomControl()
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

    protected override object Build()
        => new Grid()
            .Rows("Auto, Auto, *, Auto")
            .Children(
                new StackPanel()
                    .Orientation(Orientation.Horizontal)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Children(
                        new TextBlock().Text("Enter text:")
                            .VerticalAlignment(VerticalAlignment.Center),
                        new TextBox()
                            .Text(@NewValue, BindingMode.TwoWay, bindingSource: this)
                            .MinWidth(150)
                    ),

                new StackPanel().Row(1)
                    .Margin(0, 10)
                    .Orientation(Orientation.Horizontal)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .HorizontalAlignment(HorizontalAlignment.Left)
                    .Children(
                        new TextBlock().Text("Saved text:")
                            .VerticalAlignment(VerticalAlignment.Center),
                        new TextBox()
                            .Text(@SavedValue, bindingSource: this)
                            .MinWidth(150)
                    ),
                new StackPanel().Row(3)
                    .Orientation(Orientation.Horizontal)
                    .HorizontalAlignment(HorizontalAlignment.Right)
                    .Children(
                        new Button().Content("Cancel")
                            .Margin(5, 0)
                            .IsEnabled(Bind(CanSaveProperty))
                            .Command(Bind(this, "Cancel")),
                        new Button().Content("Save")
                            .Margin(5, 0)
                            .IsEnabled(Bind(CanSaveProperty))
                            .Command(Bind(this, "Save"))

                    )
            );

}