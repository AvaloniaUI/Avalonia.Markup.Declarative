using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class TemplateBindingTests : AvaloniaTestBase
{
    public class TemplateTestView : ViewBase
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<Button>(
            (control, scope) => new FuncView<Button>(control, c =>
                new TextBox()
                    .Text(() => (c.Content?.ToString() ?? ""), val => c.Content = val)
            )
        );

        protected override object Build() =>
            new Button()
                .Content("Initial")
                .Template(() => MyControlTemplate)
                .Ref(out MyButton);

        public Button MyButton = null!; // Using a field to check it's value in tests
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
        var textBox = button.GetSelfAndVisualDescendants().OfType<TextBox>().FirstOrDefault();
        Assert.NotNull(textBox);

        // Should have set the initial text
        Assert.Equal("Initial", textBox.Text);
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