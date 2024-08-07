#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class LabelExtensions
{
public static Label Target(this Label control, IBinding binding)
   => control._set(Label.TargetProperty, binding);
public static Label Target(this Label control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Label.TargetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Label Target(this Label control, Func<IInputElement> func, Action<IInputElement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Label.TargetProperty, func, onChanged, expression);
public static Label Target(this Label control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Label.TargetProperty, ps, () => control.Target = value, bindingMode, converter, bindingSource);
public static Label Target<TValue>(this Label control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Label.TargetProperty, ps, () => control.Target = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

