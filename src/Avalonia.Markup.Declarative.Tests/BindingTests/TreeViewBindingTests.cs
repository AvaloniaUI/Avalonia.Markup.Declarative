using System.Collections.ObjectModel;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Threading;

namespace Avalonia.Markup.Declarative.Tests.BindingTests;

public class TreeViewBindingTests : AvaloniaTestBase
{
    public class Node(string name, IEnumerable<Node>? children = null)
    {
        public string Name { get; set; } = name;
        public ObservableCollection<Node> Children { get; set; } = new(children ?? []);
    }

    public class TreeViewSampleView : ComponentBase
    {
        protected override object Build() =>
            new StackPanel()
                .Children(
                    new TreeView()
                        .Ref(out _tree)
                        .ItemsSource(Nodes)
                        .ItemTemplate(
                            new FuncTreeDataTemplate<Node>((n, _) => new TextBlock().Text(n.Name), n => n.Children)
                        )
                        .SelectedItem(() => SelectedNode!, v => SelectedNode = (Node?)v),

                    new TextBlock().Ref(out _text).Text(() => SelectedNode?.Name ?? "-")
                );

        public TreeView _tree = null!;
        public TextBlock _text = null!;

        public Node? SelectedNode { get; set; }

        public ObservableCollection<Node> Nodes { get; set; } =
        [
            new Node("Animals", [ new Node("Mammals", [ new Node("Lion"), new Node("Cat"), new Node("Zebra") ]) ])
        ];
    }

    [Fact]
    public void TreeView_SelectedItem_TwoWay_Works()
    {
        var view = new TreeViewSampleView();
        var window = new Window { Content = view };
        window.Show();
        Dispatcher.UIThread.RunJobs();

        // Programmatic set should reflect in control
        var lion = view.Nodes[0].Children[0].Children[0];
    view.SelectedNode = lion;
    view.UpdateState();
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(lion, (Node?)view._tree.SelectedItem);
        Assert.Equal("Lion", view._text.Text);

        // Control-side change should pop back
        var cat = view.Nodes[0].Children[0].Children[1];
        view._tree.SelectedItem = cat;
        view.UpdateState();
        Dispatcher.UIThread.RunJobs();
        Assert.Equal(cat, view.SelectedNode);
        Assert.Equal("Cat", view._text.Text);
    }
}
