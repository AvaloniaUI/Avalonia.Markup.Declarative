#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelExtensions
{
public static T ItemHeight<T>(this T control, IBinding binding) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemHeightProperty, binding);
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemHeightProperty, func, onChanged, expression);
public static T ItemHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static T ItemHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PanelType<T>(this T control, IBinding binding) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.PanelTypeProperty, binding);
public static T PanelType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.PanelTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PanelType<T>(this T control, Func<DateTimePickerPanelType> func, Action<DateTimePickerPanelType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.PanelTypeProperty, func, onChanged, expression);
public static T PanelType<T>(this T control, DateTimePickerPanelType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = value, bindingMode, converter, bindingSource);
public static T PanelType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DateTimePickerPanelType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemFormat<T>(this T control, IBinding binding) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemFormatProperty, binding);
public static T ItemFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemFormat<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ItemFormatProperty, func, onChanged, expression);
public static T ItemFormat<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = value, bindingMode, converter, bindingSource);
public static T ItemFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShouldLoop<T>(this T control, IBinding binding) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ShouldLoopProperty, binding);
public static T ShouldLoop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ShouldLoopProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShouldLoop<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DateTimePickerPanel
   => control._set(DateTimePickerPanel.ShouldLoopProperty, func, onChanged, expression);
public static T ShouldLoop<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = value, bindingMode, converter, bindingSource);
public static T ShouldLoop<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DateTimePickerPanel
=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

