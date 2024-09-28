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
public static partial class NativeMenuBar_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//
 // EnableMenuItemClickForwardingProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MenuItem
 => control._setEx(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty, ps, () => Avalonia.Controls.NativeMenuBar.SetEnableMenuItemClickForwarding(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
