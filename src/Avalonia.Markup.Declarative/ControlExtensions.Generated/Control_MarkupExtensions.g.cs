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
public static partial class Control_MarkupExtensions
{
//================= Properties ======================//
 // FocusAdorner

/*BindFromExpressionSetterGenerator*/
public static T FocusAdorner<T>(this T control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FocusAdorner<T>(this T control,Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FocusAdorner<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.FocusAdornerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FocusAdorner<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.FocusAdornerProperty, ps, () => control.FocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Tag

/*BindFromExpressionSetterGenerator*/
public static T Tag<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Tag<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.TagProperty, ps, () => control.Tag = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Tag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Tag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.TagProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Tag<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.TagProperty, ps, () => control.Tag = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ContextMenu

/*BindFromExpressionSetterGenerator*/
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu> func, Action<Avalonia.Controls.ContextMenu>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ContextMenu<T>(this T control,Avalonia.Controls.ContextMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.ContextMenuProperty, ps, () => control.ContextMenu = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContextMenu<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextMenuProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ContextMenu<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ContextMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.ContextMenuProperty, ps, () => control.ContextMenu = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ContextFlyout

/*BindFromExpressionSetterGenerator*/
public static T ContextFlyout<T>(this T control, Func<Avalonia.Controls.Primitives.FlyoutBase> func, Action<Avalonia.Controls.Primitives.FlyoutBase>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ContextFlyout<T>(this T control,Avalonia.Controls.Primitives.FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContextFlyout<T>(this T control, IBinding binding) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContextFlyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.Control.ContextFlyoutProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ContextFlyout<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control 
=> control._setEx(Avalonia.Controls.Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // ContextRequested

/*ActionToEventGenerator*/
public static T OnContextRequested<T>(this T control, Action<Avalonia.Controls.ContextRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.Control 
{
  if (routes == 0) routes = Avalonia.Controls.Control.ContextRequestedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.Control.ContextRequestedEvent, (_, args) => action(args), routes);
  return control; 
}



 // Loaded

/*ActionToEventGenerator*/
public static T OnLoaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.Control 
{
  if (routes == 0) routes = Avalonia.Controls.Control.LoadedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.Control.LoadedEvent, (_, args) => action(args), routes);
  return control; 
}



 // Unloaded

/*ActionToEventGenerator*/
public static T OnUnloaded<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.Control 
{
  if (routes == 0) routes = Avalonia.Controls.Control.UnloadedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.Control.UnloadedEvent, (_, args) => action(args), routes);
  return control; 
}



 // SizeChanged

/*ActionToEventGenerator*/
public static T OnSizeChanged<T>(this T control, Action<Avalonia.Controls.SizeChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.Control 
{
  if (routes == 0) routes = Avalonia.Controls.Control.SizeChangedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.Control.SizeChangedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // FocusAdorner

/*ValueStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FocusAdorner<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.FocusAdornerProperty, binding);


 // Tag

/*ValueStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Tag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.TagProperty, binding);


 // ContextMenu

/*ValueStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, Avalonia.Controls.ContextMenu value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextMenu<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextMenuProperty, binding);


 // ContextFlyout

/*ValueStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, Avalonia.Controls.Primitives.FlyoutBase value) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ContextFlyout<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Control 
=> style._addSetter(Avalonia.Controls.Control.ContextFlyoutProperty, binding);



}
