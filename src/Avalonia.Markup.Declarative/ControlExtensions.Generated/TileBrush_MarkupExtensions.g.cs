#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class TileBrush_MarkupExtensions
{
//================= Properties ======================//
 // AlignmentX

/*BindFromExpressionSetterGenerator*/
public static T AlignmentX<T>(this T control, Func<Avalonia.Media.AlignmentX> func, Action<Avalonia.Media.AlignmentX>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AlignmentX<T>(this T control,Avalonia.Media.AlignmentX value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AlignmentX<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlignmentX<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AlignmentX<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.AlignmentX> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AlignmentY

/*BindFromExpressionSetterGenerator*/
public static T AlignmentY<T>(this T control, Func<Avalonia.Media.AlignmentY> func, Action<Avalonia.Media.AlignmentY>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AlignmentY<T>(this T control,Avalonia.Media.AlignmentY value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AlignmentY<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AlignmentY<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AlignmentY<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.AlignmentY> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DestinationRect

/*BindFromExpressionSetterGenerator*/
public static T DestinationRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DestinationRect<T>(this T control,Avalonia.RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T DestinationRect<T>(this T control, System.Double x = default, System.Double y = default, System.Double width = default, System.Double height = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T DestinationRect<T>(this T control, Avalonia.Rect rect = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(rect, unit));
public static T DestinationRect<T>(this T control, Avalonia.Size size = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point position = default, Avalonia.Size size = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(position, size, unit));
public static T DestinationRect<T>(this T control, Avalonia.Point topLeft = default, Avalonia.Point bottomRight = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.DestinationRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));

/*BindSetterGenerator*/
public static T DestinationRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DestinationRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DestinationRect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SourceRect

/*BindFromExpressionSetterGenerator*/
public static T SourceRect<T>(this T control, Func<Avalonia.RelativeRect> func, Action<Avalonia.RelativeRect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SourceRect<T>(this T control,Avalonia.RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T SourceRect<T>(this T control, System.Double x = default, System.Double y = default, System.Double width = default, System.Double height = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(x, y, width, height, unit));
public static T SourceRect<T>(this T control, Avalonia.Rect rect = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(rect, unit));
public static T SourceRect<T>(this T control, Avalonia.Size size = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point position = default, Avalonia.Size size = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(position, size, unit));
public static T SourceRect<T>(this T control, Avalonia.Point topLeft = default, Avalonia.Point bottomRight = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Media.TileBrush 
   => control._set(() => control.SourceRect = new Avalonia.RelativeRect(topLeft, bottomRight, unit));

/*BindSetterGenerator*/
public static T SourceRect<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SourceRect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SourceRect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Stretch

/*BindFromExpressionSetterGenerator*/
public static T Stretch<T>(this T control, Func<Avalonia.Media.Stretch> func, Action<Avalonia.Media.Stretch>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Stretch<T>(this T control,Avalonia.Media.Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Stretch<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Stretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Stretch<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TileMode

/*BindFromExpressionSetterGenerator*/
public static T TileMode<T>(this T control, Func<Avalonia.Media.TileMode> func, Action<Avalonia.Media.TileMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TileMode<T>(this T control,Avalonia.Media.TileMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.TileModeProperty, ps, () => control.TileMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TileMode<T>(this T control, IBinding binding) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TileMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.TileBrush 
   => control._set(Avalonia.Media.TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TileMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TileMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.TileBrush 
=> control._setEx(Avalonia.Media.TileBrush.TileModeProperty, ps, () => control.TileMode = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
