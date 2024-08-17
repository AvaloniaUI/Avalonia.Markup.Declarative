#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DrawingImage = Avalonia.Media.DrawingImage;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingImageExtensions
{
public static T Drawing<T>(this T control, IBinding binding) where T : Avalonia.Media.DrawingImage
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, binding);
public static T Drawing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DrawingImage
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Drawing<T>(this T control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.DrawingImage
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, func, onChanged, expression);
public static T Drawing<T>(this T control, Avalonia.Media.Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DrawingImage
=> control._setEx(Avalonia.Media.DrawingImage.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static T Drawing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DrawingImage
=> control._setEx(Avalonia.Media.DrawingImage.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

