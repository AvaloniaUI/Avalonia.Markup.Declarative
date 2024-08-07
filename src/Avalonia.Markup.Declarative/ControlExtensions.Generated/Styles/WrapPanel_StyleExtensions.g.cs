using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WrapPanelExtensions
{
public static Style<WrapPanel> Orientation(this Style<WrapPanel> style, Orientation value)
=> style._addSetter(WrapPanel.OrientationProperty, value);
public static Style<WrapPanel> Orientation(this Style<WrapPanel> style, IBinding binding)
=> style._addSetter(WrapPanel.OrientationProperty, binding);
public static Style<WrapPanel> ItemWidth(this Style<WrapPanel> style, Double value)
=> style._addSetter(WrapPanel.ItemWidthProperty, value);
public static Style<WrapPanel> ItemWidth(this Style<WrapPanel> style, IBinding binding)
=> style._addSetter(WrapPanel.ItemWidthProperty, binding);
public static Style<WrapPanel> ItemHeight(this Style<WrapPanel> style, Double value)
=> style._addSetter(WrapPanel.ItemHeightProperty, value);
public static Style<WrapPanel> ItemHeight(this Style<WrapPanel> style, IBinding binding)
=> style._addSetter(WrapPanel.ItemHeightProperty, binding);
}

