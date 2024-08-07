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
public static Style<Label> Target(this Style<Label> style, IInputElement value)
=> style._addSetter(Label.TargetProperty, value);
public static Style<Label> Target(this Style<Label> style, IBinding binding)
=> style._addSetter(Label.TargetProperty, binding);
}

