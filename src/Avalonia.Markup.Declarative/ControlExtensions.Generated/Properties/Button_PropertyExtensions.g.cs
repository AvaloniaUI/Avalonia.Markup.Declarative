#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Button = Avalonia.Controls.Button;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonExtensions
{
public static T ClickMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.ClickModeProperty, binding);
public static T ClickMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.ClickModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ClickMode<T>(this T control, Func<Avalonia.Controls.ClickMode> func, Action<Avalonia.Controls.ClickMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.ClickModeProperty, func, onChanged, expression);
public static T ClickMode<T>(this T control, Avalonia.Controls.ClickMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);
public static T ClickMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ClickMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.ClickModeProperty, ps, () => control.ClickMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDefault<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, binding);
public static T IsDefault<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDefault<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsDefaultProperty, func, onChanged, expression);
public static T IsDefault<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);
public static T IsDefault<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.IsDefaultProperty, ps, () => control.IsDefault = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsCancel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsCancelProperty, binding);
public static T IsCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.IsCancelProperty, func, onChanged, expression);
public static T IsCancel<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);
public static T IsCancel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.IsCancelProperty, ps, () => control.IsCancel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.FlyoutProperty, binding);
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Button
   => control._set(Avalonia.Controls.Button.FlyoutProperty, func, onChanged, expression);
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static T Flyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Button
=> control._setEx(Avalonia.Controls.Button.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

