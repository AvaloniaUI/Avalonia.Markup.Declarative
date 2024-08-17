#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ColumnDefinition = Avalonia.Controls.ColumnDefinition;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ColumnDefinitionExtensions
{
public static T MaxWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, binding);
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, func, onChanged, expression);
public static T MaxWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static T MaxWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty, binding);
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.MinWidthProperty, func, onChanged, expression);
public static T MinWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static T MinWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Width<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty, binding);
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Width<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ColumnDefinition
   => control._set(Avalonia.Controls.ColumnDefinition.WidthProperty, func, onChanged, expression);
public static T Width<T>(this T control, Avalonia.Controls.GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static T Width<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ColumnDefinition
=> control._setEx(Avalonia.Controls.ColumnDefinition.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Width<T>(this T control, Double value = default) where T : Avalonia.Controls.ColumnDefinition
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value));
public static T Width<T>(this T control, Double value = default, GridUnitType type = default) where T : Avalonia.Controls.ColumnDefinition
   => control._set(() => control.Width = new Avalonia.Controls.GridLength(value, type));
}

