using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TrackExtensions
{
public static Style<T> Minimum<T>(this Style<T> style, Double value) where T : Track
=> style._addSetter(Track.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, Double value) where T : Track
=> style._addSetter(Track.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.MaximumProperty, binding);
public static Style<T> Value<T>(this Style<T> style, Double value) where T : Track
=> style._addSetter(Track.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.ValueProperty, binding);
public static Style<T> ViewportSize<T>(this Style<T> style, Double value) where T : Track
=> style._addSetter(Track.ViewportSizeProperty, value);
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.ViewportSizeProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : Track
=> style._addSetter(Track.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.OrientationProperty, binding);
public static Style<T> Thumb<T>(this Style<T> style, Thumb value) where T : Track
=> style._addSetter(Track.ThumbProperty, value);
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.ThumbProperty, binding);
public static Style<T> IncreaseButton<T>(this Style<T> style, Button value) where T : Track
=> style._addSetter(Track.IncreaseButtonProperty, value);
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.IncreaseButtonProperty, binding);
public static Style<T> DecreaseButton<T>(this Style<T> style, Button value) where T : Track
=> style._addSetter(Track.DecreaseButtonProperty, value);
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.DecreaseButtonProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, Boolean value) where T : Track
=> style._addSetter(Track.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.IsDirectionReversedProperty, binding);
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, Boolean value) where T : Track
=> style._addSetter(Track.IgnoreThumbDragProperty, value);
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.IgnoreThumbDragProperty, binding);
public static Style<T> DeferThumbDrag<T>(this Style<T> style, Boolean value) where T : Track
=> style._addSetter(Track.DeferThumbDragProperty, value);
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Track
=> style._addSetter(Track.DeferThumbDragProperty, binding);
}

