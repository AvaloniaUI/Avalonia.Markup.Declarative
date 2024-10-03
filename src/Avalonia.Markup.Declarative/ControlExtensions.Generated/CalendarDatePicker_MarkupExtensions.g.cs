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
public static partial class CalendarDatePicker_MarkupExtensions
{
//================= Properties ======================//
 // DisplayDate

/*BindFromExpressionSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDate<T>(this T control,System.DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDateStart

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDateStart<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDateStart<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDateEnd

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDateEnd<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDateEnd<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FirstDayOfWeek

/*BindFromExpressionSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control,System.DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FirstDayOfWeek<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDropDownOpen

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDropDownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDropDownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTodayHighlighted

/*BindFromExpressionSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTodayHighlighted<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedDate

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedDate<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedDateFormat

/*BindFromExpressionSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, Func<Avalonia.Controls.CalendarDatePickerFormat> func, Action<Avalonia.Controls.CalendarDatePickerFormat>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedDateFormat<T>(this T control,Avalonia.Controls.CalendarDatePickerFormat value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDateFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedDateFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarDatePickerFormat> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CustomDateFormatString

/*BindFromExpressionSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CustomDateFormatString<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CustomDateFormatString<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CustomDateFormatString<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Watermark

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UseFloatingWatermark

/*BindFromExpressionSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseFloatingWatermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UseFloatingWatermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.CalendarDatePicker 
   => control._set(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.CalendarDatePicker 
=> control._setEx(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // CalendarClosed

/*ActionToEventGenerator*/
    public static T OnCalendarClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarClosed += h);


 // CalendarOpened

/*ActionToEventGenerator*/
    public static T OnCalendarOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.CalendarOpened += h);


 // DateValidationError

/*ActionToEventGenerator*/
    public static T OnDateValidationError<T>(this T control, Action<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDatePickerDateValidationErrorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DateValidationError += h);


 // SelectedDateChanged

/*ActionToEventGenerator*/
    public static T OnSelectedDateChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.CalendarDatePicker => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDateChanged += h);



//================= Styles ======================//
 // DisplayDate

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateProperty, binding);


 // DisplayDateStart

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateStartProperty, binding);


 // DisplayDateEnd

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.DisplayDateEndProperty, binding);


 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.FirstDayOfWeekProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsDropDownOpenProperty, binding);


 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.IsTodayHighlightedProperty, binding);


 // SelectedDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateProperty, binding);


 // SelectedDateFormat

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, Avalonia.Controls.CalendarDatePickerFormat value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDateFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.SelectedDateFormatProperty, binding);


 // CustomDateFormatString

/*ValueStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CustomDateFormatString<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.CustomDateFormatStringProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.TextProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.WatermarkProperty, binding);


 // UseFloatingWatermark

/*ValueStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UseFloatingWatermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.UseFloatingWatermarkProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.CalendarDatePicker 
=> style._addSetter(Avalonia.Controls.CalendarDatePicker.VerticalContentAlignmentProperty, binding);



}
