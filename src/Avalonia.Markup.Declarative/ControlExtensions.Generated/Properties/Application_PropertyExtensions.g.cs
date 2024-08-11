#nullable enable
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
public static T DataContext<T>(this T control, IBinding binding) where T : Application
   => control._set(Application.DataContextProperty, binding);
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Application
   => control._set(Application.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataContext<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Application
   => control._set(Application.DataContextProperty, func, onChanged, expression);
public static T DataContext<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static T DataContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Application
   => control._set(Application.RequestedThemeVariantProperty, binding);
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Application
   => control._set(Application.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T RequestedThemeVariant<T>(this T control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Application
   => control._set(Application.RequestedThemeVariantProperty, func, onChanged, expression);
public static T RequestedThemeVariant<T>(this T control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Name<T>(this T control, IBinding binding) where T : Application
   => control._set(Application.NameProperty, binding);
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Application
   => control._set(Application.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Name<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Application
   => control._set(Application.NameProperty, func, onChanged, expression);
public static T Name<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static T Name<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Application
=> control._setEx(Application.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

