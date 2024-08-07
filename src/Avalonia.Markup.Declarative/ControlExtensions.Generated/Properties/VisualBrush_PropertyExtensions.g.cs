#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class VisualBrushExtensions
{
public static VisualBrush Visual(this VisualBrush control, IBinding binding)
   => control._set(VisualBrush.VisualProperty, binding);
public static VisualBrush Visual(this VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static VisualBrush Visual(this VisualBrush control, Func<Visual> func, Action<Visual>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VisualBrush.VisualProperty, func, onChanged, expression);
public static VisualBrush Visual(this VisualBrush control, Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VisualBrush.VisualProperty, ps, () => control.Visual = value, bindingMode, converter, bindingSource);
public static VisualBrush Visual<TValue>(this VisualBrush control, TValue value, FuncValueConverter<TValue, Visual> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VisualBrush.VisualProperty, ps, () => control.Visual = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

