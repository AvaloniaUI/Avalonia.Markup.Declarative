#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageExtensions
{
public static Image Source(this Image control, IBinding binding)
   => control._set(Image.SourceProperty, binding);
public static Image Source(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Image.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Image Source(this Image control, Func<IImage> func, Action<IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.SourceProperty, func, onChanged, expression);
public static Image Source(this Image control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static Image Source<TValue>(this Image control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Image Stretch(this Image control, IBinding binding)
   => control._set(Image.StretchProperty, binding);
public static Image Stretch(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Image.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Image Stretch(this Image control, Func<Stretch> func, Action<Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.StretchProperty, func, onChanged, expression);
public static Image Stretch(this Image control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Image Stretch<TValue>(this Image control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Image StretchDirection(this Image control, IBinding binding)
   => control._set(Image.StretchDirectionProperty, binding);
public static Image StretchDirection(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Image.StretchDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static Image StretchDirection(this Image control, Func<StretchDirection> func, Action<StretchDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.StretchDirectionProperty, func, onChanged, expression);
public static Image StretchDirection(this Image control, StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchDirectionProperty, ps, () => control.StretchDirection = value, bindingMode, converter, bindingSource);
public static Image StretchDirection<TValue>(this Image control, TValue value, FuncValueConverter<TValue, StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

