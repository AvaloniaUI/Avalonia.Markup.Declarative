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
public static partial class RangeSlider_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.Minimum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MinimumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Minimum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.MinimumProperty, ps, () => control.Minimum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.Maximum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MaximumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Maximum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.MaximumProperty, ps, () => control.Maximum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LowerValue

/*ValueSetterGenerator*/
public static T LowerValue<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.LowerValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T LowerValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.LowerValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LowerValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.LowerValueProperty, ps, () => control.LowerValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LowerValue<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.LowerValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LowerValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.LowerValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LowerValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.LowerValueProperty, ps, () => control.LowerValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UpperValue

/*ValueSetterGenerator*/
public static T UpperValue<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.UpperValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T UpperValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.UpperValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UpperValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.UpperValueProperty, ps, () => control.UpperValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpperValue<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.UpperValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpperValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.UpperValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UpperValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.UpperValueProperty, ps, () => control.UpperValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TrackWidth

/*ValueSetterGenerator*/
public static T TrackWidth<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.TrackWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T TrackWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TrackWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TrackWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TrackWidthProperty, ps, () => control.TrackWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TrackWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TrackWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TrackWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TrackWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TrackWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TrackWidthProperty, ps, () => control.TrackWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.Orientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.OrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.OrientationProperty, ps, () => control.Orientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.IsDirectionReversed = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsDirectionReversedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDirectionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDirectionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TickFrequency

/*ValueSetterGenerator*/
public static T TickFrequency<T>(this T control, System.Double value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.TickFrequency = value!);

/*BindFromExpressionSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickFrequencyProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TickFrequency<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TickFrequencyProperty, ps, () => control.TickFrequency = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TickFrequency<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickFrequencyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TickFrequency<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Ticks

/*ValueSetterGenerator*/
public static T Ticks<T>(this T control, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.Ticks = value!);

/*BindFromExpressionSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TicksProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Ticks<T>(this T control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TicksProperty, ps, () => control.Ticks = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Ticks<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Ticks<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TickPlacement

/*ValueSetterGenerator*/
public static T TickPlacement<T>(this T control, Avalonia.Controls.TickPlacement value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.TickPlacement = value!);

/*BindFromExpressionSetterGenerator*/
public static T TickPlacement<T>(this T control, Func<Avalonia.Controls.TickPlacement> func, Action<Avalonia.Controls.TickPlacement>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickPlacementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TickPlacement<T>(this T control,Avalonia.Controls.TickPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TickPlacementProperty, ps, () => control.TickPlacement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TickPlacement<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.TickPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TickPlacement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.TickPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.TickPlacementProperty, ps, () => control.TickPlacement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSnapToTick

/*ValueSetterGenerator*/
public static T IsSnapToTick<T>(this T control, System.Boolean value) where T : Ursa.Controls.RangeSlider 
=> control._set(() => control.IsSnapToTick = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSnapToTick<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsSnapToTickProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSnapToTick<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.IsSnapToTickProperty, ps, () => control.IsSnapToTick = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSnapToTick<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsSnapToTickProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSnapToTick<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeSlider 
   => control._set(Ursa.Controls.RangeSlider.IsSnapToTickProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSnapToTick<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeSlider 
=> control._setEx(Ursa.Controls.RangeSlider.IsSnapToTickProperty, ps, () => control.IsSnapToTick = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Ursa.Controls.RangeValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.RangeSlider 
{
  control.AddHandler(Ursa.Controls.RangeSlider.ValueChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.RangeSlider.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.MaximumProperty, binding);


 // LowerValue

/*ValueStyleSetterGenerator*/
public static Style<T> LowerValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.LowerValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LowerValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.LowerValueProperty, binding);


 // UpperValue

/*ValueStyleSetterGenerator*/
public static Style<T> UpperValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.UpperValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UpperValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.UpperValueProperty, binding);


 // TrackWidth

/*ValueStyleSetterGenerator*/
public static Style<T> TrackWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TrackWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TrackWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TrackWidthProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.OrientationProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.IsDirectionReversedProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TickFrequencyProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TickFrequencyProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TicksProperty, binding);


 // TickPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, Avalonia.Controls.TickPlacement value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TickPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TickPlacement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.TickPlacementProperty, binding);


 // IsSnapToTick

/*ValueStyleSetterGenerator*/
public static Style<T> IsSnapToTick<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.IsSnapToTickProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSnapToTick<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeSlider 
=> style._addSetter(Ursa.Controls.RangeSlider.IsSnapToTickProperty, binding);



}
