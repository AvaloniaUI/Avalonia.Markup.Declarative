using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Carousel = Avalonia.Controls.Carousel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class CarouselExtensions
{
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Carousel
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, value);
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Carousel
=> style._addSetter(Avalonia.Controls.Carousel.PageTransitionProperty, binding);
}

