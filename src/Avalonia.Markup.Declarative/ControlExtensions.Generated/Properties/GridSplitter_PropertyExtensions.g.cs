#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using GridSplitter = Avalonia.Controls.GridSplitter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GridSplitterExtensions
{
public static T ResizeDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, binding);
public static T ResizeDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResizeDirection<T>(this T control, Func<Avalonia.Controls.GridResizeDirection> func, Action<Avalonia.Controls.GridResizeDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, func, onChanged, expression);
public static T ResizeDirection<T>(this T control, Avalonia.Controls.GridResizeDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = value, bindingMode, converter, bindingSource);
public static T ResizeDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridResizeDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ResizeBehavior<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, binding);
public static T ResizeBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ResizeBehavior<T>(this T control, Func<Avalonia.Controls.GridResizeBehavior> func, Action<Avalonia.Controls.GridResizeBehavior>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, func, onChanged, expression);
public static T ResizeBehavior<T>(this T control, Avalonia.Controls.GridResizeBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = value, bindingMode, converter, bindingSource);
public static T ResizeBehavior<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridResizeBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowsPreview<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, binding);
public static T ShowsPreview<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowsPreview<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, func, onChanged, expression);
public static T ShowsPreview<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = value, bindingMode, converter, bindingSource);
public static T ShowsPreview<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T KeyboardIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, binding);
public static T KeyboardIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T KeyboardIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, func, onChanged, expression);
public static T KeyboardIncrement<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = value, bindingMode, converter, bindingSource);
public static T KeyboardIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DragIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, binding);
public static T DragIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DragIncrement<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.DragIncrementProperty, func, onChanged, expression);
public static T DragIncrement<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = value, bindingMode, converter, bindingSource);
public static T DragIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PreviewContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, binding);
public static T PreviewContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PreviewContent<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.GridSplitter
   => control._set(Avalonia.Controls.GridSplitter.PreviewContentProperty, func, onChanged, expression);
public static T PreviewContent<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = value, bindingMode, converter, bindingSource);
public static T PreviewContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.GridSplitter
=> control._setEx(Avalonia.Controls.GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

