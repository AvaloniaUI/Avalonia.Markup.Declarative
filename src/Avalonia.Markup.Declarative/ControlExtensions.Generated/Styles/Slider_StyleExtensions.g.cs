using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SliderExtensions
{
public static Style<Slider> Orientation(this Style<Slider> style, Orientation value)
=> style._addSetter(Slider.OrientationProperty, value);
public static Style<Slider> Orientation(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.OrientationProperty, binding);
public static Style<Slider> IsDirectionReversed(this Style<Slider> style, Boolean value)
=> style._addSetter(Slider.IsDirectionReversedProperty, value);
public static Style<Slider> IsDirectionReversed(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.IsDirectionReversedProperty, binding);
public static Style<Slider> IsSnapToTickEnabled(this Style<Slider> style, Boolean value)
=> style._addSetter(Slider.IsSnapToTickEnabledProperty, value);
public static Style<Slider> IsSnapToTickEnabled(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.IsSnapToTickEnabledProperty, binding);
public static Style<Slider> TickFrequency(this Style<Slider> style, Double value)
=> style._addSetter(Slider.TickFrequencyProperty, value);
public static Style<Slider> TickFrequency(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.TickFrequencyProperty, binding);
public static Style<Slider> TickPlacement(this Style<Slider> style, TickPlacement value)
=> style._addSetter(Slider.TickPlacementProperty, value);
public static Style<Slider> TickPlacement(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.TickPlacementProperty, binding);
public static Style<Slider> Ticks(this Style<Slider> style, AvaloniaList<Double> value)
=> style._addSetter(Slider.TicksProperty, value);
public static Style<Slider> Ticks(this Style<Slider> style, IBinding binding)
=> style._addSetter(Slider.TicksProperty, binding);
}

