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
public static T Visualizer<T>(this T control, IBinding binding) where T : RefreshContainer
   => control._set(RefreshContainer.VisualizerProperty, binding);
public static T Visualizer<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RefreshContainer
   => control._set(RefreshContainer.VisualizerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Visualizer<T>(this T control, Func<RefreshVisualizer> func, Action<RefreshVisualizer>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RefreshContainer
   => control._set(RefreshContainer.VisualizerProperty, func, onChanged, expression);
public static T Visualizer<T>(this T control, RefreshVisualizer value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshContainer
=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = value, bindingMode, converter, bindingSource);
public static T Visualizer<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RefreshVisualizer> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshContainer
=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PullDirection<T>(this T control, IBinding binding) where T : RefreshContainer
   => control._set(RefreshContainer.PullDirectionProperty, binding);
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RefreshContainer
   => control._set(RefreshContainer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PullDirection<T>(this T control, Func<PullDirection> func, Action<PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RefreshContainer
   => control._set(RefreshContainer.PullDirectionProperty, func, onChanged, expression);
public static T PullDirection<T>(this T control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshContainer
=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static T PullDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshContainer
=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

