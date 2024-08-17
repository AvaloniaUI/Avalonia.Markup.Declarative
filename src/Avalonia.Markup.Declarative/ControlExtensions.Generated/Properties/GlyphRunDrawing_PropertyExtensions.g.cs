#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using GlyphRunDrawing = Avalonia.Media.GlyphRunDrawing;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GlyphRunDrawingExtensions
{
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, binding);
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, func, onChanged, expression);
public static Avalonia.Media.GlyphRunDrawing Foreground(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.GlyphRunDrawing Foreground<TValue>(this Avalonia.Media.GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, IBinding binding)
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, binding);
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Func<Avalonia.Media.GlyphRun> func, Action<Avalonia.Media.GlyphRun>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, func, onChanged, expression);
public static Avalonia.Media.GlyphRunDrawing GlyphRun(this Avalonia.Media.GlyphRunDrawing control, Avalonia.Media.GlyphRun value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = value, bindingMode, converter, bindingSource);
public static Avalonia.Media.GlyphRunDrawing GlyphRun<TValue>(this Avalonia.Media.GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, Avalonia.Media.GlyphRun> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

