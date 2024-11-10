using System.Diagnostics.CodeAnalysis;

namespace OpenGlSample;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(OpenGlView))]
public class OpenGlView() : ComponentBase
{
    protected override object Build() =>
        new Grid()
            .Background(Brushes.WhiteSmoke)
            .Children(
                new OpenGlPageControl()
                    .Ref(out _glContainer),

                new StackPanel().Children(
                    new TextBlock()
                        .Text("Info:"),
                    new TextBlock()
                        .MaxWidth(400)
                        .TextWrapping(TextWrapping.Wrap)
                        .Text(() => _glContainer.Info),
                    new Button()
                        .Content("Update")
                        .OnClick(OnUpdateClocked)
                )
            );

    private OpenGlPageControl _glContainer = null!;

    private void OnUpdateClocked(RoutedEventArgs obj)
    {
        _glContainer.Pitch += 0.1f;
        StateHasChanged();
    }

    protected override void OnAfterInitialized()
    {
    }

}