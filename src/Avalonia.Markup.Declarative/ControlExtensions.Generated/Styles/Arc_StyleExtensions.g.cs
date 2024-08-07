using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ArcExtensions
{
public static Style<Arc> StartAngle(this Style<Arc> style, Double value)
=> style._addSetter(Arc.StartAngleProperty, value);
public static Style<Arc> StartAngle(this Style<Arc> style, IBinding binding)
=> style._addSetter(Arc.StartAngleProperty, binding);
public static Style<Arc> SweepAngle(this Style<Arc> style, Double value)
=> style._addSetter(Arc.SweepAngleProperty, value);
public static Style<Arc> SweepAngle(this Style<Arc> style, IBinding binding)
=> style._addSetter(Arc.SweepAngleProperty, binding);
}

