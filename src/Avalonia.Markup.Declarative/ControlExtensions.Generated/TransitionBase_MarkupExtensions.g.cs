#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TransitionBase_MarkupExtensions
{
//================= Properties ======================//
 // DurationProperty

/*BindFromExpressionSetterGenerator*/
public static T Duration<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Duration<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.DurationProperty, ps, () => control.Duration = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Duration<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Duration<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DurationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Duration<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.DurationProperty, ps, () => control.Duration = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DelayProperty

/*BindFromExpressionSetterGenerator*/
public static T Delay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Delay<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Delay<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Delay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // EasingProperty

/*BindFromExpressionSetterGenerator*/
public static T Easing<T>(this T control, Func<Avalonia.Animation.Easings.Easing> func, Action<Avalonia.Animation.Easings.Easing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Easing<T>(this T control, Avalonia.Animation.Easings.Easing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.EasingProperty, ps, () => control.Easing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Easing<T>(this T control, IBinding binding) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Easing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Animation.TransitionBase
   => control._set(Avalonia.Animation.TransitionBase.EasingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Easing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.Easings.Easing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Animation.TransitionBase
=> control._setEx(Avalonia.Animation.TransitionBase.EasingProperty, ps, () => control.Easing = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
