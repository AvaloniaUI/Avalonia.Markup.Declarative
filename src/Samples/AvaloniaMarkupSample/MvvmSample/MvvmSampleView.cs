namespace AvaloniaMarkupSample.MvvmSample;

public class MvvmSampleView : ViewBase<MvvmSampleViewModel>
{
    public MvvmSampleView() : base(new MvvmSampleViewModel())
    {
    }

    protected override object Build(MvvmSampleViewModel vm) =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(@vm.MyProperty),

                new Button()
                    .Content("Execute Command")
                    .Command(new Binding(nameof(vm.MyCommand)))
                    .CommandParameter(new Binding() { Source = vm })
            );
}