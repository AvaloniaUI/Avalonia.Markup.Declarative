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
public static Application DataContext(this Application control, IBinding binding)
   => control._set(Application.DataContextProperty, binding);
public static Application DataContext(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Application.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Application DataContext(this Application control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.DataContextProperty, func, onChanged, expression);
public static Application DataContext(this Application control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static Application DataContext<TValue>(this Application control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Application RequestedThemeVariant(this Application control, IBinding binding)
   => control._set(Application.RequestedThemeVariantProperty, binding);
public static Application RequestedThemeVariant(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Application.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Application RequestedThemeVariant(this Application control, Func<ThemeVariant> func, Action<ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.RequestedThemeVariantProperty, func, onChanged, expression);
public static Application RequestedThemeVariant(this Application control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static Application RequestedThemeVariant<TValue>(this Application control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Application Name(this Application control, IBinding binding)
   => control._set(Application.NameProperty, binding);
public static Application Name(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Application.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Application Name(this Application control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.NameProperty, func, onChanged, expression);
public static Application Name(this Application control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static Application Name<TValue>(this Application control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

