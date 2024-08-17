#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using MenuItem = Avalonia.Controls.MenuItem;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class MenuItemExtensions
{
public static T Command<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, binding);
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandProperty, func, onChanged, expression);
public static T Command<T>(this T control, System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static T Command<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HotKey<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, binding);
public static T HotKey<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HotKey<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.HotKeyProperty, func, onChanged, expression);
public static T HotKey<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static T HotKey<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CommandParameter<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, binding);
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.CommandParameterProperty, func, onChanged, expression);
public static T CommandParameter<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static T CommandParameter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Icon<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IconProperty, binding);
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IconProperty, func, onChanged, expression);
public static T Icon<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static T Icon<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InputGesture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, binding);
public static T InputGesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InputGesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.InputGestureProperty, func, onChanged, expression);
public static T InputGesture<T>(this T control, Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.InputGestureProperty, ps, () => control.InputGesture = value, bindingMode, converter, bindingSource);
public static T InputGesture<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.InputGestureProperty, ps, () => control.InputGesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsSubMenuOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, binding);
public static T IsSubMenuOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsSubMenuOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, func, onChanged, expression);
public static T IsSubMenuOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value, bindingMode, converter, bindingSource);
public static T IsSubMenuOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StaysOpenOnClick<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, binding);
public static T StaysOpenOnClick<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StaysOpenOnClick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, func, onChanged, expression);
public static T StaysOpenOnClick<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = value, bindingMode, converter, bindingSource);
public static T StaysOpenOnClick<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ToggleType<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, binding);
public static T ToggleType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ToggleType<T>(this T control, Func<Avalonia.Controls.MenuItemToggleType> func, Action<Avalonia.Controls.MenuItemToggleType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.ToggleTypeProperty, func, onChanged, expression);
public static T ToggleType<T>(this T control, Avalonia.Controls.MenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static T ToggleType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.MenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T GroupName<T>(this T control, IBinding binding) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, binding);
public static T GroupName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T GroupName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MenuItem
   => control._set(Avalonia.Controls.MenuItem.GroupNameProperty, func, onChanged, expression);
public static T GroupName<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static T GroupName<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
=> control._setEx(Avalonia.Controls.MenuItem.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

