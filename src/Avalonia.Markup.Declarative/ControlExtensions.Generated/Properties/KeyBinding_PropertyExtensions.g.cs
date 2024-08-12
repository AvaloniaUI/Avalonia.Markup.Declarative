#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class KeyBindingExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : KeyBinding
   => control._set(KeyBinding.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : KeyBinding
   => control._set(KeyBinding.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : KeyBinding
   => control._set(KeyBinding.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : KeyBinding
   => control._set(KeyBinding.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : KeyBinding
   => control._set(KeyBinding.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : KeyBinding
   => control._set(KeyBinding.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Gesture<T>(this T control, IBinding binding) where T : KeyBinding
   => control._set(KeyBinding.GestureProperty, binding);
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : KeyBinding
   => control._set(KeyBinding.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Gesture<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : KeyBinding
   => control._set(KeyBinding.GestureProperty, func, onChanged, expression);
public static T Gesture<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static T Gesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : KeyBinding
=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

