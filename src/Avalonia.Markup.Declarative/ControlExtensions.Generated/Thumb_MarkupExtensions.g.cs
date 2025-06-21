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
public static T OnDragStarted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragStartedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.Thumb.DragStartedEvent.RoutingStrategies);
  return control;
}



 // DragDelta

/*ActionToEventGenerator*/
public static T OnDragDelta<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragDeltaEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.Thumb.DragDeltaEvent.RoutingStrategies);
  return control;
}



 // DragCompleted

/*ActionToEventGenerator*/
public static T OnDragCompleted<T>(this T control, Action<Avalonia.Input.VectorEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.Thumb 
{
  control.AddHandler(Avalonia.Controls.Primitives.Thumb.DragCompletedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.Thumb.DragCompletedEvent.RoutingStrategies);
  return control;
}




}
