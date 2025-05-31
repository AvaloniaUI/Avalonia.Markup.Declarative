using ReactiveSample.ViewModels;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>
{
    protected override object Build(PageViewModel vm) =>
        new TextBlock()
            .Text(vm.PropertyBinding(x => x.MyProperty))
            .HorizontalAlignment(HorizontalAlignment.Center)
            .VerticalAlignment(VerticalAlignment.Center);
}
