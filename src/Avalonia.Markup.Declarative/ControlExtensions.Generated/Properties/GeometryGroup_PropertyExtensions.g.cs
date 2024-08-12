#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryGroupExtensions
{
public static T Children<T>(this T control, IBinding binding) where T : GeometryGroup
   => control._set(GeometryGroup.ChildrenProperty, binding);
public static T Children<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeometryGroup
   => control._set(GeometryGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Children<T>(this T control, Func<GeometryCollection> func, Action<GeometryCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeometryGroup
   => control._set(GeometryGroup.ChildrenProperty, func, onChanged, expression);
public static T Children<T>(this T control, GeometryCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeometryGroup
=> control._setEx(GeometryGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static T Children<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, GeometryCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeometryGroup
=> control._setEx(GeometryGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FillRule<T>(this T control, IBinding binding) where T : GeometryGroup
   => control._set(GeometryGroup.FillRuleProperty, binding);
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : GeometryGroup
   => control._set(GeometryGroup.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FillRule<T>(this T control, Func<FillRule> func, Action<FillRule>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : GeometryGroup
   => control._set(GeometryGroup.FillRuleProperty, func, onChanged, expression);
public static T FillRule<T>(this T control, FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeometryGroup
=> control._setEx(GeometryGroup.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);
public static T FillRule<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : GeometryGroup
=> control._setEx(GeometryGroup.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

