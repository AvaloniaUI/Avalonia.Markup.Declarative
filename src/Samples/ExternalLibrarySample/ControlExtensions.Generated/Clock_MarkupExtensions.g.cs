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
public static partial class Clock_MarkupExtensions
{
//================= Properties ======================//
 // Time

/*ValueSetterGenerator*/
public static T Time<T>(this T control, System.DateTime value) where T : Ursa.Controls.Clock 
=> control._set(() => control.Time = value!);

/*BindFromExpressionSetterGenerator*/
public static T Time<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.TimeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Time<T>(this T control,System.DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.TimeProperty, ps, () => control.Time = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Time<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.TimeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Time<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.TimeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Time<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.TimeProperty, ps, () => control.Time = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowHourTicks

/*ValueSetterGenerator*/
public static T ShowHourTicks<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.ShowHourTicks = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowHourTicks<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourTicksProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowHourTicks<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowHourTicksProperty, ps, () => control.ShowHourTicks = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowHourTicks<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourTicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowHourTicks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourTicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowHourTicks<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowHourTicksProperty, ps, () => control.ShowHourTicks = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowMinuteTicks

/*ValueSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.ShowMinuteTicks = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteTicksProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowMinuteTicks<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowMinuteTicksProperty, ps, () => control.ShowMinuteTicks = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteTicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowMinuteTicks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteTicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowMinuteTicks<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowMinuteTicksProperty, ps, () => control.ShowMinuteTicks = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HandBrush

/*ValueSetterGenerator*/
public static T HandBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.Clock 
=> control._set(() => control.HandBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T HandBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.HandBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HandBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.HandBrushProperty, ps, () => control.HandBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HandBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.HandBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HandBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.HandBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HandBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.HandBrushProperty, ps, () => control.HandBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowHourHand

/*ValueSetterGenerator*/
public static T ShowHourHand<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.ShowHourHand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowHourHand<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourHandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowHourHand<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowHourHandProperty, ps, () => control.ShowHourHand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowHourHand<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourHandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowHourHand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowHourHandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowHourHand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowHourHandProperty, ps, () => control.ShowHourHand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowMinuteHand

/*ValueSetterGenerator*/
public static T ShowMinuteHand<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.ShowMinuteHand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowMinuteHand<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteHandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowMinuteHand<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowMinuteHandProperty, ps, () => control.ShowMinuteHand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowMinuteHand<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteHandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowMinuteHand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowMinuteHandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowMinuteHand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowMinuteHandProperty, ps, () => control.ShowMinuteHand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowSecondHand

/*ValueSetterGenerator*/
public static T ShowSecondHand<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.ShowSecondHand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowSecondHand<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowSecondHandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowSecondHand<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowSecondHandProperty, ps, () => control.ShowSecondHand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowSecondHand<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowSecondHandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowSecondHand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.ShowSecondHandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowSecondHand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.ShowSecondHandProperty, ps, () => control.ShowSecondHand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSmooth

/*ValueSetterGenerator*/
public static T IsSmooth<T>(this T control, System.Boolean value) where T : Ursa.Controls.Clock 
=> control._set(() => control.IsSmooth = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSmooth<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.IsSmoothProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSmooth<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.IsSmoothProperty, ps, () => control.IsSmooth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSmooth<T>(this T control, IBinding binding) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.IsSmoothProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSmooth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Clock 
   => control._set(Ursa.Controls.Clock.IsSmoothProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSmooth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Clock 
=> control._setEx(Ursa.Controls.Clock.IsSmoothProperty, ps, () => control.IsSmooth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Time

/*ValueStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, System.DateTime value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.TimeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Time<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.TimeProperty, binding);


 // ShowHourTicks

/*ValueStyleSetterGenerator*/
public static Style<T> ShowHourTicks<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowHourTicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowHourTicks<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowHourTicksProperty, binding);


 // ShowMinuteTicks

/*ValueStyleSetterGenerator*/
public static Style<T> ShowMinuteTicks<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowMinuteTicksProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowMinuteTicks<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowMinuteTicksProperty, binding);


 // HandBrush

/*ValueStyleSetterGenerator*/
public static Style<T> HandBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.HandBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HandBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.HandBrushProperty, binding);


 // ShowHourHand

/*ValueStyleSetterGenerator*/
public static Style<T> ShowHourHand<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowHourHandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowHourHand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowHourHandProperty, binding);


 // ShowMinuteHand

/*ValueStyleSetterGenerator*/
public static Style<T> ShowMinuteHand<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowMinuteHandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowMinuteHand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowMinuteHandProperty, binding);


 // ShowSecondHand

/*ValueStyleSetterGenerator*/
public static Style<T> ShowSecondHand<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowSecondHandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowSecondHand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.ShowSecondHandProperty, binding);


 // IsSmooth

/*ValueStyleSetterGenerator*/
public static Style<T> IsSmooth<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.IsSmoothProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSmooth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Clock 
=> style._addSetter(Ursa.Controls.Clock.IsSmoothProperty, binding);



}
