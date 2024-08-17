using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WrapPanel = Avalonia.Controls.WrapPanel;

namespace Avalonia.Markup.Declarative;
public static partial class WrapPanelExtensions
{
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, value);
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, value);
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);
}

