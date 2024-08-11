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
public static Style<T> MinuteIncrement<T>(this Style<T> style, Int32 value) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.MinuteIncrementProperty, value);
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.MinuteIncrementProperty, binding);
public static Style<T> ClockIdentifier<T>(this Style<T> style, String value) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.ClockIdentifierProperty, value);
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.ClockIdentifierProperty, binding);
public static Style<T> Time<T>(this Style<T> style, TimeSpan value) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.TimeProperty, value);
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : TimePickerPresenter
=> style._addSetter(TimePickerPresenter.TimeProperty, binding);
}

