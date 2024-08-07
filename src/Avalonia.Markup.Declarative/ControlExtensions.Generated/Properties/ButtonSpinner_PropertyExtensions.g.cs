#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ButtonSpinnerExtensions
{
public static ButtonSpinner AllowSpin(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.AllowSpinProperty, binding);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ButtonSpinner.AllowSpinProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.AllowSpinProperty, func, onChanged, expression);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static ButtonSpinner AllowSpin<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, func, onChanged, expression);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static ButtonSpinner ShowButtonSpinner<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, binding);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Func<Location> func, Action<Location>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, func, onChanged, expression);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static ButtonSpinner ButtonSpinnerLocation<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

