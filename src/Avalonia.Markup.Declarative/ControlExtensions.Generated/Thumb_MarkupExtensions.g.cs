#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Thumb_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//

//================= Events ======================//
 // DragStarted

/*ActionToEventGenerator*/
public static T OnDragStarted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragStartedEvent, (_, args) => action(args), routes);
  return control; 
}



 // DragDelta

/*ActionToEventGenerator*/
public static T OnDragDelta<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragDeltaEvent, (_, args) => action(args), routes);
  return control; 
}



 // DragCompleted

/*ActionToEventGenerator*/
public static T OnDragCompleted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragCompletedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//

}
