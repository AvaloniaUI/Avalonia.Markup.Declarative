using Avalonia.Controls.Templates;

public static class StaticResources
{
    public static class Templates
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<MyCustomTemplatedControl>(
            (control, scope) =>
                new Grid()
                    .Rows("Auto, Auto, *, Auto")
                    .Children(
                        new StackPanel()
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Children(
                                new TextBlock().Text("Enter text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBox()
                                    .Text(@control.NewValue, BindingMode.TwoWay, bindingSource: control)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(1)
                            .Margin(0, 10)
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .HorizontalAlignment(HorizontalAlignment.Left)
                            .Children(
                                new TextBlock().Text("Saved text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBox()
                                    .Text(@control.SavedValue, BindingMode.TwoWay, bindingSource: control)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(3)
                            .Orientation(Orientation.Horizontal)
                            .HorizontalAlignment(HorizontalAlignment.Right)
                            .Children(
                                new Button().Content("Cancel")
                                    .Margin(5, 0)
                                    .IsEnabled(@control.CanSave, bindingSource: control)
                                    .Command(new Binding(nameof(MyCustomTemplatedControl.Cancel)) {Source = control}),
                                new Button().Content("Save")
                                    .Margin(5, 0)
                                    .IsEnabled(@control.CanSave, bindingSource: control)
                                    .Command(new Binding(nameof(MyCustomTemplatedControl.Save)) {Source = control})
                            )
                    ));

        public static IControlTemplate MyAnotherControlTemplate { get; } =
            new FuncControlTemplate<MyCustomTemplatedControl>((control, scope) =>
                new StackPanel()
                    .Children(
                        new StackPanel()
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .Children(
                                new TextBlock().Text("Entered text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBlock()
                                    .Text(@control.NewValue, bindingSource: control)
                                    .MinWidth(150)
                            ),
                        new StackPanel()
                            .Margin(0, 10)
                            .Orientation(Orientation.Horizontal)
                            .VerticalAlignment(VerticalAlignment.Center)
                            .HorizontalAlignment(HorizontalAlignment.Left)
                            .Children(
                                new TextBlock().Text("Saved text:")
                                    .VerticalAlignment(VerticalAlignment.Center),
                                new TextBlock()
                                    .Text(@control.SavedValue, bindingSource: control)
                                    .MinWidth(150)
                            )
                    ));
    }
}