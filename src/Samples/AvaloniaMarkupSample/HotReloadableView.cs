using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml.Templates;

public class HotReloadView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Width(300)
            .Children(
                new TextBlock()
                    .Foreground(Brushes.White)
                    .Padding(12)
                    .FontSize(30)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Text("Hello Hot Reload!"),

                new TextBlock()
                    .Text("Custom control example:"),

                new Border()
                    .BorderBrush(Brushes.Gray)
                    .BorderThickness(1)
                    .Child(
                        new MyCustomControl()
                            .Margin(20)
                    ),

                new TextBlock()
                    .Text("Custom templated control example:"),

                new Border()
                    .BorderBrush(Brushes.Gray)
                    .BorderThickness(1)
                    .Child(
                        new MyCustomTemplatedControl()
                            .Ref(out var myCustomTemplatedControl)
                            .Margin(20)
                            .Template(StaticResources.Templates.MyControlTemplate)
                    ),
                new ToggleButton()
                    .Ref(out var tb)
                    .Content("Change template")
                    .OnClick(args =>
                    {
                        myCustomTemplatedControl.Template = !(tb.IsChecked ?? false)
                            ? StaticResources.Templates.MyControlTemplate
                            : StaticResources.Templates.MyAnotherControlTemplate;
                    })
            );
}