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
public static partial class RangeBase_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Minimum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Minimum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, ps, () => control.Minimum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Maximum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Maximum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, ps, () => control.Maximum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.Value = value!);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Value<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.ValueProperty, ps, () => control.Value = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.ValueProperty, ps, () => control.Value = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SmallChange

/*ValueSetterGenerator*/
public static T SmallChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.SmallChange = value!);

/*BindFromExpressionSetterGenerator*/
public static T SmallChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SmallChange<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, ps, () => control.SmallChange = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SmallChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SmallChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SmallChange<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, ps, () => control.SmallChange = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LargeChange

/*ValueSetterGenerator*/
public static T LargeChange<T>(this T control, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._set(() => control.LargeChange = value!);

/*BindFromExpressionSetterGenerator*/
public static T LargeChange<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LargeChange<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, ps, () => control.LargeChange = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LargeChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LargeChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.RangeBase 
   => control._set(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LargeChange<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.RangeBase 
=> control._setEx(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, ps, () => control.LargeChange = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Avalonia.Controls.Primitives.RangeBaseValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.Primitives.RangeBase 
{
  control.AddHandler(Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.Primitives.RangeBase.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.ValueProperty, binding);


 // SmallChange

/*ValueStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SmallChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.SmallChangeProperty, binding);


 // LargeChange

/*ValueStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LargeChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.RangeBase 
=> style._addSetter(Avalonia.Controls.Primitives.RangeBase.LargeChangeProperty, binding);



}
