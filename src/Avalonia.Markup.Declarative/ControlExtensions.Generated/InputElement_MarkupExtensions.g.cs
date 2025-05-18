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
public static partial class InputElement_MarkupExtensions
{
//================= Properties ======================//
 // Focusable

/*ValueSetterGenerator*/
public static T Focusable<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.Focusable = value!);

/*BindFromExpressionSetterGenerator*/
public static T Focusable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Focusable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Focusable<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Focusable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.FocusableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Focusable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsEnabled

/*ValueSetterGenerator*/
public static T IsEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.IsEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Cursor

/*ValueSetterGenerator*/
public static T Cursor<T>(this T control, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.Cursor = value!);

/*BindFromExpressionSetterGenerator*/
public static T Cursor<T>(this T control, Func<Avalonia.Input.Cursor> func, Action<Avalonia.Input.Cursor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Cursor<T>(this T control,Avalonia.Input.Cursor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Cursor<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Cursor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.CursorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Cursor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.Cursor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsHitTestVisible

/*ValueSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.IsHitTestVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsHitTestVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsHitTestVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsHitTestVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTabStop

/*ValueSetterGenerator*/
public static T IsTabStop<T>(this T control, System.Boolean value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.IsTabStop = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTabStop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTabStop<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTabStop<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTabStop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTabStop<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TabIndex

/*ValueSetterGenerator*/
public static T TabIndex<T>(this T control, System.Int32 value) where T : Avalonia.Input.InputElement 
=> control._set(() => control.TabIndex = value!);

/*BindFromExpressionSetterGenerator*/
public static T TabIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TabIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TabIndex<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TabIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement 
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TabIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement 
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // GotFocus

/*ActionToEventGenerator*/
public static T OnGotFocus<T>(this T control, Action<Avalonia.Input.GotFocusEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.GotFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.GotFocusEvent.RoutingStrategies);
  return control;
}



 // LostFocus

/*ActionToEventGenerator*/
public static T OnLostFocus<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.LostFocusEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.LostFocusEvent.RoutingStrategies);
  return control;
}



 // KeyDown

/*ActionToEventGenerator*/
public static T OnKeyDown<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyDownEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyDownEvent.RoutingStrategies);
  return control;
}



 // KeyUp

/*ActionToEventGenerator*/
public static T OnKeyUp<T>(this T control, Action<Avalonia.Input.KeyEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.KeyUpEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.KeyUpEvent.RoutingStrategies);
  return control;
}



 // TextInput

/*ActionToEventGenerator*/
public static T OnTextInput<T>(this T control, Action<Avalonia.Input.TextInputEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputEvent.RoutingStrategies);
  return control;
}



 // TextInputMethodClientRequested

/*ActionToEventGenerator*/
public static T OnTextInputMethodClientRequested<T>(this T control, Action<Avalonia.Input.TextInput.TextInputMethodClientRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TextInputMethodClientRequestedEvent.RoutingStrategies);
  return control;
}



 // PointerEntered

/*ActionToEventGenerator*/
public static T OnPointerEntered<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerEnteredEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerEnteredEvent.RoutingStrategies);
  return control;
}



 // PointerExited

/*ActionToEventGenerator*/
public static T OnPointerExited<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerExitedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerExitedEvent.RoutingStrategies);
  return control;
}



 // PointerMoved

/*ActionToEventGenerator*/
public static T OnPointerMoved<T>(this T control, Action<Avalonia.Input.PointerEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerMovedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerMovedEvent.RoutingStrategies);
  return control;
}



 // PointerPressed

/*ActionToEventGenerator*/
public static T OnPointerPressed<T>(this T control, Action<Avalonia.Input.PointerPressedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerPressedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerPressedEvent.RoutingStrategies);
  return control;
}



 // PointerReleased

/*ActionToEventGenerator*/
public static T OnPointerReleased<T>(this T control, Action<Avalonia.Input.PointerReleasedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerReleasedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerReleasedEvent.RoutingStrategies);
  return control;
}



 // PointerCaptureLost

/*ActionToEventGenerator*/
public static T OnPointerCaptureLost<T>(this T control, Action<Avalonia.Input.PointerCaptureLostEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerCaptureLostEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerCaptureLostEvent.RoutingStrategies);
  return control;
}



 // PointerWheelChanged

/*ActionToEventGenerator*/
public static T OnPointerWheelChanged<T>(this T control, Action<Avalonia.Input.PointerWheelEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.PointerWheelChangedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.PointerWheelChangedEvent.RoutingStrategies);
  return control;
}



 // Tapped

/*ActionToEventGenerator*/
public static T OnTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.TappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.TappedEvent.RoutingStrategies);
  return control;
}



 // Holding

/*ActionToEventGenerator*/
public static T OnHolding<T>(this T control, Action<Avalonia.Input.HoldingRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.HoldingEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.HoldingEvent.RoutingStrategies);
  return control;
}



 // DoubleTapped

/*ActionToEventGenerator*/
public static T OnDoubleTapped<T>(this T control, Action<Avalonia.Input.TappedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Input.InputElement 
{
  control.AddHandler(Avalonia.Input.InputElement.DoubleTappedEvent, (_, args) => action(args), routes ?? Avalonia.Input.InputElement.DoubleTappedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Focusable

/*ValueStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Focusable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.FocusableProperty, binding);


 // IsEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsEnabledProperty, binding);


 // Cursor

/*ValueStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, Avalonia.Input.Cursor value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Cursor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.CursorProperty, binding);


 // IsHitTestVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHitTestVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);


 // IsTabStop

/*ValueStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTabStop<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.IsTabStopProperty, binding);


 // TabIndex

/*ValueStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.InputElement 
=> style._addSetter(Avalonia.Input.InputElement.TabIndexProperty, binding);



}
