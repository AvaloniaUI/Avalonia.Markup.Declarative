#nullable enable
using Avalonia.Collections;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DashStyle = Avalonia.Media.DashStyle;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DashStyleExtensions
{
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, IBinding binding)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, binding);
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, func, onChanged, expression);
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DashStyle Dashes<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, IBinding binding)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, binding);
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, func, onChanged, expression);
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DashStyle Offset<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

