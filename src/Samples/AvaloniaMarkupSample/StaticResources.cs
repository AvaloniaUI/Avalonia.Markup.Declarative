using Avalonia.Controls.Templates;

public static class StaticResources
{
    public static class Templates
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<MyCustomTemplatedControl>(
            (control, scope) => new FuncView<MyCustomTemplatedControl>(control, c =>
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
                                    .Text(MyCustomTemplatedControl.NewValueProperty, c, BindingMode.TwoWay)
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
                                    .Text(MyCustomTemplatedControl.SavedValueProperty, c)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(3)
                            .Orientation(Orientation.Horizontal)
                            .HorizontalAlignment(HorizontalAlignment.Right)
                            .Children(
                                new Button().Content("Cancel")
                                    .Margin(5, 0)
                                    .IsEnabled(MyCustomTemplatedControl.CanSaveProperty, c)
                                    .OnClick(_ => c.Cancel()),
                                new Button().Content("Save")
                                    .Margin(5, 0)
                                    .IsEnabled(MyCustomTemplatedControl.CanSaveProperty, c)
                                    .OnClick(_ => c.Save())
                            )
                    ))
            );

        public static IControlTemplate MyAnotherControlTemplate { get; } =
            new FuncControlTemplate<MyCustomTemplatedControl>((control, scope) =>
                new FuncView<MyCustomTemplatedControl>(control, c =>
                    new StackPanel()
                        .Children(
                            new StackPanel()
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .Children(
                                    new TextBlock()
                                        .Text(c, x => x.NewValue!)
                                        .MinWidth(150)
                                ),
                            new StackPanel()
                                .Margin(0, 10)
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .HorizontalAlignment(HorizontalAlignment.Left)
                                .Children(
                                    new TextBlock()
                                        .Text(c, x => x.SavedValue!)
                                        .MinWidth(150)
                                )
                        ))
            );
    }
}
