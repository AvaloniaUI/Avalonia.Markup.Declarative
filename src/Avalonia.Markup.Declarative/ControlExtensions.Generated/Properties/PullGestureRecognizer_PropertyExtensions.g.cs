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
public static T PullDirection<T>(this T control, IBinding binding) where T : PullGestureRecognizer
   => control._set(PullGestureRecognizer.PullDirectionProperty, binding);
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : PullGestureRecognizer
   => control._set(PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PullDirection<T>(this T control, Func<PullDirection> func, Action<PullDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : PullGestureRecognizer
   => control._set(PullGestureRecognizer.PullDirectionProperty, func, onChanged, expression);
public static T PullDirection<T>(this T control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PullGestureRecognizer
=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static T PullDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PullGestureRecognizer
=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

