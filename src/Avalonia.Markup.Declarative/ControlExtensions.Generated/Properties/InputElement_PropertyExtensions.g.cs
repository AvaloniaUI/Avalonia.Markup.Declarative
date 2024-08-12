#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementExtensions
{
public static T Focusable<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.FocusableProperty, binding);
public static T Focusable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.FocusableProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Focusable<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.FocusableProperty, func, onChanged, expression);
public static T Focusable<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = value, bindingMode, converter, bindingSource);
public static T Focusable<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsEnabled<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, binding);
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, func, onChanged, expression);
public static T IsEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static T IsEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Cursor<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.CursorProperty, binding);
public static T Cursor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.CursorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Cursor<T>(this T control, Func<Cursor> func, Action<Cursor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.CursorProperty, func, onChanged, expression);
public static T Cursor<T>(this T control, Cursor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = value, bindingMode, converter, bindingSource);
public static T Cursor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Cursor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, binding);
public static T IsHitTestVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsHitTestVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, func, onChanged, expression);
public static T IsHitTestVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value, bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTabStop<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, binding);
public static T IsTabStop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTabStop<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, func, onChanged, expression);
public static T IsTabStop<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value, bindingMode, converter, bindingSource);
public static T IsTabStop<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TabIndex<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.TabIndexProperty, binding);
public static T TabIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : InputElement
   => control._set(InputElement.TabIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TabIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.TabIndexProperty, func, onChanged, expression);
public static T TabIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = value, bindingMode, converter, bindingSource);
public static T TabIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

