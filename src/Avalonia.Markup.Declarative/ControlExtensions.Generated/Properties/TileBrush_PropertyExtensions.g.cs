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
public static TileBrush AlignmentX(this TileBrush control, IBinding binding)
   => control._set(TileBrush.AlignmentXProperty, binding);
public static TileBrush AlignmentX(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush AlignmentX(this TileBrush control, Func<AlignmentX> func, Action<AlignmentX>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.AlignmentXProperty, func, onChanged, expression);
public static TileBrush AlignmentX(this TileBrush control, AlignmentX value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = value, bindingMode, converter, bindingSource);
public static TileBrush AlignmentX<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, AlignmentX> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush AlignmentY(this TileBrush control, IBinding binding)
   => control._set(TileBrush.AlignmentYProperty, binding);
public static TileBrush AlignmentY(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush AlignmentY(this TileBrush control, Func<AlignmentY> func, Action<AlignmentY>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.AlignmentYProperty, func, onChanged, expression);
public static TileBrush AlignmentY(this TileBrush control, AlignmentY value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = value, bindingMode, converter, bindingSource);
public static TileBrush AlignmentY<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, AlignmentY> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush DestinationRect(this TileBrush control, IBinding binding)
   => control._set(TileBrush.DestinationRectProperty, binding);
public static TileBrush DestinationRect(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush DestinationRect(this TileBrush control, Func<RelativeRect> func, Action<RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.DestinationRectProperty, func, onChanged, expression);
public static TileBrush DestinationRect(this TileBrush control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = value, bindingMode, converter, bindingSource);
public static TileBrush DestinationRect<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TileBrush DestinationRect(this TileBrush control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default)
   => control._set(() => control.DestinationRect = new RelativeRect(x, y, width, height, unit));
public static TileBrush DestinationRect(this TileBrush control, Rect rect = default, RelativeUnit unit = default)
   => control._set(() => control.DestinationRect = new RelativeRect(rect, unit));
public static TileBrush DestinationRect(this TileBrush control, Size size = default, RelativeUnit unit = default)
   => control._set(() => control.DestinationRect = new RelativeRect(size, unit));
public static TileBrush DestinationRect(this TileBrush control, Point position = default, Size size = default, RelativeUnit unit = default)
   => control._set(() => control.DestinationRect = new RelativeRect(position, size, unit));
public static TileBrush DestinationRect(this TileBrush control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default)
   => control._set(() => control.DestinationRect = new RelativeRect(topLeft, bottomRight, unit));
public static TileBrush SourceRect(this TileBrush control, IBinding binding)
   => control._set(TileBrush.SourceRectProperty, binding);
public static TileBrush SourceRect(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush SourceRect(this TileBrush control, Func<RelativeRect> func, Action<RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.SourceRectProperty, func, onChanged, expression);
public static TileBrush SourceRect(this TileBrush control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static TileBrush SourceRect<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TileBrush SourceRect(this TileBrush control, Double x = default, Double y = default, Double width = default, Double height = default, RelativeUnit unit = default)
   => control._set(() => control.SourceRect = new RelativeRect(x, y, width, height, unit));
public static TileBrush SourceRect(this TileBrush control, Rect rect = default, RelativeUnit unit = default)
   => control._set(() => control.SourceRect = new RelativeRect(rect, unit));
public static TileBrush SourceRect(this TileBrush control, Size size = default, RelativeUnit unit = default)
   => control._set(() => control.SourceRect = new RelativeRect(size, unit));
public static TileBrush SourceRect(this TileBrush control, Point position = default, Size size = default, RelativeUnit unit = default)
   => control._set(() => control.SourceRect = new RelativeRect(position, size, unit));
public static TileBrush SourceRect(this TileBrush control, Point topLeft = default, Point bottomRight = default, RelativeUnit unit = default)
   => control._set(() => control.SourceRect = new RelativeRect(topLeft, bottomRight, unit));
public static TileBrush Stretch(this TileBrush control, IBinding binding)
   => control._set(TileBrush.StretchProperty, binding);
public static TileBrush Stretch(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush Stretch(this TileBrush control, Func<Stretch> func, Action<Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.StretchProperty, func, onChanged, expression);
public static TileBrush Stretch(this TileBrush control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static TileBrush Stretch<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush TileMode(this TileBrush control, IBinding binding)
   => control._set(TileBrush.TileModeProperty, binding);
public static TileBrush TileMode(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TileBrush TileMode(this TileBrush control, Func<TileMode> func, Action<TileMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.TileModeProperty, func, onChanged, expression);
public static TileBrush TileMode(this TileBrush control, TileMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = value, bindingMode, converter, bindingSource);
public static TileBrush TileMode<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, TileMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

