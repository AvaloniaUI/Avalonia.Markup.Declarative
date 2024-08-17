#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using Image = Avalonia.Controls.Image;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ImageExtensions
{
public static T Source<T>(this T control, IBinding binding) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.SourceProperty, binding);
public static T Source<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Source<T>(this T control, Func<Avalonia.Media.IImage> func, Action<Avalonia.Media.IImage>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.SourceProperty, func, onChanged, expression);
public static T Source<T>(this T control, Avalonia.Media.IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static T Source<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchProperty, binding);
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchProperty, func, onChanged, expression);
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static T Stretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T StretchDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty, binding);
public static T StretchDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T StretchDirection<T>(this T control, Func<Avalonia.Media.StretchDirection> func, Action<Avalonia.Media.StretchDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Image
   => control._set(Avalonia.Controls.Image.StretchDirectionProperty, func, onChanged, expression);
public static T StretchDirection<T>(this T control, Avalonia.Media.StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.StretchDirectionProperty, ps, () => control.StretchDirection = value, bindingMode, converter, bindingSource);
public static T StretchDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Image
=> control._setEx(Avalonia.Controls.Image.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

