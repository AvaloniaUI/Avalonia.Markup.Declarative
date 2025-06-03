using Avalonia.Styling;
using ReactiveSample.ViewModels;

namespace ReactiveSample.Views;

internal class PageView1 : ReactiveViewBase<PageViewModel1>
{
    protected override StyleGroup? BuildStyles() =>
    [
         new Style(x => x.Is<TextBlock>())
             .Setter(Control.HorizontalAlignmentProperty, HorizontalAlignment.Center)
             .Setter(Control.VerticalAlignmentProperty, VerticalAlignment.Center),
         new Style(x => x.Is<TextBox>())
             .Setter(Control.HorizontalAlignmentProperty, HorizontalAlignment.Center)
             .Setter(Control.VerticalAlignmentProperty, VerticalAlignment.Center),
    ];

    protected override object Build(PageViewModel1 vm) =>
        new StackPanel()
            .Children([
                new TextBlock()
                    .ReactiveBinding(TextBox.TextProperty, vm, x => x.MyProperty),
                new TextBox()
                    .ReactiveBinding(TextBox.TextProperty, vm, x => x.MyProperty, x => vm.MyProperty = x!),
                new TextBox()
                    .ReactiveBinding(TextBox.TextProperty, vm, x => x.MyProperty, x => vm.MyProperty = x!),
            ]);
}
