#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using KeyBinding = Avalonia.Input.KeyBinding;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class KeyBindingExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Gesture<T>(this T control, IBinding binding) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.GestureProperty, binding);
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Input.KeyBinding
   => control._set(Avalonia.Input.KeyBinding.GestureProperty, func, onChanged, expression);
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static T Gesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Input.KeyBinding
=> control._setEx(Avalonia.Input.KeyBinding.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

