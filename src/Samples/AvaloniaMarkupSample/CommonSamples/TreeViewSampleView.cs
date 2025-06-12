using System.Collections.ObjectModel;
using Avalonia.Controls.Templates;

namespace AvaloniaMarkupSample.CommonSamples;

public class TreeViewSampleView : ComponentBase
{
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TreeView()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(Nodes)
                    .ItemTemplate(
                        new FuncTreeDataTemplate<Node>(
                            (n, _) => new TextBlock().Text(n.Name),
                            n => n.Children)
                    )
                    .SelectedItem(() => SelectedNode, v => SelectedNode = (Node?)v),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(() => SelectedNode?.Name ?? "-")
            );

    private Node? _selectedNode = null;
    public Node? SelectedNode
    {
        get => _selectedNode;
        set
        {
            _selectedNode = value;
            StateHasChanged();
            OnPropertyChanged();
        }
    }

    public ObservableCollection<Node> Nodes { get; set; } =
    [
        new Node("Animals", [
            new Node("Mammals", [
                new Node("Lion"), new Node("Cat"), new Node("Zebra")
            ])
        ])
    ];

}

public class Node(string name, IEnumerable<Node>? children = null)
{
    public string Name { get; set; } = name;

    public ObservableCollection<Node> Children { get; set; } = new(children ?? []);
}