#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TopLevel_MarkupExtensions
{
//================= Properties ======================//
 // TransparencyLevelHintProperty

/*BindFromExpressionSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, Func<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> func, Action<System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyLevelHint<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TransparencyLevelHint<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TransparencyBackgroundFallbackProperty

/*BindFromExpressionSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TransparencyBackgroundFallback<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TransparencyBackgroundFallback<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RequestedThemeVariantProperty

/*BindFromExpressionSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Func<Avalonia.Styling.ThemeVariant> func, Action<Avalonia.Styling.ThemeVariant>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, Avalonia.Styling.ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, IBinding binding) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RequestedThemeVariant<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TopLevel
   => control._set(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RequestedThemeVariant<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TopLevel
=> control._setEx(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Opened

/*ActionToEventGenerator*/
    public static T OnOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Opened += h);


 // Closed

/*ActionToEventGenerator*/
    public static T OnClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Closed += h);


 // ScalingChanged

/*ActionToEventGenerator*/
    public static T OnScalingChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ScalingChanged += h);


 // BackRequested

/*ActionToEventGenerator*/
    public static T OnBackRequested<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.TopLevel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.BackRequested += h);



//================= Styles ======================//
 // TransparencyLevelHintProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, System.Collections.Generic.IReadOnlyList<Avalonia.Controls.WindowTransparencyLevel> value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyLevelHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyLevelHintProperty, binding);


 // TransparencyBackgroundFallbackProperty

/*ValueStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TransparencyBackgroundFallback<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.TransparencyBackgroundFallbackProperty, binding);


 // RequestedThemeVariantProperty

/*ValueStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, Avalonia.Styling.ThemeVariant value) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RequestedThemeVariant<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TopLevel
=> style._addSetter(Avalonia.Controls.TopLevel.RequestedThemeVariantProperty, binding);



}
