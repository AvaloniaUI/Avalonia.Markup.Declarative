#nullable enable
using Avalonia.Collections;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DashStyleExtensions
{
public static DashStyle Dashes(this DashStyle control, IBinding binding)
   => control._set(DashStyle.DashesProperty, binding);
public static DashStyle Dashes(this DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DashStyle.DashesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DashStyle Dashes(this DashStyle control, Func<AvaloniaList<Double>> func, Action<AvaloniaList<Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DashStyle.DashesProperty, func, onChanged, expression);
public static DashStyle Dashes(this DashStyle control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.DashesProperty, ps, () => control.Dashes = value, bindingMode, converter, bindingSource);
public static DashStyle Dashes<TValue>(this DashStyle control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.DashesProperty, ps, () => control.Dashes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DashStyle Offset(this DashStyle control, IBinding binding)
   => control._set(DashStyle.OffsetProperty, binding);
public static DashStyle Offset(this DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DashStyle.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DashStyle Offset(this DashStyle control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DashStyle.OffsetProperty, func, onChanged, expression);
public static DashStyle Offset(this DashStyle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static DashStyle Offset<TValue>(this DashStyle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

