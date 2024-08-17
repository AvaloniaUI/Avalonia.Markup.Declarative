using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using StackPanel = Avalonia.Controls.StackPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StackPanelExtensions
{
public static Style<T> Spacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, value);
public static Style<T> Spacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, binding);
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, binding);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, value);
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, value);
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, binding);
}

