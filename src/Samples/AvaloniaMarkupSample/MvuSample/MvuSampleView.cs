using Avalonia.Markup.Declarative;

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
                            .Ref(out _nestedComponent)
                            .ComponentParameter(Bind(MvuComponentParam))
                    ),

                new Button()
                    .Content("Change nested component parameter")
                    .OnClick(OnButton3Click)

            );

    private string _myNotifiedProperty1 = "Click me";
    private MvuComponent _nestedComponent;

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

    public string MvuComponentParam { get; set; } = "Hello nested component";

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

    private void OnButton3Click(RoutedEventArgs obj)
    {
        MvuComponentParam = "I changed from external view!";
        _nestedComponent.UpdateState();
    }
}