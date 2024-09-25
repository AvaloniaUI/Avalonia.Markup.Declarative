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
public static partial class DatePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // DateProperty

/*BindFromExpressionSetterGenerator*/
public static T Date<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Date<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Date<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Date<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Date<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayFormatProperty

/*BindFromExpressionSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayVisibleProperty

/*BindFromExpressionSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxYearProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinYearProperty

/*BindFromExpressionSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinYear<T>(this T control, System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinYear<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthFormatProperty

/*BindFromExpressionSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthVisibleProperty

/*BindFromExpressionSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearFormatProperty

/*BindFromExpressionSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearFormat<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearFormat<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearVisibleProperty

/*BindFromExpressionSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // DateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);


 // DayFormatProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);


 // DayVisibleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);


 // MaxYearProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);


 // MinYearProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);


 // MonthFormatProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);


 // MonthVisibleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);


 // YearFormatProperty

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);


 // YearVisibleProperty

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);



}
