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
using TopLevel = Avalonia.Controls.TopLevel;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevelExtensions
{
public static T TransparencyLevelHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);
public static T TransparencyLevelHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, func, onChanged, expression);
public static T TransparencyLevelHint<T>(this T control, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);
public static T TransparencyLevelHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TransparencyBackgroundFallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static T TransparencyBackgroundFallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, func, onChanged, expression);
public static T TransparencyBackgroundFallback<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);
public static T TransparencyBackgroundFallback<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, func, onChanged, expression);
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

