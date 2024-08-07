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
public static TrayIcon Command(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.CommandProperty, binding);
public static TrayIcon Command(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon Command(this TrayIcon control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.CommandProperty, func, onChanged, expression);
public static TrayIcon Command(this TrayIcon control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static TrayIcon Command<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon CommandParameter(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.CommandParameterProperty, binding);
public static TrayIcon CommandParameter(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon CommandParameter(this TrayIcon control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.CommandParameterProperty, func, onChanged, expression);
public static TrayIcon CommandParameter(this TrayIcon control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static TrayIcon CommandParameter<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon Menu(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.MenuProperty, binding);
public static TrayIcon Menu(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon Menu(this TrayIcon control, Func<NativeMenu> func, Action<NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.MenuProperty, func, onChanged, expression);
public static TrayIcon Menu(this TrayIcon control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static TrayIcon Menu<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon Icon(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.IconProperty, binding);
public static TrayIcon Icon(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon Icon(this TrayIcon control, Func<WindowIcon> func, Action<WindowIcon>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.IconProperty, func, onChanged, expression);
public static TrayIcon Icon(this TrayIcon control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static TrayIcon Icon<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon ToolTipText(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.ToolTipTextProperty, binding);
public static TrayIcon ToolTipText(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon ToolTipText(this TrayIcon control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.ToolTipTextProperty, func, onChanged, expression);
public static TrayIcon ToolTipText(this TrayIcon control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = value, bindingMode, converter, bindingSource);
public static TrayIcon ToolTipText<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon IsVisible(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.IsVisibleProperty, binding);
public static TrayIcon IsVisible(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TrayIcon IsVisible(this TrayIcon control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.IsVisibleProperty, func, onChanged, expression);
public static TrayIcon IsVisible(this TrayIcon control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static TrayIcon IsVisible<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

