#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class TrayIconExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Menu<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.MenuProperty, binding);
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Menu<T>(this T control, Func<NativeMenu> func, Action<NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.MenuProperty, func, onChanged, expression);
public static T Menu<T>(this T control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static T Menu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<WindowIcon> func, Action<WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToolTipText<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.ToolTipTextProperty, binding);
public static T ToolTipText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToolTipText<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.ToolTipTextProperty, func, onChanged, expression);
public static T ToolTipText<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = value, bindingMode, converter, bindingSource);
public static T ToolTipText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : TrayIcon
   => control._set(TrayIcon.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TrayIcon
   => control._set(TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TrayIcon
   => control._set(TrayIcon.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TrayIcon
=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

