#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using LayoutTransformControl = Avalonia.Controls.LayoutTransformControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LayoutTransformControlExtensions
{
public static T LayoutTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);
public static T LayoutTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LayoutTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, func, onChanged, expression);
public static T LayoutTransform<T>(this T control, Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl
=> control._setEx(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = value, bindingMode, converter, bindingSource);
public static T LayoutTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl
=> control._setEx(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseRenderTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);
public static T UseRenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseRenderTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.LayoutTransformControl
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, func, onChanged, expression);
public static T UseRenderTransform<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl
=> control._setEx(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = value, bindingMode, converter, bindingSource);
public static T UseRenderTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl
=> control._setEx(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

