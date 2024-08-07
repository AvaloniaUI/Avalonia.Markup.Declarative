#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryExtensions
{
public static Geometry Transform(this Geometry control, IBinding binding)
   => control._set(Geometry.TransformProperty, binding);
public static Geometry Transform(this Geometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Geometry.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Geometry Transform(this Geometry control, Func<Transform> func, Action<Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Geometry.TransformProperty, func, onChanged, expression);
public static Geometry Transform(this Geometry control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Geometry.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Geometry Transform<TValue>(this Geometry control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Geometry.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

