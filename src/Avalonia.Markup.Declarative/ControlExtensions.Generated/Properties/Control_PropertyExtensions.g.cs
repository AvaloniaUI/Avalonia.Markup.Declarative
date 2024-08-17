#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Control = Avalonia.Controls.Control;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ControlExtensions
{
public static T FocusAdorner<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, binding);
public static T FocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, func, onChanged, expression);
public static T FocusAdorner<T>(this T control, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value, bindingMode, converter, bindingSource);
public static T FocusAdorner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.FocusAdornerProperty, ps, () => control.FocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Tag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.TagProperty, binding);
public static T Tag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.TagProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Tag<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.TagProperty, func, onChanged, expression);
public static T Tag<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.TagProperty, ps, () => control.Tag = value, bindingMode, converter, bindingSource);
public static T Tag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.TagProperty, ps, () => control.Tag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextMenu<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, binding);
public static T ContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu> func, Action<Avalonia.Controls.ContextMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, func, onChanged, expression);
public static T ContextMenu<T>(this T control, Avalonia.Controls.ContextMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.ContextMenuProperty, ps, () => control.ContextMenu = value, bindingMode, converter, bindingSource);
public static T ContextMenu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ContextMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.ContextMenuProperty, ps, () => control.ContextMenu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextFlyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, binding);
public static T ContextFlyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContextFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Control
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, func, onChanged, expression);
public static T ContextFlyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = value, bindingMode, converter, bindingSource);
public static T ContextFlyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
=> control._setEx(Avalonia.Controls.Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

