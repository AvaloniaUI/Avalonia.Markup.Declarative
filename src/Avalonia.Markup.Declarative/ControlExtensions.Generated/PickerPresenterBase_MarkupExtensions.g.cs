#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class PickerPresenterBase_MarkupExtensions
{
//================= Events ======================//
 // Confirmed

/*ActionToEventGenerator*/
public static T OnConfirmed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Confirmed += h);


 // Dismissed

/*ActionToEventGenerator*/
public static T OnDismissed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.PickerPresenterBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Dismissed += h);



}
