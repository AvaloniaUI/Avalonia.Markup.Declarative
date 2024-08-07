#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseExtensions
{
public static WindowBase Topmost(this WindowBase control, IBinding binding)
   => control._set(WindowBase.TopmostProperty, binding);
public static WindowBase Topmost(this WindowBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(WindowBase.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static WindowBase Topmost(this WindowBase control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowBase.TopmostProperty, func, onChanged, expression);
public static WindowBase Topmost(this WindowBase control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowBase.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static WindowBase Topmost<TValue>(this WindowBase control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowBase.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

