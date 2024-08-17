using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ButtonSpinner = Avalonia.Controls.ButtonSpinner;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonSpinnerExtensions
{
public static Style<T> AllowSpin<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, value);
public static Style<T> AllowSpin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, binding);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, value);
public static Style<T> ShowButtonSpinner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, Avalonia.Controls.Location value) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, value);
public static Style<T> ButtonSpinnerLocation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
=> style._addSetter(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, binding);
}

