using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerPresenterExtensions
{
public static Style<DatePickerPresenter> Date(this Style<DatePickerPresenter> style, DateTimeOffset value)
=> style._addSetter(DatePickerPresenter.DateProperty, value);
public static Style<DatePickerPresenter> Date(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.DateProperty, binding);
public static Style<DatePickerPresenter> DayFormat(this Style<DatePickerPresenter> style, String value)
=> style._addSetter(DatePickerPresenter.DayFormatProperty, value);
public static Style<DatePickerPresenter> DayFormat(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.DayFormatProperty, binding);
public static Style<DatePickerPresenter> DayVisible(this Style<DatePickerPresenter> style, Boolean value)
=> style._addSetter(DatePickerPresenter.DayVisibleProperty, value);
public static Style<DatePickerPresenter> DayVisible(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.DayVisibleProperty, binding);
public static Style<DatePickerPresenter> MaxYear(this Style<DatePickerPresenter> style, DateTimeOffset value)
=> style._addSetter(DatePickerPresenter.MaxYearProperty, value);
public static Style<DatePickerPresenter> MaxYear(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.MaxYearProperty, binding);
public static Style<DatePickerPresenter> MinYear(this Style<DatePickerPresenter> style, DateTimeOffset value)
=> style._addSetter(DatePickerPresenter.MinYearProperty, value);
public static Style<DatePickerPresenter> MinYear(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.MinYearProperty, binding);
public static Style<DatePickerPresenter> MonthFormat(this Style<DatePickerPresenter> style, String value)
=> style._addSetter(DatePickerPresenter.MonthFormatProperty, value);
public static Style<DatePickerPresenter> MonthFormat(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.MonthFormatProperty, binding);
public static Style<DatePickerPresenter> MonthVisible(this Style<DatePickerPresenter> style, Boolean value)
=> style._addSetter(DatePickerPresenter.MonthVisibleProperty, value);
public static Style<DatePickerPresenter> MonthVisible(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.MonthVisibleProperty, binding);
public static Style<DatePickerPresenter> YearFormat(this Style<DatePickerPresenter> style, String value)
=> style._addSetter(DatePickerPresenter.YearFormatProperty, value);
public static Style<DatePickerPresenter> YearFormat(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.YearFormatProperty, binding);
public static Style<DatePickerPresenter> YearVisible(this Style<DatePickerPresenter> style, Boolean value)
=> style._addSetter(DatePickerPresenter.YearVisibleProperty, value);
public static Style<DatePickerPresenter> YearVisible(this Style<DatePickerPresenter> style, IBinding binding)
=> style._addSetter(DatePickerPresenter.YearVisibleProperty, binding);
}

