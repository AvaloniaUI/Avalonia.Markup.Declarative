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
public static Style<ButtonSpinner> AllowSpin(this Style<ButtonSpinner> style, Boolean value)
=> style._addSetter(ButtonSpinner.AllowSpinProperty, value);
public static Style<ButtonSpinner> AllowSpin(this Style<ButtonSpinner> style, IBinding binding)
=> style._addSetter(ButtonSpinner.AllowSpinProperty, binding);
public static Style<ButtonSpinner> ShowButtonSpinner(this Style<ButtonSpinner> style, Boolean value)
=> style._addSetter(ButtonSpinner.ShowButtonSpinnerProperty, value);
public static Style<ButtonSpinner> ShowButtonSpinner(this Style<ButtonSpinner> style, IBinding binding)
=> style._addSetter(ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static Style<ButtonSpinner> ButtonSpinnerLocation(this Style<ButtonSpinner> style, Location value)
=> style._addSetter(ButtonSpinner.ButtonSpinnerLocationProperty, value);
public static Style<ButtonSpinner> ButtonSpinnerLocation(this Style<ButtonSpinner> style, IBinding binding)
=> style._addSetter(ButtonSpinner.ButtonSpinnerLocationProperty, binding);
}

