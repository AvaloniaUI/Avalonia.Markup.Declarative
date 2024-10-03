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
public static partial class OverlayPopupHost_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*BindFromExpressionSetterGenerator*/
public static T Transform<T>(this T control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Transform<T>(this T control,Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> control._setEx(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Transform<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Transform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
   => control._set(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Transform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> control._setEx(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, Avalonia.Media.Transform value) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Transform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.OverlayPopupHost 
=> style._addSetter(Avalonia.Controls.Primitives.OverlayPopupHost.TransformProperty, binding);



}
