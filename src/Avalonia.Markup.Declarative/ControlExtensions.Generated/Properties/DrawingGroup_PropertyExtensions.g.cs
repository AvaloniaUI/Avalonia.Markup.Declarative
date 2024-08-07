#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingGroupExtensions
{
public static DrawingGroup Opacity(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.OpacityProperty, binding);
public static DrawingGroup Opacity(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingGroup.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingGroup Opacity(this DrawingGroup control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.OpacityProperty, func, onChanged, expression);
public static DrawingGroup Opacity(this DrawingGroup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static DrawingGroup Opacity<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup Transform(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.TransformProperty, binding);
public static DrawingGroup Transform(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingGroup.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingGroup Transform(this DrawingGroup control, Func<Transform> func, Action<Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.TransformProperty, func, onChanged, expression);
public static DrawingGroup Transform(this DrawingGroup control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static DrawingGroup Transform<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup ClipGeometry(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.ClipGeometryProperty, binding);
public static DrawingGroup ClipGeometry(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingGroup.ClipGeometryProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingGroup ClipGeometry(this DrawingGroup control, Func<Geometry> func, Action<Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.ClipGeometryProperty, func, onChanged, expression);
public static DrawingGroup ClipGeometry(this DrawingGroup control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = value, bindingMode, converter, bindingSource);
public static DrawingGroup ClipGeometry<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup OpacityMask(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.OpacityMaskProperty, binding);
public static DrawingGroup OpacityMask(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingGroup.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingGroup OpacityMask(this DrawingGroup control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.OpacityMaskProperty, func, onChanged, expression);
public static DrawingGroup OpacityMask(this DrawingGroup control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static DrawingGroup OpacityMask<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup Children(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.ChildrenProperty, binding);
public static DrawingGroup Children(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingGroup Children(this DrawingGroup control, Func<DrawingCollection> func, Action<DrawingCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.ChildrenProperty, func, onChanged, expression);
public static DrawingGroup Children(this DrawingGroup control, DrawingCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static DrawingGroup Children<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, DrawingCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

