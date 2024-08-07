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
public static partial class TransitioningContentControlExtensions
{
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, IBinding binding)
   => control._set(TransitioningContentControl.PageTransitionProperty, binding);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransitioningContentControl.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, Func<IPageTransition> func, Action<IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitioningContentControl.PageTransitionProperty, func, onChanged, expression);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static TransitioningContentControl PageTransition<TValue>(this TransitioningContentControl control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TransitioningContentControl IsTransitionReversed(this TransitioningContentControl control, IBinding binding)
   => control._set(TransitioningContentControl.IsTransitionReversedProperty, binding);
public static TransitioningContentControl IsTransitionReversed(this TransitioningContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TransitioningContentControl.IsTransitionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TransitioningContentControl IsTransitionReversed(this TransitioningContentControl control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitioningContentControl.IsTransitionReversedProperty, func, onChanged, expression);
public static TransitioningContentControl IsTransitionReversed(this TransitioningContentControl control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = value, bindingMode, converter, bindingSource);
public static TransitioningContentControl IsTransitionReversed<TValue>(this TransitioningContentControl control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

