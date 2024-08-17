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
using TickBar = Avalonia.Controls.TickBar;

namespace Avalonia.Markup.Declarative;
public static partial class TickBarExtensions
{
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, value);
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, binding);
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, binding);
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, value);
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, binding);
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, value);
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, binding);
public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Rect value) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, value);
public static Style<T> ReservedSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);

public static Style<T> ReservedSpace<T>(this Style<T> style, Double x, Double y, Double width, Double height) where T : Avalonia.Controls.TickBar
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(x, y, width, height));
public static Style<T> ReservedSpace<T>(this Style<T> style, Size size) where T : Avalonia.Controls.TickBar
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(size));
public static Style<T> ReservedSpace<T>(this Style<T> style, Point position, Size size) where T : Avalonia.Controls.TickBar
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(position, size));
public static Style<T> ReservedSpace<T>(this Style<T> style, Point topLeft, Point bottomRight) where T : Avalonia.Controls.TickBar
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(topLeft, bottomRight));
}

