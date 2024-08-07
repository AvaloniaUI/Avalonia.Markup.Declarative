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
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, IBinding binding)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, binding);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, func, onChanged, expression);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static ThemeVariantScope RequestedThemeVariant<TValue>(this ThemeVariantScope control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

