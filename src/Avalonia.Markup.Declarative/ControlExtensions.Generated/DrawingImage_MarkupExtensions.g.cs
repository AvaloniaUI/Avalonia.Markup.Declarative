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
public static partial class DrawingImage_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*BindFromExpressionSetterGenerator*/
public static T Drawing<T>(this T control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Drawing<T>(this T control,Avalonia.Media.Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.DrawingImage 
=> control._setEx(Avalonia.Media.DrawingImage.DrawingProperty, ps, () => control.Drawing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Drawing<T>(this T control, IBinding binding) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Drawing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DrawingImage 
   => control._set(Avalonia.Media.DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Drawing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.DrawingImage 
=> control._setEx(Avalonia.Media.DrawingImage.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // Invalidated

/*ActionToEventGenerator*/
public static T OnInvalidated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Media.DrawingImage  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Invalidated += h);



}
