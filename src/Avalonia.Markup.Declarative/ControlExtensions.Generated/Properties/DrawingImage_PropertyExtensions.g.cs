#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingImageExtensions
{
public static T Drawing<T>(this T control, IBinding binding) where T : DrawingImage
   => control._set(DrawingImage.DrawingProperty, binding);
public static T Drawing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DrawingImage
   => control._set(DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Drawing<T>(this T control, Func<Drawing> func, Action<Drawing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DrawingImage
   => control._set(DrawingImage.DrawingProperty, func, onChanged, expression);
public static T Drawing<T>(this T control, Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DrawingImage
=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static T Drawing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DrawingImage
=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

