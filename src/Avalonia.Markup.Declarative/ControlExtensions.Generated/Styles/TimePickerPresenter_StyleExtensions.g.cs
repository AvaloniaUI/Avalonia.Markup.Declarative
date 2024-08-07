using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerPresenterExtensions
{
public static Style<TimePickerPresenter> MinuteIncrement(this Style<TimePickerPresenter> style, Int32 value)
=> style._addSetter(TimePickerPresenter.MinuteIncrementProperty, value);
public static Style<TimePickerPresenter> MinuteIncrement(this Style<TimePickerPresenter> style, IBinding binding)
=> style._addSetter(TimePickerPresenter.MinuteIncrementProperty, binding);
public static Style<TimePickerPresenter> ClockIdentifier(this Style<TimePickerPresenter> style, String value)
=> style._addSetter(TimePickerPresenter.ClockIdentifierProperty, value);
public static Style<TimePickerPresenter> ClockIdentifier(this Style<TimePickerPresenter> style, IBinding binding)
=> style._addSetter(TimePickerPresenter.ClockIdentifierProperty, binding);
public static Style<TimePickerPresenter> Time(this Style<TimePickerPresenter> style, TimeSpan value)
=> style._addSetter(TimePickerPresenter.TimeProperty, value);
public static Style<TimePickerPresenter> Time(this Style<TimePickerPresenter> style, IBinding binding)
=> style._addSetter(TimePickerPresenter.TimeProperty, binding);
}

