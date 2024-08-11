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
public static Style<T> Orientation<T>(this Style<T> style, RefreshVisualizerOrientation value) where T : RefreshVisualizer
=> style._addSetter(RefreshVisualizer.OrientationProperty, value);
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : RefreshVisualizer
=> style._addSetter(RefreshVisualizer.OrientationProperty, binding);
}

