# Avalonia.Markup.Declarative
Write Avalonia UI with C#

*Avalonia.Markup.Declarative* is the set of base classes and extension methods over Avalonia's controls to define views markup with C# code instead of having separate XAML files

## Installation

for now this project available as a source code. Sou you need to clone or download repository and Add *Avalonia.Markup.Declarative* project to your solution.

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
                    .With(ButtonStyle) //Execte LabelStyle method over TextBlock control 
            );

    private void ButtonStyle(Bitton b) => b
        .VerticalAlignment(VerticalAlignment.Center)
        .FontSize(12);
}
```

## Hot reload support

ViewBase class automagiacally supports .Net 6 hot reload feature.

 * make sure that your view classes are located in the Assembly that doesn't contain any Xaml files, otherwise hot reload feature will always throw "need to rebuild" message.