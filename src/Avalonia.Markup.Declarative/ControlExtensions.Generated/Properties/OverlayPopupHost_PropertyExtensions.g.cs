#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using OverlayPopupHost = Avalonia.Controls.Primitives.OverlayPopupHost;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class OverlayPopupHostExtensions
{
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, func, onChanged, expression);
public static T Transform<T>(this T control, Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost
=> control._setEx(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static T Transform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost
=> control._setEx(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

