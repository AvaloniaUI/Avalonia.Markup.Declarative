using Avalonia.Controls;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class ModalHostTests : AvaloniaTestBase
{
    public class ModalHost : ViewBase
    {
        internal Panel? HostPanel;

        public Control? MainContent { get; set; }

        public bool WasMainContentNullDuringBuild { get; private set; }

        protected override object Build()
        {
            var children = new List<Control>();

            WasMainContentNullDuringBuild = MainContent is null;
            if (MainContent is not null)
                children.Add(MainContent);

            children.Add(new Panel());

            var hostPanel = new Panel()
                .Children(children.ToArray());

            HostPanel = hostPanel;
            return hostPanel;
        }
    }

    [Fact]
    public void Build_is_called_lazily_on_visual_tree_attachment()
    {
        var host = new ModalHost();
        // MainContent set BEFORE attaching to visual tree
        host.MainContent = new TextBlock();

        // Build not yet called
        Assert.Null(host.HostPanel);

        // Attach to visual tree triggers Build
        var window = new Window { Content = host };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        Assert.NotNull(host.HostPanel);
        // MainContent was set before Build, so it should be included
        Assert.False(host.WasMainContentNullDuringBuild);
        Assert.Equal(2, host.HostPanel!.Children.Count); // MainContent + Modals panel
    }

    [Fact]
    public void Children_not_updated_when_setting_MainContent_after_build()
    {
        var host = new ModalHost();
        var window = new Window { Content = host };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Build was called without MainContent
        Assert.True(host.WasMainContentNullDuringBuild);
        Assert.NotNull(host.HostPanel);
        Assert.Single(host.HostPanel!.Children);

        // Setting MainContent after Build doesn't update children
        host.MainContent = new TextBlock();
        Assert.Single(host.HostPanel.Children);
    }
}
