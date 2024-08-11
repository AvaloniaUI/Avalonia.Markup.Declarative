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
public static Style<T> StartAngle<T>(this Style<T> style, Double value) where T : Sector
=> style._addSetter(Sector.StartAngleProperty, value);
public static Style<T> StartAngle<T>(this Style<T> style, IBinding binding) where T : Sector
=> style._addSetter(Sector.StartAngleProperty, binding);
public static Style<T> SweepAngle<T>(this Style<T> style, Double value) where T : Sector
=> style._addSetter(Sector.SweepAngleProperty, value);
public static Style<T> SweepAngle<T>(this Style<T> style, IBinding binding) where T : Sector
=> style._addSetter(Sector.SweepAngleProperty, binding);
}

