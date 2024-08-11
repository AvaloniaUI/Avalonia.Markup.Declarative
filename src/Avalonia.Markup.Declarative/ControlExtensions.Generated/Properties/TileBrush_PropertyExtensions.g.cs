#nullable enable
using Avalonia;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TileBrushExtensions
{
public static T AlignmentX<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.AlignmentXProperty, binding);
public static T AlignmentX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AlignmentX<T>(this T control, Func<AlignmentX> func, Action<AlignmentX>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.AlignmentXProperty, func, onChanged, expression);
public static T AlignmentX<T>(this T control, AlignmentX value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = value, bindingMode, converter, bindingSource);
public static T AlignmentX<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AlignmentX> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AlignmentY<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.AlignmentYProperty, binding);
public static T AlignmentY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AlignmentY<T>(this T control, Func<AlignmentY> func, Action<AlignmentY>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.AlignmentYProperty, func, onChanged, expression);
public static T AlignmentY<T>(this T control, AlignmentY value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = value, bindingMode, converter, bindingSource);
public static T AlignmentY<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AlignmentY> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DestinationRect<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.DestinationRectProperty, binding);
public static T DestinationRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DestinationRect<T>(this T control, Func<RelativeRect> func, Action<RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.DestinationRectProperty, func, onChanged, expression);
public static T DestinationRect<T>(this T control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = value, bindingMode, converter, bindingSource);
public static T DestinationRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T DestinationRect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.DestinationRect = new RelativeRect(x, y, width, height, unit));
public static T DestinationRect<T>(this T control, Rect rect = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.DestinationRect = new RelativeRect(rect, unit));
public static T DestinationRect<T>(this T control, Size size = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.DestinationRect = new RelativeRect(size, unit));
public static T DestinationRect<T>(this T control, Point position = default, Size size = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.DestinationRect = new RelativeRect(position, size, unit));
public static T DestinationRect<T>(this T control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.DestinationRect = new RelativeRect(topLeft, bottomRight, unit));
public static T SourceRect<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.SourceRectProperty, binding);
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SourceRect<T>(this T control, Func<RelativeRect> func, Action<RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.SourceRectProperty, func, onChanged, expression);
public static T SourceRect<T>(this T control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static T SourceRect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T SourceRect<T>(this T control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.SourceRect = new RelativeRect(x, y, width, height, unit));
public static T SourceRect<T>(this T control, Rect rect = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.SourceRect = new RelativeRect(rect, unit));
public static T SourceRect<T>(this T control, Size size = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.SourceRect = new RelativeRect(size, unit));
public static T SourceRect<T>(this T control, Point position = default, Size size = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.SourceRect = new RelativeRect(position, size, unit));
public static T SourceRect<T>(this T control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default) where T : TileBrush
   => control._set(() => control.SourceRect = new RelativeRect(topLeft, bottomRight, unit));
public static T Stretch<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.StretchProperty, binding);
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Stretch<T>(this T control, Func<Stretch> func, Action<Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.StretchProperty, func, onChanged, expression);
public static T Stretch<T>(this T control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static T Stretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TileMode<T>(this T control, IBinding binding) where T : TileBrush
   => control._set(TileBrush.TileModeProperty, binding);
public static T TileMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TileBrush
   => control._set(TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TileMode<T>(this T control, Func<TileMode> func, Action<TileMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TileBrush
   => control._set(TileBrush.TileModeProperty, func, onChanged, expression);
public static T TileMode<T>(this T control, TileMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = value, bindingMode, converter, bindingSource);
public static T TileMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TileMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TileBrush
=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

