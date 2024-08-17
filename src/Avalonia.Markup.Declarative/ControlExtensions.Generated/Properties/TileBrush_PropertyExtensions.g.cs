#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using TileBrush = Avalonia.Media.TileBrush;

namespace Avalonia.Markup.Declarative;
public static partial class TileBrushExtensions
{
public static T AlignmentX<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, binding);
public static T AlignmentX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AlignmentX<T>(this T control, Func<Avalonia.Media.AlignmentX> func, Action<Avalonia.Media.AlignmentX>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, func, onChanged, expression);
public static T AlignmentX<T>(this T control, Avalonia.Media.AlignmentX value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = value, bindingMode, converter, bindingSource);
public static T AlignmentX<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.AlignmentX> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AlignmentY<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, binding);
public static T AlignmentY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AlignmentY<T>(this T control, Func<Avalonia.Media.AlignmentY> func, Action<Avalonia.Media.AlignmentY>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, func, onChanged, expression);
public static T AlignmentY<T>(this T control, Avalonia.Media.AlignmentY value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = value, bindingMode, converter, bindingSource);
public static T AlignmentY<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.AlignmentY> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DestinationRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, binding);
public static T DestinationRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DestinationRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, func, onChanged, expression);
public static T DestinationRect<T>(this T control, Avalonia.RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = value, bindingMode, converter, bindingSource);
public static T DestinationRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T DestinationRect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T DestinationRect<T>(this T control, Rect rect = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(rect, unit));
public static T DestinationRect<T>(this T control, Size size = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(size, unit));
public static T DestinationRect<T>(this T control, Point position = default, Size size = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(position, size, unit));
public static T DestinationRect<T>(this T control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, binding);
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SourceRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, func, onChanged, expression);
public static T SourceRect<T>(this T control, Avalonia.RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static T SourceRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T SourceRect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T SourceRect<T>(this T control, Rect rect = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(rect, unit));
public static T SourceRect<T>(this T control, Size size = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(size, unit));
public static T SourceRect<T>(this T control, Point position = default, Size size = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(position, size, unit));
public static T SourceRect<T>(this T control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default) where T : Avalonia.Media.TileBrush
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.StretchProperty, binding);
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.StretchProperty, func, onChanged, expression);
public static T Stretch<T>(this T control, Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static T Stretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TileMode<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, binding);
public static T TileMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TileMode<T>(this T control, Func<Avalonia.Media.TileMode> func, Action<Avalonia.Media.TileMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, func, onChanged, expression);
public static T TileMode<T>(this T control, Avalonia.Media.TileMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.TileModeProperty, ps, () => control.TileMode = value, bindingMode, converter, bindingSource);
public static T TileMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TileMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush
=> control._setEx(Avalonia.Media.TileBrush.TileModeProperty, ps, () => control.TileMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

