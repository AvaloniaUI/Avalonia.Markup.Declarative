namespace AvaloniaMarkupSample.CommonSamples;

public class InvalidMarkupView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Spacing(10)
            .Children(
                new TextBlock().Text("This control is perfectly fine"),

                // ERROR HERE: Negative width is invalid in Avalonia.
                // Without [StackTraceHidden], the debugger would stop inside the framework's _set() method.
                // With our improvements, the debugger will highlight exactly the .Width(-50) line!
                // And if we intercept this in _set with CallerLineNumber, the log will point to this exact line.
                new Border()
                    .Background(Brushes.Red)
                    .Height(50)
                    .Width(-50)
                    .Child(new TextBlock().Text("I shouldn't be rendered"))
            );
}

public class ExceptionSampleView : ViewBase
{
    protected override object Build() =>
        new StackPanel()
            .Spacing(15)
            .Margin(20)
            .Children(
                new TextBlock()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .FontSize(18)
                    .Text("Declarative Markup Debugging"),

                new TextBlock()
                    .TextWrapping(TextWrapping.Wrap)
                    .Foreground(Brushes.Gray)
                    .Text("Click the button to try rendering a View with invalid markup (Width = -50). Verify that the debugger stops on the specific extension line rather than inside the framework's internal code."),

                new Button()
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Content("Render invalid markup")
                    .OnClick(_ =>
                    {
                        try
                        {
                            _container.Content = new InvalidMarkupView();
                        }
                        catch (Exception ex)
                        {
                            // If you implemented ViewBuildingException with CallerLineNumber, 
                            // you can output a nice message specifying the file and line here
                            _container.Content = new TextBlock()
                                .Foreground(Brushes.Red)
                                .TextWrapping(TextWrapping.Wrap)
                                .Text($"Exception caught:\n{ex.Message}");
                        }
                    }),

                new ContentControl()
                    .Ref(out _container)
                    .Margin(0, 20, 0, 0)
            );

    private ContentControl _container = null!;
}