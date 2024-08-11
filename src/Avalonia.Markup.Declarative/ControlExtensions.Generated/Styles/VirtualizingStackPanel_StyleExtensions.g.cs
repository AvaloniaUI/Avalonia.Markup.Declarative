using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VirtualizingStackPanelExtensions
{
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.OrientationProperty, binding);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, Boolean value) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, value);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, Boolean value) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, value);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : VirtualizingStackPanel
=> style._addSetter(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);
}

