using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Polygon = Avalonia.Controls.Shapes.Polygon;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolygonExtensions
{
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polygon
=> style._addSetter(Avalonia.Controls.Shapes.Polygon.PointsProperty, value);
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polygon
=> style._addSetter(Avalonia.Controls.Shapes.Polygon.PointsProperty, binding);
}

