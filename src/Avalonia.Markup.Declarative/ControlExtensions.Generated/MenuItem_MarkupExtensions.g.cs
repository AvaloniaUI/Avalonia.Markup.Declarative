#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class MenuItem_MarkupExtensions
{
//================= Properties ======================//
 // Command

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HotKey

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HotKey<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HotKey<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CommandParameter

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Icon

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InputGesture

/*BindFromExpressionSetterGenerator*/
public static T InputGesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InputGesture<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.InputGestureProperty, ps, () => control.InputGesture = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InputGesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InputGesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InputGesture<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.InputGestureProperty, ps, () => control.InputGesture = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsSubMenuOpen

/*BindFromExpressionSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSubMenuOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsSubMenuOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // StaysOpenOnClick

/*BindFromExpressionSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StaysOpenOnClick<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T StaysOpenOnClick<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ToggleType

/*BindFromExpressionSetterGenerator*/
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.MenuItemToggleType> func, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ToggleType<T>(this T control,Avalonia.Controls.MenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ToggleType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.MenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsChecked

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsChecked<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsChecked<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // GroupName

/*BindFromExpressionSetterGenerator*/
public static T GroupName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T GroupName<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T GroupName<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T GroupName<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem 
=> control._setEx(Avalonia.Controls.MenuItem.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.MenuItem 
{
  if (routes == 0) routes = Avalonia.Controls.MenuItem.ClickEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.MenuItem.ClickEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerEnteredItem

/*ActionToEventGenerator*/
public static T OnPointerEnteredItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.MenuItem 
{
  if (routes == 0) routes = Avalonia.Controls.MenuItem.PointerEnteredItemEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.MenuItem.PointerEnteredItemEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerExitedItem

/*ActionToEventGenerator*/
public static T OnPointerExitedItem<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.MenuItem 
{
  if (routes == 0) routes = Avalonia.Controls.MenuItem.PointerExitedItemEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.MenuItem.PointerExitedItemEvent, (_, args) => action(args), routes);
  return control; 
}



 // SubmenuOpened

/*ActionToEventGenerator*/
public static T OnSubmenuOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.MenuItem 
{
  if (routes == 0) routes = Avalonia.Controls.MenuItem.SubmenuOpenedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.MenuItem.SubmenuOpenedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IconProperty, binding);


 // InputGesture

/*ValueStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InputGesture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.InputGestureProperty, binding);


 // IsSubMenuOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSubMenuOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);


 // StaysOpenOnClick

/*ValueStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> StaysOpenOnClick<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);


 // ToggleType

/*ValueStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, Avalonia.Controls.MenuItemToggleType value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ToggleType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);


 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);


 // GroupName

/*ValueStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MenuItem 
=> style._addSetter(Avalonia.Controls.MenuItem.GroupNameProperty, binding);



}
