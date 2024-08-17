using Arc = Avalonia.Controls.Shapes.Arc;
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
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty, value);
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc
=> style._addSetter(Avalonia.Controls.Shapes.Arc.StartAngleProperty, binding);
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Arc
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, value);
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Arc
=> style._addSetter(Avalonia.Controls.Shapes.Arc.SweepAngleProperty, binding);
}

