#nullable enable
using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Polyline = Avalonia.Controls.Shapes.Polyline;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolylineExtensions
{
public static T Points<T>(this T control, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);
public static T Points<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Shapes.Polyline
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Points<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Point>> func, Action<System.Collections.Generic.IList<Avalonia.Point>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Shapes.Polyline
   => control._set(Avalonia.Controls.Shapes.Polyline.PointsProperty, func, onChanged, expression);
public static T Points<T>(this T control, System.Collections.Generic.IList<Avalonia.Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Polyline
=> control._setEx(Avalonia.Controls.Shapes.Polyline.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static T Points<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Shapes.Polyline
=> control._setEx(Avalonia.Controls.Shapes.Polyline.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

