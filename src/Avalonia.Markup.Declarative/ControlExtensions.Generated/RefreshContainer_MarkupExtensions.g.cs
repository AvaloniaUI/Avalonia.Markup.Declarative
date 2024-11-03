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
public static partial class RefreshContainer_MarkupExtensions
{
//================= Properties ======================//
 // Visualizer

/*BindFromExpressionSetterGenerator*/
public static T Visualizer<T>(this T control, Func<Avalonia.Controls.RefreshVisualizer> func, Action<Avalonia.Controls.RefreshVisualizer>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Visualizer<T>(this T control,Avalonia.Controls.RefreshVisualizer value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.RefreshContainer 
=> control._setEx(Avalonia.Controls.RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Visualizer<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Visualizer<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.VisualizerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Visualizer<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.RefreshVisualizer> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.RefreshContainer 
=> control._setEx(Avalonia.Controls.RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PullDirection

/*BindFromExpressionSetterGenerator*/
public static T PullDirection<T>(this T control, Func<Avalonia.Input.PullDirection> func, Action<Avalonia.Input.PullDirection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PullDirection<T>(this T control,Avalonia.Input.PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.RefreshContainer 
=> control._setEx(Avalonia.Controls.RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PullDirection<T>(this T control, IBinding binding) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PullDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RefreshContainer 
   => control._set(Avalonia.Controls.RefreshContainer.PullDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PullDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.RefreshContainer 
=> control._setEx(Avalonia.Controls.RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // RefreshRequested

/*ActionToEventGenerator*/
public static T OnRefreshRequested<T>(this T control, Action<Avalonia.Controls.RefreshRequestedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = Avalonia.Interactivity.RoutingStrategies.Tunnel | Avalonia.Interactivity.RoutingStrategies.Bubble) where T : Avalonia.Controls.RefreshContainer 
{
  control.AddHandler(Avalonia.Controls.RefreshContainer.RefreshRequestedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // PullDirection

/*ValueStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, Avalonia.Input.PullDirection value) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PullDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.RefreshContainer 
=> style._addSetter(Avalonia.Controls.RefreshContainer.PullDirectionProperty, binding);



}
