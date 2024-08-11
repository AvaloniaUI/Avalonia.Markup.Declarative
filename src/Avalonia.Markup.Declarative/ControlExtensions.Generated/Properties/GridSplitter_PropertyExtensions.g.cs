#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridSplitterExtensions
{
public static T ResizeDirection<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.ResizeDirectionProperty, binding);
public static T ResizeDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.ResizeDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResizeDirection<T>(this T control, Func<GridResizeDirection> func, Action<GridResizeDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.ResizeDirectionProperty, func, onChanged, expression);
public static T ResizeDirection<T>(this T control, GridResizeDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = value, bindingMode, converter, bindingSource);
public static T ResizeDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GridResizeDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResizeBehavior<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.ResizeBehaviorProperty, binding);
public static T ResizeBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.ResizeBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResizeBehavior<T>(this T control, Func<GridResizeBehavior> func, Action<GridResizeBehavior>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.ResizeBehaviorProperty, func, onChanged, expression);
public static T ResizeBehavior<T>(this T control, GridResizeBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = value, bindingMode, converter, bindingSource);
public static T ResizeBehavior<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GridResizeBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowsPreview<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.ShowsPreviewProperty, binding);
public static T ShowsPreview<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.ShowsPreviewProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowsPreview<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.ShowsPreviewProperty, func, onChanged, expression);
public static T ShowsPreview<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = value, bindingMode, converter, bindingSource);
public static T ShowsPreview<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T KeyboardIncrement<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.KeyboardIncrementProperty, binding);
public static T KeyboardIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.KeyboardIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T KeyboardIncrement<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.KeyboardIncrementProperty, func, onChanged, expression);
public static T KeyboardIncrement<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = value, bindingMode, converter, bindingSource);
public static T KeyboardIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DragIncrement<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.DragIncrementProperty, binding);
public static T DragIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.DragIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DragIncrement<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.DragIncrementProperty, func, onChanged, expression);
public static T DragIncrement<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = value, bindingMode, converter, bindingSource);
public static T DragIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreviewContent<T>(this T control, IBinding binding) where T : GridSplitter
   => control._set(GridSplitter.PreviewContentProperty, binding);
public static T PreviewContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GridSplitter
   => control._set(GridSplitter.PreviewContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreviewContent<T>(this T control, Func<ITemplate<Control>> func, Action<ITemplate<Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GridSplitter
   => control._set(GridSplitter.PreviewContentProperty, func, onChanged, expression);
public static T PreviewContent<T>(this T control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = value, bindingMode, converter, bindingSource);
public static T PreviewContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GridSplitter
=> control._setEx(GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

