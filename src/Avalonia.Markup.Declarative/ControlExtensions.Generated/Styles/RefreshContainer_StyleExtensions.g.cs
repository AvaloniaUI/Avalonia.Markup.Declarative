using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshContainerExtensions
{
public static Style<T> Visualizer<T>(this Style<T> style, RefreshVisualizer value) where T : RefreshContainer
=> style._addSetter(RefreshContainer.VisualizerProperty, value);
public static Style<T> Visualizer<T>(this Style<T> style, IBinding binding) where T : RefreshContainer
=> style._addSetter(RefreshContainer.VisualizerProperty, binding);
public static Style<T> PullDirection<T>(this Style<T> style, PullDirection value) where T : RefreshContainer
=> style._addSetter(RefreshContainer.PullDirectionProperty, value);
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : RefreshContainer
=> style._addSetter(RefreshContainer.PullDirectionProperty, binding);
}

