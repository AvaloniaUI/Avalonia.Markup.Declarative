using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using RadioButton = Avalonia.Controls.RadioButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RadioButtonExtensions
{
public static Style<T> GroupName<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.RadioButton
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty, value);
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RadioButton
=> style._addSetter(Avalonia.Controls.RadioButton.GroupNameProperty, binding);
}

