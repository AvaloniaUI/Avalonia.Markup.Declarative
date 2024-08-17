using Avalonia;
using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Polyline = Avalonia.Controls.Shapes.Polyline;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PolylineExtensions
{
public static Style<T> Points<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Point> value) where T : Avalonia.Controls.Shapes.Polyline
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, value);
public static Style<T> Points<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Polyline
=> style._addSetter(Avalonia.Controls.Shapes.Polyline.PointsProperty, binding);
}

