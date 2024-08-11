using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LineExtensions
{
public static Style<T> StartPoint<T>(this Style<T> style, Point value) where T : Line
=> style._addSetter(Line.StartPointProperty, value);
public static Style<T> StartPoint<T>(this Style<T> style, IBinding binding) where T : Line
=> style._addSetter(Line.StartPointProperty, binding);
public static Style<T> EndPoint<T>(this Style<T> style, Point value) where T : Line
=> style._addSetter(Line.EndPointProperty, value);
public static Style<T> EndPoint<T>(this Style<T> style, IBinding binding) where T : Line
=> style._addSetter(Line.EndPointProperty, binding);
}

