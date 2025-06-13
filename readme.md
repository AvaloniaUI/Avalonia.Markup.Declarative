# Avalonia.Markup.Declarative
Write Avalonia UI with C#

*Avalonia.Markup.Declarative* is the set of base classes and extension methods over Avalonia's controls to define views/markup with C# code instead of XAML.

## Installation

Add the `Avalonia.Markup.Declarative` NuGet package to your project

## MVU Pattern implementation (Recommended)

Inspired by Blazor's Components layout. A basic component should look like this:

```C#
public class Component : ComponentBase
{

//styles
    protected override StyleGroup? BuildStyles() =>
    [
        new Style<Button>()
            .Margin(6)
            .Background(Brushes.DarkSalmon),
    ];

//markup part
    protected override object Build() =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Ref(out _textBlock1)
                    .Text("Hello world"),
                new TextBlock()
                    .Text(() => $"Counter: {(Counter == 0 ? "zero" : Counter)}"),
                new Button()
                    .Content("Click me")
                    .OnClick(OnButtonClick)
            );
            
//code part
    [Inject] SampleDataService DataService { get; set; } = null!; //service injection

    public int Counter { get; set; } //no need to implement AvaloniaProperty or OnPropertyChanged behaviors, since component has registry of all properties and emits ProperyChanged event after changing state of component.

    private void OnButtonClick(RoutedEventArgs e)
    {
        Counter++;
        _textBlock1.Text = DataService.GetData();
        StateHasChanged(); //for now we have to call this method manually. In future there will be some additional triggers like user input, that will rise this method automatically
    }
}
```

## MVVM Pattern implementation 

to keep compatibilty with classic Avalonia/Wpf approach

```C#
public class MainView : ViewBase<MainViewModel>
{
    public static IValueConverter InverseBooleanConverter { get; } 
        = new FuncValueConverter<bool, bool>(b => !b);

    // This method is executed before View building
    protected override void OnCreated()
    {
        ViewModel = new MainViewModel();
    }

    // Define markup in Build method
    protected override object Build(MainViewModel vm) =>
        new Grid()
            
            .Styles(
                new Style<Button>(s => s.Class(":pointerover").Child())      //make button red when pointer is over using avalonia styles
                    .Background(Brushes.Red)
            )

            .Cols("Auto, 100, *")                   // equivalent of Grid.ColumnDefintions property
            .Background(Brushes.Green)                  // the same as grid.Background = Brushes.Green
            .Children(
                
                new TextBlock()
                    .Text(() => vm.TextVal),                // Bind control's property to ViewModel's property using lambda

                new TextBlock()
                    .Col(1) //equivalent of Grid.SetColumn(textBlock, 1)
                    .IsVisible(
                        () => vm.HideGreeting,              // Bind TextBlock.IsVisible to MainViewModel.HideGreeting property using lambda
                        bindingMode: BindingMode.OneWay,    // We can set Binding mode if necessary.
                        converter: InverseBooleanConverter  // Set value converter to invert values.
                    )
                    .Text("Hello Avalonia"), 

                new Button()
                    .Col(2) //equivalent of Grid.SetColumn(textBlock, 1)
                    // we don't actually need binding here, 
                    // so just direct set to Command on view model
                    .Command(vm.ClickButtonCommand) 
                    .Content("Click me") // Content = "Click me"
                    .Padding(left: 8) //Set left padding to 8
                    .With(ButtonStyle) //Execute LabelStyle method over TextBlock control 
            );

    private void ButtonStyle(Button b) => b
        .VerticalAlignment(VerticalAlignment.Center)
        .FontSize(12);
}
```

## Hot reload support

- ViewBase classes auto-magically supports .NET 6.0+'s `Hot Reload` feature.

- Make sure that your view classes are located in the Assembly that doesn't contain any XAML files, otherwise `Hot Reload` will always throw "need to rebuild" message.

- 2023 note - according to the latest reports, with .net 7.0 and latest avalonia versions there are no conflicts anymore between AXAML files and the `Hot Reload` functionality. So you can mix AXAML with C# Markup in the same project.

- JetBrains Rider has an issue with default .net hot reload behavior while debugging, so you can use following workaround:
  ```C#
  //init app
  AppBuilder.Configure<Application>()
    .UseRiderHotReload() //this line adds watcher that checks, if Views were changed during debugging session
    .SetupWithLifetime(lifetime);
  ```
  
## Properties support on custom controls

There are two source generators to add Markup Extensions on your own controls. If you downloaded source code or cloned this repo, add them by referencing `Avalonia.Markup.Declarative.SourceGenerator` project in your csproj file like this:

```xml
    <ItemGroup>
        <ProjectReference Include="..\..\AvaloniaMarkup.Declarative.SourceGenerator\Avalonia.Markup.Declarative.SourceGenerator.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
    </ItemGroup>
```
Make sure that the path to the source generator project is correct relative to your project.

> **Note**: If you are using this library as a **Nuget**, source generator will added to your project **automatically**.

## External libraries support

By default *Avalonia.Markup.Declarative* contains only extension from Avalonia Framework controls and also has source generator, that adds Extensions from sources of your project. 
But sometimes you need to use third-party controls from Nuget Packages. For that cases you need to use AvaloniaExtensionGenerator tool ( https://www.nuget.org/packages/AvaloniaExtensionGenerator/ ).

## Installation
```
dotnet tool install --global AvaloniaExtensionGenerator
```

## Usage

tool should be run from the folder where **.csproj** file is located 
```
cd c:\your\project\
```

call the command
```
avalonia-amd-gen
```
