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
public static partial class CalendarYearButton_MarkupExtensions
{
//================= Events ======================//
 // ItemSelected

/*ActionToEventGenerator*/
public static T OnItemSelected<T>(this T control, Action<Ursa.Controls.CalendarYearButtonEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.CalendarYearButton 
{
  control.AddHandler(Ursa.Controls.CalendarYearButton.ItemSelectedEvent, (_, args) => action(args), routes ?? Ursa.Controls.CalendarYearButton.ItemSelectedEvent.RoutingStrategies);
  return control;
}




}
