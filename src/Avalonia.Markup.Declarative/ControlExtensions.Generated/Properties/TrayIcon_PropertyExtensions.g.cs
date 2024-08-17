#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using TrayIcon = Avalonia.Controls.TrayIcon;

namespace Avalonia.Markup.Declarative;
public static partial class TrayIconExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, binding);
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.MenuProperty, func, onChanged, expression);
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static T Menu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<Avalonia.Controls.WindowIcon> func, Action<Avalonia.Controls.WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, Avalonia.Controls.WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToolTipText<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, binding);
public static T ToolTipText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToolTipText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.ToolTipTextProperty, func, onChanged, expression);
public static T ToolTipText<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = value, bindingMode, converter, bindingSource);
public static T ToolTipText<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TrayIcon
   => control._set(Avalonia.Controls.TrayIcon.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TrayIcon
=> control._setEx(Avalonia.Controls.TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

