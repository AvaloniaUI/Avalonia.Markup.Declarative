#nullable enable
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
public static RefreshContainer Visualizer(this RefreshContainer control, IBinding binding)
   => control._set(RefreshContainer.VisualizerProperty, binding);
public static RefreshContainer Visualizer(this RefreshContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RefreshContainer.VisualizerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RefreshContainer Visualizer(this RefreshContainer control, Func<RefreshVisualizer> func, Action<RefreshVisualizer>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshContainer.VisualizerProperty, func, onChanged, expression);
public static RefreshContainer Visualizer(this RefreshContainer control, RefreshVisualizer value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = value, bindingMode, converter, bindingSource);
public static RefreshContainer Visualizer<TValue>(this RefreshContainer control, TValue value, FuncValueConverter<TValue, RefreshVisualizer> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RefreshContainer PullDirection(this RefreshContainer control, IBinding binding)
   => control._set(RefreshContainer.PullDirectionProperty, binding);
public static RefreshContainer PullDirection(this RefreshContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RefreshContainer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RefreshContainer PullDirection(this RefreshContainer control, Func<PullDirection> func, Action<PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshContainer.PullDirectionProperty, func, onChanged, expression);
public static RefreshContainer PullDirection(this RefreshContainer control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static RefreshContainer PullDirection<TValue>(this RefreshContainer control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

