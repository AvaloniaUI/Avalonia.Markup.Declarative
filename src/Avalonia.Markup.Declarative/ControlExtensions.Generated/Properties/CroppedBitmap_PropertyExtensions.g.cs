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
public static T Source<T>(this T control, IBinding binding) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceProperty, binding);
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Source<T>(this T control, Func<IImage> func, Action<IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceProperty, func, onChanged, expression);
public static T Source<T>(this T control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CroppedBitmap
=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static T Source<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CroppedBitmap
=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SourceRect<T>(this T control, IBinding binding) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceRectProperty, binding);
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SourceRect<T>(this T control, Func<PixelRect> func, Action<PixelRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : CroppedBitmap
   => control._set(CroppedBitmap.SourceRectProperty, func, onChanged, expression);
public static T SourceRect<T>(this T control, PixelRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CroppedBitmap
=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static T SourceRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PixelRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : CroppedBitmap
=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T SourceRect<T>(this T control, Int32 x = default, Int32 y = default, Int32 width = default, Int32 height = default) where T : CroppedBitmap
   => control._set(() => control.SourceRect = new PixelRect(x, y, width, height));
public static T SourceRect<T>(this T control, PixelSize size = default) where T : CroppedBitmap
   => control._set(() => control.SourceRect = new PixelRect(size));
public static T SourceRect<T>(this T control, PixelPoint position = default, PixelSize size = default) where T : CroppedBitmap
   => control._set(() => control.SourceRect = new PixelRect(position, size));
public static T SourceRect<T>(this T control, PixelPoint topLeft = default, PixelPoint bottomRight = default) where T : CroppedBitmap
   => control._set(() => control.SourceRect = new PixelRect(topLeft, bottomRight));
}

