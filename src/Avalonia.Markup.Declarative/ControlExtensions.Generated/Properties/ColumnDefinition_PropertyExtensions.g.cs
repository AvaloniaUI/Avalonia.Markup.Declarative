#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ColumnDefinitionExtensions
{
public static ColumnDefinition MaxWidth(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.MaxWidthProperty, binding);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ColumnDefinition.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.MaxWidthProperty, func, onChanged, expression);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static ColumnDefinition MaxWidth<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ColumnDefinition MinWidth(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.MinWidthProperty, binding);
public static ColumnDefinition MinWidth(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ColumnDefinition.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ColumnDefinition MinWidth(this ColumnDefinition control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.MinWidthProperty, func, onChanged, expression);
public static ColumnDefinition MinWidth(this ColumnDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static ColumnDefinition MinWidth<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ColumnDefinition Width(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.WidthProperty, binding);
public static ColumnDefinition Width(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ColumnDefinition.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ColumnDefinition Width(this ColumnDefinition control, Func<GridLength> func, Action<GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.WidthProperty, func, onChanged, expression);
public static ColumnDefinition Width(this ColumnDefinition control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static ColumnDefinition Width<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ColumnDefinition Width(this ColumnDefinition control, Double value = default)
   => control._set(() => control.Width = new GridLength(value));
public static ColumnDefinition Width(this ColumnDefinition control, Double value = default, GridUnitType type = default)
   => control._set(() => control.Width = new GridLength(value, type));
}

