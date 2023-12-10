# Avalonia.Markup.Declarative
Write Avalonia UI with C#

*Avalonia.Markup.Declarative* is the set of base classes and extension methods over Avalonia's controls to define views markup with C# code instead of having separate XAML files

## Installation

for now this project available as a source code. So you need to clone or download repository and Add *Avalonia.Markup.Declarative* project to your solution.

There will be Nuget package available later.

## Usage

```C#
public class MainView : ViewBase<MainViewModel>
{
    public static IValueConverter InverseBooleanConverter { get; } 
        = new FuncValueConverter<bool, bool>(b => !b);

    //This method is executed before View building
    protected override void OnCreated()
    {
        ViewModel = new MainViewModel();
    }

    //Define markup in Build method
    protected override object Build(MainViewModel vm) =>
        new Grid()
            
            .Styles(
                new Style<Button>(s => s.Class(":pointerover")) //make button red when pointer is over using avalonia styles
                    .Background(Brushes.Red)
            )

            .Cols("Auto, 100, *") // equivalent of Grid.ColumnDefintions property
            .Background(Brushes.Green) // the same as grid.Background = Brushes.Green
            .Children(
                
                new TextBlock()
                    .Text( @vm.TextVal ), // use @ character before to Bind control's property to ViewModel's property

                new TextBlock()
                    .Col(1) //equivalent of Grid.SetColumn(textBlock, 1)
                    .IsVisible( @vm.HideGreeting, //bind TextBlock.IsVisible to MainViewModel.HideGreeting property
                                bindingMode: BindingMode.OneWay, // we can set Binding mode if necessery
                                converter: InverseBooleanConverter ), //Set value converter to invert value
                    .Text( "Hello Avalonia" ), 

                new Button()
                    .Col(2) //equivalent of Grid.SetColumn(textBlock, 1)
                    // we don't actually need binding here, 
                    // so just direct set to Command on view model
                    .Command(vm.ClickButtonCommand) 
                    .Content("Click me") // Content = "Click me"
                    .Padding(8, 0, 0, 0) //Set left padding to 8
                    .With(ButtonStyle) //Execute LabelStyle method over TextBlock control 
            );

    private void ButtonStyle(Button b) => b
        .VerticalAlignment(VerticalAlignment.Center)
        .FontSize(12);
}
```

## Hot reload support

ViewBase class automagiacally supports .Net 6 hot reload feature.

* make sure that your view classes are located in the Assembly that doesn't contain any Xaml files, otherwise hot reload feature will always throw "need to rebuild" message.
** 2023 note - according to the latest experience with .net 7 and latest avalonia versions there is no conflict anymore between axaml files and hotreload functionality. So you can mix axmal with cs markup in one project 

## Properties support on custom controls
There are two source generators to add markup extensions on your own controls. If you downloaded source code or clonned this repo, you have to add them by referencing Avalonia.Markup.Declarative.SourceGenerator project in csproj file like this:

```xml
	<ItemGroup>
		<ProjectReference Include="..\..\AvaloniaMarkup.Declarative.SourceGenerator\Avalonia.Markup.Declarative.SourceGenerator.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
	</ItemGroup>
```
* make sure, that path to source generator project is correct relative to your project

## MVU Pattern implementation

Inspired by blazor component layout. So basic component will looks like:

```C#
public class Component : ComponentBase
{
//markup part
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Ref(out _textBlock1)
                    .Text("Hello world"),
                new TextBlock()
                    .Text(Bind(CounterText)),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );
            
//code part
    [Inject] SampleDataService DataService { get; set; } = null!; //service injection

    public int Counter { get; set; }
    public string CounterText => $"Counter: {Counter}";  //no need to implement AvaloniaProperty or OnPropertyChanged behaviors, since component has registry of all properties and emits ProperyChanged event after changing state of component.

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        _textBlock1.Text = DataService.GetData();
        StateHasChanged(); //for now we have to call this method manually. In future there will be some additional triggers like user input, that will rise this method automatically
    }
}
```
