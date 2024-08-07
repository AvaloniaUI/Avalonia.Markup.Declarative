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
public static TopLevel TransparencyLevelHint(this TopLevel control, IBinding binding)
   => control._set(TopLevel.TransparencyLevelHintProperty, binding);
public static TopLevel TransparencyLevelHint(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TopLevel TransparencyLevelHint(this TopLevel control, Func<IReadOnlyList<WindowTransparencyLevel>> func, Action<IReadOnlyList<WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.TransparencyLevelHintProperty, func, onChanged, expression);
public static TopLevel TransparencyLevelHint(this TopLevel control, IReadOnlyList<WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);
public static TopLevel TransparencyLevelHint<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, IReadOnlyList<WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBinding binding)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, func, onChanged, expression);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);
public static TopLevel TransparencyBackgroundFallback<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TopLevel RequestedThemeVariant(this TopLevel control, IBinding binding)
   => control._set(TopLevel.RequestedThemeVariantProperty, binding);
public static TopLevel RequestedThemeVariant(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TopLevel RequestedThemeVariant(this TopLevel control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.RequestedThemeVariantProperty, func, onChanged, expression);
public static TopLevel RequestedThemeVariant(this TopLevel control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static TopLevel RequestedThemeVariant<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

