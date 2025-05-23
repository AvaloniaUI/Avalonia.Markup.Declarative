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
public static partial class BlurEffect_MarkupExtensions
{
//================= Properties ======================//
 // Radius

/*ValueSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, System.Double value)  
=> control._set(() => control.Radius = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.BlurEffect.RadiusProperty, ps, () => control.Radius = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, IBinding binding)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.BlurEffect Radius(this Avalonia.Media.BlurEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.BlurEffect.RadiusProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.BlurEffect Radius<TValue>(this Avalonia.Media.BlurEffect control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.BlurEffect.RadiusProperty, ps, () => control.Radius = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
