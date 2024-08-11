#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Themes.Fluent;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class FluentThemeExtensions
{
public static T DensityStyle<T>(this T control, IBinding binding) where T : FluentTheme
   => control._set(FluentTheme.DensityStyleProperty, binding);
public static T DensityStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : FluentTheme
   => control._set(FluentTheme.DensityStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DensityStyle<T>(this T control, Func<DensityStyle> func, Action<DensityStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : FluentTheme
   => control._set(FluentTheme.DensityStyleProperty, func, onChanged, expression);
public static T DensityStyle<T>(this T control, DensityStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : FluentTheme
=> control._setEx(FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = value, bindingMode, converter, bindingSource);
public static T DensityStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, DensityStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : FluentTheme
=> control._setEx(FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

