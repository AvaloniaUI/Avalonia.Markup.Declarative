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
public static Decorator Child(this Decorator control, IBinding binding)
   => control._set(Decorator.ChildProperty, binding);
public static Decorator Child(this Decorator control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Decorator.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Decorator Child(this Decorator control, Func<Control> func, Action<Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Decorator.ChildProperty, func, onChanged, expression);
public static Decorator Child(this Decorator control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Decorator Child<TValue>(this Decorator control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Decorator Padding(this Decorator control, IBinding binding)
   => control._set(Decorator.PaddingProperty, binding);
public static Decorator Padding(this Decorator control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Decorator.PaddingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Decorator Padding(this Decorator control, Func<Thickness> func, Action<Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Decorator.PaddingProperty, func, onChanged, expression);
public static Decorator Padding(this Decorator control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static Decorator Padding<TValue>(this Decorator control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Decorator Padding(this Decorator control, Double uniformLength = default)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static Decorator Padding(this Decorator control, Double horizontal = default, Double vertical = default)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static Decorator Padding(this Decorator control, Double left = default, Double top = default, Double right = default, Double bottom = default)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
}

