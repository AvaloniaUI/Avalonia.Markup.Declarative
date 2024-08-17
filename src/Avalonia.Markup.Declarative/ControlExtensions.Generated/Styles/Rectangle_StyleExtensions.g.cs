using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Rectangle = Avalonia.Controls.Shapes.Rectangle;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RectangleExtensions
{
public static Style<T> RadiusX<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, value);
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusXProperty, binding);
public static Style<T> RadiusY<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Rectangle
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, value);
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Rectangle
=> style._addSetter(Avalonia.Controls.Shapes.Rectangle.RadiusYProperty, binding);
}

