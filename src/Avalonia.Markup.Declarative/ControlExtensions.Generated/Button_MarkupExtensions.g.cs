#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Button_MarkupExtensions
{
//================= Properties ======================//
 // ClickMode

/*BindFromExpressionSetterGenerator*/
public static T ClickMode<T>(this T control, Func<Avalonia.Controls.ClickMode> func, Action<Avalonia.Controls.ClickMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClickMode<T>(this T control,Avalonia.Controls.ClickMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClickMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClickMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.ClickModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClickMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ClickMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.ClickModeProperty, ps, () => control.ClickMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Command

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HotKey

/*BindFromExpressionSetterGenerator*/
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HotKey<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HotKey<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CommandParameter

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDefault

/*BindFromExpressionSetterGenerator*/
public static T IsDefault<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDefault<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDefault<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDefault<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDefault<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.IsDefaultProperty, ps, () => control.IsDefault = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsCancel

/*BindFromExpressionSetterGenerator*/
public static T IsCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsCancel<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsCancel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.IsCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsCancel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.IsCancelProperty, ps, () => control.IsCancel = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Flyout

/*BindFromExpressionSetterGenerator*/
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Flyout<T>(this T control,Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button 
   => control._set(Avalonia.Controls.Button.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Flyout<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button 
=> control._setEx(Avalonia.Controls.Button.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // Click

/*ActionToEventGenerator*/
public static T OnClick<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Button 
{
  control.AddHandler(Avalonia.Controls.Button.ClickEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // ClickMode

/*ValueStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, Avalonia.Controls.ClickMode value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClickMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.ClickModeProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandProperty, binding);


 // HotKey

/*ValueStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HotKey<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.HotKeyProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.CommandParameterProperty, binding);


 // IsDefault

/*ValueStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDefault<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsDefaultProperty, binding);


 // IsCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCancel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.IsCancelProperty, binding);


 // Flyout

/*ValueStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Flyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Button 
=> style._addSetter(Avalonia.Controls.Button.FlyoutProperty, binding);



}
