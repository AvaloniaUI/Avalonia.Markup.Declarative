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
public static Style<T> ViewportSize<T>(this Style<T> style, Double value) where T : ScrollBar
=> style._addSetter(ScrollBar.ViewportSizeProperty, value);
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.ViewportSizeProperty, binding);
public static Style<T> Visibility<T>(this Style<T> style, ScrollBarVisibility value) where T : ScrollBar
=> style._addSetter(ScrollBar.VisibilityProperty, value);
public static Style<T> Visibility<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.VisibilityProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : ScrollBar
=> style._addSetter(ScrollBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.OrientationProperty, binding);
public static Style<T> AllowAutoHide<T>(this Style<T> style, Boolean value) where T : ScrollBar
=> style._addSetter(ScrollBar.AllowAutoHideProperty, value);
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.AllowAutoHideProperty, binding);
public static Style<T> HideDelay<T>(this Style<T> style, TimeSpan value) where T : ScrollBar
=> style._addSetter(ScrollBar.HideDelayProperty, value);
public static Style<T> HideDelay<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.HideDelayProperty, binding);
public static Style<T> ShowDelay<T>(this Style<T> style, TimeSpan value) where T : ScrollBar
=> style._addSetter(ScrollBar.ShowDelayProperty, value);
public static Style<T> ShowDelay<T>(this Style<T> style, IBinding binding) where T : ScrollBar
=> style._addSetter(ScrollBar.ShowDelayProperty, binding);
}

