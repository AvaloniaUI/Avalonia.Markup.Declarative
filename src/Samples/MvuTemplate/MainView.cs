namespace MvuTemplate;

public class MainView : ComponentBase
{
    protected override object Build()
        => New<SimpleComponent>() // creates Child SimpleComponent and injects it's dependencies into constructor
            .Name("MainView"); //set component name
}