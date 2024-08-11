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
public static T Orientation<T>(this T control, IBinding binding) where T : RefreshVisualizer
   => control._set(RefreshVisualizer.OrientationProperty, binding);
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : RefreshVisualizer
   => control._set(RefreshVisualizer.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Orientation<T>(this T control, Func<RefreshVisualizerOrientation> func, Action<RefreshVisualizerOrientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : RefreshVisualizer
   => control._set(RefreshVisualizer.OrientationProperty, func, onChanged, expression);
public static T Orientation<T>(this T control, RefreshVisualizerOrientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshVisualizer
=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RefreshVisualizerOrientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : RefreshVisualizer
=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

