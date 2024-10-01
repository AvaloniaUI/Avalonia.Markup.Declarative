#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TransitioningContentControl_MarkupExtensions
{
//================= Properties ======================//
 // PageTransition

/*BindFromExpressionSetterGenerator*/
public static T PageTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PageTransition<T>(this T control,Avalonia.Animation.IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl 
=> control._setEx(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PageTransition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl 
=> control._setEx(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTransitionReversed

/*BindFromExpressionSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTransitionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl 
=> control._setEx(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTransitionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TransitioningContentControl 
   => control._set(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTransitionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TransitioningContentControl 
=> control._setEx(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, ps, () => control.IsTransitionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // TransitionCompleted

/*ActionToEventGenerator*/
    public static T OnTransitionCompleted<T>(this T control, Action<Avalonia.Controls.TransitionCompletedEventArgs> action) where T : Avalonia.Controls.TransitioningContentControl => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TransitionCompletedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.TransitionCompleted += h);



//================= Styles ======================//
 // PageTransition

/*ValueStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PageTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.PageTransitionProperty, binding);


 // IsTransitionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTransitionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TransitioningContentControl 
=> style._addSetter(Avalonia.Controls.TransitioningContentControl.IsTransitionReversedProperty, binding);



}
