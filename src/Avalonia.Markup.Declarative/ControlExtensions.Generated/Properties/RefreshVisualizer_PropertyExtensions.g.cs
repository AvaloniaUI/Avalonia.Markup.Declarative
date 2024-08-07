#nullable enable
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
public static RefreshVisualizer Orientation(this RefreshVisualizer control, IBinding binding)
   => control._set(RefreshVisualizer.OrientationProperty, binding);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(RefreshVisualizer.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, Func<RefreshVisualizerOrientation> func, Action<RefreshVisualizerOrientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshVisualizer.OrientationProperty, func, onChanged, expression);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, RefreshVisualizerOrientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static RefreshVisualizer Orientation<TValue>(this RefreshVisualizer control, TValue value, FuncValueConverter<TValue, RefreshVisualizerOrientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

