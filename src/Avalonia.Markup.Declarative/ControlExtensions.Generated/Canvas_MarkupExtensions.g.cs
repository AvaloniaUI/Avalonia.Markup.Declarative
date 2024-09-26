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
public static partial class Canvas_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//
 // LeftProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Left<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.AvaloniaObject
 => control._setEx(Avalonia.Controls.Canvas.LeftProperty, ps, () => Avalonia.Controls.Canvas.SetLeft(control, value), bindingMode, converter, bindingSource);


 // TopProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Top<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.AvaloniaObject
 => control._setEx(Avalonia.Controls.Canvas.TopProperty, ps, () => Avalonia.Controls.Canvas.SetTop(control, value), bindingMode, converter, bindingSource);


 // RightProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Right<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.AvaloniaObject
 => control._setEx(Avalonia.Controls.Canvas.RightProperty, ps, () => Avalonia.Controls.Canvas.SetRight(control, value), bindingMode, converter, bindingSource);


 // BottomProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Bottom<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.AvaloniaObject
 => control._setEx(Avalonia.Controls.Canvas.BottomProperty, ps, () => Avalonia.Controls.Canvas.SetBottom(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
