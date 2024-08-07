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
public static Style<Track> Minimum(this Style<Track> style, Double value)
=> style._addSetter(Track.MinimumProperty, value);
public static Style<Track> Minimum(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.MinimumProperty, binding);
public static Style<Track> Maximum(this Style<Track> style, Double value)
=> style._addSetter(Track.MaximumProperty, value);
public static Style<Track> Maximum(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.MaximumProperty, binding);
public static Style<Track> Value(this Style<Track> style, Double value)
=> style._addSetter(Track.ValueProperty, value);
public static Style<Track> Value(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.ValueProperty, binding);
public static Style<Track> ViewportSize(this Style<Track> style, Double value)
=> style._addSetter(Track.ViewportSizeProperty, value);
public static Style<Track> ViewportSize(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.ViewportSizeProperty, binding);
public static Style<Track> Orientation(this Style<Track> style, Orientation value)
=> style._addSetter(Track.OrientationProperty, value);
public static Style<Track> Orientation(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.OrientationProperty, binding);
public static Style<Track> Thumb(this Style<Track> style, Thumb value)
=> style._addSetter(Track.ThumbProperty, value);
public static Style<Track> Thumb(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.ThumbProperty, binding);
public static Style<Track> IncreaseButton(this Style<Track> style, Button value)
=> style._addSetter(Track.IncreaseButtonProperty, value);
public static Style<Track> IncreaseButton(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.IncreaseButtonProperty, binding);
public static Style<Track> DecreaseButton(this Style<Track> style, Button value)
=> style._addSetter(Track.DecreaseButtonProperty, value);
public static Style<Track> DecreaseButton(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.DecreaseButtonProperty, binding);
public static Style<Track> IsDirectionReversed(this Style<Track> style, Boolean value)
=> style._addSetter(Track.IsDirectionReversedProperty, value);
public static Style<Track> IsDirectionReversed(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.IsDirectionReversedProperty, binding);
public static Style<Track> IgnoreThumbDrag(this Style<Track> style, Boolean value)
=> style._addSetter(Track.IgnoreThumbDragProperty, value);
public static Style<Track> IgnoreThumbDrag(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.IgnoreThumbDragProperty, binding);
public static Style<Track> DeferThumbDrag(this Style<Track> style, Boolean value)
=> style._addSetter(Track.DeferThumbDragProperty, value);
public static Style<Track> DeferThumbDrag(this Style<Track> style, IBinding binding)
=> style._addSetter(Track.DeferThumbDragProperty, binding);
}

