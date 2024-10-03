#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class DatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DayFormat

/*BindFromExpressionSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayVisible

/*BindFromExpressionSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxYear

/*BindFromExpressionSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxYear<T>(this T control,System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxYear<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinYear

/*BindFromExpressionSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinYear<T>(this T control,System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinYear<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthFormat

/*BindFromExpressionSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthVisible

/*BindFromExpressionSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearFormat

/*BindFromExpressionSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearVisible

/*BindFromExpressionSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedDate

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTimeOffset>> func, Action<System.Nullable<System.DateTimeOffset>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedDate<T>(this T control,System.Nullable<System.DateTimeOffset> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePicker 
   => control._set(Avalonia.Controls.DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTimeOffset>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePicker 
=> control._setEx(Avalonia.Controls.DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectedDateChanged

/*ActionToEventGenerator*/
public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs> action) where T : Avalonia.Controls.DatePicker  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.DatePickerSelectedValueChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker 
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);



}
