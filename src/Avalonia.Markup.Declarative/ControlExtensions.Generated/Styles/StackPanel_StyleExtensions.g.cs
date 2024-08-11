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
public static Style<T> Spacing<T>(this Style<T> style, Double value) where T : StackPanel
=> style._addSetter(StackPanel.SpacingProperty, value);
public static Style<T> Spacing<T>(this Style<T> style, IBinding binding) where T : StackPanel
=> style._addSetter(StackPanel.SpacingProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Orientation value) where T : StackPanel
=> style._addSetter(StackPanel.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : StackPanel
=> style._addSetter(StackPanel.OrientationProperty, binding);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, Boolean value) where T : StackPanel
=> style._addSetter(StackPanel.AreHorizontalSnapPointsRegularProperty, value);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : StackPanel
=> style._addSetter(StackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, Boolean value) where T : StackPanel
=> style._addSetter(StackPanel.AreVerticalSnapPointsRegularProperty, value);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : StackPanel
=> style._addSetter(StackPanel.AreVerticalSnapPointsRegularProperty, binding);
}

