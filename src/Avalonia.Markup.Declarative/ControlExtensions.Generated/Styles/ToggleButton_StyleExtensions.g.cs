using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleButtonExtensions
{
public static Style<T> IsChecked<T>(this Style<T> style, Nullable<Boolean> value) where T : ToggleButton
=> style._addSetter(ToggleButton.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : ToggleButton
=> style._addSetter(ToggleButton.IsCheckedProperty, binding);
public static Style<T> IsThreeState<T>(this Style<T> style, Boolean value) where T : ToggleButton
=> style._addSetter(ToggleButton.IsThreeStateProperty, value);
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : ToggleButton
=> style._addSetter(ToggleButton.IsThreeStateProperty, binding);
}

