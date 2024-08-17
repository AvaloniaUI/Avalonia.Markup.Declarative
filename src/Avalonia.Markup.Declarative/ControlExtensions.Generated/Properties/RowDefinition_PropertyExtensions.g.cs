#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RowDefinition = Avalonia.Controls.RowDefinition;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RowDefinitionExtensions
{
public static T MaxHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, binding);
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, func, onChanged, expression);
public static T MaxHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, binding);
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, func, onChanged, expression);
public static T MinHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Height<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, binding);
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Height<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, func, onChanged, expression);
public static T Height<T>(this T control, Avalonia.Controls.GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Height<T>(this T control, Double value = default) where T : Avalonia.Controls.RowDefinition
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value));
public static T Height<T>(this T control, Double value = default, GridUnitType type = default) where T : Avalonia.Controls.RowDefinition
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value, type));
}

