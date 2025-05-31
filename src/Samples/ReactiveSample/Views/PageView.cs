using ReactiveSample.ViewModels;
using ReactiveUI;
using System.Reactive.Linq;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>
{
    protected override object Build(PageViewModel? vm) =>
        new TextBlock()
            .Text(vm.ObservableForProperty(x => x.MyProperty, false, false).Select(x => x.GetValue()).ToBinding())
            .HorizontalAlignment(HorizontalAlignment.Center)
            .VerticalAlignment(VerticalAlignment.Center);
}
