#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PullGestureRecognizerExtensions
{
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, IBinding binding)
   => control._set(PullGestureRecognizer.PullDirectionProperty, binding);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, Func<PullDirection> func, Action<PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PullGestureRecognizer.PullDirectionProperty, func, onChanged, expression);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static PullGestureRecognizer PullDirection<TValue>(this PullGestureRecognizer control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

