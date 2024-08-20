#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Carousel_MarkupExtensions
{
//================= Properties ======================//
 // PageTransitionProperty

/*BindFromExpressionSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Carousel
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Carousel
=> control._setEx(Avalonia.Controls.Carousel.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Carousel
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Carousel
   => control._set(Avalonia.Controls.Carousel.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PageTransition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Carousel
=> control._setEx(Avalonia.Controls.Carousel.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // PageTransitionProperty

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Carousel
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Carousel
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, binding);



}
