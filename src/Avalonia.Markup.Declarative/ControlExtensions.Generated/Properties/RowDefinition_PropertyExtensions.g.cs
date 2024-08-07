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
public static RowDefinition MaxHeight(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.MaxHeightProperty, binding);
public static RowDefinition MaxHeight(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RowDefinition.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RowDefinition MaxHeight(this RowDefinition control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.MaxHeightProperty, func, onChanged, expression);
public static RowDefinition MaxHeight(this RowDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static RowDefinition MaxHeight<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RowDefinition MinHeight(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.MinHeightProperty, binding);
public static RowDefinition MinHeight(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RowDefinition.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RowDefinition MinHeight(this RowDefinition control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.MinHeightProperty, func, onChanged, expression);
public static RowDefinition MinHeight(this RowDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static RowDefinition MinHeight<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RowDefinition Height(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.HeightProperty, binding);
public static RowDefinition Height(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RowDefinition.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RowDefinition Height(this RowDefinition control, Func<GridLength> func, Action<GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.HeightProperty, func, onChanged, expression);
public static RowDefinition Height(this RowDefinition control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static RowDefinition Height<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RowDefinition Height(this RowDefinition control, Double value = default)
   => control._set(() => control.Height = new GridLength(value));
public static RowDefinition Height(this RowDefinition control, Double value = default, GridUnitType type = default)
   => control._set(() => control.Height = new GridLength(value, type));
}

