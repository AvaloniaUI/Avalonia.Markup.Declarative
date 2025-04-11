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
                     new EmbedMvuView()
                            .SetState(x => { x.State = State; })
                            .Observe(this),
                     new EmbedMvuView()
                            .SetState(x => { x.State = State; }, false)
                            .Observe(this),
                     new Button().IsVisible(() => State.Counter < 5)
                                .Content("Click me")
                                .OnClick(OnButtonClick)
            );

    internal CounterState State { get; set; } = new CounterState();

    private void OnButtonClick(RoutedEventArgs e)
    {
        State.Counter++;
        int count = State.Counter;

        this.State = new CounterState() { Counter = count };

        if (State.Counter >= 5)
        {
            this.ClearObserverViews();
            this.Reload();
        }
        else
            StateHasChanged();
    }
}

public class EmbedMvuView : MvuView
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => $"[EmbedMvuView] Counter: {(State.Counter == 0 ? "zero" : State.Counter)}")
            );

    internal CounterState State { get; set; } = CounterState.Default;
}