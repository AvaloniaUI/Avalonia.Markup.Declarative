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
public static KeyBinding Command(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.CommandProperty, binding);
public static KeyBinding Command(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(KeyBinding.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static KeyBinding Command(this KeyBinding control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.CommandProperty, func, onChanged, expression);
public static KeyBinding Command(this KeyBinding control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static KeyBinding Command<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static KeyBinding CommandParameter(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.CommandParameterProperty, binding);
public static KeyBinding CommandParameter(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(KeyBinding.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static KeyBinding CommandParameter(this KeyBinding control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.CommandParameterProperty, func, onChanged, expression);
public static KeyBinding CommandParameter(this KeyBinding control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static KeyBinding CommandParameter<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static KeyBinding Gesture(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.GestureProperty, binding);
public static KeyBinding Gesture(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(KeyBinding.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static KeyBinding Gesture(this KeyBinding control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.GestureProperty, func, onChanged, expression);
public static KeyBinding Gesture(this KeyBinding control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static KeyBinding Gesture<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

