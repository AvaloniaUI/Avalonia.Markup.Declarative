using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PullGestureRecognizerExtensions
{
public static Style<PullGestureRecognizer> PullDirection(this Style<PullGestureRecognizer> style, PullDirection value)
=> style._addSetter(PullGestureRecognizer.PullDirectionProperty, value);
public static Style<PullGestureRecognizer> PullDirection(this Style<PullGestureRecognizer> style, IBinding binding)
=> style._addSetter(PullGestureRecognizer.PullDirectionProperty, binding);
}

