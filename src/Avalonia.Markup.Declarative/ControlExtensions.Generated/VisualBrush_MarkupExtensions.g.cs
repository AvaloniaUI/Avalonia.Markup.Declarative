#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class VisualBrush_MarkupExtensions
{
//================= Properties ======================//
 // Visual

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control,Avalonia.Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IBinding binding)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.VisualBrush Visual<TValue>(this Avalonia.Media.VisualBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Visual> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
