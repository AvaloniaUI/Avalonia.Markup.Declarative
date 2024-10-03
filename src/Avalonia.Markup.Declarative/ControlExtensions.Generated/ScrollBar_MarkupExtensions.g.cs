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
public static partial class ScrollBar_MarkupExtensions
{
//================= Properties ======================//
 // ViewportSize

/*BindFromExpressionSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ViewportSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewportSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ViewportSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Visibility

/*BindFromExpressionSetterGenerator*/
public static T Visibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Visibility<T>(this T control,Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, ps, () => control.Visibility = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Visibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Visibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Visibility<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, ps, () => control.Visibility = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Orientation

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AllowAutoHide

/*BindFromExpressionSetterGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AllowAutoHide<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AllowAutoHide<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HideDelay

/*BindFromExpressionSetterGenerator*/
public static T HideDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HideDelay<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HideDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HideDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HideDelay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, ps, () => control.HideDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ShowDelay

/*BindFromExpressionSetterGenerator*/
public static T ShowDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowDelay<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ScrollBar 
   => control._set(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowDelay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ScrollBar 
=> control._setEx(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Scroll

/*ActionToEventGenerator*/
public static T OnScroll<T>(this T control, Action<Avalonia.Controls.Primitives.ScrollEventArgs> action) where T : Avalonia.Controls.Primitives.ScrollBar  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.Primitives.ScrollEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Scroll += h);



//================= Styles ======================//
 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);


 // Visibility

/*ValueStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Visibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);


 // HideDelay

/*ValueStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HideDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);


 // ShowDelay

/*ValueStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar 
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);



}
