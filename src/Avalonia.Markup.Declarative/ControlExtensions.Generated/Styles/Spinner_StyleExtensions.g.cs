using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Spinner = Avalonia.Controls.Spinner;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerExtensions
{
public static Style<T> ValidSpinDirection<T>(this Style<T> style, Avalonia.Controls.ValidSpinDirections value) where T : Avalonia.Controls.Spinner
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, value);
public static Style<T> ValidSpinDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Spinner
=> style._addSetter(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);
}

