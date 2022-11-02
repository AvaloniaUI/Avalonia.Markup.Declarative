namespace AvaloniaMarkupSample.MvuSample;

public class MvuSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(Bind(MyProperty)),

                new TextBlock()
                    .Text(Bind(State.StateProperty)),

                new Button()
                    .Content(Bind(MyNotifiedProperty))
                    .OnClick(OnButtonClick),

                new Button()
                    .Content("Update separate state")
                    .OnClick(OnButton2Click),

                new Border()
                    .Background(Colors.Aquamarine.ToBrush())
                    .Child(
                        new MvuComponent()
                            .ComponentParameter("Hello component")
                    )
            );


    private string _myNotifiedProperty1 = "Click me";
    public string MyNotifiedProperty
    {
        get => _myNotifiedProperty1;
        set
        {
            if (value != _myNotifiedProperty1)
            {
                _myNotifiedProperty1 = value;
                OnPropertyChanged();
            }
        }
    }

    public string MyProperty { get; set; } = "Hello MVU";

    public SeparatedViewState State { get; set; } = new();

    private void OnButtonClick(RoutedEventArgs obj)
    {
        MyProperty = "Button was clicked!";
        StateHasChanged();

        MyNotifiedProperty = "You clicked me!";
    }
    private void OnButton2Click(RoutedEventArgs obj)
    {
        State.StateProperty = "Value changed!";
    }

}