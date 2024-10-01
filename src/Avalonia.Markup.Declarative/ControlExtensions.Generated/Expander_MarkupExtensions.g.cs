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
public static partial class Expander_MarkupExtensions
{
//================= Properties ======================//
 // ContentTransition

/*BindFromExpressionSetterGenerator*/
public static T ContentTransition<T>(this T control, Func<Avalonia.Animation.IPageTransition> func, Action<Avalonia.Animation.IPageTransition>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ContentTransition<T>(this T control,Avalonia.Animation.IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContentTransition<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTransition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ContentTransition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.ContentTransitionProperty, ps, () => control.ContentTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ExpandDirection

/*BindFromExpressionSetterGenerator*/
public static T ExpandDirection<T>(this T control, Func<Avalonia.Controls.ExpandDirection> func, Action<Avalonia.Controls.ExpandDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ExpandDirection<T>(this T control,Avalonia.Controls.ExpandDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ExpandDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ExpandDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ExpandDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ExpandDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsExpanded

/*BindFromExpressionSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsExpanded<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsExpanded<T>(this T control, IBinding binding) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Expander 
   => control._set(Avalonia.Controls.Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsExpanded<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Expander 
=> control._setEx(Avalonia.Controls.Expander.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // Collapsed

/*ActionToEventGenerator*/
    public static T OnCollapsed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Collapsed += h);


 // Collapsing

/*ActionToEventGenerator*/
    public static T OnCollapsing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Collapsing += h);


 // Expanded

/*ActionToEventGenerator*/
    public static T OnExpanded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Expanded += h);


 // Expanding

/*ActionToEventGenerator*/
    public static T OnExpanding<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action) where T : Avalonia.Controls.Expander => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.CancelRoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Expanding += h);



//================= Styles ======================//
 // ContentTransition

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, Avalonia.Animation.IPageTransition value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTransition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ContentTransitionProperty, binding);


 // ExpandDirection

/*ValueStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, Avalonia.Controls.ExpandDirection value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ExpandDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.ExpandDirectionProperty, binding);


 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Expander 
=> style._addSetter(Avalonia.Controls.Expander.IsExpandedProperty, binding);



}
