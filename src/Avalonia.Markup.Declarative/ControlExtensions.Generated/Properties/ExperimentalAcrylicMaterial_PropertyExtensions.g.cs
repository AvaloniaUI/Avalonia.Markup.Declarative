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
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, binding);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintColor<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, binding);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, Func<AcrylicBackgroundSource> func, Action<AcrylicBackgroundSource>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, AcrylicBackgroundSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial BackgroundSource<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, AcrylicBackgroundSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, binding);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintOpacity<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, binding);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial MaterialOpacity<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, binding);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, binding);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, func, onChanged, expression);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial FallbackColor<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

