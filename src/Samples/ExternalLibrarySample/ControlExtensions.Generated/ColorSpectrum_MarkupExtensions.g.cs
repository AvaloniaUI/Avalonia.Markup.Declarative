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
public static partial class ColorSpectrum_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.Color = value!);

/*BindFromExpressionSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Color<T>(this T control,Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty, ps, () => control.Color = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Color<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Color<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty, ps, () => control.Color = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Components

/*ValueSetterGenerator*/
public static T Components<T>(this T control, Avalonia.Controls.ColorSpectrumComponents value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.Components = value!);

/*BindFromExpressionSetterGenerator*/
public static T Components<T>(this T control, Func<Avalonia.Controls.ColorSpectrumComponents> func, Action<Avalonia.Controls.ColorSpectrumComponents>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Components<T>(this T control,Avalonia.Controls.ColorSpectrumComponents value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty, ps, () => control.Components = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Components<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Components<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Components<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorSpectrumComponents> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty, ps, () => control.Components = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HsvColor

/*ValueSetterGenerator*/
public static T HsvColor<T>(this T control, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.HsvColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T HsvColor<T>(this T control, Func<Avalonia.Media.HsvColor> func, Action<Avalonia.Media.HsvColor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T HsvColor<T>(this T control, System.Double alpha = default!, System.Double hue = default!, System.Double saturation = default!, System.Double value = default!) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(alpha, hue, saturation, value));
public static T HsvColor<T>(this T control, Avalonia.Media.Color color = default!) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(color));

/*MagicalSetterGenerator*/
[Obsolete]
public static T HsvColor<T>(this T control,Avalonia.Media.HsvColor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, ps, () => control.HsvColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HsvColor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HsvColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HsvColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.HsvColor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, ps, () => control.HsvColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxHue

/*ValueSetterGenerator*/
public static T MaxHue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MaxHue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxHue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxHue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty, ps, () => control.MaxHue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxHue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxHue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxHue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty, ps, () => control.MaxHue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxSaturation

/*ValueSetterGenerator*/
public static T MaxSaturation<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MaxSaturation = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxSaturation<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxSaturation<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty, ps, () => control.MaxSaturation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxSaturation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxSaturation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxSaturation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty, ps, () => control.MaxSaturation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxValue

/*ValueSetterGenerator*/
public static T MaxValue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MaxValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxValue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxValue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty, ps, () => control.MaxValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty, ps, () => control.MaxValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinHue

/*ValueSetterGenerator*/
public static T MinHue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MinHue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinHue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinHue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty, ps, () => control.MinHue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinHue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinHue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinHue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty, ps, () => control.MinHue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinSaturation

/*ValueSetterGenerator*/
public static T MinSaturation<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MinSaturation = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinSaturation<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinSaturation<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty, ps, () => control.MinSaturation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinSaturation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinSaturation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinSaturation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty, ps, () => control.MinSaturation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinValue

/*ValueSetterGenerator*/
public static T MinValue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.MinValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinValue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinValue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty, ps, () => control.MinValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty, ps, () => control.MinValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Shape

/*ValueSetterGenerator*/
public static T Shape<T>(this T control, Avalonia.Controls.ColorSpectrumShape value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._set(() => control.Shape = value!);

/*BindFromExpressionSetterGenerator*/
public static T Shape<T>(this T control, Func<Avalonia.Controls.ColorSpectrumShape> func, Action<Avalonia.Controls.ColorSpectrumShape>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Shape<T>(this T control,Avalonia.Controls.ColorSpectrumShape value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty, ps, () => control.Shape = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Shape<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Shape<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => control._set(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Shape<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorSpectrumShape> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> control._setEx(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty, ps, () => control.Shape = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ColorChanged

/*ActionToEventGenerator*/
public static T OnColorChanged<T>(this T control, Action<Avalonia.Controls.ColorChangedEventArgs> action) where T : Avalonia.Controls.Primitives.ColorSpectrum  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ColorChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ColorChanged += h);



//================= Styles ======================//
 // Color

/*ValueStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, Avalonia.Media.Color value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ColorProperty, binding);


 // Components

/*ValueStyleSetterGenerator*/
public static Style<T> Components<T>(this Style<T> style, Avalonia.Controls.ColorSpectrumComponents value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Components<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ComponentsProperty, binding);


 // HsvColor

/*ValueStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, System.Double alpha, System.Double hue, System.Double saturation, System.Double value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, new Avalonia.Media.HsvColor(alpha, hue, saturation, value));public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.Color color) where T : Avalonia.Controls.Primitives.ColorSpectrum 
   => style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.HsvColorProperty, new Avalonia.Media.HsvColor(color));


 // MaxHue

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxHueProperty, binding);


 // MaxSaturation

/*ValueStyleSetterGenerator*/
public static Style<T> MaxSaturation<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxSaturation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxSaturationProperty, binding);


 // MaxValue

/*ValueStyleSetterGenerator*/
public static Style<T> MaxValue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MaxValueProperty, binding);


 // MinHue

/*ValueStyleSetterGenerator*/
public static Style<T> MinHue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinHue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinHueProperty, binding);


 // MinSaturation

/*ValueStyleSetterGenerator*/
public static Style<T> MinSaturation<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinSaturation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinSaturationProperty, binding);


 // MinValue

/*ValueStyleSetterGenerator*/
public static Style<T> MinValue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.MinValueProperty, binding);


 // Shape

/*ValueStyleSetterGenerator*/
public static Style<T> Shape<T>(this Style<T> style, Avalonia.Controls.ColorSpectrumShape value) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Shape<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSpectrum 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSpectrum.ShapeProperty, binding);



}
