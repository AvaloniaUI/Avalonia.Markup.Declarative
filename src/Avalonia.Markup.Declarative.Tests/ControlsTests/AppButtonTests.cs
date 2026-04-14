using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Interactivity;
using Avalonia.Layout;
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Avalonia.Threading;
using System;
using System.Windows.Input;
using Xunit;

namespace Avalonia.Markup.Declarative.Tests.ControlsTests;

public class AppButtonTests : AvaloniaTestBase
{
    public class AppButton : ViewBase
    {
        public const string IconControlName = "app-button-icon";
        public const string LabelControlName = "app-button-label";
        public event Action? Click;

        public static readonly DirectProperty<AppButton, string> LabelProperty
            = AvaloniaProperty.RegisterDirect<AppButton, string>(nameof(Label), o => o.Label, (o, v) => o.Label = v);
        private string _label = "Label";
        public string Label
        {
            get => _label;
            set => SetAndRaise(LabelProperty, ref _label, value);
        }

        public IBrush Background
        {
            get => GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }

        public static readonly StyledProperty<IBrush> BackgroundProperty =
            AvaloniaProperty.Register<AppButton, IBrush>(nameof(Background));

        /// <summary>
        /// Command
        /// </summary>
        public static readonly DirectProperty<AppButton, ICommand> CommandProperty
            = AvaloniaProperty.RegisterDirect<AppButton, ICommand>(nameof(Command), o => o.Command, (o, v) => o.Command = v);
        private ICommand _command = null!;
        public ICommand Command
        {
            get => _command;
            set => SetAndRaise(CommandProperty, ref _command, value);
        }

        /// <summary>
        /// Content
        /// </summary>
        public static readonly DirectProperty<AppButton, object> ContentProperty
            = AvaloniaProperty.RegisterDirect<AppButton, object>(nameof(Content), o => o.Content, (o, v) => o.Content = v);
        private object _content = null!;
        public object Content
        {
            get => _content;
            set => SetAndRaise(ContentProperty, ref _content, value);
        }

        /// <summary>
        /// Content
        /// </summary>
        public static readonly DirectProperty<AppButton, FontFamily> IconFontFamilyProperty
            = AvaloniaProperty.RegisterDirect<AppButton, FontFamily>(nameof(IconFontFamily), o => o.IconFontFamily, (o, v) => o.IconFontFamily = v);
        private FontFamily _iconFontFamily = null!;
        public FontFamily IconFontFamily
        {
            get => _iconFontFamily;
            set => SetAndRaise(IconFontFamilyProperty, ref _iconFontFamily, value);
        }

        protected override object Build() =>
            new Button()
                .Classes("app-button")
                .Command(this, x => x.Command, BindingMode.OneWay)
                .HorizontalAlignment(HorizontalAlignment.Stretch)
                .VerticalAlignment(VerticalAlignment.Stretch)
                .HorizontalContentAlignment(HorizontalAlignment.Stretch)
                .VerticalContentAlignment(VerticalAlignment.Stretch)
                .Padding(0)
                .Margin(0)
                .OnClick(_ => Click?.Invoke())
                .Content(
                    new Border()
                        .Child(
                            new Grid()
                                .Rows("24, Auto")
                                .VerticalAlignment(VerticalAlignment.Center)
                                .Children(
                                    new ContentControl()
                                        .Name(IconControlName, Scope)
                                        .FontSize(16)
                                        .HorizontalAlignment(HorizontalAlignment.Center)
                                        .VerticalAlignment(VerticalAlignment.Center)
                                        .HorizontalContentAlignment(HorizontalAlignment.Stretch)
                                        .VerticalContentAlignment(VerticalAlignment.Stretch)
                                        .FontFamily(this, x => x.IconFontFamily, BindingMode.OneWay)
                                        .Content(this, x => x.Content, BindingMode.OneWay),

                                    new TextBlock().Row(1)
                                        .Name(LabelControlName, Scope)
                                        .Text(this, x => x.Label, BindingMode.OneWay)
                                        .HorizontalAlignment(HorizontalAlignment.Center)
                                )
                        )
                );
    }

    [Fact]
    public void AppButton_Should_Update_Labels_And_Content()
    {
        var button = new AppButton();
        var window = new Window { Content = button };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var labelControl = button.FindControl<TextBlock>(AppButton.LabelControlName);
        var iconControl = button.FindControl<ContentControl>(AppButton.IconControlName);

        Assert.NotNull(labelControl);
        Assert.NotNull(iconControl);

        Assert.Equal("Label", labelControl.Text);

        button.Label = "New Label";
        button.Content = "New Content";
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("New Label", labelControl.Text);
        Assert.Equal("New Content", iconControl.Content);
    }

    [Fact]
    public void AppButton_Click_Event_Should_Fire()
    {
        bool clicked = false;
        var button = new AppButton();
        button.Click += () => clicked = true;

        var window = new Window { Content = button };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var avaloniaButton = (Button)button.Child!;
        avaloniaButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));

        Assert.True(clicked);
    }
}
