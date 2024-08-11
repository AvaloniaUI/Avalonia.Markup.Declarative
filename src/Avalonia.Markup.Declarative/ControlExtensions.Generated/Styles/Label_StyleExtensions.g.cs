using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LabelExtensions
{
public static Style<T> Target<T>(this Style<T> style, IInputElement value) where T : Label
=> style._addSetter(Label.TargetProperty, value);
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Label
=> style._addSetter(Label.TargetProperty, binding);
}

