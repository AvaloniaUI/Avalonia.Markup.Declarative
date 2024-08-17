using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleSplitButton = Avalonia.Controls.ToggleSplitButton;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleSplitButtonExtensions
{
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ToggleSplitButton
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSplitButton
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, binding);
}

