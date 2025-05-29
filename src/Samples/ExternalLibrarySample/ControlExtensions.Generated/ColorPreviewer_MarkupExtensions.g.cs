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
public static partial class ColorPreviewer_MarkupExtensions
{
//================= Properties ======================//
 // HsvColor

/*ValueSetterGenerator*/
public static T HsvColor<T>(this T control, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._set(() => control.HsvColor = value!);

/*BindFromExpressionSetterGenerator*/
public static T HsvColor<T>(this T control, Func<Avalonia.Media.HsvColor> func, Action<Avalonia.Media.HsvColor>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T HsvColor<T>(this T control, System.Double alpha = default!, System.Double hue = default!, System.Double saturation = default!, System.Double value = default!) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(alpha, hue, saturation, value));
public static T HsvColor<T>(this T control, Avalonia.Media.Color color = default!) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(() => control.HsvColor = new Avalonia.Media.HsvColor(color));

/*MagicalSetterGenerator*/
[Obsolete]
public static T HsvColor<T>(this T control,Avalonia.Media.HsvColor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._setEx(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, ps, () => control.HsvColor = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HsvColor<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HsvColor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HsvColor<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.HsvColor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._setEx(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, ps, () => control.HsvColor = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsAccentColorsVisible

/*ValueSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._set(() => control.IsAccentColorsVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsAccentColorsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._setEx(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty, ps, () => control.IsAccentColorsVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsAccentColorsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => control._set(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsAccentColorsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> control._setEx(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty, ps, () => control.IsAccentColorsVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // ColorChanged

/*ActionToEventGenerator*/
public static T OnColorChanged<T>(this T control, Action<Avalonia.Controls.ColorChangedEventArgs> action) where T : Avalonia.Controls.Primitives.ColorPreviewer  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ColorChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ColorChanged += h);



//================= Styles ======================//
 // HsvColor

/*ValueStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.HsvColor value) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> HsvColor<T>(this Style<T> style, System.Double alpha, System.Double hue, System.Double saturation, System.Double value) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, new Avalonia.Media.HsvColor(alpha, hue, saturation, value));public static Style<T> HsvColor<T>(this Style<T> style, Avalonia.Media.Color color) where T : Avalonia.Controls.Primitives.ColorPreviewer 
   => style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.HsvColorProperty, new Avalonia.Media.HsvColor(color));


 // IsAccentColorsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsAccentColorsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsAccentColorsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ColorPreviewer 
=> style._addSetter(Avalonia.Controls.Primitives.ColorPreviewer.IsAccentColorsVisibleProperty, binding);



}
