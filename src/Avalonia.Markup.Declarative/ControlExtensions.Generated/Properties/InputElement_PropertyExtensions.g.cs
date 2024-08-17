#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using InputElement = Avalonia.Input.InputElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class InputElementExtensions
{
public static T Focusable<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.FocusableProperty, binding);
public static T Focusable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.FocusableProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Focusable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.FocusableProperty, func, onChanged, expression);
public static T Focusable<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = value, bindingMode, converter, bindingSource);
public static T Focusable<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.FocusableProperty, ps, () => control.Focusable = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, binding);
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsEnabledProperty, func, onChanged, expression);
public static T IsEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static T IsEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Cursor<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.CursorProperty, binding);
public static T Cursor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.CursorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Cursor<T>(this T control, Func<Avalonia.Input.Cursor> func, Action<Avalonia.Input.Cursor>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.CursorProperty, func, onChanged, expression);
public static T Cursor<T>(this T control, Avalonia.Input.Cursor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = value, bindingMode, converter, bindingSource);
public static T Cursor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.Cursor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.CursorProperty, ps, () => control.Cursor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, binding);
public static T IsHitTestVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsHitTestVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsHitTestVisibleProperty, func, onChanged, expression);
public static T IsHitTestVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value, bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTabStop<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, binding);
public static T IsTabStop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTabStop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.IsTabStopProperty, func, onChanged, expression);
public static T IsTabStop<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value, bindingMode, converter, bindingSource);
public static T IsTabStop<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.IsTabStopProperty, ps, () => control.IsTabStop = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TabIndex<T>(this T control, IBinding binding) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, binding);
public static T TabIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TabIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.InputElement
   => control._set(Avalonia.Input.InputElement.TabIndexProperty, func, onChanged, expression);
public static T TabIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = value, bindingMode, converter, bindingSource);
public static T TabIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.InputElement
=> control._setEx(Avalonia.Input.InputElement.TabIndexProperty, ps, () => control.TabIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

