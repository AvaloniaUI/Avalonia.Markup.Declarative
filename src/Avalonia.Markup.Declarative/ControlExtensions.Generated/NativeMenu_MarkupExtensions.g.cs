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
public static partial class NativeMenu_MarkupExtensions
{
//================= Attached Properties ======================//
 // Menu

/*AttachedPropertyMagicalSetterGenerator*/
public static T NativeMenu_Menu<T>(this T control, Avalonia.Controls.NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.AvaloniaObject
 => control._setEx(Avalonia.Controls.NativeMenu.MenuProperty, ps, () => Avalonia.Controls.NativeMenu.SetMenu(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T NativeMenu_Menu<T>(this T control, Func<Avalonia.Controls.NativeMenu> func, Action<Avalonia.Controls.NativeMenu>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.AvaloniaObject 
   => control._set(Avalonia.Controls.NativeMenu.MenuProperty, func, onChanged, expression);



//================= Events ======================//
 // NeedsUpdate

/*ActionToEventGenerator*/
public static T OnNeedsUpdate<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.NeedsUpdate += h);


 // Opening

/*ActionToEventGenerator*/
public static T OnOpening<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Opening += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.NativeMenu  => 
 control._setEvent((System.EventHandler<System.EventArgs>) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



}
