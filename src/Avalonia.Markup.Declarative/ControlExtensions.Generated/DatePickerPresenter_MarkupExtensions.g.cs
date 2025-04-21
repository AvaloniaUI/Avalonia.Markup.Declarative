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
public static partial class DatePickerPresenter_MarkupExtensions
{
//================= Properties ======================//
 // Date

/*BindFromExpressionSetterGenerator*/
public static T Date<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Date<T>(this T control,System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Date<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Date<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Date<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayFormat

/*BindFromExpressionSetterGenerator*/
public static T DayFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayVisible

/*BindFromExpressionSetterGenerator*/
public static T DayVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DayVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DayVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DayVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DayVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxYear

/*BindFromExpressionSetterGenerator*/
public static T MaxYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxYear<T>(this T control,System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxYear<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinYear

/*BindFromExpressionSetterGenerator*/
public static T MinYear<T>(this T control, Func<System.DateTimeOffset> func, Action<System.DateTimeOffset>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinYear<T>(this T control,System.DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinYear<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinYear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinYear<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthFormat

/*BindFromExpressionSetterGenerator*/
public static T MonthFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MonthVisible

/*BindFromExpressionSetterGenerator*/
public static T MonthVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MonthVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MonthVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MonthVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MonthVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearFormat

/*BindFromExpressionSetterGenerator*/
public static T YearFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // YearVisible

/*BindFromExpressionSetterGenerator*/
public static T YearVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T YearVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T YearVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T YearVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DatePickerPresenter 
   => control._set(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T YearVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DatePickerPresenter 
=> control._setEx(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Date

/*ValueStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);


 // DayFormat

/*ValueStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);


 // DayVisible

/*ValueStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);


 // MaxYear

/*ValueStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);


 // MinYear

/*ValueStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);


 // MonthFormat

/*ValueStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);


 // MonthVisible

/*ValueStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);


 // YearFormat

/*ValueStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);


 // YearVisible

/*ValueStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter 
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);



}
