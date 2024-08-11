#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DecoratorExtensions
{
public static T Child<T>(this T control, IBinding binding) where T : Decorator
   => control._set(Decorator.ChildProperty, binding);
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Decorator
   => control._set(Decorator.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Child<T>(this T control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Decorator
   => control._set(Decorator.ChildProperty, func, onChanged, expression);
public static T Child<T>(this T control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Decorator
=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Decorator
=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : Decorator
   => control._set(Decorator.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Decorator
   => control._set(Decorator.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Padding<T>(this T control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Decorator
   => control._set(Decorator.PaddingProperty, func, onChanged, expression);
public static T Padding<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Decorator
=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Decorator
=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength = default) where T : Decorator
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal = default, Double vertical = default) where T : Decorator
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Decorator
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
}

