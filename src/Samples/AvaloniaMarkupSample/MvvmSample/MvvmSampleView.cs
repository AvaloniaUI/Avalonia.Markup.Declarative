namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleView() : ViewBase<MvvmSampleViewModel>(new MvvmSampleViewModel())
{
    protected override object Build(MvvmSampleViewModel? vm) =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(() => vm?.MyObject.MyProperty ?? ""),

                new Button()
                    .Content("Execute Command")
                    .Command(new Binding(nameof(vm.MyCommand))) //it demonstrates build in Avalonia Command binding to method mechanism, when you don't need to have ICommand object and pass method name directly
                    .CommandParameter(new Binding { Source = vm })
                    //but with Avalonia.Markup.Declarative you can just call
                    //.OnClick(args => vm.MyCommand(vm))

            );
}