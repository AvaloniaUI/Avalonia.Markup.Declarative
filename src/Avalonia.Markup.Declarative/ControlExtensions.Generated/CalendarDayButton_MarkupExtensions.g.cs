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
public static partial class CalendarDayButton_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//

//================= Events ======================//
 // CalendarDayButtonMouseDown

/*ActionToEventGenerator*/
    public static Avalonia.Controls.Primitives.CalendarDayButton OnCalendarDayButtonMouseDown(this Avalonia.Controls.Primitives.CalendarDayButton control, Action<Avalonia.Input.PointerPressedEventArgs> action) => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerPressedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarDayButtonMouseDown += h);


 // CalendarDayButtonMouseUp

/*ActionToEventGenerator*/
    public static Avalonia.Controls.Primitives.CalendarDayButton OnCalendarDayButtonMouseUp(this Avalonia.Controls.Primitives.CalendarDayButton control, Action<Avalonia.Input.PointerReleasedEventArgs> action) => 
        control._setEvent((System.EventHandler<Avalonia.Input.PointerReleasedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.CalendarDayButtonMouseUp += h);



//================= Styles ======================//

}
