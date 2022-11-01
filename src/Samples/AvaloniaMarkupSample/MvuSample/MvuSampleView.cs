namespace AvaloniaMarkupSample.MvvmSample;

public class MvuSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(@MyProperty, bindingSource: this),

                new Button()
                    .Content("Click me " + @MyProperty1)
                    .OnClick(OnButtonClick)
            );

    public string MyProperty { get; set; } = "Hello MVU";
    public string MyProperty1 { get; set; } = "No changes";

    private void OnButtonClick(RoutedEventArgs obj)
    {
        MyProperty = "Button was clicked!";
        StateHasChnaged();
    }
}