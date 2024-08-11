#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class AdornerLayerExtensions
{
public static T DefaultFocusAdorner<T>(this T control, IBinding binding) where T : AdornerLayer
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, binding);
public static T DefaultFocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AdornerLayer
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DefaultFocusAdorner<T>(this T control, Func<ITemplate<Control>> func, Action<ITemplate<Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AdornerLayer
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, func, onChanged, expression);
public static T DefaultFocusAdorner<T>(this T control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AdornerLayer
=> control._setEx(AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = value, bindingMode, converter, bindingSource);
public static T DefaultFocusAdorner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AdornerLayer
=> control._setEx(AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

