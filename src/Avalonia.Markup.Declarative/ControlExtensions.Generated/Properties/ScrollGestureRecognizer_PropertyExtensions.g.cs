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
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, func, onChanged, expression);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanHorizontallyScroll<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, func, onChanged, expression);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanVerticallyScroll<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, func, onChanged, expression);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer IsScrollInertiaEnabled<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, func, onChanged, expression);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer ScrollStartDistance<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

