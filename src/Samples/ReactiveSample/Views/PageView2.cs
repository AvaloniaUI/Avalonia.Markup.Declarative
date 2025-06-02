using ReactiveSample.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveSample.Views;

internal class PageView2 : ReactiveViewBase<PageViewModel2>
{
    private TextBlock tb1 = null!;
    private TextBox tb2 = null!;
    private TextBox tb3 = null!;

    protected override object Build(PageViewModel2 vm)
    {
        var controls = new StackPanel()
            .Children([
                new TextBlock()
                    .Ref(out tb1)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center),
                new TextBox()
                    .Ref(out tb2)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center),
                new TextBox()
                    .Ref(out tb3)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center)
            ]);

        this.WhenActivated(disposable =>
        {
            this.OneWayBind(vm, x => x.MyProperty, x => x.tb1.Text)
                .DisposeWith(disposable);
            this.Bind(vm, x => x.MyProperty, x => x.tb2.Text)
                .DisposeWith(disposable);
            this.Bind(vm, x => x.MyProperty, x => x.tb3.Text)
                .DisposeWith(disposable);
        });

        return controls;
    }
}
