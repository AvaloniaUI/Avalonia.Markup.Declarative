#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuItemExtensions
{
public static T Menu<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.MenuProperty, binding);
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Menu<T>(this T control, Func<NativeMenu> func, Action<NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.MenuProperty, func, onChanged, expression);
public static T Menu<T>(this T control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static T Menu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<Bitmap> func, Action<Bitmap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, Bitmap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Bitmap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Header<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.HeaderProperty, binding);
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Header<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.HeaderProperty, func, onChanged, expression);
public static T Header<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static T Header<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToolTip<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToolTipProperty, binding);
public static T ToolTip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToolTipProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToolTip<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToolTipProperty, func, onChanged, expression);
public static T ToolTip<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = value, bindingMode, converter, bindingSource);
public static T ToolTip<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Gesture<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.GestureProperty, binding);
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Gesture<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.GestureProperty, func, onChanged, expression);
public static T Gesture<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static T Gesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsChecked<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToggleType<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToggleTypeProperty, binding);
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToggleType<T>(this T control, Func<NativeMenuItemToggleType> func, Action<NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.ToggleTypeProperty, func, onChanged, expression);
public static T ToggleType<T>(this T control, NativeMenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static T ToggleType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, NativeMenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Command<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsEnabled<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsEnabledProperty, binding);
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsEnabledProperty, func, onChanged, expression);
public static T IsEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static T IsEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : NativeMenuItem
   => control._set(NativeMenuItem.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : NativeMenuItem
=> control._setEx(NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

