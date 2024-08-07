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
public static NativeMenuItem Menu(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.MenuProperty, binding);
public static NativeMenuItem Menu(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem Menu(this NativeMenuItem control, Func<NativeMenu> func, Action<NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.MenuProperty, func, onChanged, expression);
public static NativeMenuItem Menu(this NativeMenuItem control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Menu<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Icon(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IconProperty, binding);
public static NativeMenuItem Icon(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem Icon(this NativeMenuItem control, Func<Bitmap> func, Action<Bitmap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IconProperty, func, onChanged, expression);
public static NativeMenuItem Icon(this NativeMenuItem control, Bitmap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Icon<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Bitmap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Header(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.HeaderProperty, binding);
public static NativeMenuItem Header(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem Header(this NativeMenuItem control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.HeaderProperty, func, onChanged, expression);
public static NativeMenuItem Header(this NativeMenuItem control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Header<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem ToolTip(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.ToolTipProperty, binding);
public static NativeMenuItem ToolTip(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.ToolTipProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem ToolTip(this NativeMenuItem control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.ToolTipProperty, func, onChanged, expression);
public static NativeMenuItem ToolTip(this NativeMenuItem control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = value, bindingMode, converter, bindingSource);
public static NativeMenuItem ToolTip<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Gesture(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.GestureProperty, binding);
public static NativeMenuItem Gesture(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem Gesture(this NativeMenuItem control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.GestureProperty, func, onChanged, expression);
public static NativeMenuItem Gesture(this NativeMenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Gesture<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem IsChecked(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IsCheckedProperty, binding);
public static NativeMenuItem IsChecked(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem IsChecked(this NativeMenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IsCheckedProperty, func, onChanged, expression);
public static NativeMenuItem IsChecked(this NativeMenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static NativeMenuItem IsChecked<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem ToggleType(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.ToggleTypeProperty, binding);
public static NativeMenuItem ToggleType(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem ToggleType(this NativeMenuItem control, Func<NativeMenuItemToggleType> func, Action<NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.ToggleTypeProperty, func, onChanged, expression);
public static NativeMenuItem ToggleType(this NativeMenuItem control, NativeMenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static NativeMenuItem ToggleType<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, NativeMenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Command(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.CommandProperty, binding);
public static NativeMenuItem Command(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem Command(this NativeMenuItem control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.CommandProperty, func, onChanged, expression);
public static NativeMenuItem Command(this NativeMenuItem control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Command<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.CommandParameterProperty, binding);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.CommandParameterProperty, func, onChanged, expression);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static NativeMenuItem CommandParameter<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IsEnabledProperty, binding);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IsEnabledProperty, func, onChanged, expression);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static NativeMenuItem IsEnabled<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem IsVisible(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IsVisibleProperty, binding);
public static NativeMenuItem IsVisible(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(NativeMenuItem.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static NativeMenuItem IsVisible(this NativeMenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IsVisibleProperty, func, onChanged, expression);
public static NativeMenuItem IsVisible(this NativeMenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static NativeMenuItem IsVisible<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

