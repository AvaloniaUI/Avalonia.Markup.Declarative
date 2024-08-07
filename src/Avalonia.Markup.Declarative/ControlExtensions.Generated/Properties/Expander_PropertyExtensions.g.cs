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
public static Expander ContentTransition(this Expander control, IBinding binding)
   => control._set(Expander.ContentTransitionProperty, binding);
public static Expander ContentTransition(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Expander ContentTransition(this Expander control, Func<IPageTransition> func, Action<IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.ContentTransitionProperty, func, onChanged, expression);
public static Expander ContentTransition(this Expander control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value, bindingMode, converter, bindingSource);
public static Expander ContentTransition<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Expander ExpandDirection(this Expander control, IBinding binding)
   => control._set(Expander.ExpandDirectionProperty, binding);
public static Expander ExpandDirection(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Expander ExpandDirection(this Expander control, Func<ExpandDirection> func, Action<ExpandDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.ExpandDirectionProperty, func, onChanged, expression);
public static Expander ExpandDirection(this Expander control, ExpandDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value, bindingMode, converter, bindingSource);
public static Expander ExpandDirection<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, ExpandDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Expander IsExpanded(this Expander control, IBinding binding)
   => control._set(Expander.IsExpandedProperty, binding);
public static Expander IsExpanded(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Expander IsExpanded(this Expander control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.IsExpandedProperty, func, onChanged, expression);
public static Expander IsExpanded(this Expander control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static Expander IsExpanded<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

