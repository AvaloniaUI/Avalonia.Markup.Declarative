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
public static MenuItem Command(this MenuItem control, IBinding binding)
   => control._set(MenuItem.CommandProperty, binding);
public static MenuItem Command(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem Command(this MenuItem control, Func<ICommand> func, Action<ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.CommandProperty, func, onChanged, expression);
public static MenuItem Command(this MenuItem control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static MenuItem Command<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem HotKey(this MenuItem control, IBinding binding)
   => control._set(MenuItem.HotKeyProperty, binding);
public static MenuItem HotKey(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem HotKey(this MenuItem control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.HotKeyProperty, func, onChanged, expression);
public static MenuItem HotKey(this MenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static MenuItem HotKey<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem CommandParameter(this MenuItem control, IBinding binding)
   => control._set(MenuItem.CommandParameterProperty, binding);
public static MenuItem CommandParameter(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem CommandParameter(this MenuItem control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.CommandParameterProperty, func, onChanged, expression);
public static MenuItem CommandParameter(this MenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static MenuItem CommandParameter<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem Icon(this MenuItem control, IBinding binding)
   => control._set(MenuItem.IconProperty, binding);
public static MenuItem Icon(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem Icon(this MenuItem control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.IconProperty, func, onChanged, expression);
public static MenuItem Icon(this MenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static MenuItem Icon<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem InputGesture(this MenuItem control, IBinding binding)
   => control._set(MenuItem.InputGestureProperty, binding);
public static MenuItem InputGesture(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem InputGesture(this MenuItem control, Func<KeyGesture> func, Action<KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.InputGestureProperty, func, onChanged, expression);
public static MenuItem InputGesture(this MenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = value, bindingMode, converter, bindingSource);
public static MenuItem InputGesture<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem IsSubMenuOpen(this MenuItem control, IBinding binding)
   => control._set(MenuItem.IsSubMenuOpenProperty, binding);
public static MenuItem IsSubMenuOpen(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem IsSubMenuOpen(this MenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.IsSubMenuOpenProperty, func, onChanged, expression);
public static MenuItem IsSubMenuOpen(this MenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value, bindingMode, converter, bindingSource);
public static MenuItem IsSubMenuOpen<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem StaysOpenOnClick(this MenuItem control, IBinding binding)
   => control._set(MenuItem.StaysOpenOnClickProperty, binding);
public static MenuItem StaysOpenOnClick(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem StaysOpenOnClick(this MenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.StaysOpenOnClickProperty, func, onChanged, expression);
public static MenuItem StaysOpenOnClick(this MenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = value, bindingMode, converter, bindingSource);
public static MenuItem StaysOpenOnClick<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem ToggleType(this MenuItem control, IBinding binding)
   => control._set(MenuItem.ToggleTypeProperty, binding);
public static MenuItem ToggleType(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem ToggleType(this MenuItem control, Func<MenuItemToggleType> func, Action<MenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.ToggleTypeProperty, func, onChanged, expression);
public static MenuItem ToggleType(this MenuItem control, MenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static MenuItem ToggleType<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, MenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem IsChecked(this MenuItem control, IBinding binding)
   => control._set(MenuItem.IsCheckedProperty, binding);
public static MenuItem IsChecked(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem IsChecked(this MenuItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.IsCheckedProperty, func, onChanged, expression);
public static MenuItem IsChecked(this MenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static MenuItem IsChecked<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem GroupName(this MenuItem control, IBinding binding)
   => control._set(MenuItem.GroupNameProperty, binding);
public static MenuItem GroupName(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(MenuItem.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static MenuItem GroupName(this MenuItem control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.GroupNameProperty, func, onChanged, expression);
public static MenuItem GroupName(this MenuItem control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static MenuItem GroupName<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

