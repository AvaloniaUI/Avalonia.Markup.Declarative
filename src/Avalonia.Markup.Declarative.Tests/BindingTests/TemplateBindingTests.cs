using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Threading;
using Avalonia.VisualTree;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class TemplateBindingTests : AvaloniaTestBase
{
    public class TemplateTestView : ViewBase
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<Button>(
            (control, scope) =>
                new TextBox()
                    .Text(control, x => (string?)x.Content, BindingMode.OneWay)
        );

        protected override object Build() =>
            new Button()
                .Content("Initial")
                .Template(MyControlTemplate)
                .Ref(out MyButton);

        public Button MyButton = null!;
    }

    [Fact]
    public void TextBox_Text_Bound_To_Button_Content()
    {
        var view = new TemplateTestView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        var button = view.MyButton;
        Assert.NotNull(button);
        var textBox = button.GetSelfAndVisualDescendants().OfType<TextBox>().FirstOrDefault();
        Assert.NotNull(textBox);

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
        var textBox = button.GetSelfAndVisualDescendants().OfType<TextBox>().FirstOrDefault();
        Assert.NotNull(textBox);

        button.Content = "Changed";
        Dispatcher.UIThread.RunJobs();

        Assert.Equal("Changed", textBox.Text);
    }
}
