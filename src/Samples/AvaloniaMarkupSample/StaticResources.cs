using Avalonia.Controls.Templates;

public static class StaticResources
{
    public static class Templates
    {
        public static IControlTemplate MyControlTemplate { get; } = new FuncControlTemplate<MyCustomTemplatedControl>(
            // Using FuncView to generate ViewContext that will be used for binding
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
                                    .Text(() => c.NewValue ?? "", v => c.NewValue = v)
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
                                    .Text(() => c.SavedValue ?? "", v => c.SavedValue = v)
                                    .MinWidth(150)
                            ),
                        new StackPanel().Row(3)
                            .Orientation(Orientation.Horizontal)
                            .HorizontalAlignment(HorizontalAlignment.Right)
                            .Children(
                                new Button().Content("Cancel")
                                    .Margin(5, 0)
                                    .IsEnabled(() => c.CanSave)
                                    .OnClick(_ => c.Cancel()),
                                new Button().Content("Save")
                                    .Margin(5, 0)
                                    .IsEnabled(() => c.CanSave)
                                    .OnClick(_ => c.Save())
                            )
                    ))
            );

        public static IControlTemplate MyAnotherControlTemplate { get; } =
            new FuncControlTemplate<MyCustomTemplatedControl>((control, scope) =>
                // Using FuncView to generate ViewContext that will be used for binding
                new FuncView<MyCustomTemplatedControl>(control, c =>
                    new StackPanel()
                        .Children(
                            new StackPanel()
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .Children(
                                    new TextBlock()
                                        .Text(() => $"Entered text: {c.NewValue}")
                                        .MinWidth(150)
                                ),
                            new StackPanel()
                                .Margin(0, 10)
                                .Orientation(Orientation.Horizontal)
                                .VerticalAlignment(VerticalAlignment.Center)
                                .HorizontalAlignment(HorizontalAlignment.Left)
                                .Children(
                                    new TextBlock()
                                        .Text(() => $"Saved text: {c.SavedValue}")
                                        .MinWidth(150)
                                )
                        ))
            );
    }
}