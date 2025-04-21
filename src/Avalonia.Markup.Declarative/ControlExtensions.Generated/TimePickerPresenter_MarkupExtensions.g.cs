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
public static partial class TimePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrement

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SecondIncrement

/*BindFromExpressionSetterGenerator*/
public static T SecondIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SecondIncrement<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, ps, () => control.SecondIncrement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SecondIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SecondIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SecondIncrement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, ps, () => control.SecondIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ClockIdentifier

/*BindFromExpressionSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClockIdentifier<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClockIdentifier<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UseSeconds

/*BindFromExpressionSetterGenerator*/
public static T UseSeconds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UseSeconds<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, ps, () => control.UseSeconds = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseSeconds<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseSeconds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UseSeconds<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, ps, () => control.UseSeconds = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Time

/*BindFromExpressionSetterGenerator*/
public static T Time<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Time<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.TimeProperty, ps, () => control.Time = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Time<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Time<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePickerPresenter 
   => control._set(Avalonia.Controls.TimePickerPresenter.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Time<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TimePickerPresenter 
=> control._setEx(Avalonia.Controls.TimePickerPresenter.TimeProperty, ps, () => control.Time = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // MinuteIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);


 // SecondIncrement

/*ValueStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SecondIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.SecondIncrementProperty, binding);


 // ClockIdentifier

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);


 // UseSeconds

/*ValueStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UseSeconds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.UseSecondsProperty, binding);


 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter 
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);



}
