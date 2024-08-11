#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class MenuItemExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InputGesture<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.InputGestureProperty, binding);
public static T InputGesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InputGesture<T>(this T control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.InputGestureProperty, func, onChanged, expression);
public static T InputGesture<T>(this T control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = value, bindingMode, converter, bindingSource);
public static T InputGesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsSubMenuOpen<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.IsSubMenuOpenProperty, binding);
public static T IsSubMenuOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsSubMenuOpen<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.IsSubMenuOpenProperty, func, onChanged, expression);
public static T IsSubMenuOpen<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value, bindingMode, converter, bindingSource);
public static T IsSubMenuOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StaysOpenOnClick<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.StaysOpenOnClickProperty, binding);
public static T StaysOpenOnClick<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StaysOpenOnClick<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.StaysOpenOnClickProperty, func, onChanged, expression);
public static T StaysOpenOnClick<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = value, bindingMode, converter, bindingSource);
public static T StaysOpenOnClick<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToggleType<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.ToggleTypeProperty, binding);
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToggleType<T>(this T control, Func<MenuItemToggleType> func, Action<MenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.ToggleTypeProperty, func, onChanged, expression);
public static T ToggleType<T>(this T control, MenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static T ToggleType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, MenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsChecked<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T GroupName<T>(this T control, IBinding binding) where T : MenuItem
   => control._set(MenuItem.GroupNameProperty, binding);
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : MenuItem
   => control._set(MenuItem.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T GroupName<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : MenuItem
   => control._set(MenuItem.GroupNameProperty, func, onChanged, expression);
public static T GroupName<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static T GroupName<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : MenuItem
=> control._setEx(MenuItem.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

