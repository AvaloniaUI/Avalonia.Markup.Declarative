#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static T FocusAdorner<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.FocusAdornerProperty, binding);
public static T FocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Control
   => control._set(Control.FocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FocusAdorner<T>(this T control, Func<ITemplate<Control>> func, Action<ITemplate<Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.FocusAdornerProperty, func, onChanged, expression);
public static T FocusAdorner<T>(this T control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value, bindingMode, converter, bindingSource);
public static T FocusAdorner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Tag<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.TagProperty, binding);
public static T Tag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Control
   => control._set(Control.TagProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Tag<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.TagProperty, func, onChanged, expression);
public static T Tag<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.TagProperty, ps, () => control.Tag = value, bindingMode, converter, bindingSource);
public static T Tag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.TagProperty, ps, () => control.Tag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextMenu<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.ContextMenuProperty, binding);
public static T ContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Control
   => control._set(Control.ContextMenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContextMenu<T>(this T control, Func<ContextMenu> func, Action<ContextMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.ContextMenuProperty, func, onChanged, expression);
public static T ContextMenu<T>(this T control, ContextMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextMenuProperty, ps, () => control.ContextMenu = value, bindingMode, converter, bindingSource);
public static T ContextMenu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ContextMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextMenuProperty, ps, () => control.ContextMenu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextFlyout<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.ContextFlyoutProperty, binding);
public static T ContextFlyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Control
   => control._set(Control.ContextFlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContextFlyout<T>(this T control, Func<FlyoutBase> func, Action<FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.ContextFlyoutProperty, func, onChanged, expression);
public static T ContextFlyout<T>(this T control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = value, bindingMode, converter, bindingSource);
public static T ContextFlyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

