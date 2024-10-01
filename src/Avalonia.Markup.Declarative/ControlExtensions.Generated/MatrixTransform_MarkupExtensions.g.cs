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
public static partial class MatrixTransform_MarkupExtensions
{
//================= Properties ======================//
 // Matrix

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, Func<Avalonia.Matrix> func, Action<Avalonia.Matrix>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control,Avalonia.Matrix value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.MatrixTransform.MatrixProperty, ps, () => control.Matrix = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default, System.Double skewY = default, System.Double skewX = default, System.Double scaleY = default, System.Double offsetX = default, System.Double offsetY = default)  
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY));
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, System.Double scaleX = default, System.Double skewY = default, System.Double perspX = default, System.Double skewX = default, System.Double scaleY = default, System.Double perspY = default, System.Double offsetX = default, System.Double offsetY = default, System.Double perspZ = default)  
   => control._set(() => control.Matrix = new Avalonia.Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ));

/*BindSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, IBinding binding)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix(this Avalonia.Media.MatrixTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.MatrixTransform.MatrixProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.MatrixTransform Matrix<TValue>(this Avalonia.Media.MatrixTransform control, TValue value, FuncValueConverter<TValue, Avalonia.Matrix> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Media.MatrixTransform.MatrixProperty, ps, () => control.Matrix = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
