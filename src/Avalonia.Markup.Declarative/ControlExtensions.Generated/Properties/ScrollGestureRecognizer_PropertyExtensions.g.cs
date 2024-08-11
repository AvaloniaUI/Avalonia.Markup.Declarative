#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input.GestureRecognizers;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollGestureRecognizerExtensions
{
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanHorizontallyScroll<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, func, onChanged, expression);
public static T CanHorizontallyScroll<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static T CanHorizontallyScroll<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanVerticallyScroll<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, func, onChanged, expression);
public static T CanVerticallyScroll<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static T CanVerticallyScroll<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollInertiaEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, func, onChanged, expression);
public static T IsScrollInertiaEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ScrollStartDistance<T>(this T control, IBinding binding) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);
public static T ScrollStartDistance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ScrollStartDistance<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollGestureRecognizer
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, func, onChanged, expression);
public static T ScrollStartDistance<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = value, bindingMode, converter, bindingSource);
public static T ScrollStartDistance<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollGestureRecognizer
=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

