using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TimePickerPresenter = Avalonia.Controls.TimePickerPresenter;

namespace Avalonia.Markup.Declarative;
public static partial class TimePickerPresenterExtensions
{
public static Style<T> MinuteIncrement<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, value);
public static Style<T> MinuteIncrement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.MinuteIncrementProperty, binding);
public static Style<T> ClockIdentifier<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, value);
public static Style<T> ClockIdentifier<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.ClockIdentifierProperty, binding);
public static Style<T> Time<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, value);
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TimePickerPresenter
=> style._addSetter(Avalonia.Controls.TimePickerPresenter.TimeProperty, binding);
}

