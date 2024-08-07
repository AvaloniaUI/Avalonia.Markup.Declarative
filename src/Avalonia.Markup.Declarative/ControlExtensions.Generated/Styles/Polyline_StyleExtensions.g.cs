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
public static partial class PolylineExtensions
{
public static Style<Polyline> Points(this Style<Polyline> style, IList<Point> value)
=> style._addSetter(Polyline.PointsProperty, value);
public static Style<Polyline> Points(this Style<Polyline> style, IBinding binding)
=> style._addSetter(Polyline.PointsProperty, binding);
}

