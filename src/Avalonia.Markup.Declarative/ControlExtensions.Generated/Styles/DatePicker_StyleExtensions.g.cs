using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DatePicker = Avalonia.Controls.DatePicker;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DatePickerExtensions
{
public static Style<T> DayFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, value);
public static Style<T> DayFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.DayFormatProperty, binding);
public static Style<T> DayVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, value);
public static Style<T> DayVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.DayVisibleProperty, binding);
public static Style<T> MaxYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, value);
public static Style<T> MaxYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MaxYearProperty, binding);
public static Style<T> MinYear<T>(this Style<T> style, System.DateTimeOffset value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, value);
public static Style<T> MinYear<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MinYearProperty, binding);
public static Style<T> MonthFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, value);
public static Style<T> MonthFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MonthFormatProperty, binding);
public static Style<T> MonthVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, value);
public static Style<T> MonthVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.MonthVisibleProperty, binding);
public static Style<T> YearFormat<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, value);
public static Style<T> YearFormat<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.YearFormatProperty, binding);
public static Style<T> YearVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, value);
public static Style<T> YearVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.YearVisibleProperty, binding);
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTimeOffset> value) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, value);
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DatePicker
=> style._addSetter(Avalonia.Controls.DatePicker.SelectedDateProperty, binding);
}

