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
public static Style<T> Points<T>(this Style<T> style, IList<Point> value) where T : Polygon
=> style._addSetter(Polygon.PointsProperty, value);
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Polygon
=> style._addSetter(Polygon.PointsProperty, binding);
}

