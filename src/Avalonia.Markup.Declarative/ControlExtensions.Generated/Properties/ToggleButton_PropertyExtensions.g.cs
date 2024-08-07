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
public static ToggleButton IsChecked(this ToggleButton control, IBinding binding)
   => control._set(ToggleButton.IsCheckedProperty, binding);
public static ToggleButton IsChecked(this ToggleButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ToggleButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ToggleButton IsChecked(this ToggleButton control, Func<Nullable<Boolean>> func, Action<Nullable<Boolean>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleButton.IsCheckedProperty, func, onChanged, expression);
public static ToggleButton IsChecked(this ToggleButton control, Nullable<Boolean> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static ToggleButton IsChecked<TValue>(this ToggleButton control, TValue value, FuncValueConverter<TValue, Nullable<Boolean>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleButton IsThreeState(this ToggleButton control, IBinding binding)
   => control._set(ToggleButton.IsThreeStateProperty, binding);
public static ToggleButton IsThreeState(this ToggleButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ToggleButton IsThreeState(this ToggleButton control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleButton.IsThreeStateProperty, func, onChanged, expression);
public static ToggleButton IsThreeState(this ToggleButton control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value, bindingMode, converter, bindingSource);
public static ToggleButton IsThreeState<TValue>(this ToggleButton control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

