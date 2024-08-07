#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class MenuFlyoutExtensions
{
public static MenuFlyout ItemsSource(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemsSourceProperty, binding);
public static MenuFlyout ItemsSource(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuFlyout.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuFlyout ItemsSource(this MenuFlyout control, Func<IEnumerable> func, Action<IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemsSourceProperty, func, onChanged, expression);
public static MenuFlyout ItemsSource(this MenuFlyout control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemsSource<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout ItemTemplate(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemTemplateProperty, binding);
public static MenuFlyout ItemTemplate(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuFlyout.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuFlyout ItemTemplate(this MenuFlyout control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemTemplateProperty, func, onChanged, expression);
public static MenuFlyout ItemTemplate(this MenuFlyout control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemTemplate<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemContainerThemeProperty, binding);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuFlyout.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, Func<ControlTheme> func, Action<ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemContainerThemeProperty, func, onChanged, expression);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemContainerTheme<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, binding);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, Func<ControlTheme> func, Action<ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, func, onChanged, expression);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value, bindingMode, converter, bindingSource);
public static MenuFlyout FlyoutPresenterTheme<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

