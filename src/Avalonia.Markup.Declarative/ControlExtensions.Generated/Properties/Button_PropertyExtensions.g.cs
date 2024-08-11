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
public static T ClickMode<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.ClickModeProperty, binding);
public static T ClickMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.ClickModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClickMode<T>(this T control, Func<ClickMode> func, Action<ClickMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.ClickModeProperty, func, onChanged, expression);
public static T ClickMode<T>(this T control, ClickMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);
public static T ClickMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ClickMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Command<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDefault<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.IsDefaultProperty, binding);
public static T IsDefault<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDefault<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.IsDefaultProperty, func, onChanged, expression);
public static T IsDefault<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);
public static T IsDefault<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsCancel<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.IsCancelProperty, binding);
public static T IsCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.IsCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsCancel<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.IsCancelProperty, func, onChanged, expression);
public static T IsCancel<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);
public static T IsCancel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Flyout<T>(this T control, IBinding binding) where T : Button
   => control._set(Button.FlyoutProperty, binding);
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Button
   => control._set(Button.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Flyout<T>(this T control, Func<FlyoutBase> func, Action<FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Button
   => control._set(Button.FlyoutProperty, func, onChanged, expression);
public static T Flyout<T>(this T control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static T Flyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Button
=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

