#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class DashStyle_MarkupExtensions
{
//================= Properties ======================//
 // DashesProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, IBinding binding)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DashStyle Dashes(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DashStyle.DashesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.DashStyle Dashes<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.DashesProperty, ps, () => control.Dashes = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OffsetProperty

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, IBinding binding)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DashStyle Offset(this Avalonia.Media.DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(Avalonia.Media.DashStyle.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.DashStyle Offset<TValue>(this Avalonia.Media.DashStyle control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Media.DashStyle.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
