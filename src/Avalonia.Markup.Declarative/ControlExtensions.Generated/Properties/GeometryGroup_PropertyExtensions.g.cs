#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using GeometryGroup = Avalonia.Media.GeometryGroup;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GeometryGroupExtensions
{
public static T Children<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, binding);
public static T Children<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Children<T>(this T control, Func<Avalonia.Media.GeometryCollection> func, Action<Avalonia.Media.GeometryCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, func, onChanged, expression);
public static T Children<T>(this T control, Avalonia.Media.GeometryCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.GeometryGroup
=> control._setEx(Avalonia.Media.GeometryGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static T Children<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.GeometryCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.GeometryGroup
=> control._setEx(Avalonia.Media.GeometryGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FillRule<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, binding);
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.GeometryGroup
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, func, onChanged, expression);
public static T FillRule<T>(this T control, Avalonia.Media.FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.GeometryGroup
=> control._setEx(Avalonia.Media.GeometryGroup.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);
public static T FillRule<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.GeometryGroup
=> control._setEx(Avalonia.Media.GeometryGroup.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

