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
public static Style<Spinner> ValidSpinDirection(this Style<Spinner> style, ValidSpinDirections value)
=> style._addSetter(Spinner.ValidSpinDirectionProperty, value);
public static Style<Spinner> ValidSpinDirection(this Style<Spinner> style, IBinding binding)
=> style._addSetter(Spinner.ValidSpinDirectionProperty, binding);
}

