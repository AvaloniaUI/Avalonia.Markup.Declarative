#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ProgressBar_MarkupExtensions
{
//================= Properties ======================//
 // IsIndeterminateProperty

/*BindFromExpressionSetterGenerator*/
public static T IsIndeterminate<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsIndeterminate<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsIndeterminate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsIndeterminate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ShowProgressTextProperty

/*BindFromExpressionSetterGenerator*/
public static T ShowProgressText<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ShowProgressText<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowProgressText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowProgressText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ShowProgressText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ProgressTextFormatProperty

/*BindFromExpressionSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ProgressTextFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ProgressTextFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OrientationProperty

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ProgressBar
   => control._set(Avalonia.Controls.ProgressBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ProgressBar
=> control._setEx(Avalonia.Controls.ProgressBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // IsIndeterminateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsIndeterminate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.IsIndeterminateProperty, binding);


 // ShowProgressTextProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowProgressText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ShowProgressTextProperty, binding);


 // ProgressTextFormatProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ProgressTextFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.ProgressTextFormatProperty, binding);


 // OrientationProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ProgressBar
=> style._addSetter(Avalonia.Controls.ProgressBar.OrientationProperty, binding);



}
