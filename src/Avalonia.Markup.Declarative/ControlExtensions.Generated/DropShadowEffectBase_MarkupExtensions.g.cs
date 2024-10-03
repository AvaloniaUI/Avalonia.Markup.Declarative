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
public static partial class DropShadowEffectBase_MarkupExtensions
{
//================= Properties ======================//
 // BlurRadius

/*BindFromExpressionSetterGenerator*/
public static T BlurRadius<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BlurRadius<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BlurRadius<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BlurRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BlurRadius<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Color

/*BindFromExpressionSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Color<T>(this T control,Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Color<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Color<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Opacity

/*BindFromExpressionSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Opacity<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.DropShadowEffectBase 
   => control._set(Avalonia.Media.DropShadowEffectBase.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Opacity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.DropShadowEffectBase 
=> control._setEx(Avalonia.Media.DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
