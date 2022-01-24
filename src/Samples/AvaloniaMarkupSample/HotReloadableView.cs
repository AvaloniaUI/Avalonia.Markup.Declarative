public class HotReloadView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Width(300)
            .Children(
                new TextBlock()
                    .Foreground(Brushes.White)
                    .Padding(12)
                    .FontSize(30)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text("Hello Hot Reload!"),

                new TextBlock()
                    .Text("Custom control example:"),

                new Border()
                    .BorderBrush(Brushes.Gray)
                    .BorderThickness(1)
                    .Child(
                    new MyCustomControl()
                        .Margin(20)
                    )
            );
}