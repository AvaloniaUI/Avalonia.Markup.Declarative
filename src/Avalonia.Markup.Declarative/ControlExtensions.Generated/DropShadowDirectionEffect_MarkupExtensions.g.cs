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
public static partial class DropShadowDirectionEffect_MarkupExtensions
{
//================= Properties ======================//
 // ShadowDepth

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth(this Avalonia.Media.DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect ShadowDepth<TValue>(this Avalonia.Media.DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Direction

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, IBinding binding)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction(this Avalonia.Media.DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.DropShadowDirectionEffect Direction<TValue>(this Avalonia.Media.DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
