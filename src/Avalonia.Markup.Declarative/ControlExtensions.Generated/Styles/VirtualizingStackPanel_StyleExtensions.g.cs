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
public static Style<VirtualizingStackPanel> Orientation(this Style<VirtualizingStackPanel> style, Orientation value)
=> style._addSetter(VirtualizingStackPanel.OrientationProperty, value);
public static Style<VirtualizingStackPanel> Orientation(this Style<VirtualizingStackPanel> style, IBinding binding)
=> style._addSetter(VirtualizingStackPanel.OrientationProperty, binding);
public static Style<VirtualizingStackPanel> AreHorizontalSnapPointsRegular(this Style<VirtualizingStackPanel> style, Boolean value)
=> style._addSetter(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, value);
public static Style<VirtualizingStackPanel> AreHorizontalSnapPointsRegular(this Style<VirtualizingStackPanel> style, IBinding binding)
=> style._addSetter(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static Style<VirtualizingStackPanel> AreVerticalSnapPointsRegular(this Style<VirtualizingStackPanel> style, Boolean value)
=> style._addSetter(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, value);
public static Style<VirtualizingStackPanel> AreVerticalSnapPointsRegular(this Style<VirtualizingStackPanel> style, IBinding binding)
=> style._addSetter(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);
}

