#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Border_MarkupExtensions
{
//================= Properties ======================//
 // BackgroundProperty

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BackgroundSizingProperty

/*BindFromExpressionSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Func<Avalonia.Media.BackgroundSizing> func, Action<Avalonia.Media.BackgroundSizing>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BackgroundSizing<T>(this T control, Avalonia.Media.BackgroundSizing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BackgroundSizing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BackgroundSizingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BackgroundSizing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BackgroundSizing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BackgroundSizingProperty, ps, () => control.BackgroundSizing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderBrushProperty

/*BindFromExpressionSetterGenerator*/
public static T BorderBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderBrush<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BorderBrush<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BorderThicknessProperty

/*BindFromExpressionSetterGenerator*/
public static T BorderThickness<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BorderThickness<T>(this T control, Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T BorderThickness<T>(this T control, System.Double uniformLength = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(uniformLength));
public static T BorderThickness<T>(this T control, System.Double horizontal = default, System.Double vertical = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, System.Double left = default, System.Double top = default, System.Double right = default, System.Double bottom = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BorderThickness = new Avalonia.Thickness(left, top, right, bottom));

/*BindSetterGenerator*/
public static T BorderThickness<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BorderThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BorderThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CornerRadiusProperty

/*BindFromExpressionSetterGenerator*/
public static T CornerRadius<T>(this T control, Func<Avalonia.CornerRadius> func, Action<Avalonia.CornerRadius>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CornerRadius<T>(this T control, Avalonia.CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T CornerRadius<T>(this T control, System.Double uniformRadius = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, System.Double top = default, System.Double bottom = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, System.Double topLeft = default, System.Double topRight = default, System.Double bottomRight = default, System.Double bottomLeft = default) where T : Avalonia.Controls.Border
   => control._set(() => control.CornerRadius = new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));

/*BindSetterGenerator*/
public static T CornerRadius<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.CornerRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BoxShadowProperty

/*BindFromExpressionSetterGenerator*/
public static T BoxShadow<T>(this T control, Func<Avalonia.Media.BoxShadows> func, Action<Avalonia.Media.BoxShadows>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow shadow = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(shadow));
public static T BoxShadow<T>(this T control, Avalonia.Media.BoxShadow first = default, Avalonia.Media.BoxShadow[] rest = default) where T : Avalonia.Controls.Border
   => control._set(() => control.BoxShadow = new Avalonia.Media.BoxShadows(first, rest));

/*BindSetterGenerator*/
public static T BoxShadow<T>(this T control, IBinding binding) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BoxShadow<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Border
   => control._set(Avalonia.Controls.Border.BoxShadowProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BoxShadow<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Border
=> control._setEx(Avalonia.Controls.Border.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // BackgroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BackgroundProperty, binding);


 // BackgroundSizingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, Avalonia.Media.BackgroundSizing value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BackgroundSizing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BackgroundSizingProperty, binding);


 // BorderBrushProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderBrush<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BorderBrushProperty, binding);


 // BorderThicknessProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, Avalonia.Thickness value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BorderThickness<T>(this Style<T> style, System.Double uniformLength) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(uniformLength));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> BorderThickness<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.BorderThicknessProperty, new Avalonia.Thickness(left, top, right, bottom));


 // CornerRadiusProperty

/*ValueStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, Avalonia.CornerRadius value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> CornerRadius<T>(this Style<T> style, System.Double uniformRadius) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(uniformRadius));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double top, System.Double bottom) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(top, bottom));public static Style<T> CornerRadius<T>(this Style<T> style, System.Double topLeft, System.Double topRight, System.Double bottomRight, System.Double bottomLeft) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.CornerRadiusProperty, new Avalonia.CornerRadius(topLeft, topRight, bottomRight, bottomLeft));


 // BoxShadowProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadows value) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Border
=> style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow shadow) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(shadow));public static Style<T> BoxShadow<T>(this Style<T> style, Avalonia.Media.BoxShadow first, Avalonia.Media.BoxShadow[] rest) where T : Avalonia.Controls.Border
   => style._addSetter(Avalonia.Controls.Border.BoxShadowProperty, new Avalonia.Media.BoxShadows(first, rest));



}
