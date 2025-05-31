using ReactiveSample.ViewModels;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>
{
    protected override object Build(PageViewModel? vm) =>
        new TextBlock()
            .Text("This is a page view")
            .HorizontalAlignment(HorizontalAlignment.Center)
            .VerticalAlignment(VerticalAlignment.Center);
}
