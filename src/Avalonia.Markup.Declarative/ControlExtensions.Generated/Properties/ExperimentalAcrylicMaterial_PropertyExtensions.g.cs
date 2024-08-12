#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExperimentalAcrylicMaterialExtensions
{
public static T TintColor<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, binding);
public static T TintColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TintColor<T>(this T control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, func, onChanged, expression);
public static T TintColor<T>(this T control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = value, bindingMode, converter, bindingSource);
public static T TintColor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BackgroundSource<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, binding);
public static T BackgroundSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BackgroundSource<T>(this T control, Func<AcrylicBackgroundSource> func, Action<AcrylicBackgroundSource>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, func, onChanged, expression);
public static T BackgroundSource<T>(this T control, AcrylicBackgroundSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = value, bindingMode, converter, bindingSource);
public static T BackgroundSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AcrylicBackgroundSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TintOpacity<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, binding);
public static T TintOpacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TintOpacity<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, func, onChanged, expression);
public static T TintOpacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = value, bindingMode, converter, bindingSource);
public static T TintOpacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaterialOpacity<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, binding);
public static T MaterialOpacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaterialOpacity<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, func, onChanged, expression);
public static T MaterialOpacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = value, bindingMode, converter, bindingSource);
public static T MaterialOpacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlatformTransparencyCompensationLevel<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, binding);
public static T PlatformTransparencyCompensationLevel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PlatformTransparencyCompensationLevel<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, func, onChanged, expression);
public static T PlatformTransparencyCompensationLevel<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = value, bindingMode, converter, bindingSource);
public static T PlatformTransparencyCompensationLevel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FallbackColor<T>(this T control, IBinding binding) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, binding);
public static T FallbackColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FallbackColor<T>(this T control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ExperimentalAcrylicMaterial
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, func, onChanged, expression);
public static T FallbackColor<T>(this T control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = value, bindingMode, converter, bindingSource);
public static T FallbackColor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ExperimentalAcrylicMaterial
=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

