#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using PolyLineSegment = Avalonia.Media.PolyLineSegment;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolyLineSegmentExtensions
{
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, IBinding binding)
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, binding);
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.PolyLineSegment.PointsProperty, func, onChanged, expression);
public static Avalonia.Media.PolyLineSegment Points(this Avalonia.Media.PolyLineSegment control, System.Collections.Generic.IList<Avalonia.Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PolyLineSegment.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.PolyLineSegment Points<TValue>(this Avalonia.Media.PolyLineSegment control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.PolyLineSegment.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

