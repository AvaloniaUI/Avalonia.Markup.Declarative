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
public static partial class ColorSlider_MarkupExtensions
{
//================= Properties ======================//
 // Color

/*ValueSetterGenerator*/
public static T Color<T>(this T control, Avalonia.Media.Color value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.Color = value!);

/*BindFromExpressionSetterGenerator*/
public static T Color<T>(this T control, Func<Avalonia.Media.Color> func, Action<Avalonia.Media.Color>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Color<T>(this T control,Avalonia.Media.Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorProperty, ps, () => control.Color = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Color<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Color<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Color<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorProperty, ps, () => control.Color = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColorComponent

/*ValueSetterGenerator*/
public static T ColorComponent<T>(this T control, Avalonia.Controls.ColorComponent value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.ColorComponent = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColorComponent<T>(this T control, Func<Avalonia.Controls.ColorComponent> func, Action<Avalonia.Controls.ColorComponent>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColorComponent<T>(this T control,Avalonia.Controls.ColorComponent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty, ps, () => control.ColorComponent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColorComponent<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColorComponent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColorComponent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorComponent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty, ps, () => control.ColorComponent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ColorModel

/*ValueSetterGenerator*/
public static T ColorModel<T>(this T control, Avalonia.Controls.ColorModel value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.ColorModel = value!);

/*BindFromExpressionSetterGenerator*/
public static T ColorModel<T>(this T control, Func<Avalonia.Controls.ColorModel> func, Action<Avalonia.Controls.ColorModel>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ColorModel<T>(this T control,Avalonia.Controls.ColorModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty, ps, () => control.ColorModel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ColorModel<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ColorModel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ColorModel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ColorModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty, ps, () => control.ColorModel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HsvColor

/*ValueSetterGenerator*/
public static T HsvColor<T>(this T control, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.HsvColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T HsvColor<T>(this T control, Func<Avalonia.Media.HsvColor> func, Action<Avalonia.Media.HsvColor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T HsvColor<T>(this T control, System.Double alpha = default!, System.Double hue = default!, System.Double saturation = default!, System.Double value = default!) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(alpha, hue, saturation, value));
public static T HsvColor<T>(this T control, Avalonia.Media.Color color = default!) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(color));

/*MagicalSetterGenerator*/
[Obsolete]
public static T HsvColor<T>(this T control,Avalonia.Media.HsvColor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, ps, () => control.HsvColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HsvColor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HsvColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HsvColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.HsvColor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, ps, () => control.HsvColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAlphaVisible

/*ValueSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.IsAlphaVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAlphaVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty, ps, () => control.IsAlphaVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAlphaVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAlphaVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty, ps, () => control.IsAlphaVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsPerceptive

/*ValueSetterGenerator*/
public static T IsPerceptive<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.IsPerceptive = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsPerceptive<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsPerceptive<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty, ps, () => control.IsPerceptive = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsPerceptive<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsPerceptive<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsPerceptive<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty, ps, () => control.IsPerceptive = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsRoundingEnabled

/*ValueSetterGenerator*/
public static T IsRoundingEnabled<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._set(() => control.IsRoundingEnabled = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsRoundingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsRoundingEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty, ps, () => control.IsRoundingEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsRoundingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsRoundingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorSlider 
   => control._set(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsRoundingEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorSlider 
=> control._setEx(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty, ps, () => control.IsRoundingEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ColorChanged

/*ActionToEventGenerator*/
public static T OnColorChanged<T>(this T control, Action<Avalonia.Controls.ColorChangedEventArgs> action) where T : Avalonia.Controls.Primitives.ColorSlider  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ColorChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ColorChanged += h);



//================= Styles ======================//
 // Color

/*ValueStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, Avalonia.Media.Color value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Color<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorProperty, binding);


 // ColorComponent

/*ValueStyleSetterGenerator*/
public static Style<T> ColorComponent<T>(this Style<T> style, Avalonia.Controls.ColorComponent value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColorComponent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorComponentProperty, binding);


 // ColorModel

/*ValueStyleSetterGenerator*/
public static Style<T> ColorModel<T>(this Style<T> style, Avalonia.Controls.ColorModel value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ColorModel<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.ColorModelProperty, binding);


 // HsvColor

/*ValueStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, System.Double alpha, System.Double hue, System.Double saturation, System.Double value) where T : Avalonia.Controls.Primitives.ColorSlider 
   => style._addSetter(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, new Avalonia.Media.HsvColor(alpha, hue, saturation, value));public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.Color color) where T : Avalonia.Controls.Primitives.ColorSlider 
   => style._addSetter(Avalonia.Controls.Primitives.ColorSlider.HsvColorProperty, new Avalonia.Media.HsvColor(color));


 // IsAlphaVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsAlphaVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAlphaVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsAlphaVisibleProperty, binding);


 // IsPerceptive

/*ValueStyleSetterGenerator*/
public static Style<T> IsPerceptive<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsPerceptive<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsPerceptiveProperty, binding);


 // IsRoundingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsRoundingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsRoundingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorSlider 
=> style._addSetter(Avalonia.Controls.Primitives.ColorSlider.IsRoundingEnabledProperty, binding);



}
