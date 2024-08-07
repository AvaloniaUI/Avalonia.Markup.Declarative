#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingBrushExtensions
{
public static DrawingBrush Drawing(this DrawingBrush control, IBinding binding)
   => control._set(DrawingBrush.DrawingProperty, binding);
public static DrawingBrush Drawing(this DrawingBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DrawingBrush.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DrawingBrush Drawing(this DrawingBrush control, Func<Drawing> func, Action<Drawing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingBrush.DrawingProperty, func, onChanged, expression);
public static DrawingBrush Drawing(this DrawingBrush control, Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingBrush.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static DrawingBrush Drawing<TValue>(this DrawingBrush control, TValue value, FuncValueConverter<TValue, Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingBrush.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

