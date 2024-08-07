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
public static Carousel PageTransition(this Carousel control, IBinding binding)
   => control._set(Carousel.PageTransitionProperty, binding);
public static Carousel PageTransition(this Carousel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Carousel.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Carousel PageTransition(this Carousel control, Func<IPageTransition> func, Action<IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Carousel.PageTransitionProperty, func, onChanged, expression);
public static Carousel PageTransition(this Carousel control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static Carousel PageTransition<TValue>(this Carousel control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

