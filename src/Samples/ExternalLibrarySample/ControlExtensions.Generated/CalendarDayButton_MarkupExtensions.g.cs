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
public static partial class CalendarDayButton_MarkupExtensions
{
//================= Events ======================//
 // DateSelected

/*ActionToEventGenerator*/
public static T OnDateSelected<T>(this T control, Action<Ursa.Controls.CalendarDayButtonEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.CalendarDayButton 
{
  control.AddHandler(Ursa.Controls.CalendarDayButton.DateSelectedEvent, (_, args) => action(args), routes ?? Ursa.Controls.CalendarDayButton.DateSelectedEvent.RoutingStrategies);
  return control;
}



 // DatePreviewed

/*ActionToEventGenerator*/
public static T OnDatePreviewed<T>(this T control, Action<Ursa.Controls.CalendarDayButtonEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.CalendarDayButton 
{
  control.AddHandler(Ursa.Controls.CalendarDayButton.DatePreviewedEvent, (_, args) => action(args), routes ?? Ursa.Controls.CalendarDayButton.DatePreviewedEvent.RoutingStrategies);
  return control;
}




}
