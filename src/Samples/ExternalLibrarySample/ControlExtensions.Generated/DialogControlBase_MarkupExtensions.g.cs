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
public static partial class DialogControlBase_MarkupExtensions
{
//================= Properties ======================//
 // IsFullScreen

/*ValueSetterGenerator*/
public static T IsFullScreen<T>(this T control, System.Boolean value) where T : Ursa.Controls.DialogControlBase 
=> control._set(() => control.IsFullScreen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsFullScreen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.IsFullScreenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsFullScreen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DialogControlBase 
=> control._setEx(Ursa.Controls.DialogControlBase.IsFullScreenProperty, ps, () => control.IsFullScreen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsFullScreen<T>(this T control, IBinding binding) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.IsFullScreenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFullScreen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.IsFullScreenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsFullScreen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DialogControlBase 
=> control._setEx(Ursa.Controls.DialogControlBase.IsFullScreenProperty, ps, () => control.IsFullScreen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Ursa.Controls.DialogControlBase 
=> control._set(() => control.CanResize = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.CanResizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanResize<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DialogControlBase 
=> control._setEx(Ursa.Controls.DialogControlBase.CanResizeProperty, ps, () => control.CanResize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanResize<T>(this T control, IBinding binding) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.CanResizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DialogControlBase 
   => control._set(Ursa.Controls.DialogControlBase.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanResize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DialogControlBase 
=> control._setEx(Ursa.Controls.DialogControlBase.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // CanDragMove

/*AttachedPropertyMagicalSetterGenerator*/
public static T DialogControlBase_CanDragMove<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement
 => control._setEx(Ursa.Controls.DialogControlBase.CanDragMoveProperty, ps, () => Ursa.Controls.DialogControlBase.SetCanDragMove(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T DialogControlBase_CanDragMove<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Ursa.Controls.DialogControlBase.CanDragMoveProperty!, func, onChanged, expression);


 // CanClose

/*AttachedPropertyMagicalSetterGenerator*/
public static T DialogControlBase_CanClose<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Input.InputElement
 => control._setEx(Ursa.Controls.DialogControlBase.CanCloseProperty, ps, () => Ursa.Controls.DialogControlBase.SetCanClose(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T DialogControlBase_CanClose<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Input.InputElement 
   => control._set(Ursa.Controls.DialogControlBase.CanCloseProperty!, func, onChanged, expression);



//================= Events ======================//
 // LayerChanged

/*ActionToEventGenerator*/
public static T OnLayerChanged<T>(this T control, Action<Ursa.Controls.DialogLayerChangeEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.DialogControlBase 
{
  control.AddHandler(Ursa.Controls.DialogControlBase.LayerChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.DialogControlBase.LayerChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.DialogControlBase 
=> style._addSetter(Ursa.Controls.DialogControlBase.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DialogControlBase 
=> style._addSetter(Ursa.Controls.DialogControlBase.CanResizeProperty, binding);



}
