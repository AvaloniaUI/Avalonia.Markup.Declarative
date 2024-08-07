using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RadioButtonExtensions
{
public static Style<RadioButton> GroupName(this Style<RadioButton> style, String value)
=> style._addSetter(RadioButton.GroupNameProperty, value);
public static Style<RadioButton> GroupName(this Style<RadioButton> style, IBinding binding)
=> style._addSetter(RadioButton.GroupNameProperty, binding);
}

