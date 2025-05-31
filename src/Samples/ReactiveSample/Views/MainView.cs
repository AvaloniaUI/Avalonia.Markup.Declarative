using Avalonia.ReactiveUI;
using Avalonia.Styling;
using ReactiveSample.ViewModels;
using ReactiveUI;
using System.Reactive.Linq;

namespace ReactiveSample.Views;

internal class MainView : ReactiveViewBase<MainViewModel>
{
    public MainView()
    {
        this.WhenActivated(disposables => { });
    }

    protected override object Build(MainViewModel? vm) =>
        new Grid()
            .Rows("*, Auto")
            .Children([
                new RoutedViewHost
                {
                    ViewLocator = new AppViewLocator()
                }
                    .DefaultContent(
                        new TextBlock()
                            .Text("Default content")
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .VerticalAlignment(VerticalAlignment.Center)
                    )
                    .Router(new Binding("Router"))
                    //.Router(vm.ObservableForProperty((x) => x.Router).ToBinding())
                    .Row(0),
                new StackPanel()
                {
                    Orientation = Orientation.Horizontal,
                    Margin = new Thickness(15),
                }
                    .Orientation(Orientation.Horizontal)
                    .Margin(new Thickness(15))
                    .Styles([
                        new Style(x => x.OfType<StackPanel>().Child().OfType<Control>())
                            .Setter(Control.MarginProperty, new Thickness(2)),
                        new Style(x => x.OfType<StackPanel>().Child().OfType<TextBlock>())
                            .Setter(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center),
                    ])
                    .Row(1)
                    .Children([
                        new Button()
                            .Content("Go next")
                            .Command(vm?.GoNext),
                        new Button()
                            .Content("Go back")
                            .Command(vm?.GoBack),
                        new TextBlock()
                            .Text(new Binding("Router.NavigationStack.Count"))
                            //.Text(vm.ObservableForProperty((x) => x.Router.NavigationStack.Count).ToBinding())
                    ])
            ]);

}