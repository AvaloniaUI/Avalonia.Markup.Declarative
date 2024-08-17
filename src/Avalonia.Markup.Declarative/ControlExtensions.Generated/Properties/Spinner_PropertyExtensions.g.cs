#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Spinner = Avalonia.Controls.Spinner;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerExtensions
{
public static T ValidSpinDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Spinner
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, binding);
public static T ValidSpinDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Spinner
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ValidSpinDirection<T>(this T control, Func<Avalonia.Controls.ValidSpinDirections> func, Action<Avalonia.Controls.ValidSpinDirections>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Spinner
   => control._set(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, func, onChanged, expression);
public static T ValidSpinDirection<T>(this T control, Avalonia.Controls.ValidSpinDirections value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Spinner
=> control._setEx(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = value, bindingMode, converter, bindingSource);
public static T ValidSpinDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ValidSpinDirections> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Spinner
=> control._setEx(Avalonia.Controls.Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

