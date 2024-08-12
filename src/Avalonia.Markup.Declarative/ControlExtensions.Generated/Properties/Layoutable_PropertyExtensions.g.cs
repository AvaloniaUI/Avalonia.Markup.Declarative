#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableExtensions
{
public static T Width<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.WidthProperty, binding);
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Width<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.WidthProperty, func, onChanged, expression);
public static T Width<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static T Width<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Height<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.HeightProperty, binding);
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Height<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.HeightProperty, func, onChanged, expression);
public static T Height<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, binding);
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinWidth<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, func, onChanged, expression);
public static T MinWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static T MinWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, binding);
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxWidth<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, func, onChanged, expression);
public static T MaxWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static T MaxWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, binding);
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, func, onChanged, expression);
public static T MinHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, binding);
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, func, onChanged, expression);
public static T MaxHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Margin<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MarginProperty, binding);
public static T Margin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.MarginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Margin<T>(this T control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MarginProperty, func, onChanged, expression);
public static T Margin<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MarginProperty, ps, () => control.Margin = value, bindingMode, converter, bindingSource);
public static T Margin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MarginProperty, ps, () => control.Margin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Margin<T>(this T control, Double uniformLength = default) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(uniformLength));
public static T Margin<T>(this T control, Double horizontal = default, Double vertical = default) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(horizontal, vertical));
public static T Margin<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(left, top, right, bottom));
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, binding);
public static T HorizontalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalAlignment<T>(this T control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, func, onChanged, expression);
public static T HorizontalAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, binding);
public static T VerticalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalAlignment<T>(this T control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, func, onChanged, expression);
public static T VerticalAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, binding);
public static T UseLayoutRounding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseLayoutRounding<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, func, onChanged, expression);
public static T UseLayoutRounding<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = value, bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

