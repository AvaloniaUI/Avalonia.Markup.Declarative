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
public static partial class InputElement_MarkupExtensions
{
//================= Properties ======================//
 // Focusable

/*BindFromExpressionSetterGenerator*/
public static T Focusable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Focusable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Focusable<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Focusable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Focusable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Cursor

/*BindFromExpressionSetterGenerator*/
public static T Cursor<T>(this T control, Func<Avalonia.Input.Cursor> func, Action<Avalonia.Input.Cursor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Cursor<T>(this T control,Avalonia.Input.Cursor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Cursor<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Cursor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Cursor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.Cursor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsHitTestVisible

/*BindFromExpressionSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsHitTestVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsHitTestVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTabStop

/*BindFromExpressionSetterGenerator*/
public static T IsTabStop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTabStop<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTabStop<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTabStop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTabStop<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TabIndex

/*BindFromExpressionSetterGenerator*/
public static T TabIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TabIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TabIndex<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TabIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TabIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // GotFocus

/*ActionToEventGenerator*/
public static T OnGotFocus<T>(this T control, Action<Avalonia.Input.GotFocusEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GotFocusEvent, (_, args) => action(args), routes);
  return control; 
}



 // LostFocus

/*ActionToEventGenerator*/
public static T OnLostFocus<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Input.InputElement  => 
 control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.LostFocus += h);


 // KeyDown

/*ActionToEventGenerator*/
public static T OnKeyDown<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyDownEvent, (_, args) => action(args), routes);
  return control; 
}



 // KeyUp

/*ActionToEventGenerator*/
public static T OnKeyUp<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyUpEvent, (_, args) => action(args), routes);
  return control; 
}



 // TextInput

/*ActionToEventGenerator*/
public static T OnTextInput<T>(this T control, Action<Avalonia.Input.TextInputEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputEvent, (_, args) => action(args), routes);
  return control; 
}



 // TextInputMethodClientRequested

/*ActionToEventGenerator*/
public static T OnTextInputMethodClientRequested<T>(this T control, Action<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerEntered

/*ActionToEventGenerator*/
public static T OnPointerEntered<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerEnteredEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerExited

/*ActionToEventGenerator*/
public static T OnPointerExited<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerExitedEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerMoved

/*ActionToEventGenerator*/
public static T OnPointerMoved<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerMovedEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerPressed

/*ActionToEventGenerator*/
public static T OnPointerPressed<T>(this T control, Action<Avalonia.Input.PointerPressedEventArgs> action) where T : Avalonia.Input.InputElement  => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerPressed += h);


 // PointerReleased

/*ActionToEventGenerator*/
public static T OnPointerReleased<T>(this T control, Action<Avalonia.Input.PointerReleasedEventArgs> action) where T : Avalonia.Input.InputElement  => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerReleased += h);


 // PointerCaptureLost

/*ActionToEventGenerator*/
public static T OnPointerCaptureLost<T>(this T control, Action<Avalonia.Input.PointerCaptureLostEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerCaptureLostEvent, (_, args) => action(args), routes);
  return control; 
}



 // PointerWheelChanged

/*ActionToEventGenerator*/
public static T OnPointerWheelChanged<T>(this T control, Action<Avalonia.Input.PointerWheelEventArgs> action) where T : Avalonia.Input.InputElement  => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerWheelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PointerWheelChanged += h);


 // Tapped

/*ActionToEventGenerator*/
public static T OnTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TappedEvent, (_, args) => action(args), routes);
  return control; 
}



 // Holding

/*ActionToEventGenerator*/
public static T OnHolding<T>(this T control, Action<Avalonia.Input.HoldingRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.HoldingEvent, (_, args) => action(args), routes);
  return control; 
}



 // DoubleTapped

/*ActionToEventGenerator*/
public static T OnDoubleTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.DoubleTappedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // Focusable

/*ValueStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, binding);


 // IsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, binding);


 // Cursor

/*ValueStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, binding);


 // IsHitTestVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);


 // IsTabStop

/*ValueStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, binding);


 // TabIndex

/*ValueStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, binding);



}
