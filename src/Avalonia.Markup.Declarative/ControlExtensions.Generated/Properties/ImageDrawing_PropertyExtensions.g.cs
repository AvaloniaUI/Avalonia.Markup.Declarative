#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageDrawingExtensions
{
public static ImageDrawing ImageSource(this ImageDrawing control, IBinding binding)
   => control._set(ImageDrawing.ImageSourceProperty, binding);
public static ImageDrawing ImageSource(this ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ImageDrawing.ImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ImageDrawing ImageSource(this ImageDrawing control, Func<IImage> func, Action<IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageDrawing.ImageSourceProperty, func, onChanged, expression);
public static ImageDrawing ImageSource(this ImageDrawing control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = value, bindingMode, converter, bindingSource);
public static ImageDrawing ImageSource<TValue>(this ImageDrawing control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ImageDrawing Rect(this ImageDrawing control, IBinding binding)
   => control._set(ImageDrawing.RectProperty, binding);
public static ImageDrawing Rect(this ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ImageDrawing.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ImageDrawing Rect(this ImageDrawing control, Func<Rect> func, Action<Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageDrawing.RectProperty, func, onChanged, expression);
public static ImageDrawing Rect(this ImageDrawing control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static ImageDrawing Rect<TValue>(this ImageDrawing control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ImageDrawing Rect(this ImageDrawing control, Double x = default, Double y = default, Double width = default, Double height = default)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static ImageDrawing Rect(this ImageDrawing control, Size size = default)
   => control._set(() => control.Rect = new Rect(size));
public static ImageDrawing Rect(this ImageDrawing control, Point position = default, Size size = default)
   => control._set(() => control.Rect = new Rect(position, size));
public static ImageDrawing Rect(this ImageDrawing control, Point topLeft = default, Point bottomRight = default)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
}

