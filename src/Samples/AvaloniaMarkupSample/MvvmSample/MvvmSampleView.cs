namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleView() : ViewBase<MvvmSampleViewModel>(new MvvmSampleViewModel())
{
    #region NewValue Styled Avalonia Property
    public string? NewValue
    {
        get => GetValue(NewValueProperty);
        set => SetValue(NewValueProperty, value);
    }

    public static readonly StyledProperty<string?> NewValueProperty =
        AvaloniaProperty.Register<MvvmSampleView, string?>
        (
            nameof(NewValue)
        );
    #endregion NewValue Styled Avalonia Property

    protected override object Build(MvvmSampleViewModel vm) =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(@vm.MyObject.MyProperty),

                new Button()
                    .Content("Execute Command")
                    .Command(new Binding(nameof(vm.MyCommand)))
                    .CommandParameter(new Binding() { Source = vm })
            );
}