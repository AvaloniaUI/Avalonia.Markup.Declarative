#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using CroppedBitmap = Avalonia.Media.Imaging.CroppedBitmap;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CroppedBitmapExtensions
{
public static T Source<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, binding);
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, func, onChanged, expression);
public static T Source<T>(this T control, Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static T Source<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, binding);
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SourceRect<T>(this T control, Func<Avalonia.PixelRect> func, Action<Avalonia.PixelRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, func, onChanged, expression);
public static T SourceRect<T>(this T control, Avalonia.PixelRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static T SourceRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.PixelRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T SourceRect<T>(this T control, Int32 x = default, Int32 y = default, Int32 width = default, Int32 height = default) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(x, y, width, height));
public static T SourceRect<T>(this T control, PixelSize size = default) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(size));
public static T SourceRect<T>(this T control, PixelPoint position = default, PixelSize size = default) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(position, size));
public static T SourceRect<T>(this T control, PixelPoint topLeft = default, PixelPoint bottomRight = default) where T : Avalonia.Media.Imaging.CroppedBitmap
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(topLeft, bottomRight));
}

