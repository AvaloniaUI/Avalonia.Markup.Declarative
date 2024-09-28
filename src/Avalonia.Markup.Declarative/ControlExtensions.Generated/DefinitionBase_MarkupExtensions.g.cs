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
public static partial class DefinitionBase_MarkupExtensions
{
//================= Properties ======================//
 // SharedSizeGroupProperty

/*BindFromExpressionSetterGenerator*/
public static T DefinitionBase_SharedSizeGroup<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DefinitionBase
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DefinitionBase_SharedSizeGroup<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DefinitionBase
=> control._setEx(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
