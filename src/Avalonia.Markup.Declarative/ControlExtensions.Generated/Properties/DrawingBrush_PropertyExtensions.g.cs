#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using DrawingBrush = Avalonia.Media.DrawingBrush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DrawingBrushExtensions
{
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, IBinding binding)
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, binding);
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, func, onChanged, expression);
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Avalonia.Media.Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingBrush.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.DrawingBrush Drawing<TValue>(this Avalonia.Media.DrawingBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DrawingBrush.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

