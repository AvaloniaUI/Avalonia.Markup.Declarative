using Avalonia.Controls.Primitives;
using Avalonia.Styling;

namespace AvaloniaMarkupSample.MvuSample;

public class SampleMvuView : ComponentBase
{
    protected override StyleGroup BuildStyles() =>
    [
        //general
        new Style<TextBlock>(x => x.Class("beautiful-textblock"))
            .Foreground(Brushes.CornflowerBlue)
            .TextAlignment(TextAlignment.Center)
            .FontSize(22),

            new Style<ScrollViewer>(s => s.OfType<SampleMvuView>().Descendant().OfType<ScrollViewer>())
                .VerticalScrollBarVisibility(ScrollBarVisibility.Disabled)
                .HorizontalScrollBarVisibility(ScrollBarVisibility.Hidden),
    ];


    protected override object Build() =>
        new ScrollViewer()
            .VerticalScrollBarVisibility(ScrollBarVisibility.Hidden)
            .Content(

                new StackPanel()
                    .Children(
                        new TextBlock()
                            .Classes("beautiful-textblock")
                            .TextWrapping(TextWrapping.Wrap)
                            .Name("NamedTextBlock")
                            .Text("NamedTextBlock"),

                        new TextBlock()
                            .Text(() => MyProperty),

                        new TextBlock()
                            .Text(() => State.StateProperty),

                        new Button()
                            .Content(() => MyNotifiedProperty)
                            .OnClick(OnButtonClick),

                        new Button()
                            .Content("Update separate state")
                            .OnClick(OnButton2Click),

                        new Border()
                            .Background(() => BorderColor)
                            .Child(
                                new Component()
                                    .InnerContent(() => MvuComponentParam)
                                    .OnButtonClicked()
                            ),

                        new Button()
                            .Content("Change nested component parameter")
                            .OnClick(OnButton3Click),


                        new TextBlock()
                            .Text("lambda binding sample")
                            .FontSize(24),
                        new TextBlock()
                            .Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"),
                        new NumericUpDown()
                            .Value(() => Counter, v => Counter = v)

                    )
            );

    private decimal? Counter { get; set; } = 0;

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

    public Brush BorderColor { get; set; } = Colors.Red.ToBrush();
    public string MyProperty { get; set; } = "Hello MVU";

    public SeparatedViewState State { get; set; } = new();

    public string MvuComponentParam { get; set; } = "Hello nested component";

    private void OnButtonClick(RoutedEventArgs args)
    {
        var tb = this.FindControl<TextBlock>("NamedTextBlock");

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
        BorderColor = Colors.Green.ToBrush();
        StateHasChanged();
    }
}