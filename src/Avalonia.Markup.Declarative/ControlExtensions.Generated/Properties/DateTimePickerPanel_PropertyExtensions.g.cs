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
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ItemHeightProperty, binding);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DateTimePickerPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ItemHeightProperty, func, onChanged, expression);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemHeight<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.PanelTypeProperty, binding);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DateTimePickerPanel.PanelTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, Func<DateTimePickerPanelType> func, Action<DateTimePickerPanelType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.PanelTypeProperty, func, onChanged, expression);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, DateTimePickerPanelType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel PanelType<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, DateTimePickerPanelType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ItemFormatProperty, binding);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DateTimePickerPanel.ItemFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ItemFormatProperty, func, onChanged, expression);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemFormat<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, binding);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, func, onChanged, expression);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ShouldLoop<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

