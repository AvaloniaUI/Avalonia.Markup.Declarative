#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DateTimePickerPanel = Avalonia.Controls.Primitives.DateTimePickerPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DateTimePickerPanelExtensions
{
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, binding);
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, func, onChanged, expression);
public static T ItemHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static T ItemHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PanelType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, binding);
public static T PanelType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PanelType<T>(this T control, Func<Avalonia.Controls.Primitives.DateTimePickerPanelType> func, Action<Avalonia.Controls.Primitives.DateTimePickerPanelType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, func, onChanged, expression);
public static T PanelType<T>(this T control, Avalonia.Controls.Primitives.DateTimePickerPanelType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = value, bindingMode, converter, bindingSource);
public static T PanelType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.DateTimePickerPanelType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, binding);
public static T ItemFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, func, onChanged, expression);
public static T ItemFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = value, bindingMode, converter, bindingSource);
public static T ItemFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShouldLoop<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, binding);
public static T ShouldLoop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShouldLoop<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
   => control._set(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, func, onChanged, expression);
public static T ShouldLoop<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = value, bindingMode, converter, bindingSource);
public static T ShouldLoop<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.DateTimePickerPanel
=> control._setEx(Avalonia.Controls.Primitives.DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

