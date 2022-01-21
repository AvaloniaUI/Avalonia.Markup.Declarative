AppBuilder.Configure<Application>()
    .UsePlatformDetect()
    .UseFluentTheme()
    .StartWithClassicDesktopLifetime(desktop =>
    {
        var count = 0;

        desktop.MainWindow = 
            new Window().Ref(out var wnd).Content(

                new StackPanel().Children(
                    new Button().Ref(out var button)
                        .Content("Welcome to Avalonia, please click me!"),

                    new TextBox().Ref(out var tb1)
                        .Text("Minimal Declarative Avalonia"),

                    new TextBox()
                        .Text(@wnd.Title, BindingMode.TwoWay, bindingSource: wnd),

                    new Label().Content(
                        button.OnClick().Select(_ => count++).Select(x => $"You clicked {x} times.").ToBinding())
                ))
            .Title(tb1.GetObservable(TextBox.TextProperty).Select(x => x.ToUpper()).ToBinding());
    }, args);

