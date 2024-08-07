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
public static Style<DatePicker> DayFormat(this Style<DatePicker> style, String value)
=> style._addSetter(DatePicker.DayFormatProperty, value);
public static Style<DatePicker> DayFormat(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.DayFormatProperty, binding);
public static Style<DatePicker> DayVisible(this Style<DatePicker> style, Boolean value)
=> style._addSetter(DatePicker.DayVisibleProperty, value);
public static Style<DatePicker> DayVisible(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.DayVisibleProperty, binding);
public static Style<DatePicker> MaxYear(this Style<DatePicker> style, DateTimeOffset value)
=> style._addSetter(DatePicker.MaxYearProperty, value);
public static Style<DatePicker> MaxYear(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.MaxYearProperty, binding);
public static Style<DatePicker> MinYear(this Style<DatePicker> style, DateTimeOffset value)
=> style._addSetter(DatePicker.MinYearProperty, value);
public static Style<DatePicker> MinYear(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.MinYearProperty, binding);
public static Style<DatePicker> MonthFormat(this Style<DatePicker> style, String value)
=> style._addSetter(DatePicker.MonthFormatProperty, value);
public static Style<DatePicker> MonthFormat(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.MonthFormatProperty, binding);
public static Style<DatePicker> MonthVisible(this Style<DatePicker> style, Boolean value)
=> style._addSetter(DatePicker.MonthVisibleProperty, value);
public static Style<DatePicker> MonthVisible(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.MonthVisibleProperty, binding);
public static Style<DatePicker> YearFormat(this Style<DatePicker> style, String value)
=> style._addSetter(DatePicker.YearFormatProperty, value);
public static Style<DatePicker> YearFormat(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.YearFormatProperty, binding);
public static Style<DatePicker> YearVisible(this Style<DatePicker> style, Boolean value)
=> style._addSetter(DatePicker.YearVisibleProperty, value);
public static Style<DatePicker> YearVisible(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.YearVisibleProperty, binding);
public static Style<DatePicker> SelectedDate(this Style<DatePicker> style, Nullable<DateTimeOffset> value)
=> style._addSetter(DatePicker.SelectedDateProperty, value);
public static Style<DatePicker> SelectedDate(this Style<DatePicker> style, IBinding binding)
=> style._addSetter(DatePicker.SelectedDateProperty, binding);
}

