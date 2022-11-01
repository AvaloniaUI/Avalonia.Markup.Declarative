namespace AvaloniaMarkupSample.MvvmSample;

public class MvuSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(@MyProperty),

                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );

    public string MyProperty { get; set; } = "Hello MVU";

    private void OnButtonClick(RoutedEventArgs obj)
    {
        throw new NotImplementedException();
    }
}