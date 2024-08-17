#nullable enable
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
public static T PageTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, func, onChanged, expression);
public static T PageTransition<T>(this T control, Avalonia.Animation.IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl
=> control._setEx(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static T PageTransition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl
=> control._setEx(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTransitionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);
public static T IsTransitionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTransitionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, func, onChanged, expression);
public static T IsTransitionReversed<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl
=> control._setEx(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = value, bindingMode, converter, bindingSource);
public static T IsTransitionReversed<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl
=> control._setEx(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

