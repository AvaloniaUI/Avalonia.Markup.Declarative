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
public static partial class CalendarButton_MarkupExtensions
{
//================= Events ======================//
 // CalendarLeftMouseButtonDown

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonDown(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerPressedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonDown += h);


 // CalendarLeftMouseButtonUp

/*ActionToEventGenerator*/
public static Avalonia.Controls.Primitives.CalendarButton OnCalendarLeftMouseButtonUp(this Avalonia.Controls.Primitives.CalendarButton control, Action<Avalonia.Input.PointerReleasedEventArgs> action)   => 
 control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarLeftMouseButtonUp += h);



}
