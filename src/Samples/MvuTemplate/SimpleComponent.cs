using System.Diagnostics.CodeAnalysis;
using Avalonia.Styling;

namespace MvuTemplate;

//prevent from trimming [injected] services by native aot compilation
[method: DynamicDependency(DynamicallyAccessedMemberTypes.PublicProperties, typeof(SimpleComponent))]
public class SimpleComponent() : ComponentBase
{

	[Inject] public SampleDataService? DataService { get; set; }

	protected override StyleGroup? BuildStyles() =>
	[
		new Style<Button>()
			.Margin(6)
			.Background(Brushes.DarkSalmon),

		new StyleGroup(x => x.Class("narrow").Descendant())
		{
			new Style<StackPanel>(s => s.Name("SideBar"))
				.IsVisible(false)
		}
	];

	protected override object Build() =>
		new Grid().Cols("150, *")
			.BindClass(() => Bounds.Width < 400, "narrow")
			.Children(
				new StackPanel()
					.Name("SideBar")
					.Background(Brushes.CadetBlue)
					.Children(
						new TextBlock().Text("Sidebar").Margin(16)
					),

				new StackPanel().Col(1)
					.VerticalAlignment(VerticalAlignment.Center)
					.HorizontalAlignment(HorizontalAlignment.Center)
					.Children(
						new TextBlock().Ref(out _textBlock1)
							.Text("Hello world"),
						new TextBlock()
							.Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"),
						new NumericUpDown()
							.Value(() => Counter, onChanged: v => Counter = v), //two-side binding sample
						new Button()
							.HorizontalAlignment(HorizontalAlignment.Center)
							.Content("Click me")
							.OnClick(OnButtonClick)
					)
			);

	private TextBlock _textBlock1 = null!;

	private decimal? Counter { get; set; } = 0;

	private void OnButtonClick(RoutedEventArgs e)
	{
		_textBlock1.Text = DataService?.GetData() ?? "Data service is `null`";
		StateHasChanged();
	}

	protected override void OnSizeChanged(SizeChangedEventArgs e)
	{
		//force recalculation on window width to check if it's Narrow state now
		StateHasChanged();
		base.OnSizeChanged(e);
	}
}