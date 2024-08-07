using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolygonExtensions
{
public static Style<Polygon> Points(this Style<Polygon> style, IList<Point> value)
=> style._addSetter(Polygon.PointsProperty, value);
public static Style<Polygon> Points(this Style<Polygon> style, IBinding binding)
=> style._addSetter(Polygon.PointsProperty, binding);
}

