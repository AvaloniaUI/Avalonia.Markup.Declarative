using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollBarExtensions
{
public static Style<ScrollBar> ViewportSize(this Style<ScrollBar> style, Double value)
=> style._addSetter(ScrollBar.ViewportSizeProperty, value);
public static Style<ScrollBar> ViewportSize(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.ViewportSizeProperty, binding);
public static Style<ScrollBar> Visibility(this Style<ScrollBar> style, ScrollBarVisibility value)
=> style._addSetter(ScrollBar.VisibilityProperty, value);
public static Style<ScrollBar> Visibility(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.VisibilityProperty, binding);
public static Style<ScrollBar> Orientation(this Style<ScrollBar> style, Orientation value)
=> style._addSetter(ScrollBar.OrientationProperty, value);
public static Style<ScrollBar> Orientation(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.OrientationProperty, binding);
public static Style<ScrollBar> AllowAutoHide(this Style<ScrollBar> style, Boolean value)
=> style._addSetter(ScrollBar.AllowAutoHideProperty, value);
public static Style<ScrollBar> AllowAutoHide(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.AllowAutoHideProperty, binding);
public static Style<ScrollBar> HideDelay(this Style<ScrollBar> style, TimeSpan value)
=> style._addSetter(ScrollBar.HideDelayProperty, value);
public static Style<ScrollBar> HideDelay(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.HideDelayProperty, binding);
public static Style<ScrollBar> ShowDelay(this Style<ScrollBar> style, TimeSpan value)
=> style._addSetter(ScrollBar.ShowDelayProperty, value);
public static Style<ScrollBar> ShowDelay(this Style<ScrollBar> style, IBinding binding)
=> style._addSetter(ScrollBar.ShowDelayProperty, binding);
}

