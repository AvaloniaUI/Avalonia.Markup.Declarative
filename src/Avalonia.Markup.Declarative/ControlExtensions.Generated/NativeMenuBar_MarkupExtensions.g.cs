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
public static partial class NativeMenuBar_MarkupExtensions
{
//================= Attached Properties ======================//
 // EnableMenuItemClickForwarding

/*AttachedPropertyMagicalSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.MenuItem
 => control._setEx(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty, ps, () => Avalonia.Controls.NativeMenuBar.SetEnableMenuItemClickForwarding(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T NativeMenuBar_EnableMenuItemClickForwarding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.MenuItem 
   => control._set(Avalonia.Controls.NativeMenuBar.EnableMenuItemClickForwardingProperty!, func, onChanged, expression);



}
