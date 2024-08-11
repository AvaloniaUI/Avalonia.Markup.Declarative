#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RowDefinitionExtensions
{
public static T MaxHeight<T>(this T control, IBinding binding) where T : RowDefinition
   => control._set(RowDefinition.MaxHeightProperty, binding);
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RowDefinition
   => control._set(RowDefinition.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RowDefinition
   => control._set(RowDefinition.MaxHeightProperty, func, onChanged, expression);
public static T MaxHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinHeight<T>(this T control, IBinding binding) where T : RowDefinition
   => control._set(RowDefinition.MinHeightProperty, binding);
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RowDefinition
   => control._set(RowDefinition.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RowDefinition
   => control._set(RowDefinition.MinHeightProperty, func, onChanged, expression);
public static T MinHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Height<T>(this T control, IBinding binding) where T : RowDefinition
   => control._set(RowDefinition.HeightProperty, binding);
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RowDefinition
   => control._set(RowDefinition.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Height<T>(this T control, Func<GridLength> func, Action<GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RowDefinition
   => control._set(RowDefinition.HeightProperty, func, onChanged, expression);
public static T Height<T>(this T control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RowDefinition
=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Height<T>(this T control, Double value = default) where T : RowDefinition
   => control._set(() => control.Height = new GridLength(value));
public static T Height<T>(this T control, Double value = default, GridUnitType type = default) where T : RowDefinition
   => control._set(() => control.Height = new GridLength(value, type));
}

