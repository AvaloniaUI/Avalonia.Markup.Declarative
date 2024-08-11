#nullable enable
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CarouselExtensions
{
public static T PageTransition<T>(this T control, IBinding binding) where T : Carousel
   => control._set(Carousel.PageTransitionProperty, binding);
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Carousel
   => control._set(Carousel.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PageTransition<T>(this T control, Func<IPageTransition> func, Action<IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Carousel
   => control._set(Carousel.PageTransitionProperty, func, onChanged, expression);
public static T PageTransition<T>(this T control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Carousel
=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static T PageTransition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Carousel
=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

