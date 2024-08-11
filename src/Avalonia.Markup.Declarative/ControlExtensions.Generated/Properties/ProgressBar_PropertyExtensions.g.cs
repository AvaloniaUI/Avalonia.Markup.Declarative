#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ProgressBarExtensions
{
public static T IsIndeterminate<T>(this T control, IBinding binding) where T : ProgressBar
   => control._set(ProgressBar.IsIndeterminateProperty, binding);
public static T IsIndeterminate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ProgressBar
   => control._set(ProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsIndeterminate<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ProgressBar
   => control._set(ProgressBar.IsIndeterminateProperty, func, onChanged, expression);
public static T IsIndeterminate<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value, bindingMode, converter, bindingSource);
public static T IsIndeterminate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowProgressText<T>(this T control, IBinding binding) where T : ProgressBar
   => control._set(ProgressBar.ShowProgressTextProperty, binding);
public static T ShowProgressText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ProgressBar
   => control._set(ProgressBar.ShowProgressTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowProgressText<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ProgressBar
   => control._set(ProgressBar.ShowProgressTextProperty, func, onChanged, expression);
public static T ShowProgressText<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = value, bindingMode, converter, bindingSource);
public static T ShowProgressText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ProgressTextFormat<T>(this T control, IBinding binding) where T : ProgressBar
   => control._set(ProgressBar.ProgressTextFormatProperty, binding);
public static T ProgressTextFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ProgressBar
   => control._set(ProgressBar.ProgressTextFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ProgressTextFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ProgressBar
   => control._set(ProgressBar.ProgressTextFormatProperty, func, onChanged, expression);
public static T ProgressTextFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = value, bindingMode, converter, bindingSource);
public static T ProgressTextFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Orientation<T>(this T control, IBinding binding) where T : ProgressBar
   => control._set(ProgressBar.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ProgressBar
   => control._set(ProgressBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ProgressBar
   => control._set(ProgressBar.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ProgressBar
=> control._setEx(ProgressBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

