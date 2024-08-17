using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleButton = Avalonia.Controls.Primitives.ToggleButton;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleButtonExtensions
{
public static Style<T> IsChecked<T>(this Style<T> style, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, value);
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);
public static Style<T> IsThreeState<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, value);
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);
}

