using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Label = Avalonia.Controls.Label;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LabelExtensions
{
public static Style<T> Target<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Label
=> style._addSetter(Avalonia.Controls.Label.TargetProperty, value);
public static Style<T> Target<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Label
=> style._addSetter(Avalonia.Controls.Label.TargetProperty, binding);
}

