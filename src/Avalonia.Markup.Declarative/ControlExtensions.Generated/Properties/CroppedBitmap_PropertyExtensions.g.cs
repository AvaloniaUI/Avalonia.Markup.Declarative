#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CroppedBitmapExtensions
{
public static CroppedBitmap Source(this CroppedBitmap control, IBinding binding)
   => control._set(CroppedBitmap.SourceProperty, binding);
public static CroppedBitmap Source(this CroppedBitmap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CroppedBitmap Source(this CroppedBitmap control, Func<IImage> func, Action<IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CroppedBitmap.SourceProperty, func, onChanged, expression);
public static CroppedBitmap Source(this CroppedBitmap control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static CroppedBitmap Source<TValue>(this CroppedBitmap control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CroppedBitmap SourceRect(this CroppedBitmap control, IBinding binding)
   => control._set(CroppedBitmap.SourceRectProperty, binding);
public static CroppedBitmap SourceRect(this CroppedBitmap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static CroppedBitmap SourceRect(this CroppedBitmap control, Func<PixelRect> func, Action<PixelRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CroppedBitmap.SourceRectProperty, func, onChanged, expression);
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static CroppedBitmap SourceRect<TValue>(this CroppedBitmap control, TValue value, FuncValueConverter<TValue, PixelRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static CroppedBitmap SourceRect(this CroppedBitmap control, Int32 x = default, Int32 y = default, Int32 width = default, Int32 height = default)
   => control._set(() => control.SourceRect = new PixelRect(x, y, width, height));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelSize size = default)
   => control._set(() => control.SourceRect = new PixelRect(size));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelPoint position = default, PixelSize size = default)
   => control._set(() => control.SourceRect = new PixelRect(position, size));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelPoint topLeft = default, PixelPoint bottomRight = default)
   => control._set(() => control.SourceRect = new PixelRect(topLeft, bottomRight));
}

