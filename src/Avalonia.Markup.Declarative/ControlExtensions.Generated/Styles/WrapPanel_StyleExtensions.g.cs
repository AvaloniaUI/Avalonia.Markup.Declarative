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
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : WrapPanel
=> style._addSetter(WrapPanel.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : WrapPanel
=> style._addSetter(WrapPanel.OrientationProperty, binding);
public static Style<T> ItemWidth<T>(this Style<T> style, Double value) where T : WrapPanel
=> style._addSetter(WrapPanel.ItemWidthProperty, value);
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : WrapPanel
=> style._addSetter(WrapPanel.ItemWidthProperty, binding);
public static Style<T> ItemHeight<T>(this Style<T> style, Double value) where T : WrapPanel
=> style._addSetter(WrapPanel.ItemHeightProperty, value);
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : WrapPanel
=> style._addSetter(WrapPanel.ItemHeightProperty, binding);
}

