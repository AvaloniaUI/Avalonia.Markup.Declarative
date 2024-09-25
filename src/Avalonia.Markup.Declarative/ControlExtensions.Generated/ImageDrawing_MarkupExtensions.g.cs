#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ImageDrawing_MarkupExtensions
{
//================= Properties ======================//
 // ImageSourceProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, IBinding binding)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource(this Avalonia.Media.ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ImageDrawing.ImageSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ImageDrawing ImageSource<TValue>(this Avalonia.Media.ImageDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RectProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, System.Double x = default, System.Double y = default, System.Double width = default, System.Double height = default)
   => control._set(() => control.Rect = new Avalonia.Rect(x, y, width, height));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Size size = default)
   => control._set(() => control.Rect = new Avalonia.Rect(size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point position = default, Avalonia.Size size = default)
   => control._set(() => control.Rect = new Avalonia.Rect(position, size));
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, Avalonia.Point topLeft = default, Avalonia.Point bottomRight = default)
   => control._set(() => control.Rect = new Avalonia.Rect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, IBinding binding)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ImageDrawing Rect(this Avalonia.Media.ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.ImageDrawing.RectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ImageDrawing Rect<TValue>(this Avalonia.Media.ImageDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.ImageDrawing.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
