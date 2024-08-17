#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Layoutable = Avalonia.Layout.Layoutable;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutableExtensions
{
public static T Width<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.WidthProperty, binding);
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Width<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.WidthProperty, func, onChanged, expression);
public static T Width<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static T Width<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Height<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HeightProperty, binding);
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Height<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HeightProperty, func, onChanged, expression);
public static T Height<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinWidth<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty, binding);
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinWidthProperty, func, onChanged, expression);
public static T MinWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static T MinWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxWidth<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty, binding);
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxWidthProperty, func, onChanged, expression);
public static T MaxWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static T MaxWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinHeight<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty, binding);
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MinHeightProperty, func, onChanged, expression);
public static T MinHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxHeight<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty, binding);
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MaxHeightProperty, func, onChanged, expression);
public static T MaxHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Margin<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MarginProperty, binding);
public static T Margin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MarginProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Margin<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.MarginProperty, func, onChanged, expression);
public static T Margin<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MarginProperty, ps, () => control.Margin = value, bindingMode, converter, bindingSource);
public static T Margin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.MarginProperty, ps, () => control.Margin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Margin<T>(this T control, Double uniformLength = default) where T : Avalonia.Layout.Layoutable
   => control._set(() => control.Margin = new Avalonia.Thickness(uniformLength));
public static T Margin<T>(this T control, Double horizontal = default, Double vertical = default) where T : Avalonia.Layout.Layoutable
   => control._set(() => control.Margin = new Avalonia.Thickness(horizontal, vertical));
public static T Margin<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Avalonia.Layout.Layoutable
   => control._set(() => control.Margin = new Avalonia.Thickness(left, top, right, bottom));
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, binding);
public static T HorizontalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, func, onChanged, expression);
public static T HorizontalAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, binding);
public static T VerticalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, func, onChanged, expression);
public static T VerticalAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, binding);
public static T UseLayoutRounding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseLayoutRounding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Layout.Layoutable
   => control._set(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, func, onChanged, expression);
public static T UseLayoutRounding<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = value, bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Layout.Layoutable
=> control._setEx(Avalonia.Layout.Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

