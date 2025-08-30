using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Styling;
using Avalonia.Threading;
using System.Linq;
using Avalonia.Data;
using Avalonia.Media;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class StyleBindingTests : AvaloniaTestBase
{
    public class TabVm
    {
        public string Title { get; }
        public bool Enabled { get; set; }
        public string Content => Title + " Content";

        public TabVm(string title, bool enabled = true)
        {
            Title = title;
            Enabled = enabled;
        }
    }

    public class TabsView : ViewBase
    {
        protected override StyleGroup? BuildStyles() =>
        [
            new Style<TabItem>()
                .IsEnabled(new Binding(nameof(TabVm.Enabled)))
                .Foreground(Brushes.YellowGreen)
        ];

        protected override object Build() =>
            new TabControl()
                .Ref(out _tabs)
                .ItemTemplate<TabVm>(tab => new TextBlock().Text(tab.Title))
                .ItemsSource(Tabs);

        public TabControl _tabs = null!;
        public List<TabVm> Tabs { get; set; } = new() { new("Tab1"), new("Disabled", false) };
    }

    [Fact]
    public void TabItem_IsEnabled_Binding_Via_Style_Works()
    {
        var view = new TabsView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

    // Collect generated TabItems via visual tree
    var items = view._tabs.GetSelfAndVisualDescendants().OfType<TabItem>().ToList();
        Assert.True(items.Count >= 2);

        var first = items[0];
        var second = items[1];
        Assert.True(first.IsEnabled);
        Assert.False(second.IsEnabled);

        // Toggle VM and ensure style updates
    view.Tabs[1].Enabled = true;
    // Force refresh by reassigning ItemsSource
    var itemsSrc = view.Tabs.ToList();
    view._tabs.ItemsSource = null;
    view._tabs.ItemsSource = itemsSrc;
        Dispatcher.UIThread.RunJobs();
        Assert.True(second.IsEnabled);
    }
}
