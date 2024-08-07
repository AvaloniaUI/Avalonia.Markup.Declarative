using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input.GestureRecognizers;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollGestureRecognizerExtensions
{
public static Style<ScrollGestureRecognizer> CanHorizontallyScroll(this Style<ScrollGestureRecognizer> style, Boolean value)
=> style._addSetter(ScrollGestureRecognizer.CanHorizontallyScrollProperty, value);
public static Style<ScrollGestureRecognizer> CanHorizontallyScroll(this Style<ScrollGestureRecognizer> style, IBinding binding)
=> style._addSetter(ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);
public static Style<ScrollGestureRecognizer> CanVerticallyScroll(this Style<ScrollGestureRecognizer> style, Boolean value)
=> style._addSetter(ScrollGestureRecognizer.CanVerticallyScrollProperty, value);
public static Style<ScrollGestureRecognizer> CanVerticallyScroll(this Style<ScrollGestureRecognizer> style, IBinding binding)
=> style._addSetter(ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);
public static Style<ScrollGestureRecognizer> IsScrollInertiaEnabled(this Style<ScrollGestureRecognizer> style, Boolean value)
=> style._addSetter(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, value);
public static Style<ScrollGestureRecognizer> IsScrollInertiaEnabled(this Style<ScrollGestureRecognizer> style, IBinding binding)
=> style._addSetter(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);
public static Style<ScrollGestureRecognizer> ScrollStartDistance(this Style<ScrollGestureRecognizer> style, Int32 value)
=> style._addSetter(ScrollGestureRecognizer.ScrollStartDistanceProperty, value);
public static Style<ScrollGestureRecognizer> ScrollStartDistance(this Style<ScrollGestureRecognizer> style, IBinding binding)
=> style._addSetter(ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);
}

