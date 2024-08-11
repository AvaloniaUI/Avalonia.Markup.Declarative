using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerExtensions
{
public static Style<T> ValidSpinDirection<T>(this Style<T> style, ValidSpinDirections value) where T : Spinner
=> style._addSetter(Spinner.ValidSpinDirectionProperty, value);
public static Style<T> ValidSpinDirection<T>(this Style<T> style, IBinding binding) where T : Spinner
=> style._addSetter(Spinner.ValidSpinDirectionProperty, binding);
}

