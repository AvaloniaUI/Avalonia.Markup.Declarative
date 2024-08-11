#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Avalonia.Styling;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelExtensions
{
public static T TransparencyLevelHint<T>(this T control, IBinding binding) where T : TopLevel
   => control._set(TopLevel.TransparencyLevelHintProperty, binding);
public static T TransparencyLevelHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TopLevel
   => control._set(TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransparencyLevelHint<T>(this T control, Func<IReadOnlyList<WindowTransparencyLevel>> func, Action<IReadOnlyList<WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TopLevel
   => control._set(TopLevel.TransparencyLevelHintProperty, func, onChanged, expression);
public static T TransparencyLevelHint<T>(this T control, IReadOnlyList<WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);
public static T TransparencyLevelHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IReadOnlyList<WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TransparencyBackgroundFallback<T>(this T control, IBinding binding) where T : TopLevel
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static T TransparencyBackgroundFallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TopLevel
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransparencyBackgroundFallback<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TopLevel
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, func, onChanged, expression);
public static T TransparencyBackgroundFallback<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);
public static T TransparencyBackgroundFallback<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : TopLevel
   => control._set(TopLevel.RequestedThemeVariantProperty, binding);
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TopLevel
   => control._set(TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RequestedThemeVariant<T>(this T control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TopLevel
   => control._set(TopLevel.RequestedThemeVariantProperty, func, onChanged, expression);
public static T RequestedThemeVariant<T>(this T control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TopLevel
=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

