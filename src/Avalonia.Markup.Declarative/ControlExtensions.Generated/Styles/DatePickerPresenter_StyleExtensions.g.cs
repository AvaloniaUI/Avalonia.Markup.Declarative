using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DatePickerPresenter = Avalonia.Controls.DatePickerPresenter;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerPresenterExtensions
{
public static Style<T> Date<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, value);
public static Style<T> Date<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DateProperty, binding);
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, value);
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayFormatProperty, binding);
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, value);
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.DayVisibleProperty, binding);
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, value);
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MaxYearProperty, binding);
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, value);
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MinYearProperty, binding);
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, value);
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthFormatProperty, binding);
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, value);
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.MonthVisibleProperty, binding);
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, value);
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearFormatProperty, binding);
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, value);
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePickerPresenter
=> style._addSetter(Avalonia.Controls.DatePickerPresenter.YearVisibleProperty, binding);
}

