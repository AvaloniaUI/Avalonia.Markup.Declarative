#nullable enable
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderExtensions
{
public static T ContentTransition<T>(this T control, IBinding binding) where T : Expander
   => control._set(Expander.ContentTransitionProperty, binding);
public static T ContentTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Expander
   => control._set(Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContentTransition<T>(this T control, Func<IPageTransition> func, Action<IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Expander
   => control._set(Expander.ContentTransitionProperty, func, onChanged, expression);
public static T ContentTransition<T>(this T control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value, bindingMode, converter, bindingSource);
public static T ContentTransition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExpandDirection<T>(this T control, IBinding binding) where T : Expander
   => control._set(Expander.ExpandDirectionProperty, binding);
public static T ExpandDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Expander
   => control._set(Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExpandDirection<T>(this T control, Func<ExpandDirection> func, Action<ExpandDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Expander
   => control._set(Expander.ExpandDirectionProperty, func, onChanged, expression);
public static T ExpandDirection<T>(this T control, ExpandDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value, bindingMode, converter, bindingSource);
public static T ExpandDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ExpandDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsExpanded<T>(this T control, IBinding binding) where T : Expander
   => control._set(Expander.IsExpandedProperty, binding);
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Expander
   => control._set(Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsExpanded<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Expander
   => control._set(Expander.IsExpandedProperty, func, onChanged, expression);
public static T IsExpanded<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static T IsExpanded<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Expander
=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

