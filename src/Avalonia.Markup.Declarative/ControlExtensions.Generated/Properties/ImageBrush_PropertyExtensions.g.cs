#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageBrushExtensions
{
public static ImageBrush Source(this ImageBrush control, IBinding binding)
   => control._set(ImageBrush.SourceProperty, binding);
public static ImageBrush Source(this ImageBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ImageBrush.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ImageBrush Source(this ImageBrush control, Func<IImageBrushSource> func, Action<IImageBrushSource>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageBrush.SourceProperty, func, onChanged, expression);
public static ImageBrush Source(this ImageBrush control, IImageBrushSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageBrush.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static ImageBrush Source<TValue>(this ImageBrush control, TValue value, FuncValueConverter<TValue, IImageBrushSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageBrush.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

