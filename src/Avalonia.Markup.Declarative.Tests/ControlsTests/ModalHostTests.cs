using System.Collections.Generic;
using Avalonia.Controls;
using Xunit;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class ModalHostTests : AvaloniaTestBase
{
    // Reproduces the MVU-style component from the issue
    public class ModalHost : ComponentBase
    {
        internal Panel? HostPanel;

        // Common (non-Avalonia) property
        public Control? MainContent { get; set; }

        // Diagnostics
        public bool WasMainContentNullDuringBuild { get; private set; }
        public bool AvaloniaOnPropertyChangedFiredForMainContent { get; private set; }

        protected override object Build()
        {
            var children = new List<Control>();

            WasMainContentNullDuringBuild = MainContent is null;
            if (MainContent is not null)
                children.Add(MainContent);

            // Modals container (always present)
            children.Add(new Panel());

            return new Panel()
                .Ref(out HostPanel)
                .Children(children.ToArray());
        }

        protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
        {
            base.OnPropertyChanged(change);

            if (change.Property.Name.Contains(nameof(MainContent)))
                AvaloniaOnPropertyChangedFiredForMainContent = true;
        }
    }

    [Fact]
    public void Build_is_called_before_MainContent_is_set()
    {
        var host = new ModalHost();
        host.MainContent = new TextBlock(); // set after construction

        Assert.True(host.WasMainContentNullDuringBuild);
    }

    [Fact]
    public void Setting_Common_property_does_not_raise_Avalonia_OnPropertyChanged()
    {
        var host = new ModalHost();

        Assert.False(host.AvaloniaOnPropertyChangedFiredForMainContent);

        host.MainContent = new TextBlock();

        // Because MainContent is a common (non-Avalonia) property, overriding Avalonia OnPropertyChanged won't see it
        Assert.False(host.AvaloniaOnPropertyChangedFiredForMainContent);
    }

    [Fact]
    public void Children_are_not_updated_automatically_when_setting_MainContent_after_build()
    {
        var host = new ModalHost();
        host.MainContent = new TextBlock();

        // Build executed with MainContent == null, so only the modals panel is present
        Assert.NotNull(host.HostPanel);
        Assert.Equal(1, host.HostPanel!.Children.Count);
    }
}
