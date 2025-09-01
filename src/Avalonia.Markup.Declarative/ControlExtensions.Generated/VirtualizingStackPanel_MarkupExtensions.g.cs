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
public static partial class VirtualizingStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.Orientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AreHorizontalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.AreHorizontalSnapPointsRegular = value!);

/*BindFromExpressionSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AreHorizontalSnapPointsRegular<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AreHorizontalSnapPointsRegular<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AreVerticalSnapPointsRegular

/*ValueSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.AreVerticalSnapPointsRegular = value!);

/*BindFromExpressionSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AreVerticalSnapPointsRegular<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AreVerticalSnapPointsRegular<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CacheLength

/*ValueSetterGenerator*/
public static T CacheLength<T>(this T control, System.Double value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._set(() => control.CacheLength = value!);

/*BindFromExpressionSetterGenerator*/
public static T CacheLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CacheLength<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, ps, () => control.CacheLength = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CacheLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CacheLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.VirtualizingStackPanel 
   => control._set(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CacheLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.VirtualizingStackPanel 
=> control._setEx(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, ps, () => control.CacheLength = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.HorizontalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}



 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.VirtualizingStackPanel 
{
  control.AddHandler(Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.VirtualizingStackPanel.VerticalSnapPointsChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegular

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);


 // CacheLength

/*ValueStyleSetterGenerator*/
public static Style<T> CacheLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CacheLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.VirtualizingStackPanel 
=> style._addSetter(Avalonia.Controls.VirtualizingStackPanel.CacheLengthProperty, binding);



}
