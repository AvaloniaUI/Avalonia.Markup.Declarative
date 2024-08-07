using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RectangleExtensions
{
public static Style<Rectangle> RadiusX(this Style<Rectangle> style, Double value)
=> style._addSetter(Rectangle.RadiusXProperty, value);
public static Style<Rectangle> RadiusX(this Style<Rectangle> style, IBinding binding)
=> style._addSetter(Rectangle.RadiusXProperty, binding);
public static Style<Rectangle> RadiusY(this Style<Rectangle> style, Double value)
=> style._addSetter(Rectangle.RadiusYProperty, value);
public static Style<Rectangle> RadiusY(this Style<Rectangle> style, IBinding binding)
=> style._addSetter(Rectangle.RadiusYProperty, binding);
}

