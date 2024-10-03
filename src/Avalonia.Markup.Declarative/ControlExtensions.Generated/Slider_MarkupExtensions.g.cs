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
public static partial class Slider_MarkupExtensions
{
//================= Properties ======================//
 // Orientation

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDirectionReversed

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDirectionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsSnapToTickEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSnapToTickEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsSnapToTickEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TickFrequency

/*BindFromExpressionSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TickFrequency<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TickFrequency<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TickFrequency<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TickPlacement

/*BindFromExpressionSetterGenerator*/
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func, Action<Avalonia.Controls.TickPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TickPlacement<T>(this T control,Avalonia.Controls.TickPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TickPlacementProperty, ps, () => control.TickPlacement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TickPlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TickPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TickPlacement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.TickPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TickPlacementProperty, ps, () => control.TickPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Ticks

/*BindFromExpressionSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Ticks<T>(this T control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Ticks<T>(this T control, IBinding binding) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Slider 
   => control._set(Avalonia.Controls.Slider.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Ticks<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Slider 
=> control._setEx(Avalonia.Controls.Slider.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.OrientationProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsDirectionReversedProperty, binding);


 // IsSnapToTickEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSnapToTickEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.IsSnapToTickEnabledProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickFrequencyProperty, binding);


 // TickPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TickPlacementProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Slider 
=> style._addSetter(Avalonia.Controls.Slider.TicksProperty, binding);



}
