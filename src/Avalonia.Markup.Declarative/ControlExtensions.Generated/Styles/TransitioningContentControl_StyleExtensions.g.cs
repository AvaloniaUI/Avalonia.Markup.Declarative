using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TransitioningContentControl = Avalonia.Controls.TransitioningContentControl;

namespace Avalonia.Markup.Declarative;
public static partial class TransitioningContentControlExtensions
{
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, value);
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);
public static Style<T> IsTransitionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, value);
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);
}

