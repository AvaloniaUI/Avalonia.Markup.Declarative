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
public static Style<ToggleSplitButton> IsChecked(this Style<ToggleSplitButton> style, Boolean value)
=> style._addSetter(ToggleSplitButton.IsCheckedProperty, value);
public static Style<ToggleSplitButton> IsChecked(this Style<ToggleSplitButton> style, IBinding binding)
=> style._addSetter(ToggleSplitButton.IsCheckedProperty, binding);
}

