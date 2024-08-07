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
public static SplitButton Command(this SplitButton control, IBinding binding)
   => control._set(SplitButton.CommandProperty, binding);
public static SplitButton Command(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitButton Command(this SplitButton control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.CommandProperty, func, onChanged, expression);
public static SplitButton Command(this SplitButton control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static SplitButton Command<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitButton CommandParameter(this SplitButton control, IBinding binding)
   => control._set(SplitButton.CommandParameterProperty, binding);
public static SplitButton CommandParameter(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitButton CommandParameter(this SplitButton control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.CommandParameterProperty, func, onChanged, expression);
public static SplitButton CommandParameter(this SplitButton control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static SplitButton CommandParameter<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitButton Flyout(this SplitButton control, IBinding binding)
   => control._set(SplitButton.FlyoutProperty, binding);
public static SplitButton Flyout(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitButton Flyout(this SplitButton control, Func<FlyoutBase> func, Action<FlyoutBase>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.FlyoutProperty, func, onChanged, expression);
public static SplitButton Flyout(this SplitButton control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static SplitButton Flyout<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitButton HotKey(this SplitButton control, IBinding binding)
   => control._set(SplitButton.HotKeyProperty, binding);
public static SplitButton HotKey(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitButton.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitButton HotKey(this SplitButton control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.HotKeyProperty, func, onChanged, expression);
public static SplitButton HotKey(this SplitButton control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static SplitButton HotKey<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

