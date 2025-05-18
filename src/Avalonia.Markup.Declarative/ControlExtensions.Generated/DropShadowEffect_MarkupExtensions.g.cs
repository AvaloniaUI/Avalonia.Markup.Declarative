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
public static partial class DropShadowEffect_MarkupExtensions
{
//================= Properties ======================//
 // OffsetX

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetX = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetX(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetXProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.DropShadowEffect OffsetX<TValue>(this Avalonia.Media.DropShadowEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OffsetY

/*ValueSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, System.Double value)  
=> control._set(() => control.OffsetY = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowEffect OffsetY(this Avalonia.Media.DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowEffect.OffsetYProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.DropShadowEffect OffsetY<TValue>(this Avalonia.Media.DropShadowEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
