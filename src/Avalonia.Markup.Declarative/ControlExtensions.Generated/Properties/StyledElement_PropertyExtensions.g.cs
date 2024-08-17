#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Styling;
using StyledElement = Avalonia.StyledElement;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StyledElementExtensions
{
public static T DataContext<T>(this T control, IBinding binding) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.DataContextProperty, binding);
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.DataContextProperty, func, onChanged, expression);
public static T DataContext<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static T DataContext<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Name<T>(this T control, IBinding binding) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.NameProperty, binding);
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.NameProperty, func, onChanged, expression);
public static T Name<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static T Name<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Theme<T>(this T control, IBinding binding) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.ThemeProperty, binding);
public static T Theme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.ThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Theme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.StyledElement
   => control._set(Avalonia.StyledElement.ThemeProperty, func, onChanged, expression);
public static T Theme<T>(this T control, Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.ThemeProperty, ps, () => control.Theme = value, bindingMode, converter, bindingSource);
public static T Theme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.StyledElement
=> control._setEx(Avalonia.StyledElement.ThemeProperty, ps, () => control.Theme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

