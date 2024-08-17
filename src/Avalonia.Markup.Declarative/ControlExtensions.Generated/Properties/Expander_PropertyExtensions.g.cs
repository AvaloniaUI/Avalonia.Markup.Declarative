#nullable enable
using Avalonia.Animation;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Expander = Avalonia.Controls.Expander;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ExpanderExtensions
{
public static T ContentTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, binding);
public static T ContentTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContentTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, func, onChanged, expression);
public static T ContentTransition<T>(this T control, Avalonia.Animation.IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value, bindingMode, converter, bindingSource);
public static T ContentTransition<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.ContentTransitionProperty, ps, () => control.ContentTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ExpandDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);
public static T ExpandDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ExpandDirection<T>(this T control, Func<Avalonia.Controls.ExpandDirection> func, Action<Avalonia.Controls.ExpandDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, func, onChanged, expression);
public static T ExpandDirection<T>(this T control, Avalonia.Controls.ExpandDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value, bindingMode, converter, bindingSource);
public static T ExpandDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ExpandDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsExpanded<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, binding);
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, func, onChanged, expression);
public static T IsExpanded<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static T IsExpanded<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander
=> control._setEx(Avalonia.Controls.Expander.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

