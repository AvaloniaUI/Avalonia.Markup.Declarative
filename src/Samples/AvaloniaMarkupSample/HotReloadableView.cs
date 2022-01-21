public class HotReloadView : ViewBase
{
    protected override object Build() =>
        new Grid()
            .Background(Brushes.SaddleBrown)
            .Children(
                new TextBlock()
                    .Foreground(Brushes.White)
                    .Padding(12)
                    .FontSize(30)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text("Hello Hot Reload!")
            );
}