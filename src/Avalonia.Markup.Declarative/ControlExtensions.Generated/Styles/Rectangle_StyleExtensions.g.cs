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
public static Style<T> RadiusX<T>(this Style<T> style, Double value) where T : Rectangle
=> style._addSetter(Rectangle.RadiusXProperty, value);
public static Style<T> RadiusX<T>(this Style<T> style, IBinding binding) where T : Rectangle
=> style._addSetter(Rectangle.RadiusXProperty, binding);
public static Style<T> RadiusY<T>(this Style<T> style, Double value) where T : Rectangle
=> style._addSetter(Rectangle.RadiusYProperty, value);
public static Style<T> RadiusY<T>(this Style<T> style, IBinding binding) where T : Rectangle
=> style._addSetter(Rectangle.RadiusYProperty, binding);
}

