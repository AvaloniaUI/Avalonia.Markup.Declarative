#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class OverlayPopupHostExtensions
{
public static OverlayPopupHost Transform(this OverlayPopupHost control, IBinding binding)
   => control._set(OverlayPopupHost.TransformProperty, binding);
public static OverlayPopupHost Transform(this OverlayPopupHost control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(OverlayPopupHost.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static OverlayPopupHost Transform(this OverlayPopupHost control, Func<Transform> func, Action<Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(OverlayPopupHost.TransformProperty, func, onChanged, expression);
public static OverlayPopupHost Transform(this OverlayPopupHost control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(OverlayPopupHost.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static OverlayPopupHost Transform<TValue>(this OverlayPopupHost control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(OverlayPopupHost.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

