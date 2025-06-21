#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Marquee_MarkupExtensions
{
//================= Properties ======================//
 // IsRunning

/*ValueSetterGenerator*/
public static T IsRunning<T>(this T control, System.Boolean value) where T : Ursa.Controls.Marquee 
=> control._set(() => control.IsRunning = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsRunning<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.IsRunningProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsRunning<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.IsRunningProperty, ps, () => control.IsRunning = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsRunning<T>(this T control, IBinding binding) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.IsRunningProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsRunning<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.IsRunningProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsRunning<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.IsRunningProperty, ps, () => control.IsRunning = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Direction

/*ValueSetterGenerator*/
public static T Direction<T>(this T control, Ursa.Controls.Direction value) where T : Ursa.Controls.Marquee 
=> control._set(() => control.Direction = value!);

/*BindFromExpressionSetterGenerator*/
public static T Direction<T>(this T control, Func<Ursa.Controls.Direction> func, Action<Ursa.Controls.Direction>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.DirectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Direction<T>(this T control,Ursa.Controls.Direction value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.DirectionProperty, ps, () => control.Direction = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Direction<T>(this T control, IBinding binding) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.DirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Direction<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.DirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Direction<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.Direction> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.DirectionProperty, ps, () => control.Direction = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Speed

/*ValueSetterGenerator*/
public static T Speed<T>(this T control, System.Double value) where T : Ursa.Controls.Marquee 
=> control._set(() => control.Speed = value!);

/*BindFromExpressionSetterGenerator*/
public static T Speed<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.SpeedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Speed<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.SpeedProperty, ps, () => control.Speed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Speed<T>(this T control, IBinding binding) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.SpeedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Speed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Marquee 
   => control._set(Ursa.Controls.Marquee.SpeedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Speed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Marquee 
=> control._setEx(Ursa.Controls.Marquee.SpeedProperty, ps, () => control.Speed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsRunning

/*ValueStyleSetterGenerator*/
public static Style<T> IsRunning<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.IsRunningProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsRunning<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.IsRunningProperty, binding);


 // Direction

/*ValueStyleSetterGenerator*/
public static Style<T> Direction<T>(this Style<T> style, Ursa.Controls.Direction value) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.DirectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Direction<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.DirectionProperty, binding);


 // Speed

/*ValueStyleSetterGenerator*/
public static Style<T> Speed<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.SpeedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Speed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Marquee 
=> style._addSetter(Ursa.Controls.Marquee.SpeedProperty, binding);



}
