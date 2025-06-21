using Avalonia.Controls.Templates;
using Avalonia.Styling;

namespace AvaloniaMarkupSample.CommonSamples;

public class StylesSampleView : ViewBase
{
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Button>(s => s.Class("nested-button"))
            .FontSize(26d)
    ];

    protected override object Build() =>
        new StackPanel()
            .Classes("sample-wrapper")
            .Children(
            [
                new TabControl()
                    .ItemTemplate<TabViewModel>(tab => new TextBlock().Text(tab.Title))
                    .ContentTemplate(
                        new FuncDataTemplate<TabViewModel>((item, ns) =>
                            new FuncView<TabViewModel>(item, vm =>
                                new TextBlock().Text(() => vm.Content)))
                    )
                    .ItemsSource(Tabs)
                    .Styles(
                        new Style<TabItem>()
                            .IsEnabled(new Binding(nameof(TabViewModel.Enabled)))
                            .Foreground(Brushes.YellowGreen)
                    ),

                new Button()
                    .Classes("nested-button")
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Content("Hello styles!")
                    .Height(50)
                    .Styles(
                        // Typed generic style
                        new Style<Button>(x =>
                                x.OfType<StackPanel>().Class("sample-wrapper").Descendant().OfType<Button>()
                                    .Class("nested-button"))
                            .Background(Brushes.Green),
                        new Style<Button>(s =>
                                s.OfType<Button>().Class(":pointerover")
                                    .Child()) //add child selector to change color of content presenter inside button
                            .Background(Brushes.Red)),

                new Button()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Content("Unstyled buton")
                    .Width(150)
            ]);

    public List<TabViewModel> Tabs { get; set; } = new()
    {
        new TabViewModel("Tab1"),
        new TabViewModel("Tab2"),
        new TabViewModel("Disabled tab",false)
    };
}

public class TabViewModel
{
    public TabViewModel(string title, bool enabled = true)
    {
        Title = title;
        Enabled = enabled;
    }

    public string Title { get; }
    public bool Enabled { get; }

    public string Content => Title + " Content";
}