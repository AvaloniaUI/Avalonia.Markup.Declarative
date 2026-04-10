namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleView() : ViewBase<MvvmSampleViewModel>(new MvvmSampleViewModel())
{
    protected override object Build(MvvmSampleViewModel? vm) =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(vm!, x => x.MyObject.MyProperty),

                new Button()
                    .Content("Execute Command")
                    .OnClick(_ => vm?.MyCommand(vm))
            );
}