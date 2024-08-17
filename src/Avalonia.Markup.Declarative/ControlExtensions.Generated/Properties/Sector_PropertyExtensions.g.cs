#nullable enable
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Sector = Avalonia.Controls.Shapes.Sector;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SectorExtensions
{
public static T StartAngle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty, binding);
public static T StartAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StartAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.StartAngleProperty, func, onChanged, expression);
public static T StartAngle<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Sector
=> control._setEx(Avalonia.Controls.Shapes.Sector.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static T StartAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Sector
=> control._setEx(Avalonia.Controls.Shapes.Sector.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SweepAngle<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, binding);
public static T SweepAngle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SweepAngle<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Sector
   => control._set(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, func, onChanged, expression);
public static T SweepAngle<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Sector
=> control._setEx(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static T SweepAngle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Sector
=> control._setEx(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

