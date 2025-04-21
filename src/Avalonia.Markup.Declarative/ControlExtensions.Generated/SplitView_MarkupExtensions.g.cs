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
public static partial class SplitView_MarkupExtensions
{
//================= Properties ======================//
 // CompactPaneLength

/*BindFromExpressionSetterGenerator*/
public static T CompactPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CompactPaneLength<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CompactPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CompactPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CompactPaneLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayMode

/*BindFromExpressionSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayMode<T>(this T control,Avalonia.Controls.SplitViewDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SplitViewDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsPaneOpen

/*BindFromExpressionSetterGenerator*/
public static T IsPaneOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsPaneOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsPaneOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsPaneOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsPaneOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OpenPaneLength

/*BindFromExpressionSetterGenerator*/
public static T OpenPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OpenPaneLength<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OpenPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OpenPaneLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PaneBackground

/*BindFromExpressionSetterGenerator*/
public static T PaneBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PaneBackground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PaneBackground<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaneBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PaneBackground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PanePlacement

/*BindFromExpressionSetterGenerator*/
public static T PanePlacement<T>(this T control, Func<Avalonia.Controls.SplitViewPanePlacement> func, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PanePlacement<T>(this T control,Avalonia.Controls.SplitViewPanePlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PanePlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PanePlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PanePlacement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SplitViewPanePlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PanePlacementProperty, ps, () => control.PanePlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Pane

/*BindFromExpressionSetterGenerator*/
public static T Pane<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Pane<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneProperty, ps, () => control.Pane = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Pane<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Pane<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Pane<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneProperty, ps, () => control.Pane = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PaneTemplate

/*BindFromExpressionSetterGenerator*/
public static T PaneTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PaneTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PaneTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaneTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PaneTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // UseLightDismissOverlayMode

/*BindFromExpressionSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseLightDismissOverlayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView 
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T UseLightDismissOverlayMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.SplitView 
=> control._setEx(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // PaneClosed

/*ActionToEventGenerator*/
public static T OnPaneClosed<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.SplitView 
{
  if (routes == 0) routes = Avalonia.Controls.SplitView.PaneClosedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosedEvent, (_, args) => action(args), routes);
  return control; 
}



 // PaneClosing

/*ActionToEventGenerator*/
public static T OnPaneClosing<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.SplitView 
{
  if (routes == 0) routes = Avalonia.Controls.SplitView.PaneClosingEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.SplitView.PaneClosingEvent, (_, args) => action(args), routes);
  return control; 
}



 // PaneOpened

/*ActionToEventGenerator*/
public static T OnPaneOpened<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.SplitView 
{
  if (routes == 0) routes = Avalonia.Controls.SplitView.PaneOpenedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpenedEvent, (_, args) => action(args), routes);
  return control; 
}



 // PaneOpening

/*ActionToEventGenerator*/
public static T OnPaneOpening<T>(this T control, Action<Avalonia.Interactivity.CancelRoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.SplitView 
{
  if (routes == 0) routes = Avalonia.Controls.SplitView.PaneOpeningEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.SplitView.PaneOpeningEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // CompactPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);


 // DisplayMode

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, binding);


 // IsPaneOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);


 // OpenPaneLength

/*ValueStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);


 // PaneBackground

/*ValueStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);


 // PanePlacement

/*ValueStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, binding);


 // Pane

/*ValueStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, binding);


 // PaneTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);


 // UseLightDismissOverlayMode

/*ValueStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView 
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);



}
