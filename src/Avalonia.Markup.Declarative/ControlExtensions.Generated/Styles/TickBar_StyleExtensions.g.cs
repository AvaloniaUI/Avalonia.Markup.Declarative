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
public static Style<T> Fill<T>(this Style<T> style, IBrush value) where T : TickBar
=> style._addSetter(TickBar.FillProperty, value);
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.FillProperty, binding);
public static Style<T> Minimum<T>(this Style<T> style, Double value) where T : TickBar
=> style._addSetter(TickBar.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, Double value) where T : TickBar
=> style._addSetter(TickBar.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.MaximumProperty, binding);
public static Style<T> TickFrequency<T>(this Style<T> style, Double value) where T : TickBar
=> style._addSetter(TickBar.TickFrequencyProperty, value);
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.TickFrequencyProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : TickBar
=> style._addSetter(TickBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.OrientationProperty, binding);
public static Style<T> Ticks<T>(this Style<T> style, AvaloniaList<Double> value) where T : TickBar
=> style._addSetter(TickBar.TicksProperty, value);
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.TicksProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, Boolean value) where T : TickBar
=> style._addSetter(TickBar.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.IsDirectionReversedProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, TickBarPlacement value) where T : TickBar
=> style._addSetter(TickBar.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.PlacementProperty, binding);
public static Style<T> ReservedSpace<T>(this Style<T> style, Rect value) where T : TickBar
=> style._addSetter(TickBar.ReservedSpaceProperty, value);
public static Style<T> ReservedSpace<T>(this Style<T> style, IBinding binding) where T : TickBar
=> style._addSetter(TickBar.ReservedSpaceProperty, binding);

public static Style<T> ReservedSpace<T>(this Style<T> style, Double x, Double y, Double width, Double height) where T : TickBar
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(x, y, width, height));
public static Style<T> ReservedSpace<T>(this Style<T> style, Size size) where T : TickBar
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(size));
public static Style<T> ReservedSpace<T>(this Style<T> style, Point position, Size size) where T : TickBar
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(position, size));
public static Style<T> ReservedSpace<T>(this Style<T> style, Point topLeft, Point bottomRight) where T : TickBar
   => style._addSetter(TickBar.ReservedSpaceProperty, new Rect(topLeft, bottomRight));
}

