using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StackPanelExtensions
{
public static Style<StackPanel> Spacing(this Style<StackPanel> style, Double value)
=> style._addSetter(StackPanel.SpacingProperty, value);
public static Style<StackPanel> Spacing(this Style<StackPanel> style, IBinding binding)
=> style._addSetter(StackPanel.SpacingProperty, binding);
public static Style<StackPanel> Orientation(this Style<StackPanel> style, Orientation value)
=> style._addSetter(StackPanel.OrientationProperty, value);
public static Style<StackPanel> Orientation(this Style<StackPanel> style, IBinding binding)
=> style._addSetter(StackPanel.OrientationProperty, binding);
public static Style<StackPanel> AreHorizontalSnapPointsRegular(this Style<StackPanel> style, Boolean value)
=> style._addSetter(StackPanel.AreHorizontalSnapPointsRegularProperty, value);
public static Style<StackPanel> AreHorizontalSnapPointsRegular(this Style<StackPanel> style, IBinding binding)
=> style._addSetter(StackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static Style<StackPanel> AreVerticalSnapPointsRegular(this Style<StackPanel> style, Boolean value)
=> style._addSetter(StackPanel.AreVerticalSnapPointsRegularProperty, value);
public static Style<StackPanel> AreVerticalSnapPointsRegular(this Style<StackPanel> style, IBinding binding)
=> style._addSetter(StackPanel.AreVerticalSnapPointsRegularProperty, binding);
}

