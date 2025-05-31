using Avalonia.ReactiveUI;
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
                // RoutedViewHost with DefaultContent and ViewLocator
                new RoutedViewHost
                {
                    ViewLocator = new AppViewLocator()
                }
                .DefaultContent(
                    new TextBlock {
                        Text = "Default content",
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    }
                )
                .Router(vm.ObservableForProperty((x) => x.Router).ToBinding())
                .Row(0),
            ])
        ;
        //{
            //RowDefinitions =
            //{
            //    new RowDefinition(GridLength.Star),
            //    new RowDefinition(GridLength.Auto)
            //},
            //Children =
            //{
            //    // RoutedViewHost with DefaultContent and ViewLocator
            //    new RoutedViewHost
            //    {
            //        [!RoutedViewHost.RouterProperty] = new Binding("Router"),
            //        DefaultContent = new TextBlock
            //        {
            //            Text = "Default content",
            //            HorizontalAlignment = HorizontalAlignment.Center,
            //            VerticalAlignment = VerticalAlignment.Center
            //        },
            //        ViewLocator = new AppViewLocator()
            //    }.Row(0),

            //    // StackPanel with styles and controls
            //    new StackPanel
            //    {
            //        Orientation = Orientation.Horizontal,
            //        Margin = new Thickness(15),
            //        Styles =
            //        {
            //            // Style for all direct child controls
            //            new Style(x => x.OfType<StackPanel>().Child().OfType<Control>())
            //            {
            //                Setters =
            //                {
            //                    new Setter(Control.MarginProperty, new Thickness(2))
            //                }
            //            },
            //            // Style for all direct child TextBlocks
            //            new Style(x => x.OfType<StackPanel>().Child().OfType<TextBlock>())
            //            {
            //                Setters =
            //                {
            //                    new Setter(TextBlock.VerticalAlignmentProperty, VerticalAlignment.Center)
            //                }
            //            }
            //        },
            //        Children =
            //        {
            //            new Button
            //            {
            //                Content = "Go next",
            //                //[!Button.CommandProperty] = this.BindCommand(vm, x => x.GoNext)
            //            },
            //            new Button
            //            {
            //                Content = "Go back",
            //                //[!Button.CommandProperty] = this.BindCommand(vm, x => x.GoBack)
            //            },
            //            new TextBlock
            //            {
            //                //[!TextBlock.TextProperty] = this.OneWayBind(vm, x => x.Router.NavigationStack.Count, v => v.Text)
            //            }
            //        }
            //    }.Row(1)
            //}
       // };
}