#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Label = Avalonia.Controls.Label;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LabelExtensions
{
public static T Target<T>(this T control, IBinding binding) where T : Avalonia.Controls.Label
   => control._set(Avalonia.Controls.Label.TargetProperty, binding);
public static T Target<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Label
   => control._set(Avalonia.Controls.Label.TargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Target<T>(this T control, Func<Avalonia.Input.IInputElement> func, Action<Avalonia.Input.IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Label
   => control._set(Avalonia.Controls.Label.TargetProperty, func, onChanged, expression);
public static T Target<T>(this T control, Avalonia.Input.IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Label
=> control._setEx(Avalonia.Controls.Label.TargetProperty, ps, () => control.Target = value, bindingMode, converter, bindingSource);
public static T Target<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Label
=> control._setEx(Avalonia.Controls.Label.TargetProperty, ps, () => control.Target = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

