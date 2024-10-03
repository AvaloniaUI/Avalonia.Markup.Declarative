#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class CroppedBitmap_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*BindFromExpressionSetterGenerator*/
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Source<T>(this T control,Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Source<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Source<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SourceRect

/*BindFromExpressionSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.PixelRect> func, Action<Avalonia.PixelRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SourceRect<T>(this T control,Avalonia.PixelRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Int32 x = default, System.Int32 y = default, System.Int32 width = default, System.Int32 height = default) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(x, y, width, height));
public static T SourceRect<T>(this T control, Avalonia.PixelSize size = default) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint position = default, Avalonia.PixelSize size = default) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(position, size));
public static T SourceRect<T>(this T control, Avalonia.PixelPoint topLeft = default, Avalonia.PixelPoint bottomRight = default) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(() => control.SourceRect = new Avalonia.PixelRect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
   => control._set(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SourceRect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.PixelRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.Imaging.CroppedBitmap 
=> control._setEx(Avalonia.Media.Imaging.CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.Imaging.CroppedBitmap  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
