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
public static partial class ColorView_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.Color = value!);

/*BindFromExpressionSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Color<T>(this T control,Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorProperty, ps, () => control.Color = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Color<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Color<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorProperty, ps, () => control.Color = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColorModel

/*ValueSetterGenerator*/
public static T ColorModel<T>(this T control, Avalonia.Controls.ColorModel value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.ColorModel = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColorModel<T>(this T control, Func<Avalonia.Controls.ColorModel> func, Action<Avalonia.Controls.ColorModel>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorModelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColorModel<T>(this T control,Avalonia.Controls.ColorModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorModelProperty, ps, () => control.ColorModel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColorModel<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorModelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColorModel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorModelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColorModel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorModelProperty, ps, () => control.ColorModel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColorSpectrumComponents

/*ValueSetterGenerator*/
public static T ColorSpectrumComponents<T>(this T control, Avalonia.Controls.ColorSpectrumComponents value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.ColorSpectrumComponents = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColorSpectrumComponents<T>(this T control, Func<Avalonia.Controls.ColorSpectrumComponents> func, Action<Avalonia.Controls.ColorSpectrumComponents>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColorSpectrumComponents<T>(this T control,Avalonia.Controls.ColorSpectrumComponents value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty, ps, () => control.ColorSpectrumComponents = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColorSpectrumComponents<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColorSpectrumComponents<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColorSpectrumComponents<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorSpectrumComponents> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty, ps, () => control.ColorSpectrumComponents = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColorSpectrumShape

/*ValueSetterGenerator*/
public static T ColorSpectrumShape<T>(this T control, Avalonia.Controls.ColorSpectrumShape value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.ColorSpectrumShape = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColorSpectrumShape<T>(this T control, Func<Avalonia.Controls.ColorSpectrumShape> func, Action<Avalonia.Controls.ColorSpectrumShape>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColorSpectrumShape<T>(this T control,Avalonia.Controls.ColorSpectrumShape value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty, ps, () => control.ColorSpectrumShape = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColorSpectrumShape<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColorSpectrumShape<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColorSpectrumShape<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorSpectrumShape> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty, ps, () => control.ColorSpectrumShape = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HexInputAlphaPosition

/*ValueSetterGenerator*/
public static T HexInputAlphaPosition<T>(this T control, Avalonia.Controls.AlphaComponentPosition value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.HexInputAlphaPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T HexInputAlphaPosition<T>(this T control, Func<Avalonia.Controls.AlphaComponentPosition> func, Action<Avalonia.Controls.AlphaComponentPosition>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HexInputAlphaPosition<T>(this T control,Avalonia.Controls.AlphaComponentPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty, ps, () => control.HexInputAlphaPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HexInputAlphaPosition<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HexInputAlphaPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HexInputAlphaPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AlphaComponentPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty, ps, () => control.HexInputAlphaPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HsvColor

/*ValueSetterGenerator*/
public static T HsvColor<T>(this T control, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.HsvColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T HsvColor<T>(this T control, Func<Avalonia.Media.HsvColor> func, Action<Avalonia.Media.HsvColor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HsvColorProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T HsvColor<T>(this T control, System.Double alpha = default!, System.Double hue = default!, System.Double saturation = default!, System.Double value = default!) where T : Avalonia.Controls.ColorView 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(alpha, hue, saturation, value));
public static T HsvColor<T>(this T control, Avalonia.Media.Color color = default!) where T : Avalonia.Controls.ColorView 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(color));

/*MagicalSetterGenerator*/
[Obsolete]
public static T HsvColor<T>(this T control,Avalonia.Media.HsvColor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.HsvColorProperty, ps, () => control.HsvColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HsvColor<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HsvColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HsvColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.HsvColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HsvColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.HsvColor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.HsvColorProperty, ps, () => control.HsvColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAccentColorsVisible

/*ValueSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsAccentColorsVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAccentColorsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty, ps, () => control.IsAccentColorsVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAccentColorsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty, ps, () => control.IsAccentColorsVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAlphaEnabled

/*ValueSetterGenerator*/
public static T IsAlphaEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsAlphaEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAlphaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAlphaEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAlphaEnabledProperty, ps, () => control.IsAlphaEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAlphaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAlphaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAlphaEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAlphaEnabledProperty, ps, () => control.IsAlphaEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAlphaVisible

/*ValueSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsAlphaVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAlphaVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAlphaVisibleProperty, ps, () => control.IsAlphaVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsAlphaVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAlphaVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsAlphaVisibleProperty, ps, () => control.IsAlphaVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorComponentsVisible

/*ValueSetterGenerator*/
public static T IsColorComponentsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorComponentsVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorComponentsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorComponentsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty, ps, () => control.IsColorComponentsVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorComponentsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorComponentsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorComponentsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty, ps, () => control.IsColorComponentsVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorModelVisible

/*ValueSetterGenerator*/
public static T IsColorModelVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorModelVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorModelVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorModelVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorModelVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorModelVisibleProperty, ps, () => control.IsColorModelVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorModelVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorModelVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorModelVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorModelVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorModelVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorModelVisibleProperty, ps, () => control.IsColorModelVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorPaletteVisible

/*ValueSetterGenerator*/
public static T IsColorPaletteVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorPaletteVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorPaletteVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorPaletteVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty, ps, () => control.IsColorPaletteVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorPaletteVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorPaletteVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorPaletteVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty, ps, () => control.IsColorPaletteVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorPreviewVisible

/*ValueSetterGenerator*/
public static T IsColorPreviewVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorPreviewVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorPreviewVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorPreviewVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty, ps, () => control.IsColorPreviewVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorPreviewVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorPreviewVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorPreviewVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty, ps, () => control.IsColorPreviewVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorSpectrumVisible

/*ValueSetterGenerator*/
public static T IsColorSpectrumVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorSpectrumVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorSpectrumVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorSpectrumVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty, ps, () => control.IsColorSpectrumVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorSpectrumVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorSpectrumVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorSpectrumVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty, ps, () => control.IsColorSpectrumVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsColorSpectrumSliderVisible

/*ValueSetterGenerator*/
public static T IsColorSpectrumSliderVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsColorSpectrumSliderVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsColorSpectrumSliderVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsColorSpectrumSliderVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty, ps, () => control.IsColorSpectrumSliderVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsColorSpectrumSliderVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsColorSpectrumSliderVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsColorSpectrumSliderVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty, ps, () => control.IsColorSpectrumSliderVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsComponentSliderVisible

/*ValueSetterGenerator*/
public static T IsComponentSliderVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsComponentSliderVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsComponentSliderVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsComponentSliderVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty, ps, () => control.IsComponentSliderVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsComponentSliderVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsComponentSliderVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsComponentSliderVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty, ps, () => control.IsComponentSliderVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsComponentTextInputVisible

/*ValueSetterGenerator*/
public static T IsComponentTextInputVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsComponentTextInputVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsComponentTextInputVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsComponentTextInputVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty, ps, () => control.IsComponentTextInputVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsComponentTextInputVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsComponentTextInputVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsComponentTextInputVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty, ps, () => control.IsComponentTextInputVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsHexInputVisible

/*ValueSetterGenerator*/
public static T IsHexInputVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.IsHexInputVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsHexInputVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsHexInputVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsHexInputVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsHexInputVisibleProperty, ps, () => control.IsHexInputVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsHexInputVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsHexInputVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsHexInputVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.IsHexInputVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsHexInputVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.IsHexInputVisibleProperty, ps, () => control.IsHexInputVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxHue

/*ValueSetterGenerator*/
public static T MaxHue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MaxHue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxHue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxHueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxHue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxHueProperty, ps, () => control.MaxHue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxHue<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxHueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxHue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxHueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxHue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxHueProperty, ps, () => control.MaxHue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxSaturation

/*ValueSetterGenerator*/
public static T MaxSaturation<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MaxSaturation = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxSaturation<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxSaturationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxSaturation<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxSaturationProperty, ps, () => control.MaxSaturation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxSaturation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxSaturationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxSaturation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxSaturationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxSaturation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxSaturationProperty, ps, () => control.MaxSaturation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxValue

/*ValueSetterGenerator*/
public static T MaxValue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MaxValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxValue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxValue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxValueProperty, ps, () => control.MaxValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MaxValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MaxValueProperty, ps, () => control.MaxValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinHue

/*ValueSetterGenerator*/
public static T MinHue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MinHue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinHue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinHueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinHue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinHueProperty, ps, () => control.MinHue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinHue<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinHueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinHue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinHueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinHue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinHueProperty, ps, () => control.MinHue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinSaturation

/*ValueSetterGenerator*/
public static T MinSaturation<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MinSaturation = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinSaturation<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinSaturationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinSaturation<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinSaturationProperty, ps, () => control.MinSaturation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinSaturation<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinSaturationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinSaturation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinSaturationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinSaturation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinSaturationProperty, ps, () => control.MinSaturation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MinValue

/*ValueSetterGenerator*/
public static T MinValue<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.MinValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T MinValue<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MinValue<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinValueProperty, ps, () => control.MinValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.MinValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MinValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.MinValueProperty, ps, () => control.MinValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PaletteColors

/*ValueSetterGenerator*/
public static T PaletteColors<T>(this T control, System.Collections.Generic.IEnumerable<Avalonia.Media.Color> value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.PaletteColors = value!);

/*BindFromExpressionSetterGenerator*/
public static T PaletteColors<T>(this T control, Func<System.Collections.Generic.IEnumerable<Avalonia.Media.Color>> func, Action<System.Collections.Generic.IEnumerable<Avalonia.Media.Color>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColorsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PaletteColors<T>(this T control,System.Collections.Generic.IEnumerable<Avalonia.Media.Color> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteColorsProperty, ps, () => control.PaletteColors = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PaletteColors<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColorsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaletteColors<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColorsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PaletteColors<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IEnumerable<Avalonia.Media.Color>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteColorsProperty, ps, () => control.PaletteColors = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PaletteColumnCount

/*ValueSetterGenerator*/
public static T PaletteColumnCount<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.PaletteColumnCount = value!);

/*BindFromExpressionSetterGenerator*/
public static T PaletteColumnCount<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColumnCountProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PaletteColumnCount<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteColumnCountProperty, ps, () => control.PaletteColumnCount = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PaletteColumnCount<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColumnCountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PaletteColumnCount<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteColumnCountProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PaletteColumnCount<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteColumnCountProperty, ps, () => control.PaletteColumnCount = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Palette

/*ValueSetterGenerator*/
public static T Palette<T>(this T control, Avalonia.Controls.IColorPalette value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.Palette = value!);

/*BindFromExpressionSetterGenerator*/
public static T Palette<T>(this T control, Func<Avalonia.Controls.IColorPalette> func, Action<Avalonia.Controls.IColorPalette>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Palette<T>(this T control,Avalonia.Controls.IColorPalette value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteProperty, ps, () => control.Palette = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Palette<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Palette<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.PaletteProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Palette<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.IColorPalette> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.PaletteProperty, ps, () => control.Palette = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedIndex

/*ValueSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> control._set(() => control.SelectedIndex = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.SelectedIndexProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.SelectedIndexProperty, ps, () => control.SelectedIndex = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.SelectedIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ColorView 
   => control._set(Avalonia.Controls.ColorView.SelectedIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ColorView 
=> control._setEx(Avalonia.Controls.ColorView.SelectedIndexProperty, ps, () => control.SelectedIndex = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ColorChanged

/*ActionToEventGenerator*/
public static T OnColorChanged<T>(this T control, Action<Avalonia.Controls.ColorChangedEventArgs> action) where T : Avalonia.Controls.ColorView  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ColorChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ColorChanged += h);



//================= Styles ======================//
 // Color

/*ValueStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, Avalonia.Media.Color value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorProperty, binding);


 // ColorModel

/*ValueStyleSetterGenerator*/
public static Style<T> ColorModel<T>(this Style<T> style, Avalonia.Controls.ColorModel value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorModelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColorModel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorModelProperty, binding);


 // ColorSpectrumComponents

/*ValueStyleSetterGenerator*/
public static Style<T> ColorSpectrumComponents<T>(this Style<T> style, Avalonia.Controls.ColorSpectrumComponents value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColorSpectrumComponents<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorSpectrumComponentsProperty, binding);


 // ColorSpectrumShape

/*ValueStyleSetterGenerator*/
public static Style<T> ColorSpectrumShape<T>(this Style<T> style, Avalonia.Controls.ColorSpectrumShape value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColorSpectrumShape<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.ColorSpectrumShapeProperty, binding);


 // HexInputAlphaPosition

/*ValueStyleSetterGenerator*/
public static Style<T> HexInputAlphaPosition<T>(this Style<T> style, Avalonia.Controls.AlphaComponentPosition value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HexInputAlphaPosition<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.HexInputAlphaPositionProperty, binding);


 // HsvColor

/*ValueStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.HsvColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.HsvColorProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, System.Double alpha, System.Double hue, System.Double saturation, System.Double value) where T : Avalonia.Controls.ColorView 
   => style._addSetter(Avalonia.Controls.ColorView.HsvColorProperty, new Avalonia.Media.HsvColor(alpha, hue, saturation, value));public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.Color color) where T : Avalonia.Controls.ColorView 
   => style._addSetter(Avalonia.Controls.ColorView.HsvColorProperty, new Avalonia.Media.HsvColor(color));


 // IsAccentColorsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsAccentColorsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAccentColorsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAccentColorsVisibleProperty, binding);


 // IsAlphaEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsAlphaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAlphaEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAlphaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAlphaEnabledProperty, binding);


 // IsAlphaVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsAlphaVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAlphaVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAlphaVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsAlphaVisibleProperty, binding);


 // IsColorComponentsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorComponentsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorComponentsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorComponentsVisibleProperty, binding);


 // IsColorModelVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorModelVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorModelVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorModelVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorModelVisibleProperty, binding);


 // IsColorPaletteVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorPaletteVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorPaletteVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorPaletteVisibleProperty, binding);


 // IsColorPreviewVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorPreviewVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorPreviewVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorPreviewVisibleProperty, binding);


 // IsColorSpectrumVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorSpectrumVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorSpectrumVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorSpectrumVisibleProperty, binding);


 // IsColorSpectrumSliderVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsColorSpectrumSliderVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsColorSpectrumSliderVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsColorSpectrumSliderVisibleProperty, binding);


 // IsComponentSliderVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsComponentSliderVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsComponentSliderVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsComponentSliderVisibleProperty, binding);


 // IsComponentTextInputVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsComponentTextInputVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsComponentTextInputVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsComponentTextInputVisibleProperty, binding);


 // IsHexInputVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsHexInputVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsHexInputVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsHexInputVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.IsHexInputVisibleProperty, binding);


 // MaxHue

/*ValueStyleSetterGenerator*/
public static Style<T> MaxHue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxHueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxHue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxHueProperty, binding);


 // MaxSaturation

/*ValueStyleSetterGenerator*/
public static Style<T> MaxSaturation<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxSaturationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxSaturation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxSaturationProperty, binding);


 // MaxValue

/*ValueStyleSetterGenerator*/
public static Style<T> MaxValue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MaxValueProperty, binding);


 // MinHue

/*ValueStyleSetterGenerator*/
public static Style<T> MinHue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinHueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinHue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinHueProperty, binding);


 // MinSaturation

/*ValueStyleSetterGenerator*/
public static Style<T> MinSaturation<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinSaturationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinSaturation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinSaturationProperty, binding);


 // MinValue

/*ValueStyleSetterGenerator*/
public static Style<T> MinValue<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MinValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.MinValueProperty, binding);


 // PaletteColors

/*ValueStyleSetterGenerator*/
public static Style<T> PaletteColors<T>(this Style<T> style, System.Collections.Generic.IEnumerable<Avalonia.Media.Color> value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteColorsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaletteColors<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteColorsProperty, binding);


 // PaletteColumnCount

/*ValueStyleSetterGenerator*/
public static Style<T> PaletteColumnCount<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteColumnCountProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PaletteColumnCount<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteColumnCountProperty, binding);


 // Palette

/*ValueStyleSetterGenerator*/
public static Style<T> Palette<T>(this Style<T> style, Avalonia.Controls.IColorPalette value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Palette<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.PaletteProperty, binding);


 // SelectedIndex

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.SelectedIndexProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ColorView 
=> style._addSetter(Avalonia.Controls.ColorView.SelectedIndexProperty, binding);



}
