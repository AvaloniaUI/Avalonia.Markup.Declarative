using Avalonia.Controls.Templates;
using Avalonia.Styling;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace AvaloniaMarkupSample.CommonSamples;

public class StylesSampleView : ViewBase
{
    public TabViewModel TabViewModel { get; } = new("Template");

    protected override StyleGroup? BuildStyles() =>
    [
        new Style<TabItem>(s => s.Class("styles-sample-tabs").Descendant().OfType<TabItem>())
            .Foreground(Brushes.YellowGreen)
            .IsEnabled(default(TabViewModel)!, x => x.Enabled),
        new Style<Button>(s => s.Class("nested-button"))
            .FontSize(26d)
    ];

    protected override object Build() =>
        new StackPanel()
            .Classes("sample-wrapper")
            .Children(
            [
                new TabControl()
                    .Classes("styles-sample-tabs")
                    .ItemsSource(Tabs)
                    .ItemTemplate<TabViewModel>(tab => new TextBlock().Text(tab.Title))
                    .ContentTemplate(
                        new FuncDataTemplate<TabViewModel>((item, ns) =>
                                new TextBlock().Text(item, x => x.Content))
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
        new TabViewModel("Disabled tab", false)
    };
}

public class TabViewModel(string title, bool enabled = true) : INotifyPropertyChanged
{
    private string title = title;
    private bool enabled = enabled;

    public string Title
    {
        get => title;
        set
        {
            title = value;
            OnPropertyChanged();
        }
    }
    public bool Enabled
    {
        get => enabled;
        set
        {
            enabled = value;
            OnPropertyChanged();
        }
    }

    public string Content => Title + " Content";

    public event PropertyChangedEventHandler? PropertyChanged;

    protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

}
