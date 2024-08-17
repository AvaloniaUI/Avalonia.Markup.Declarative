#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Media.Imaging;
using NativeMenuItem = Avalonia.Controls.NativeMenuItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class NativeMenuItemExtensions
{
public static T Menu<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, binding);
public static T Menu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.MenuProperty, func, onChanged, expression);
public static T Menu<T>(this T control, Avalonia.Controls.NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static T Menu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<Avalonia.Media.Imaging.Bitmap> func, Action<Avalonia.Media.Imaging.Bitmap>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, Avalonia.Media.Imaging.Bitmap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Imaging.Bitmap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, binding);
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Header<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.HeaderProperty, func, onChanged, expression);
public static T Header<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static T Header<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToolTip<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, binding);
public static T ToolTip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToolTip<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToolTipProperty, func, onChanged, expression);
public static T ToolTip<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = value, bindingMode, converter, bindingSource);
public static T ToolTip<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToolTipProperty, ps, () => control.ToolTip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Gesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, binding);
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.GestureProperty, func, onChanged, expression);
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static T Gesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, binding);
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.NativeMenuItemToggleType> func, Action<Avalonia.Controls.NativeMenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, func, onChanged, expression);
public static T ToggleType<T>(this T control, Avalonia.Controls.NativeMenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static T ToggleType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.NativeMenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, binding);
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, func, onChanged, expression);
public static T IsEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static T IsEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.NativeMenuItem
   => control._set(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, func, onChanged, expression);
public static T IsVisible<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.NativeMenuItem
=> control._setEx(Avalonia.Controls.NativeMenuItem.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

