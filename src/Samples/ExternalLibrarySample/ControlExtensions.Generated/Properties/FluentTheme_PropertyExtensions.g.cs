#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Themes.Fluent;
using FluentTheme = Avalonia.Themes.Fluent.FluentTheme;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class FluentThemeExtensions
{
public static T DensityStyle<T>(this T control, IBinding binding) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, binding);
public static T DensityStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DensityStyle<T>(this T control, Func<Avalonia.Themes.Fluent.DensityStyle> func, Action<Avalonia.Themes.Fluent.DensityStyle>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Themes.Fluent.FluentTheme
   => control._set(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, func, onChanged, expression);
public static T DensityStyle<T>(this T control, Avalonia.Themes.Fluent.DensityStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.FluentTheme
=> control._setEx(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = value, bindingMode, converter, bindingSource);
public static T DensityStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Themes.Fluent.DensityStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Themes.Fluent.FluentTheme
=> control._setEx(Avalonia.Themes.Fluent.FluentTheme.DensityStyleProperty, ps, () => control.DensityStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

