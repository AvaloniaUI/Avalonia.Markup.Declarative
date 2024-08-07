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
public static Style<RefreshContainer> Visualizer(this Style<RefreshContainer> style, RefreshVisualizer value)
=> style._addSetter(RefreshContainer.VisualizerProperty, value);
public static Style<RefreshContainer> Visualizer(this Style<RefreshContainer> style, IBinding binding)
=> style._addSetter(RefreshContainer.VisualizerProperty, binding);
public static Style<RefreshContainer> PullDirection(this Style<RefreshContainer> style, PullDirection value)
=> style._addSetter(RefreshContainer.PullDirectionProperty, value);
public static Style<RefreshContainer> PullDirection(this Style<RefreshContainer> style, IBinding binding)
=> style._addSetter(RefreshContainer.PullDirectionProperty, binding);
}

