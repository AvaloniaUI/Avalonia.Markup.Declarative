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
public static partial class StyledElementExtensions
{
public static T DataContext<T>(this T control, IBinding binding) where T : StyledElement
   => control._set(StyledElement.DataContextProperty, binding);
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : StyledElement
   => control._set(StyledElement.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataContext<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : StyledElement
   => control._set(StyledElement.DataContextProperty, func, onChanged, expression);
public static T DataContext<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static T DataContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Name<T>(this T control, IBinding binding) where T : StyledElement
   => control._set(StyledElement.NameProperty, binding);
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : StyledElement
   => control._set(StyledElement.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Name<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : StyledElement
   => control._set(StyledElement.NameProperty, func, onChanged, expression);
public static T Name<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static T Name<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Theme<T>(this T control, IBinding binding) where T : StyledElement
   => control._set(StyledElement.ThemeProperty, binding);
public static T Theme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : StyledElement
   => control._set(StyledElement.ThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Theme<T>(this T control, Func<ControlTheme> func, Action<ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : StyledElement
   => control._set(StyledElement.ThemeProperty, func, onChanged, expression);
public static T Theme<T>(this T control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.ThemeProperty, ps, () => control.Theme = value, bindingMode, converter, bindingSource);
public static T Theme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : StyledElement
=> control._setEx(StyledElement.ThemeProperty, ps, () => control.Theme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

