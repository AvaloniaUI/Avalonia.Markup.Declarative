using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Headless;
using Avalonia.Platform;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class TemplateTestView : ViewBase
{
    public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<Button>(
        (control, scope) =>
            // using FuncView to generate ViewContext that will be used for binding
            // not elegant, but works while we are looking for a better solution
            // and supports different func template types
            new FuncView<Button>(control,
                b =>
                    new TextBox()
                        .Text(() => $"{b.Content}", val => b.Content = val)
            ));

    protected override object Build() =>
        new Button()
            .Content("Initial")
            .Template(() => MyControlTemplate)
            .Ref(out MyButton);

    public Button MyButton = null!; // Using a field to check it's value in tests
}

public class TemplateBindingTests
{
    static TemplateBindingTests()
    {
        // Initialize Avalonia with headless (offscreen) platform only once
        if (Application.Current == null)
        {
            AppBuilder.Configure<Application>()
                .UseHeadless(new AvaloniaHeadlessPlatformOptions() { UseHeadlessDrawing = true, FrameBufferFormat = PixelFormat.Bgra8888 }) // Offscreen rendering
                .SetupWithoutStarting();
        }
    }

    [Fact]
    public void TextBlock_Binding_RegistersComputedState()
    {
        var view = new TemplateTestView();

        // Attach to visual tree to ensure template is applied
        var window = new Window { Content = view };
        window.Show();

        // Process layout and rendering
        Dispatcher.UIThread.RunJobs();

        var button = view.MyButton;
        Assert.NotNull(button); // Ensure button is created
        var templateView = button.GetSelfAndVisualDescendants().OfType<FuncView<Button>>().FirstOrDefault();

        Assert.NotNull(templateView); // Ensure template view is created

        // Should have a computed state for the Text property
        Assert.Contains(templateView.__viewComputedStates, s =>
            s is ViewPropertyComputedState<TextBox, string> state &&
            state.GetterFunc() == "Initial");
    }

    [Fact]
    public void Changing_Button_Content_Updates_TextBox_Text()
    {
        var view = new TemplateTestView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var button = view.MyButton;
        Assert.NotNull(button);

        // Find the TextBox inside the template
        var textBox = button.GetSelfAndVisualDescendants().OfType<TextBox>().FirstOrDefault();
        Assert.NotNull(textBox);

        // Change Button.Content
        button.Content = "Changed";
        Dispatcher.UIThread.RunJobs();

        // Assert TextBox.Text is updated
        Assert.Equal("Changed", textBox.Text);
    }

    [Fact]
    public void Changing_TextBox_Text_Updates_Button_Content()
    {
        var view = new TemplateTestView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var button = view.MyButton;
        Assert.NotNull(button);

        // Find the TextBox inside the template
        var textBox = button.GetSelfAndVisualDescendants().OfType<TextBox>().FirstOrDefault();
        Assert.NotNull(textBox);

        // Change TextBox.Text
        textBox.Text = "FromTextBox";
        Dispatcher.UIThread.RunJobs();

        // Assert Button.Content is updated
        Assert.Equal("FromTextBox", button.Content);
    }
}