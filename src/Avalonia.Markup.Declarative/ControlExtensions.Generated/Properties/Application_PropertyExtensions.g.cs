#nullable enable
using Application = Avalonia.Application;
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ApplicationExtensions
{
public static T DataContext<T>(this T control, IBinding binding) where T : Avalonia.Application
   => control._set(Avalonia.Application.DataContextProperty, binding);
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.DataContextProperty, func, onChanged, expression);
public static T DataContext<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static T DataContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Application
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, binding);
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.RequestedThemeVariantProperty, func, onChanged, expression);
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Name<T>(this T control, IBinding binding) where T : Avalonia.Application
   => control._set(Avalonia.Application.NameProperty, binding);
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Application
   => control._set(Avalonia.Application.NameProperty, func, onChanged, expression);
public static T Name<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static T Name<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Application
=> control._setEx(Avalonia.Application.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

