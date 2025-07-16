using Avalonia.Controls.Templates;
using Avalonia.Styling;

namespace AvaloniaMarkupSample;

public class StylesSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Classes("sample-wrapper")
            .Styles(
                new Style<Button>(x => x.OfType<Button>().Class("nested-button"))
                    .FontSize(26d)
            )
            .Children(new Control[]
            {
                new TabControl()
                    .ItemTemplate<TabVm>(tab => new TextBlock().Text(tab.Title))
                    .ContentTemplate(new FuncDataTemplate<TabVm>((item, ns) => new TextBlock().Text(item?.Content)))
                    .ItemsSource(Tabs)
                    .Styles(
                        new Style<TabItem>()
                            .IsEnabled(new Binding(nameof(TabVm.Enabled)))
                            .Foreground(Brushes.YellowGreen)
                    ),

                new Button()
                    .Classes("nested-button")
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Content("Hello styles!")
                    .Height(50)
                    .Styles(
                        // Typed generic style
                        new Style<Button>(x =>
                                x.OfType<StackPanel>().Class("sample-wrapper").Descendant().OfType<Button>().Class("nested-button"))
                            .Background(Brushes.Green),
                        new Style<Button>(s => s.OfType<Button>().Class(":pointerover").Child()) //add child selector to change color of content presenter inside button
                            .Background(Brushes.Red)),
                
                new Button()
                    .Classes("unstyles-button")
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Content("Unstyled buton")
                    .Width(150),

                new Button()
                    .Classes("style2-button")
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Content("Style2 buton")
                    .Width(150)
            });

    protected override StyleGroup? BuildStyles()
    {
        return [
            // x.Class 有效
            new Style<Button>(x=>x.Class("style2-button")).BorderThickness(2d)
                .BorderBrush(Brushes.Red),

            // Selector 无效, 因此, 该样式对所有 Button 都生效
            //new Style<Button>()
            //    .Selector(x=>x.Class("style2-button")).BorderThickness(2d)
            //    .BorderBrush(Brushes.Red)
            ];
    }

    public List<TabVm> Tabs { get; set; } = new()
    {
        new TabVm("Tab1"),
        new TabVm("Tab2"),
        new TabVm("Disabled tab",false)
    };
}

public class TabVm
{
    public TabVm(string title, bool enabled = true)
    {
        Title = title;
        Enabled = enabled;
    }

    public string Title { get; }
    public bool Enabled { get; }

    public string Content => Title + " Content";
}