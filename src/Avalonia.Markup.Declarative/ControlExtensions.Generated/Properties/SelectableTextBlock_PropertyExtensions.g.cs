#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using SelectableTextBlock = Avalonia.Controls.SelectableTextBlock;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectableTextBlockExtensions
{
public static T SelectionStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, binding);
public static T SelectionStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionStart<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, func, onChanged, expression);
public static T SelectionStart<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static T SelectionStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, binding);
public static T SelectionEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionEnd<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, func, onChanged, expression);
public static T SelectionEnd<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static T SelectionEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, binding);
public static T SelectionBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, func, onChanged, expression);
public static T SelectionBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static T SelectionBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, binding);
public static T SelectionForegroundBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionForegroundBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SelectableTextBlock
   => control._set(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, func, onChanged, expression);
public static T SelectionForegroundBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static T SelectionForegroundBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SelectableTextBlock
=> control._setEx(Avalonia.Controls.SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

