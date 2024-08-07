#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SolidColorBrushExtensions
{
public static SolidColorBrush Color(this SolidColorBrush control, IBinding binding)
   => control._set(SolidColorBrush.ColorProperty, binding);
public static SolidColorBrush Color(this SolidColorBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SolidColorBrush.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SolidColorBrush Color(this SolidColorBrush control, Func<Color> func, Action<Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SolidColorBrush.ColorProperty, func, onChanged, expression);
public static SolidColorBrush Color(this SolidColorBrush control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SolidColorBrush.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static SolidColorBrush Color<TValue>(this SolidColorBrush control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SolidColorBrush.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

