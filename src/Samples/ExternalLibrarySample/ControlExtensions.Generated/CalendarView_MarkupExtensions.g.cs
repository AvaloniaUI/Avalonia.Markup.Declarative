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
public static partial class CalendarView_MarkupExtensions
{
//================= Properties ======================//
 // IsTodayHighlighted

/*ValueSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value) where T : Ursa.Controls.CalendarView 
=> control._set(() => control.IsTodayHighlighted = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.IsTodayHighlightedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTodayHighlighted<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.CalendarView 
=> control._setEx(Ursa.Controls.CalendarView.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.IsTodayHighlightedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTodayHighlighted<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.CalendarView 
=> control._setEx(Ursa.Controls.CalendarView.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FirstDayOfWeek

/*ValueSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value) where T : Ursa.Controls.CalendarView 
=> control._set(() => control.FirstDayOfWeek = value!);

/*BindFromExpressionSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.FirstDayOfWeekProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FirstDayOfWeek<T>(this T control,System.DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.CalendarView 
=> control._setEx(Ursa.Controls.CalendarView.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.FirstDayOfWeekProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.CalendarView 
   => control._set(Ursa.Controls.CalendarView.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FirstDayOfWeek<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.CalendarView 
=> control._setEx(Ursa.Controls.CalendarView.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // DateSelected

/*ActionToEventGenerator*/
public static T OnDateSelected<T>(this T control, Action<Ursa.Controls.CalendarDayButtonEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.CalendarView 
{
  control.AddHandler(Ursa.Controls.CalendarView.DateSelectedEvent, (_, args) => action(args), routes ?? Ursa.Controls.CalendarView.DateSelectedEvent.RoutingStrategies);
  return control;
}



 // DatePreviewed

/*ActionToEventGenerator*/
public static T OnDatePreviewed<T>(this T control, Action<Ursa.Controls.CalendarDayButtonEventArgs> action) where T : Ursa.Controls.CalendarView  => 
 control._setEvent((System.EventHandler<Ursa.Controls.CalendarDayButtonEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DatePreviewed += h);



//================= Styles ======================//
 // IsTodayHighlighted

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.CalendarView 
=> style._addSetter(Ursa.Controls.CalendarView.IsTodayHighlightedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.CalendarView 
=> style._addSetter(Ursa.Controls.CalendarView.IsTodayHighlightedProperty, binding);


 // FirstDayOfWeek

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Ursa.Controls.CalendarView 
=> style._addSetter(Ursa.Controls.CalendarView.FirstDayOfWeekProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.CalendarView 
=> style._addSetter(Ursa.Controls.CalendarView.FirstDayOfWeekProperty, binding);



}
