using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshVisualizerExtensions
{
public static Style<RefreshVisualizer> Orientation(this Style<RefreshVisualizer> style, RefreshVisualizerOrientation value)
=> style._addSetter(RefreshVisualizer.OrientationProperty, value);
public static Style<RefreshVisualizer> Orientation(this Style<RefreshVisualizer> style, IBinding binding)
=> style._addSetter(RefreshVisualizer.OrientationProperty, binding);
}

