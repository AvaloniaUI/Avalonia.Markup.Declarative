#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using SplitButton = Avalonia.Controls.SplitButton;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class SplitButtonExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Flyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, binding);
public static T Flyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Flyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.FlyoutProperty, func, onChanged, expression);
public static T Flyout<T>(this T control, Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static T Flyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitButton
   => control._set(Avalonia.Controls.SplitButton.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitButton
=> control._setEx(Avalonia.Controls.SplitButton.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

