using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerExtensions
{
public static Style<T> DayFormat<T>(this Style<T> style, String value) where T : DatePicker
=> style._addSetter(DatePicker.DayFormatProperty, value);
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.DayFormatProperty, binding);
public static Style<T> DayVisible<T>(this Style<T> style, Boolean value) where T : DatePicker
=> style._addSetter(DatePicker.DayVisibleProperty, value);
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.DayVisibleProperty, binding);
public static Style<T> MaxYear<T>(this Style<T> style, DateTimeOffset value) where T : DatePicker
=> style._addSetter(DatePicker.MaxYearProperty, value);
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.MaxYearProperty, binding);
public static Style<T> MinYear<T>(this Style<T> style, DateTimeOffset value) where T : DatePicker
=> style._addSetter(DatePicker.MinYearProperty, value);
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.MinYearProperty, binding);
public static Style<T> MonthFormat<T>(this Style<T> style, String value) where T : DatePicker
=> style._addSetter(DatePicker.MonthFormatProperty, value);
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.MonthFormatProperty, binding);
public static Style<T> MonthVisible<T>(this Style<T> style, Boolean value) where T : DatePicker
=> style._addSetter(DatePicker.MonthVisibleProperty, value);
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.MonthVisibleProperty, binding);
public static Style<T> YearFormat<T>(this Style<T> style, String value) where T : DatePicker
=> style._addSetter(DatePicker.YearFormatProperty, value);
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.YearFormatProperty, binding);
public static Style<T> YearVisible<T>(this Style<T> style, Boolean value) where T : DatePicker
=> style._addSetter(DatePicker.YearVisibleProperty, value);
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.YearVisibleProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, Nullable<DateTimeOffset> value) where T : DatePicker
=> style._addSetter(DatePicker.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : DatePicker
=> style._addSetter(DatePicker.SelectedDateProperty, binding);
}

