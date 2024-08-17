using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using ScrollBar = Avalonia.Controls.Primitives.ScrollBar;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollBarExtensions
{
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, value);
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ViewportSizeProperty, binding);
public static Style<T> Visibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, value);
public static Style<T> Visibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.VisibilityProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.OrientationProperty, binding);
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, value);
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.AllowAutoHideProperty, binding);
public static Style<T> HideDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, value);
public static Style<T> HideDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.HideDelayProperty, binding);
public static Style<T> ShowDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, value);
public static Style<T> ShowDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ScrollBar
=> style._addSetter(Avalonia.Controls.Primitives.ScrollBar.ShowDelayProperty, binding);
}

