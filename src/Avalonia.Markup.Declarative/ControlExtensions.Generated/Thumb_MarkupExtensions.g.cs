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
public static partial class Thumb_MarkupExtensions
{
//================= Events ======================//
 // DragStarted

/*ActionToEventGenerator*/
    public static T OnDragStarted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragStarted += h);


 // DragDelta

/*ActionToEventGenerator*/
    public static T OnDragDelta<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragDelta += h);


 // DragCompleted

/*ActionToEventGenerator*/
    public static T OnDragCompleted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action) where T : Avalonia.Controls.Primitives.Thumb => 
        control._setEvent((System.EventHandler<Avalonia.Input.VectorEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DragCompleted += h);



}
