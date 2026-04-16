# Disclaimer

> **Important:** This repository is community driven, not officially supported by avalonia team and is not part of the official Avalonia project—it's only a proof of concept demonstrating how markup can be written purely in C#. For real-world projects use Avalonia's supported XAML approach.

# Avalonia.Markup.Declarative
Write Avalonia UI with C#

*Avalonia.Markup.Declarative* is a C#-first authoring layer over Avalonia controls. The current API is compiled-binding-first and source-generator-driven, with public patterns intentionally aligned with Avalonia's `DataContext`, binding, style, and selector model.

## Installation

Add the `Avalonia.Markup.Declarative` NuGet package to your project

## Project Template

You can easily create a new project from the command line using the official template:

```bash
dotnet new install Declarative.Avalonia.Templates
dotnet new avalonia-declarative -n MyApp
```

## Declarative Component pattern (Single file component/SFC)

Use a self-contained declarative component when the view and its reactive state belong to the same feature. Add `CommunityToolkit.Mvvm` to the app project and keep the component-local state in a nested `ObservableObject`.

```csharp
using Avalonia.Data;
using CommunityToolkit.Mvvm.ComponentModel;

public class CounterComponent() : ViewBase<CounterComponent.State>(new State())
{
    public sealed partial class State : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor(nameof(CounterLabel))]
        public partial decimal? Counter { get; set; } = 0;

        [ObservableProperty]
        public partial string StatusText { get; set; } = "Hello world";

        public string CounterLabel => $"Counter: {Counter}";
    }

    protected override object Build(State state) =>
        new StackPanel()
            .Children(
                new TextBlock()
                    .Text(state, x => x.StatusText),
                new TextBlock()
                    .Text(state, x => x.CounterLabel),
                new NumericUpDown()
                    .Value(state, x => x.Counter, BindingMode.TwoWay),
                new Button()
                    .Content("Increment")
                    .OnClick(_ => state.Counter++)
            );
}
```

To compose constructor-injected views, prefer `ViewFactory.Create<T>()`. If you use DI, register `UseComponentControlFactory(...)` on `AppBuilder`.

## MVVM Pattern implementation

Use `ViewBase<TViewModel>` when you want a classic Avalonia or WPF-style view model. Generated setters expose compiled-binding overloads, so the binding syntax stays close to native Avalonia.

```csharp
using Avalonia.Data;

public class MainView() : ViewBase<MainViewModel>(new MainViewModel())
{
    protected override object Build(MainViewModel vm) =>
        new StackPanel()
            .Children(
                new TextBox()
                    .Text(vm, x => x.Message, BindingMode.TwoWay),
                new TextBlock()
                    .Text(vm, x => x.Message),
                new Button()
                    .Content("Reset")
                    .OnClick(_ => vm.Message = string.Empty)
            );
}
```

Equivalent XAML for the same view:

```xml
<UserControl
    xmlns="https://github.com/avaloniaui"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:vm="using:MyApp.ViewModels"
    x:Class="MyApp.MainView"
    x:DataType="vm:MainViewModel">
    <StackPanel>
        <TextBox Text="{CompiledBinding Message, Mode=TwoWay}" />
        <TextBlock Text="{CompiledBinding Message}" />
        <Button Content="Reset"
                Click="ResetClick" />
    </StackPanel>
</UserControl>
```

If you assign `DataContext` from the outside, the same generated setters also support DataContext-relative compiled bindings such as `new TextBlock().Text<MainViewModel>(x => x.Message);`.

Generated compiled-binding setters also apply automatic conversion for common primitive and nullable mismatches, so bindings like `new Slider().Value(vm, x => x.Counter, BindingMode.TwoWay)` work when `Counter` is `int`, and `new CheckBox().IsChecked(vm, x => x.Enabled)` work when `Enabled` is `bool`. Prefer plain member access such as `x => x.Counter`; avoid casts inside the binding expression like `x => (double)x.Counter`, because Avalonia compiled bindings reject `Convert` nodes. For lossy numeric `TwoWay` conversions, convert-back truncates toward zero.

## Hot reload support

- `ViewBase` supports .NET 6.0+ hot reload.

- Keeping declarative views in an assembly without XAML can still produce the smoothest hot reload experience.

- Current Avalonia and .NET toolchains are much better at mixing AXAML and C# markup in the same application, so the limitation is much smaller than it used to be.

- To enable AMD hot reload integration explicitly:
  ```csharp
  AppBuilder.Configure<Application>()
    .UseHotReload()
    .SetupWithLifetime(lifetime);
  ```

## Source generation for your own and external controls

The package ships with the source generator that produces markup extensions for:

- referenced Avalonia framework assemblies
- controls declared in your own project
- opted-in third-party assemblies

If you downloaded source code or cloned this repo, add the source generator project as an analyzer reference:

```xml
    <ItemGroup>
        <ProjectReference Include="..\..\Avalonia.Markup.Declarative.SourceGenerator\Avalonia.Markup.Declarative.SourceGenerator.csproj" OutputItemType="Analyzer" ReferenceOutputAssembly="false" />
    </ItemGroup>
```
Make sure that the path to the source generator project is correct relative to your project.

> **Note**: If you are using this library as a **NuGet** package, the source generator is included automatically.

## External libraries support

Framework extensions are generated automatically for the supported Avalonia assemblies that your project references. To generate extensions for a third-party library, add an assembly attribute that points to any type from that assembly:

```csharp
using Avalonia.Markup.Declarative;
using ReactiveUI.Avalonia;

[assembly: GenerateMarkupExtensionsForAssembly(typeof(RoutedViewHost))]
```

No standalone tool installation or manual `avalonia-amd-gen` step is required anymore.
