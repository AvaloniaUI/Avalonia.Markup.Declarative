using Avalonia;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TickBarExtensions
{
public static Style<TickBar> Fill(this Style<TickBar> style, IBrush value)
=> style._addSetter(TickBar.FillProperty, value);
public static Style<TickBar> Fill(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.FillProperty, binding);
public static Style<TickBar> Minimum(this Style<TickBar> style, Double value)
=> style._addSetter(TickBar.MinimumProperty, value);
public static Style<TickBar> Minimum(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.MinimumProperty, binding);
public static Style<TickBar> Maximum(this Style<TickBar> style, Double value)
=> style._addSetter(TickBar.MaximumProperty, value);
public static Style<TickBar> Maximum(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.MaximumProperty, binding);
public static Style<TickBar> TickFrequency(this Style<TickBar> style, Double value)
=> style._addSetter(TickBar.TickFrequencyProperty, value);
public static Style<TickBar> TickFrequency(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.TickFrequencyProperty, binding);
public static Style<TickBar> Orientation(this Style<TickBar> style, Orientation value)
=> style._addSetter(TickBar.OrientationProperty, value);
public static Style<TickBar> Orientation(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.OrientationProperty, binding);
public static Style<TickBar> Ticks(this Style<TickBar> style, AvaloniaList<Double> value)
=> style._addSetter(TickBar.TicksProperty, value);
public static Style<TickBar> Ticks(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.TicksProperty, binding);
public static Style<TickBar> IsDirectionReversed(this Style<TickBar> style, Boolean value)
=> style._addSetter(TickBar.IsDirectionReversedProperty, value);
public static Style<TickBar> IsDirectionReversed(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.IsDirectionReversedProperty, binding);
public static Style<TickBar> Placement(this Style<TickBar> style, TickBarPlacement value)
=> style._addSetter(TickBar.PlacementProperty, value);
public static Style<TickBar> Placement(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.PlacementProperty, binding);
public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Rect value)
=> style._addSetter(TickBar.ReservedSpaceProperty, value);
public static Style<TickBar> ReservedSpace(this Style<TickBar> style, IBinding binding)
=> style._addSetter(TickBar.ReservedSpaceProperty, binding);

public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Double x, Double y, Double width, Double height)
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(x, y, width, height));
public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Size size)
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(size));
public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Point position, Size size)
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(position, size));
public static Style<TickBar> ReservedSpace(this Style<TickBar> style, Point topLeft, Point bottomRight)
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(topLeft, bottomRight));
}

