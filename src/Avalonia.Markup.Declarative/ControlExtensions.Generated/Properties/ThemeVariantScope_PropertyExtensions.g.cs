#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ThemeVariantScopeExtensions
{
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : ThemeVariantScope
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, binding);
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ThemeVariantScope
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RequestedThemeVariant<T>(this T control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ThemeVariantScope
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, func, onChanged, expression);
public static T RequestedThemeVariant<T>(this T control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ThemeVariantScope
=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ThemeVariantScope
=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

