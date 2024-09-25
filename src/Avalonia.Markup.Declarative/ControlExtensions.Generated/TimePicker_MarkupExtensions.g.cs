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
public static partial class TimePicker_MarkupExtensions
{
//================= Properties ======================//
 // MinuteIncrementProperty

/*BindFromExpressionSetterGenerator*/
public static T MinuteIncrement<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinuteIncrement<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinuteIncrement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinuteIncrement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ClockIdentifierProperty

/*BindFromExpressionSetterGenerator*/
public static T ClockIdentifier<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClockIdentifier<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClockIdentifier<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClockIdentifier<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedTimeProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedTime<T>(this T control, Func<System.Nullable<System.TimeSpan>> func, Action<System.Nullable<System.TimeSpan>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedTime<T>(this T control, System.Nullable<System.TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedTime<T>(this T control, IBinding binding) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedTime<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TimePicker
   => control._set(Avalonia.Controls.TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedTime<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TimePicker
=> control._setEx(Avalonia.Controls.TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // SelectedTimeChanged

/*ActionToEventGenerator*/
    public static T OnSelectedTimeChanged<T>(this T control, Action<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.TimePicker => 
        control._setEvent((System.EventHandler<Avalonia.Controls.TimePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedTimeChanged += h);



//================= Styles ======================//
 // MinuteIncrementProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.MinuteIncrementProperty, binding);


 // ClockIdentifierProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.ClockIdentifierProperty, binding);


 // SelectedTimeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, System.Nullable<System.TimeSpan> value) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedTime<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePicker
=> style._addSetter(Avalonia.Controls.TimePicker.SelectedTimeProperty, binding);



}
