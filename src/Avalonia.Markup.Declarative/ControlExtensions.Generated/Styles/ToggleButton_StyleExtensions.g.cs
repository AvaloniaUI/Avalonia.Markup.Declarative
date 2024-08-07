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
public static Style<ToggleButton> IsChecked(this Style<ToggleButton> style, Nullable<Boolean> value)
=> style._addSetter(ToggleButton.IsCheckedProperty, value);
public static Style<ToggleButton> IsChecked(this Style<ToggleButton> style, IBinding binding)
=> style._addSetter(ToggleButton.IsCheckedProperty, binding);
public static Style<ToggleButton> IsThreeState(this Style<ToggleButton> style, Boolean value)
=> style._addSetter(ToggleButton.IsThreeStateProperty, value);
public static Style<ToggleButton> IsThreeState(this Style<ToggleButton> style, IBinding binding)
=> style._addSetter(ToggleButton.IsThreeStateProperty, binding);
}

