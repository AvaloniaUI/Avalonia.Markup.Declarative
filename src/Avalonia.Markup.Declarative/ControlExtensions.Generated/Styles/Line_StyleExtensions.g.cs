using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Line = Avalonia.Controls.Shapes.Line;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LineExtensions
{
public static Style<T> StartPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, value);
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line
=> style._addSetter(Avalonia.Controls.Shapes.Line.StartPointProperty, binding);
public static Style<T> EndPoint<T>(this Style<T> style, Avalonia.Point value) where T : Avalonia.Controls.Shapes.Line
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, value);
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Line
=> style._addSetter(Avalonia.Controls.Shapes.Line.EndPointProperty, binding);
}

