#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CombinedGeometryExtensions
{
public static T Geometry1<T>(this T control, IBinding binding) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry1Property, binding);
public static T Geometry1<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry1Property, avaloniaProperty, bindingMode, converter, overrideView);
public static T Geometry1<T>(this T control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry1Property, func, onChanged, expression);
public static T Geometry1<T>(this T control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.Geometry1Property, ps, () => control.Geometry1 = value, bindingMode, converter, bindingSource);
public static T Geometry1<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.Geometry1Property, ps, () => control.Geometry1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Geometry2<T>(this T control, IBinding binding) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry2Property, binding);
public static T Geometry2<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry2Property, avaloniaProperty, bindingMode, converter, overrideView);
public static T Geometry2<T>(this T control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.Geometry2Property, func, onChanged, expression);
public static T Geometry2<T>(this T control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.Geometry2Property, ps, () => control.Geometry2 = value, bindingMode, converter, bindingSource);
public static T Geometry2<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.Geometry2Property, ps, () => control.Geometry2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T GeometryCombineMode<T>(this T control, IBinding binding) where T : CombinedGeometry
   => control._set(CombinedGeometry.GeometryCombineModeProperty, binding);
public static T GeometryCombineMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.GeometryCombineModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T GeometryCombineMode<T>(this T control, Func<GeometryCombineMode> func, Action<GeometryCombineMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CombinedGeometry
   => control._set(CombinedGeometry.GeometryCombineModeProperty, func, onChanged, expression);
public static T GeometryCombineMode<T>(this T control, GeometryCombineMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.GeometryCombineModeProperty, ps, () => control.GeometryCombineMode = value, bindingMode, converter, bindingSource);
public static T GeometryCombineMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GeometryCombineMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CombinedGeometry
=> control._setEx(CombinedGeometry.GeometryCombineModeProperty, ps, () => control.GeometryCombineMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

