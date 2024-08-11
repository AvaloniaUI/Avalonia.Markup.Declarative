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
public static partial class FlyoutExtensions
{
public static T Content<T>(this T control, IBinding binding) where T : Flyout
   => control._set(Flyout.ContentProperty, binding);
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Flyout
   => control._set(Flyout.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Content<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Flyout
   => control._set(Flyout.ContentProperty, func, onChanged, expression);
public static T Content<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Flyout
=> control._setEx(Flyout.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static T Content<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Flyout
=> control._setEx(Flyout.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FlyoutPresenterTheme<T>(this T control, IBinding binding) where T : Flyout
   => control._set(Flyout.FlyoutPresenterThemeProperty, binding);
public static T FlyoutPresenterTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Flyout
   => control._set(Flyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FlyoutPresenterTheme<T>(this T control, Func<ControlTheme> func, Action<ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Flyout
   => control._set(Flyout.FlyoutPresenterThemeProperty, func, onChanged, expression);
public static T FlyoutPresenterTheme<T>(this T control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Flyout
=> control._setEx(Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value, bindingMode, converter, bindingSource);
public static T FlyoutPresenterTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Flyout
=> control._setEx(Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

