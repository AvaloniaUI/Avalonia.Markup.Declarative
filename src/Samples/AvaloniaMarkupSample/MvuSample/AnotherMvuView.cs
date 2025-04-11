using System.Collections.ObjectModel;
using System.ComponentModel;

namespace AvaloniaMarkupSample.MvuSample;

internal class CounterState
{
    public readonly static CounterState Default = new CounterState();
    public int Counter { get; set; } = 0;
}

public class AnotherMvuView : MvuView
{
    protected override object Build() =>
    new StackPanel().Spacing(10).HorizontalAlignment(HorizontalAlignment.Center)
            .Children(
                     new TextBlock()
                            .Text(() => $"[AnotherMvuView] Counter: {(State.Counter == 0 ? "zero" : State.Counter)}"),
                     new EmbedMvuView().Name("Set Once")
                            .SetState(x => { x.State = State; })
                            .Observe(this),
                     new EmbedMvuView().Name("Set Before Update")
                            .SetState(x => { x.State = State; }, false)
                            .Observe(this),
                     new Button().Content("Click me [Button1]")
                                .OnClick(OnButtonClick1),
                     new Button().Content("Click me [Button2]")
                                .OnClick(OnButtonClick2),
                     new Button().Content("Reload")
                                .OnClick(OnButtonReloadClick),
                     new ItemControlSampleView()
            );

    [Bindable(true)]
    internal CounterState State { get; set; } = new CounterState();

    private void OnButtonClick1(RoutedEventArgs e)
    {
        this.State.Counter++;
        StateHasChanged();
    }

    private void OnButtonClick2(RoutedEventArgs e)
    {
        int count = State.Counter + 1;
        this.State = new CounterState() { Counter = count };
        StateHasChanged();
    }

    private void OnButtonReloadClick(RoutedEventArgs e)
    {
        this.State.Counter = 0;
        this.ClearObserverViews();
        this.Reload();
    }
}

public class EmbedMvuView : MvuView
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => $"[EmbedMvuView ({Name})] Counter: {(State.Counter == 0 ? "zero" : State.Counter)}")
            );

    internal CounterState State { get; set; } = CounterState.Default;
}

public class ItemControlSampleView : MvuView
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new ListBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(() => State.Items)
                    .ItemTemplate<string>(item =>
                        BuildItem(item, s =>
                            new TextBlock()
                            .Background(Brushes.Beige)
                            .Text(() => s))
                    )
                    .SelectedItem(() => State.SelectedItem, v => this.UpdateState(() => State.SelectedItem = (string)v)),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(() => State.SelectedItem),

                new Button().Content("Add One")
                                .OnClick(_ => {
                                    State.Items.Add(DateTime.Now.ToFileTime().ToString());
                                    this.UpdateState();
                                })
            );



    public ListState State { get; set; } = new ListState();
}

public class ListState
{
    public ObservableCollection<string> Items { get; set; } = new()
    {
        "one",
        "two",
        "four"
    };

    public string SelectedItem { get; set; } = "one";
}