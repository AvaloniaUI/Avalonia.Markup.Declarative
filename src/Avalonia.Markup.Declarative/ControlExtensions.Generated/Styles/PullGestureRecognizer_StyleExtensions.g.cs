using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using PullGestureRecognizer = Avalonia.Input.PullGestureRecognizer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PullGestureRecognizerExtensions
{
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Input.PullGestureRecognizer
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, value);
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Input.PullGestureRecognizer
=> style._addSetter(Avalonia.Input.PullGestureRecognizer.PullDirectionProperty, binding);
}

