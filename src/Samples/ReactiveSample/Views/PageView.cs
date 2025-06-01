using ReactiveSample.ViewModels;

namespace ReactiveSample.Views;

internal class PageView : ReactiveViewBase<PageViewModel>
{
    protected override object Build(PageViewModel vm) =>
        new StackPanel()
            .Children([
                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Text(vm.ReactiveBinding(x => x.MyProperty)),
                new TextBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .OnTextChanged(x => {
                        if (x.Source is TextBox tb)
                            vm.MyProperty = tb.Text ?? "";
                    })
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Text(vm.ReactiveBinding(x => x.MyProperty)),
                new TextBox()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .OnTextChanged(x => {
                        if (x.Source is TextBox tb)
                            vm.MyProperty = tb.Text ?? "";
                    })
                    .VerticalAlignment(VerticalAlignment.Center)
                    .Text(vm.ReactiveBinding(x => x.MyProperty)),
            ]);
}
