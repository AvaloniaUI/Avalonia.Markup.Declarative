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
public static T MaxWidth<T>(this T control, IBinding binding) where T : ColumnDefinition
   => control._set(ColumnDefinition.MaxWidthProperty, binding);
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxWidth<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.MaxWidthProperty, func, onChanged, expression);
public static T MaxWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static T MaxWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinWidth<T>(this T control, IBinding binding) where T : ColumnDefinition
   => control._set(ColumnDefinition.MinWidthProperty, binding);
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinWidth<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.MinWidthProperty, func, onChanged, expression);
public static T MinWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static T MinWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Width<T>(this T control, IBinding binding) where T : ColumnDefinition
   => control._set(ColumnDefinition.WidthProperty, binding);
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Width<T>(this T control, Func<GridLength> func, Action<GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ColumnDefinition
   => control._set(ColumnDefinition.WidthProperty, func, onChanged, expression);
public static T Width<T>(this T control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static T Width<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ColumnDefinition
=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Width<T>(this T control, Double value = default) where T : ColumnDefinition
   => control._set(() => control.Width = new GridLength(value));
public static T Width<T>(this T control, Double value = default, GridUnitType type = default) where T : ColumnDefinition
   => control._set(() => control.Width = new GridLength(value, type));
}

