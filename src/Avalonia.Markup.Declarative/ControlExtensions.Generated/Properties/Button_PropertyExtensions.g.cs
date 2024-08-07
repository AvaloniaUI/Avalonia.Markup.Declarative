#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonExtensions
{
public static Button ClickMode(this Button control, IBinding binding)
   => control._set(Button.ClickModeProperty, binding);
public static Button ClickMode(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.ClickModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button ClickMode(this Button control, Func<ClickMode> func, Action<ClickMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.ClickModeProperty, func, onChanged, expression);
public static Button ClickMode(this Button control, ClickMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);
public static Button ClickMode<TValue>(this Button control, TValue value, FuncValueConverter<TValue, ClickMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button Command(this Button control, IBinding binding)
   => control._set(Button.CommandProperty, binding);
public static Button Command(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button Command(this Button control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.CommandProperty, func, onChanged, expression);
public static Button Command(this Button control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static Button Command<TValue>(this Button control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button HotKey(this Button control, IBinding binding)
   => control._set(Button.HotKeyProperty, binding);
public static Button HotKey(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button HotKey(this Button control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.HotKeyProperty, func, onChanged, expression);
public static Button HotKey(this Button control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static Button HotKey<TValue>(this Button control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button CommandParameter(this Button control, IBinding binding)
   => control._set(Button.CommandParameterProperty, binding);
public static Button CommandParameter(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button CommandParameter(this Button control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.CommandParameterProperty, func, onChanged, expression);
public static Button CommandParameter(this Button control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static Button CommandParameter<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button IsDefault(this Button control, IBinding binding)
   => control._set(Button.IsDefaultProperty, binding);
public static Button IsDefault(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button IsDefault(this Button control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.IsDefaultProperty, func, onChanged, expression);
public static Button IsDefault(this Button control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);
public static Button IsDefault<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button IsCancel(this Button control, IBinding binding)
   => control._set(Button.IsCancelProperty, binding);
public static Button IsCancel(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.IsCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button IsCancel(this Button control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.IsCancelProperty, func, onChanged, expression);
public static Button IsCancel(this Button control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);
public static Button IsCancel<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button Flyout(this Button control, IBinding binding)
   => control._set(Button.FlyoutProperty, binding);
public static Button Flyout(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Button.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Button Flyout(this Button control, Func<FlyoutBase> func, Action<FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.FlyoutProperty, func, onChanged, expression);
public static Button Flyout(this Button control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static Button Flyout<TValue>(this Button control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

