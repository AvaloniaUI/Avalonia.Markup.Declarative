#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VirtualizingStackPanelExtensions
{
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.OrientationProperty, binding);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(VirtualizingStackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.OrientationProperty, func, onChanged, expression);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel Orientation<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, func, onChanged, expression);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, func, onChanged, expression);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

