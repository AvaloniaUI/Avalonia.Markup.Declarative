#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectableTextBlockExtensions
{
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionStartProperty, binding);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SelectableTextBlock.SelectionStartProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionStartProperty, func, onChanged, expression);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionStart<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionEndProperty, binding);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SelectableTextBlock.SelectionEndProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionEndProperty, func, onChanged, expression);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionEnd<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionBrushProperty, binding);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SelectableTextBlock.SelectionBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionBrushProperty, func, onChanged, expression);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionBrush<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionForegroundBrush(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionForegroundBrushProperty, binding);
public static SelectableTextBlock SelectionForegroundBrush(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SelectableTextBlock.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SelectableTextBlock SelectionForegroundBrush(this SelectableTextBlock control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionForegroundBrushProperty, func, onChanged, expression);
public static SelectableTextBlock SelectionForegroundBrush(this SelectableTextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionForegroundBrush<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

