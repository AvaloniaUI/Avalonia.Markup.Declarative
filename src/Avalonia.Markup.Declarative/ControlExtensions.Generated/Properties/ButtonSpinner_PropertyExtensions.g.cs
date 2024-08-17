#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ButtonSpinner = Avalonia.Controls.ButtonSpinner;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonSpinnerExtensions
{
public static T AllowSpin<T>(this T control, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, binding);
public static T AllowSpin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowSpin<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, func, onChanged, expression);
public static T AllowSpin<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static T AllowSpin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T>(this T control, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static T ShowButtonSpinner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ShowButtonSpinner<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, func, onChanged, expression);
public static T ShowButtonSpinner<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static T ShowButtonSpinner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, binding);
public static T ButtonSpinnerLocation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ButtonSpinnerLocation<T>(this T control, Func<Avalonia.Controls.Location> func, Action<Avalonia.Controls.Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ButtonSpinner
   => control._set(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, func, onChanged, expression);
public static T ButtonSpinnerLocation<T>(this T control, Avalonia.Controls.Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static T ButtonSpinnerLocation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ButtonSpinner
=> control._setEx(Avalonia.Controls.ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

