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
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, Boolean value) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.CanHorizontallyScrollProperty, value);
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, Boolean value) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.CanVerticallyScrollProperty, value);
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, Boolean value) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, value);
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);
public static Style<T> ScrollStartDistance<T>(this Style<T> style, Int32 value) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.ScrollStartDistanceProperty, value);
public static Style<T> ScrollStartDistance<T>(this Style<T> style, IBinding binding) where T : ScrollGestureRecognizer
=> style._addSetter(ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);
}

