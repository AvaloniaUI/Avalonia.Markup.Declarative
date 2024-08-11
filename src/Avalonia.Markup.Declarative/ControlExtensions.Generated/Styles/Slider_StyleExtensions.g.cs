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
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : Slider
=> style._addSetter(Slider.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.OrientationProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, Boolean value) where T : Slider
=> style._addSetter(Slider.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.IsDirectionReversedProperty, binding);
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, Boolean value) where T : Slider
=> style._addSetter(Slider.IsSnapToTickEnabledProperty, value);
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.IsSnapToTickEnabledProperty, binding);
public static Style<T> TickFrequency<T>(this Style<T> style, Double value) where T : Slider
=> style._addSetter(Slider.TickFrequencyProperty, value);
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.TickFrequencyProperty, binding);
public static Style<T> TickPlacement<T>(this Style<T> style, TickPlacement value) where T : Slider
=> style._addSetter(Slider.TickPlacementProperty, value);
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.TickPlacementProperty, binding);
public static Style<T> Ticks<T>(this Style<T> style, AvaloniaList<Double> value) where T : Slider
=> style._addSetter(Slider.TicksProperty, value);
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Slider
=> style._addSetter(Slider.TicksProperty, binding);
}

