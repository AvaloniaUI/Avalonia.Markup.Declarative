using Avalonia.Styling;
using CommunityToolkit.Mvvm.ComponentModel;

namespace DeclarativeComponentTemplate;

public partial class CounterComponent(SampleDataService dataService) : ViewBase<CounterComponent.State>(new State(dataService))
{
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Button>(x => x.Class(":pointerover").Descendant())
            .Background(Brushes.LightBlue),

        new Style<Button>()
            .Margin(6)
            .Background(Brushes.DarkSalmon),

        new Style<TextBlock>(s => s.OfType<StackPanel>().Name("SideBar").Descendant())
            .FontSize(16)
            .Foreground(Brushes.White),

        new StyleGroup(x => x.Class("narrow").Descendant())
        {
            new Style<StackPanel>(s => s.Name("SideBar"))
                .IsVisible(false)
        }
    ];

    protected override object Build(State state) =>
        new Grid().Cols("150, *")
            .Children(
                new StackPanel()
                    .Name("SideBar")
                    .Background(Brushes.CadetBlue)
                    .Children(
                        new TextBlock()
                            .Name("title")
                            .Margin(left: 16, top: 16, right: 0, bottom: 0)
                            .Text("Sidebar")
                    ),

                new StackPanel().Col(1)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Children(
                        new TextBlock()
                            .Text(state, x => x.StatusText),
                        new TextBlock()
                            .Text(state, x => x.CounterDisplay),
                        new NumericUpDown()
                            .Value(state, x => x.Counter, BindingMode.TwoWay),
                        new Button()
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .Content("Click me")
                            .OnClick(_ => state.RefreshStatusText())
                    )
            );

    public partial class State(SampleDataService dataService) : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CounterDisplay))]
        public partial decimal? Counter { get; set; } = 0;

        [ObservableProperty]
        public partial string StatusText { get; set; } = "Hello world";

        public string CounterDisplay => Counter is null || Counter == 0
            ? "Counter: zero"
            : $"Counter: {Counter}";

        public void RefreshStatusText()
        {
            StatusText = dataService.GetData();
        }
    }
}
