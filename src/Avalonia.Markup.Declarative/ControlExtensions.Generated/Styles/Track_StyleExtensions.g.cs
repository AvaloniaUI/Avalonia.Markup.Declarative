using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using Track = Avalonia.Controls.Primitives.Track;

namespace Avalonia.Markup.Declarative;
public static partial class TrackExtensions
{
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, value);
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, value);
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, value);
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, binding);
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, value);
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);
public static Style<T> Thumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, value);
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);
public static Style<T> IncreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, value);
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);
public static Style<T> DecreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, value);
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, value);
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);
public static Style<T> DeferThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, value);
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);
}

