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
public static partial class RepeatButton_MarkupExtensions
{
//================= Properties ======================//
 // Interval

/*BindFromExpressionSetterGenerator*/
public static T Interval<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Interval<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton 
=> control._setEx(Avalonia.Controls.RepeatButton.IntervalProperty, ps, () => control.Interval = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Interval<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Interval<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Interval<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton 
=> control._setEx(Avalonia.Controls.RepeatButton.IntervalProperty, ps, () => control.Interval = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Delay

/*BindFromExpressionSetterGenerator*/
public static T Delay<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Delay<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton 
=> control._setEx(Avalonia.Controls.RepeatButton.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Delay<T>(this T control, IBinding binding) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Delay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RepeatButton 
   => control._set(Avalonia.Controls.RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Delay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RepeatButton 
=> control._setEx(Avalonia.Controls.RepeatButton.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Interval

/*ValueStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Interval<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.IntervalProperty, binding);


 // Delay

/*ValueStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Delay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RepeatButton 
=> style._addSetter(Avalonia.Controls.RepeatButton.DelayProperty, binding);



}
