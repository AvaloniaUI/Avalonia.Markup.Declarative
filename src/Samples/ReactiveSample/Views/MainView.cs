using Avalonia.ReactiveUI;
using Avalonia.Styling;
using ReactiveSample.ViewModels;
using ReactiveUI;
using System.Reactive.Linq;

namespace ReactiveSample.Views;

internal class MainView : ReactiveViewBase<MainViewModel>
{
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
                            .Text(vm.PropertyBinding(x => x.MyProperty))
                            .HorizontalAlignment(HorizontalAlignment.Center)
                            .VerticalAlignment(VerticalAlignment.Center)
                    )
                    .Router(vm.Router)
                    .Row(0),
                new StackPanel()
                    .Orientation(Orientation.Horizontal)
                    .Margin(new Thickness(15))
                    .Styles([
                        new Style(x => x.OfType<StackPanel>().Child().OfType<Control>())
                            .Setter(MarginProperty, new Thickness(2)),
                        new Style(x => x.OfType<StackPanel>().Child().OfType<TextBlock>())
                            .Setter(VerticalAlignmentProperty, VerticalAlignment.Center),
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
                            .Text(vm.PropertyBinding(x => x.Router.NavigationStack.Count, x => x.Value.ToString()))
                    ])
            ]);
}