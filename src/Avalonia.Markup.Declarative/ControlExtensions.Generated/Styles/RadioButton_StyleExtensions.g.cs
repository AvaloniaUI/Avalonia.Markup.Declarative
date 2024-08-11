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
public static Style<T> GroupName<T>(this Style<T> style, String value) where T : RadioButton
=> style._addSetter(RadioButton.GroupNameProperty, value);
public static Style<T> GroupName<T>(this Style<T> style, IBinding binding) where T : RadioButton
=> style._addSetter(RadioButton.GroupNameProperty, binding);
}

