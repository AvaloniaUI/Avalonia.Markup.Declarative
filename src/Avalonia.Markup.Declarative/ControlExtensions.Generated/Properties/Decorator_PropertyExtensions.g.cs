#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Decorator = Avalonia.Controls.Decorator;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DecoratorExtensions
{
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.ChildProperty, binding);
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.ChildProperty, func, onChanged, expression);
public static T Child<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Decorator
=> control._setEx(Avalonia.Controls.Decorator.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static T Child<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Decorator
=> control._setEx(Avalonia.Controls.Decorator.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Padding<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Decorator
   => control._set(Avalonia.Controls.Decorator.PaddingProperty, func, onChanged, expression);
public static T Padding<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Decorator
=> control._setEx(Avalonia.Controls.Decorator.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Decorator
=> control._setEx(Avalonia.Controls.Decorator.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength = default) where T : Avalonia.Controls.Decorator
   => control._set(() => control.Padding = new Avalonia.Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal = default, Double vertical = default) where T : Avalonia.Controls.Decorator
   => control._set(() => control.Padding = new Avalonia.Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left = default, Double top = default, Double right = default, Double bottom = default) where T : Avalonia.Controls.Decorator
   => control._set(() => control.Padding = new Avalonia.Thickness(left, top, right, bottom));
}

