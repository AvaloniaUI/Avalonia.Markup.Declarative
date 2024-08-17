#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using VisualBrush = Avalonia.Media.VisualBrush;

namespace Avalonia.Markup.Declarative;
public static partial class VisualBrushExtensions
{
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IBinding binding)
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, binding);
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, func, onChanged, expression);
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Avalonia.Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.VisualBrush Visual<TValue>(this Avalonia.Media.VisualBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Visual> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

