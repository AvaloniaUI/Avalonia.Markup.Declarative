using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSplitButtonExtensions
{
public static Style<T> IsChecked<T>(this Style<T> style, Boolean value) where T : ToggleSplitButton
=> style._addSetter(ToggleSplitButton.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : ToggleSplitButton
=> style._addSetter(ToggleSplitButton.IsCheckedProperty, binding);
}

