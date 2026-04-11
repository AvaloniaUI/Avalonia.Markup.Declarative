namespace Avalonia.Declarative.Template._1;

public class MainView() : ViewBase
{
    protected override object Build()
        => ViewFactory.Create<CounterComponent>()
            .Name("MainView", Scope);
}