#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutTransformControlExtensions
{
public static T LayoutTransform<T>(this T control, IBinding binding) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.LayoutTransformProperty, binding);
public static T LayoutTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.LayoutTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LayoutTransform<T>(this T control, Func<ITransform> func, Action<ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.LayoutTransformProperty, func, onChanged, expression);
public static T LayoutTransform<T>(this T control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LayoutTransformControl
=> control._setEx(LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = value, bindingMode, converter, bindingSource);
public static T LayoutTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LayoutTransformControl
=> control._setEx(LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseRenderTransform<T>(this T control, IBinding binding) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.UseRenderTransformProperty, binding);
public static T UseRenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.UseRenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseRenderTransform<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : LayoutTransformControl
   => control._set(LayoutTransformControl.UseRenderTransformProperty, func, onChanged, expression);
public static T UseRenderTransform<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LayoutTransformControl
=> control._setEx(LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = value, bindingMode, converter, bindingSource);
public static T UseRenderTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : LayoutTransformControl
=> control._setEx(LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

