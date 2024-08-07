using Avalonia.Controls.Shapes;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SectorExtensions
{
public static Style<Sector> StartAngle(this Style<Sector> style, Double value)
=> style._addSetter(Sector.StartAngleProperty, value);
public static Style<Sector> StartAngle(this Style<Sector> style, IBinding binding)
=> style._addSetter(Sector.StartAngleProperty, binding);
public static Style<Sector> SweepAngle(this Style<Sector> style, Double value)
=> style._addSetter(Sector.SweepAngleProperty, value);
public static Style<Sector> SweepAngle(this Style<Sector> style, IBinding binding)
=> style._addSetter(Sector.SweepAngleProperty, binding);
}

