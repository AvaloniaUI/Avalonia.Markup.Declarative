using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TransitioningContentControlExtensions
{
public static Style<T> PageTransition<T>(this Style<T> style, IPageTransition value) where T : TransitioningContentControl
=> style._addSetter(TransitioningContentControl.PageTransitionProperty, value);
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : TransitioningContentControl
=> style._addSetter(TransitioningContentControl.PageTransitionProperty, binding);
public static Style<T> IsTransitionReversed<T>(this Style<T> style, Boolean value) where T : TransitioningContentControl
=> style._addSetter(TransitioningContentControl.IsTransitionReversedProperty, value);
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : TransitioningContentControl
=> style._addSetter(TransitioningContentControl.IsTransitionReversedProperty, binding);
}

