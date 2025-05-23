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
public static partial class DashStyle_MarkupExtensions
{
//================= Properties ======================//
 // Dashes

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Avalonia.Collections.AvaloniaList<System.Double> value)  
=> control._set(() => control.Dashes = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, IBinding binding)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DashStyle.DashesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.DashStyle Dashes<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Offset

/*ValueSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, System.Double value)  
=> control._set(() => control.Offset = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, IBinding binding)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.DashStyle Offset<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
