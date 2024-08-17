#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using WindowBase = Avalonia.Controls.WindowBase;

namespace Avalonia.Markup.Declarative;
public static partial class WindowBaseExtensions
{
public static T Topmost<T>(this T control, IBinding binding) where T : Avalonia.Controls.WindowBase
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, binding);
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WindowBase
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WindowBase
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, func, onChanged, expression);
public static T Topmost<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WindowBase
=> control._setEx(Avalonia.Controls.WindowBase.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static T Topmost<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WindowBase
=> control._setEx(Avalonia.Controls.WindowBase.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

