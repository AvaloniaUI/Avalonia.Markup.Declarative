#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SectorExtensions
{
public static T StartAngle<T>(this T control, IBinding binding) where T : Sector
   => control._set(Sector.StartAngleProperty, binding);
public static T StartAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Sector
   => control._set(Sector.StartAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StartAngle<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Sector
   => control._set(Sector.StartAngleProperty, func, onChanged, expression);
public static T StartAngle<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Sector
=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static T StartAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Sector
=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SweepAngle<T>(this T control, IBinding binding) where T : Sector
   => control._set(Sector.SweepAngleProperty, binding);
public static T SweepAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Sector
   => control._set(Sector.SweepAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SweepAngle<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Sector
   => control._set(Sector.SweepAngleProperty, func, onChanged, expression);
public static T SweepAngle<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Sector
=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static T SweepAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Sector
=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

