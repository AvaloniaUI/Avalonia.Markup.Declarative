#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using VirtualizingStackPanel = Avalonia.Controls.VirtualizingStackPanel;

namespace Avalonia.Markup.Declarative;
public static partial class VirtualizingStackPanelExtensions
{
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AreHorizontalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static T AreHorizontalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, func, onChanged, expression);
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static T AreHorizontalSnapPointsRegular<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AreVerticalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);
public static T AreVerticalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, func, onChanged, expression);
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static T AreVerticalSnapPointsRegular<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

