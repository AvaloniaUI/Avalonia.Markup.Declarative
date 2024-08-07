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
public static Style<Line> StartPoint(this Style<Line> style, Point value)
=> style._addSetter(Line.StartPointProperty, value);
public static Style<Line> StartPoint(this Style<Line> style, IBinding binding)
=> style._addSetter(Line.StartPointProperty, binding);
public static Style<Line> EndPoint(this Style<Line> style, Point value)
=> style._addSetter(Line.EndPointProperty, value);
public static Style<Line> EndPoint(this Style<Line> style, IBinding binding)
=> style._addSetter(Line.EndPointProperty, binding);
}

