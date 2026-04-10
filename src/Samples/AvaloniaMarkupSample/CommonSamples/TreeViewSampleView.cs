using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Avalonia.Controls.Templates;

namespace AvaloniaMarkupSample.CommonSamples;

public class TreeViewSampleViewModel : INotifyPropertyChanged
{
    private Node? _selectedNode;
    public Node? SelectedNode
    {
        get => _selectedNode;
        set { _selectedNode = value; OnPropertyChanged(); }
    }

    public ObservableCollection<Node> Nodes { get; set; } =
    [
        new Node("Animals", [
            new Node("Mammals", [
                new Node("Lion"), new Node("Cat"), new Node("Zebra")
            ])
        ])
    ];

    public event PropertyChangedEventHandler? PropertyChanged;
    protected void OnPropertyChanged([CallerMemberName] string? name = null) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
}

public class TreeViewSampleView() : ViewBase<TreeViewSampleViewModel>(new TreeViewSampleViewModel())
{
    protected override object Build(TreeViewSampleViewModel? vm) =>
        new StackPanel()
            .Children(
                new TreeView()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .ItemsSource(vm!.Nodes)
                    .ItemTemplate(
                        new FuncTreeDataTemplate<Node>(
                            (n, _) => new TextBlock().Text(n.Name),
                            n => n.Children)
                    )
                    .SelectedItem(vm!, x => x.SelectedNode!, BindingMode.TwoWay),

                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text(vm!, x => x.SelectedNode!.Name)
            );
}

public class Node(string name, IEnumerable<Node>? children = null)
{
    public string Name { get; set; } = name;

    public ObservableCollection<Node> Children { get; set; } = new(children ?? []);
}
