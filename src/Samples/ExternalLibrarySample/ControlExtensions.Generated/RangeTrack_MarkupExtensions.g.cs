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
public static partial class RangeTrack_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*ValueSetterGenerator*/
public static T Minimum<T>(this T control, System.Double value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.Minimum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MinimumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Minimum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.MinimumProperty, ps, () => control.Minimum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Maximum

/*ValueSetterGenerator*/
public static T Maximum<T>(this T control, System.Double value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.Maximum = value!);

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MaximumProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Maximum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.MaximumProperty, ps, () => control.Maximum = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LowerValue

/*ValueSetterGenerator*/
public static T LowerValue<T>(this T control, System.Double value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.LowerValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T LowerValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LowerValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerValueProperty, ps, () => control.LowerValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LowerValue<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LowerValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LowerValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerValueProperty, ps, () => control.LowerValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UpperValue

/*ValueSetterGenerator*/
public static T UpperValue<T>(this T control, System.Double value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.UpperValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T UpperValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UpperValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperValueProperty, ps, () => control.UpperValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpperValue<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpperValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UpperValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperValueProperty, ps, () => control.UpperValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.Orientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.OrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.OrientationProperty, ps, () => control.Orientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UpperSection

/*ValueSetterGenerator*/
public static T UpperSection<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.UpperSection = value!);

/*BindFromExpressionSetterGenerator*/
public static T UpperSection<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperSectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UpperSection<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperSectionProperty, ps, () => control.UpperSection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpperSection<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperSectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpperSection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperSectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UpperSection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperSectionProperty, ps, () => control.UpperSection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LowerSection

/*ValueSetterGenerator*/
public static T LowerSection<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.LowerSection = value!);

/*BindFromExpressionSetterGenerator*/
public static T LowerSection<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerSectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LowerSection<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerSectionProperty, ps, () => control.LowerSection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LowerSection<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerSectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LowerSection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerSectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LowerSection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerSectionProperty, ps, () => control.LowerSection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerSection

/*ValueSetterGenerator*/
public static T InnerSection<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.InnerSection = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerSection<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.InnerSectionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerSection<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.InnerSectionProperty, ps, () => control.InnerSection = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerSection<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.InnerSectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerSection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.InnerSectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerSection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.InnerSectionProperty, ps, () => control.InnerSection = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TrackBackground

/*ValueSetterGenerator*/
public static T TrackBackground<T>(this T control, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.TrackBackground = value!);

/*BindFromExpressionSetterGenerator*/
public static T TrackBackground<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.TrackBackgroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TrackBackground<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.TrackBackgroundProperty, ps, () => control.TrackBackground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TrackBackground<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.TrackBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TrackBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.TrackBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TrackBackground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.TrackBackgroundProperty, ps, () => control.TrackBackground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UpperThumb

/*ValueSetterGenerator*/
public static T UpperThumb<T>(this T control, Avalonia.Controls.Primitives.Thumb value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.UpperThumb = value!);

/*BindFromExpressionSetterGenerator*/
public static T UpperThumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb> func, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperThumbProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UpperThumb<T>(this T control,Avalonia.Controls.Primitives.Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperThumbProperty, ps, () => control.UpperThumb = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UpperThumb<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperThumbProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UpperThumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.UpperThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UpperThumb<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.UpperThumbProperty, ps, () => control.UpperThumb = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LowerThumb

/*ValueSetterGenerator*/
public static T LowerThumb<T>(this T control, Avalonia.Controls.Primitives.Thumb value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.LowerThumb = value!);

/*BindFromExpressionSetterGenerator*/
public static T LowerThumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb> func, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerThumbProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LowerThumb<T>(this T control,Avalonia.Controls.Primitives.Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerThumbProperty, ps, () => control.LowerThumb = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LowerThumb<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerThumbProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LowerThumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.LowerThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LowerThumb<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.LowerThumbProperty, ps, () => control.LowerThumb = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDirectionReversed

/*ValueSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, System.Boolean value) where T : Ursa.Controls.RangeTrack 
=> control._set(() => control.IsDirectionReversed = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.IsDirectionReversedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDirectionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RangeTrack 
   => control._set(Ursa.Controls.RangeTrack.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDirectionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RangeTrack 
=> control._setEx(Ursa.Controls.RangeTrack.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ValueChanged

/*ActionToEventGenerator*/
public static T OnValueChanged<T>(this T control, Action<Ursa.Controls.RangeValueChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.RangeTrack 
{
  control.AddHandler(Ursa.Controls.RangeTrack.ValueChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.RangeTrack.ValueChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.MinimumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.MaximumProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.MaximumProperty, binding);


 // LowerValue

/*ValueStyleSetterGenerator*/
public static Style<T> LowerValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LowerValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerValueProperty, binding);


 // UpperValue

/*ValueStyleSetterGenerator*/
public static Style<T> UpperValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UpperValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperValueProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.OrientationProperty, binding);


 // UpperSection

/*ValueStyleSetterGenerator*/
public static Style<T> UpperSection<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperSectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UpperSection<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperSectionProperty, binding);


 // LowerSection

/*ValueStyleSetterGenerator*/
public static Style<T> LowerSection<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerSectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LowerSection<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerSectionProperty, binding);


 // InnerSection

/*ValueStyleSetterGenerator*/
public static Style<T> InnerSection<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.InnerSectionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerSection<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.InnerSectionProperty, binding);


 // TrackBackground

/*ValueStyleSetterGenerator*/
public static Style<T> TrackBackground<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.TrackBackgroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TrackBackground<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.TrackBackgroundProperty, binding);


 // UpperThumb

/*ValueStyleSetterGenerator*/
public static Style<T> UpperThumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperThumbProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UpperThumb<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.UpperThumbProperty, binding);


 // LowerThumb

/*ValueStyleSetterGenerator*/
public static Style<T> LowerThumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerThumbProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LowerThumb<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.LowerThumbProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.IsDirectionReversedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RangeTrack 
=> style._addSetter(Ursa.Controls.RangeTrack.IsDirectionReversedProperty, binding);



}
