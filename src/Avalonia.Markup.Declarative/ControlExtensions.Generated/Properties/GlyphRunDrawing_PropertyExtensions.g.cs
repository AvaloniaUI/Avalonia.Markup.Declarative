#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class GlyphRunDrawingExtensions
{
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, IBinding binding)
   => control._set(GlyphRunDrawing.ForegroundProperty, binding);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GlyphRunDrawing.ForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GlyphRunDrawing.ForegroundProperty, func, onChanged, expression);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static GlyphRunDrawing Foreground<TValue>(this GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, IBinding binding)
   => control._set(GlyphRunDrawing.GlyphRunProperty, binding);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(GlyphRunDrawing.GlyphRunProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, Func<GlyphRun> func, Action<GlyphRun>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GlyphRunDrawing.GlyphRunProperty, func, onChanged, expression);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, GlyphRun value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = value, bindingMode, converter, bindingSource);
public static GlyphRunDrawing GlyphRun<TValue>(this GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, GlyphRun> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

