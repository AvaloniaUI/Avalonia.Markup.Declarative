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
public static partial class StackPanelExtensions
{
public static StackPanel Spacing(this StackPanel control, IBinding binding)
   => control._set(StackPanel.SpacingProperty, binding);
public static StackPanel Spacing(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(StackPanel.SpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static StackPanel Spacing(this StackPanel control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.SpacingProperty, func, onChanged, expression);
public static StackPanel Spacing(this StackPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.SpacingProperty, ps, () => control.Spacing = value, bindingMode, converter, bindingSource);
public static StackPanel Spacing<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.SpacingProperty, ps, () => control.Spacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel Orientation(this StackPanel control, IBinding binding)
   => control._set(StackPanel.OrientationProperty, binding);
public static StackPanel Orientation(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(StackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static StackPanel Orientation(this StackPanel control, Func<Orientation> func, Action<Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.OrientationProperty, func, onChanged, expression);
public static StackPanel Orientation(this StackPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static StackPanel Orientation<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, IBinding binding)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, func, onChanged, expression);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static StackPanel AreHorizontalSnapPointsRegular<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, IBinding binding)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, binding);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, func, onChanged, expression);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static StackPanel AreVerticalSnapPointsRegular<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

