#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using ImageDrawing = Avalonia.Media.ImageDrawing;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageDrawingExtensions
{
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, IBinding binding)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding);
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, func, onChanged, expression);
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ImageDrawing ImageSource<TValue>(this Avalonia.Media.ImageDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, IBinding binding)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, binding);
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, func, onChanged, expression);
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.ImageDrawing Rect<TValue>(this Avalonia.Media.ImageDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Double x = default, Double y = default, Double width = default, Double height = default)
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Size size = default)
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Point position = default, Size size = default)
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Point topLeft = default, Point bottomRight = default)
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));
}

