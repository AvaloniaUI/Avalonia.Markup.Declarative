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
public static partial class TimeRangePicker_MarkupExtensions
{
//================= Properties ======================//
 // StartTime

/*ValueSetterGenerator*/
public static T StartTime<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeRangePicker 
=> control._set(() => control.StartTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T StartTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StartTime<T>(this T control,System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.StartTimeProperty, ps, () => control.StartTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StartTime<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StartTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.StartTimeProperty, ps, () => control.StartTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // EndTime

/*ValueSetterGenerator*/
public static T EndTime<T>(this T control, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeRangePicker 
=> control._set(() => control.EndTime = value!);

/*BindFromExpressionSetterGenerator*/
public static T EndTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndTimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T EndTime<T>(this T control,System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.EndTimeProperty, ps, () => control.EndTime = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EndTime<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T EndTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.EndTimeProperty, ps, () => control.EndTime = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StartWatermark

/*ValueSetterGenerator*/
public static T StartWatermark<T>(this T control, System.String value) where T : Ursa.Controls.TimeRangePicker 
=> control._set(() => control.StartWatermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T StartWatermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartWatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StartWatermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.StartWatermarkProperty, ps, () => control.StartWatermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StartWatermark<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.StartWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StartWatermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.StartWatermarkProperty, ps, () => control.StartWatermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // EndWatermark

/*ValueSetterGenerator*/
public static T EndWatermark<T>(this T control, System.String value) where T : Ursa.Controls.TimeRangePicker 
=> control._set(() => control.EndWatermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T EndWatermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndWatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T EndWatermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.EndWatermarkProperty, ps, () => control.EndWatermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EndWatermark<T>(this T control, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TimeRangePicker 
   => control._set(Ursa.Controls.TimeRangePicker.EndWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T EndWatermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TimeRangePicker 
=> control._setEx(Ursa.Controls.TimeRangePicker.EndWatermarkProperty, ps, () => control.EndWatermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // StartTime

/*ValueStyleSetterGenerator*/
public static Style<T> StartTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.StartTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartTime<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.StartTimeProperty, binding);


 // EndTime

/*ValueStyleSetterGenerator*/
public static Style<T> EndTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.EndTimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndTime<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.EndTimeProperty, binding);


 // StartWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> StartWatermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.StartWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartWatermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.StartWatermarkProperty, binding);


 // EndWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> EndWatermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.EndWatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndWatermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TimeRangePicker 
=> style._addSetter(Ursa.Controls.TimeRangePicker.EndWatermarkProperty, binding);



}
