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
public static Style<T> Date<T>(this Style<T> style, DateTimeOffset value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DateProperty, value);
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DateProperty, binding);
public static Style<T> DayFormat<T>(this Style<T> style, String value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DayFormatProperty, value);
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DayFormatProperty, binding);
public static Style<T> DayVisible<T>(this Style<T> style, Boolean value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DayVisibleProperty, value);
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.DayVisibleProperty, binding);
public static Style<T> MaxYear<T>(this Style<T> style, DateTimeOffset value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MaxYearProperty, value);
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MaxYearProperty, binding);
public static Style<T> MinYear<T>(this Style<T> style, DateTimeOffset value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MinYearProperty, value);
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MinYearProperty, binding);
public static Style<T> MonthFormat<T>(this Style<T> style, String value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MonthFormatProperty, value);
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MonthFormatProperty, binding);
public static Style<T> MonthVisible<T>(this Style<T> style, Boolean value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MonthVisibleProperty, value);
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.MonthVisibleProperty, binding);
public static Style<T> YearFormat<T>(this Style<T> style, String value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.YearFormatProperty, value);
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.YearFormatProperty, binding);
public static Style<T> YearVisible<T>(this Style<T> style, Boolean value) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.YearVisibleProperty, value);
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : DatePickerPresenter
=> style._addSetter(DatePickerPresenter.YearVisibleProperty, binding);
}

