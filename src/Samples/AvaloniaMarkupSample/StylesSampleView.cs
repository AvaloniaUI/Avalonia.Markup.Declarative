using Avalonia.Styling;

namespace AvaloniaMarkupSample;

public class StylesSampleView : ViewBase
{
    protected override object Build() =>
        new Button()
            .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
            .Content("Hello styles!")
            .Width(100)
            .Height(50)
            .Styles(
                new Style<Button>()
                    .Background(Brushes.Green),
                new Style<Button>(s => s.Class(":pointerover"))
                    .Background(Brushes.Red));
}