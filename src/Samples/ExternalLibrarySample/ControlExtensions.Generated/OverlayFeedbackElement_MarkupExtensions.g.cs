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
public static partial class OverlayFeedbackElement_MarkupExtensions
{
//================= Properties ======================//
 // IsClosed

/*ValueSetterGenerator*/
public static T IsClosed<T>(this T control, System.Boolean value) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
=> control._set(() => control.IsClosed = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsClosed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
   => control._set(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsClosed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
=> control._setEx(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty, ps, () => control.IsClosed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClosed<T>(this T control, IBinding binding) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
   => control._set(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClosed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
   => control._set(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsClosed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
=> control._setEx(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<Ursa.EventArgs.ResultEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
{
  control.AddHandler(Ursa.Controls.OverlayShared.OverlayFeedbackElement.ClosedEvent, (_, args) => action(args), routes ?? Ursa.Controls.OverlayShared.OverlayFeedbackElement.ClosedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // IsClosed

/*ValueStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
=> style._addSetter(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClosed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.OverlayShared.OverlayFeedbackElement 
=> style._addSetter(Ursa.Controls.OverlayShared.OverlayFeedbackElement.IsClosedProperty, binding);



}
