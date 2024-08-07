#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SpinnerExtensions
{
public static Spinner ValidSpinDirection(this Spinner control, IBinding binding)
   => control._set(Spinner.ValidSpinDirectionProperty, binding);
public static Spinner ValidSpinDirection(this Spinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Spinner.ValidSpinDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Spinner ValidSpinDirection(this Spinner control, Func<ValidSpinDirections> func, Action<ValidSpinDirections>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Spinner.ValidSpinDirectionProperty, func, onChanged, expression);
public static Spinner ValidSpinDirection(this Spinner control, ValidSpinDirections value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = value, bindingMode, converter, bindingSource);
public static Spinner ValidSpinDirection<TValue>(this Spinner control, TValue value, FuncValueConverter<TValue, ValidSpinDirections> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

