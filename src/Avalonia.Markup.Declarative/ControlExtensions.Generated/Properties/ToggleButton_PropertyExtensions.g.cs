#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleButtonExtensions
{
public static T IsChecked<T>(this T control, IBinding binding) where T : ToggleButton
   => control._set(ToggleButton.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleButton
   => control._set(ToggleButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<Nullable<Boolean>> func, Action<Nullable<Boolean>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleButton
   => control._set(ToggleButton.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, Nullable<Boolean> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleButton
=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Nullable<Boolean>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleButton
=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsThreeState<T>(this T control, IBinding binding) where T : ToggleButton
   => control._set(ToggleButton.IsThreeStateProperty, binding);
public static T IsThreeState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ToggleButton
   => control._set(ToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsThreeState<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ToggleButton
   => control._set(ToggleButton.IsThreeStateProperty, func, onChanged, expression);
public static T IsThreeState<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleButton
=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value, bindingMode, converter, bindingSource);
public static T IsThreeState<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ToggleButton
=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

