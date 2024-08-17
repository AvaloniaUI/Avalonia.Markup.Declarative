using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Sector = Avalonia.Controls.Shapes.Sector;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SectorExtensions
{
public static Style<T> StartAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty, value);
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector
=> style._addSetter(Avalonia.Controls.Shapes.Sector.StartAngleProperty, binding);
public static Style<T> SweepAngle<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Shapes.Sector
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, value);
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Shapes.Sector
=> style._addSetter(Avalonia.Controls.Shapes.Sector.SweepAngleProperty, binding);
}

