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
public static Style<TransitioningContentControl> PageTransition(this Style<TransitioningContentControl> style, IPageTransition value)
=> style._addSetter(TransitioningContentControl.PageTransitionProperty, value);
public static Style<TransitioningContentControl> PageTransition(this Style<TransitioningContentControl> style, IBinding binding)
=> style._addSetter(TransitioningContentControl.PageTransitionProperty, binding);
public static Style<TransitioningContentControl> IsTransitionReversed(this Style<TransitioningContentControl> style, Boolean value)
=> style._addSetter(TransitioningContentControl.IsTransitionReversedProperty, value);
public static Style<TransitioningContentControl> IsTransitionReversed(this Style<TransitioningContentControl> style, IBinding binding)
=> style._addSetter(TransitioningContentControl.IsTransitionReversedProperty, binding);
}

