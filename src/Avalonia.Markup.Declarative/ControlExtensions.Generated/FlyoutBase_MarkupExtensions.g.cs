#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class FlyoutBase_MarkupExtensions
{
//================= Properties ======================//

//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
    public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
    public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.Primitives.FlyoutBase => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);



//================= Styles ======================//

}
