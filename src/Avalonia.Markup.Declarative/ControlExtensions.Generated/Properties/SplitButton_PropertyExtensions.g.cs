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
public static partial class SplitButtonExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : SplitButton
   => control._set(SplitButton.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitButton
   => control._set(SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitButton
   => control._set(SplitButton.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : SplitButton
   => control._set(SplitButton.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitButton
   => control._set(SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitButton
   => control._set(SplitButton.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Flyout<T>(this T control, IBinding binding) where T : SplitButton
   => control._set(SplitButton.FlyoutProperty, binding);
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitButton
   => control._set(SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Flyout<T>(this T control, Func<FlyoutBase> func, Action<FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitButton
   => control._set(SplitButton.FlyoutProperty, func, onChanged, expression);
public static T Flyout<T>(this T control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static T Flyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : SplitButton
   => control._set(SplitButton.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitButton
   => control._set(SplitButton.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitButton
   => control._set(SplitButton.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitButton
=> control._setEx(SplitButton.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

