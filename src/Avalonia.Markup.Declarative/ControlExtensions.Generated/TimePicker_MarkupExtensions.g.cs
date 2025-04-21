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
public static partial class TimePicker_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SecondIncrement

/*BindFromExpressionSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SecondIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.SecondIncrementProperty, ps, () => control.SecondIncrement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SecondIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SecondIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SecondIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SecondIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.SecondIncrementProperty, ps, () => control.SecondIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ClockIdentifier

/*BindFromExpressionSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClockIdentifier<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClockIdentifier<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UseSeconds

/*BindFromExpressionSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UseSeconds<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.UseSecondsProperty, ps, () => control.UseSeconds = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseSeconds<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseSeconds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.UseSecondsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UseSeconds<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.UseSecondsProperty, ps, () => control.UseSeconds = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedTime

/*BindFromExpressionSetterGenerator*/
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedTime<T>(this T control,System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedTime<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker 
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedTime<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePicker 
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
public static T OnSelectedTimeChanged<T>(this T control, Action<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.TimePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedTimeChanged += h);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.UseSecondsProperty, binding);


 // SelectedTime

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker 
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);



}
