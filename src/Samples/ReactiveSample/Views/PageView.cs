using ReactiveSample.ViewModels;
using ReactiveUI;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>, IViewFor<PageViewModel>
{
    public PageView()
    {
        this.WhenActivated(disposables => { });
    }

    protected override object Build(PageViewModel? vm) =>
        new TextBlock()
            .Text("This is a page view")
            .HorizontalAlignment(HorizontalAlignment.Center)
            .VerticalAlignment(VerticalAlignment.Center);
}
