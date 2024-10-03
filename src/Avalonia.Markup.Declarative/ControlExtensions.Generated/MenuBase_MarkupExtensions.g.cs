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
public static partial class MenuBase_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//

//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase 
{
  control.AddHandler(Avalonia.Controls.MenuBase.OpenedEvent, (_, args) => action(args), routes);
  return control; 
}



 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.MenuBase 
{
  control.AddHandler(Avalonia.Controls.MenuBase.ClosedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//

}
