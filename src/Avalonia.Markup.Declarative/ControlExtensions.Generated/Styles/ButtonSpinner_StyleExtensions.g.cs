using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonSpinnerExtensions
{
public static Style<T> AllowSpin<T>(this Style<T> style, Boolean value) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.AllowSpinProperty, value);
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.AllowSpinProperty, binding);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, Boolean value) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.ShowButtonSpinnerProperty, value);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Location value) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.ButtonSpinnerLocationProperty, value);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : ButtonSpinner
=> style._addSetter(ButtonSpinner.ButtonSpinnerLocationProperty, binding);
}

