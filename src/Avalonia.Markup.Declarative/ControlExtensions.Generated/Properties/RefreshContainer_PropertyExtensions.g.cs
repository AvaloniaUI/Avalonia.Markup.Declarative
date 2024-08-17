#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using RefreshContainer = Avalonia.Controls.RefreshContainer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class RefreshContainerExtensions
{
public static T Visualizer<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, binding);
public static T Visualizer<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Visualizer<T>(this T control, Func<Avalonia.Controls.RefreshVisualizer> func, Action<Avalonia.Controls.RefreshVisualizer>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, func, onChanged, expression);
public static T Visualizer<T>(this T control, Avalonia.Controls.RefreshVisualizer value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshContainer
=> control._setEx(Avalonia.Controls.RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = value, bindingMode, converter, bindingSource);
public static T Visualizer<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.RefreshVisualizer> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshContainer
=> control._setEx(Avalonia.Controls.RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PullDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RefreshContainer
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, func, onChanged, expression);
public static T PullDirection<T>(this T control, Avalonia.Input.PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshContainer
=> control._setEx(Avalonia.Controls.RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static T PullDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RefreshContainer
=> control._setEx(Avalonia.Controls.RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

