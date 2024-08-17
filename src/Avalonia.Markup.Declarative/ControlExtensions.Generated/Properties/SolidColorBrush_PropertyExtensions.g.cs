#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using SolidColorBrush = Avalonia.Media.SolidColorBrush;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SolidColorBrushExtensions
{
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, IBinding binding)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, binding);
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.SolidColorBrush.ColorProperty, func, onChanged, expression);
public static Avalonia.Media.SolidColorBrush Color(this Avalonia.Media.SolidColorBrush control, Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SolidColorBrush.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.SolidColorBrush Color<TValue>(this Avalonia.Media.SolidColorBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.SolidColorBrush.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

