using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class BrushBindingTests : AvaloniaTestBase
{
    public class BorderBrushView : ComponentBase
    {
        protected override object Build() =>
            new Border()
                .Ref(out _border)
                .BorderBrush(() => BorderColor)
                .BorderThickness(3);

    public Border _border = null!;
    public IBrush BorderColor { get; set; } = Brushes.Red;
    }

    [Fact]
    public void Border_BorderBrush_ExpressionBinding_Updates()
    {
        var view = new BorderBrushView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(Brushes.Red, view._border.BorderBrush);

    view.BorderColor = Brushes.Green;
    view.UpdateState();
        Dispatcher.UIThread.RunJobs();

        Assert.Equal(Brushes.Green, view._border.BorderBrush);
    }
}
