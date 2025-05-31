using ReactiveSample.ViewModels;
using ReactiveUI;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>
{
    protected override object Build(PageViewModel? vm) =>
        new TextBlock()
            .Text(new Binding(nameof(PageViewModel.MyProperty)))
            //.Text(vm.ObservableForProperty(x => x.MyProperty, y => y).ToBinding())
            .HorizontalAlignment(HorizontalAlignment.Center)
            .VerticalAlignment(VerticalAlignment.Center);
}
