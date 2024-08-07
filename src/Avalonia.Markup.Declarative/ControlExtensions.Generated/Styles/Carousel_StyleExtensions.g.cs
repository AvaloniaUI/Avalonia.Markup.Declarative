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
public static Style<Carousel> PageTransition(this Style<Carousel> style, IPageTransition value)
=> style._addSetter(Carousel.PageTransitionProperty, value);
public static Style<Carousel> PageTransition(this Style<Carousel> style, IBinding binding)
=> style._addSetter(Carousel.PageTransitionProperty, binding);
}

