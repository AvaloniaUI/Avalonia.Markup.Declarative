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
public static partial class TopLevel_MarkupExtensions
{
//================= Properties ======================//
 // TransparencyLevelHint

/*BindFromExpressionSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control,System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TransparencyLevelHint<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TransparencyBackgroundFallback

/*BindFromExpressionSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TransparencyBackgroundFallback<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RequestedThemeVariant

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control,Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel 
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RequestedThemeVariant<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TopLevel 
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // SystemBarColor

/*AttachedPropertyMagicalSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Avalonia.Media.SolidColorBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TopLevel.SystemBarColorProperty, ps, () => Avalonia.Controls.TopLevel.SetSystemBarColor(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TopLevel_SystemBarColor<T>(this T control, Func<Avalonia.Media.SolidColorBrush> func, Action<Avalonia.Media.SolidColorBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.SystemBarColorProperty, func, onChanged, expression);


 // AutoSafeAreaPadding

/*AttachedPropertyMagicalSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty, ps, () => Avalonia.Controls.TopLevel.SetAutoSafeAreaPadding(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T TopLevel_AutoSafeAreaPadding<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.TopLevel.AutoSafeAreaPaddingProperty, func, onChanged, expression);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // ScalingChanged

/*ActionToEventGenerator*/
public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);


 // BackRequested

/*ActionToEventGenerator*/
public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.TopLevel 
{
  if (routes == 0) routes = Avalonia.Controls.TopLevel.BackRequestedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.TopLevel.BackRequestedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // TransparencyLevelHint

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);


 // TransparencyBackgroundFallback

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);


 // RequestedThemeVariant

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel 
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);



}
