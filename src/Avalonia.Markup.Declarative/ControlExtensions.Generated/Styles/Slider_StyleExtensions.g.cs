using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Slider = Avalonia.Controls.Slider;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SliderExtensions
{
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, binding);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, value);
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, value);
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, value);
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, binding);
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, value);
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, binding);
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, value);
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, binding);
}

