#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using ToggleButton = Avalonia.Controls.Primitives.ToggleButton;

namespace Avalonia.Markup.Declarative;
public static partial class ToggleButtonExtensions
{
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsChecked<T>(this T control, Func<System.Nullable<System.Boolean>> func, Action<System.Nullable<System.Boolean>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, func, onChanged, expression);
public static T IsChecked<T>(this T control, System.Nullable<System.Boolean> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static T IsChecked<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Boolean>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsThreeState<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);
public static T IsThreeState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsThreeState<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ToggleButton
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, func, onChanged, expression);
public static T IsThreeState<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value, bindingMode, converter, bindingSource);
public static T IsThreeState<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

