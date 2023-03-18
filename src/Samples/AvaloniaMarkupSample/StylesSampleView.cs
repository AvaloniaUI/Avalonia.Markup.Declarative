using Avalonia.Controls.Templates;
using Avalonia.Styling;

namespace AvaloniaMarkupSample;

public class StylesSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(new Control[]
            {
                new TabControl()
                    .ItemTemplate<TabVm>(tab => new TextBlock().Text(tab.Title))
                    .ContentTemplate(new FuncDataTemplate<TabVm>((item, ns) => new TextBlock().Text(item?.Content)))
                    .Items(Tabs)
                    .Styles(
                        new Style<TabItem>()
                            .IsEnabled(new Binding(nameof(TabVm.Enabled)))
                            .Foreground(Brushes.YellowGreen)
                    ),

                new Button()
                    .HorizontalAlignment(Avalonia.Layout.HorizontalAlignment.Center)
                    .Content("Hello styles!")
                    .Width(100)
                    .Height(50)
                    .Styles(
                        new Style<Button>()
                            .Background(Brushes.Green),
                        new Style<Button>(s => s.Class(":pointerover"))
                            .Background(Brushes.Red))

            });

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