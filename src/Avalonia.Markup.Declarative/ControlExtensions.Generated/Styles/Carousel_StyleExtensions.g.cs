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
public static Style<T> PageTransition<T>(this Style<T> style, IPageTransition value) where T : Carousel
=> style._addSetter(Carousel.PageTransitionProperty, value);
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Carousel
=> style._addSetter(Carousel.PageTransitionProperty, binding);
}

