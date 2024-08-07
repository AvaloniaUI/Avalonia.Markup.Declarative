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
public static Sector StartAngle(this Sector control, IBinding binding)
   => control._set(Sector.StartAngleProperty, binding);
public static Sector StartAngle(this Sector control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Sector.StartAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Sector StartAngle(this Sector control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Sector.StartAngleProperty, func, onChanged, expression);
public static Sector StartAngle(this Sector control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static Sector StartAngle<TValue>(this Sector control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Sector SweepAngle(this Sector control, IBinding binding)
   => control._set(Sector.SweepAngleProperty, binding);
public static Sector SweepAngle(this Sector control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Sector.SweepAngleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Sector SweepAngle(this Sector control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Sector.SweepAngleProperty, func, onChanged, expression);
public static Sector SweepAngle(this Sector control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static Sector SweepAngle<TValue>(this Sector control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

