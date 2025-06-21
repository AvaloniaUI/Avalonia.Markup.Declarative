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
public static partial class AspectRatioLayoutItem_MarkupExtensions
{
//================= Properties ======================//
 // StartAspectRatioValue

/*ValueSetterGenerator*/
public static T StartAspectRatioValue<T>(this T control, System.Double value) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._set(() => control.StartAspectRatioValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T StartAspectRatioValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StartAspectRatioValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._setEx(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty, ps, () => control.StartAspectRatioValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StartAspectRatioValue<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StartAspectRatioValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StartAspectRatioValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._setEx(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty, ps, () => control.StartAspectRatioValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // EndAspectRatioValue

/*ValueSetterGenerator*/
public static T EndAspectRatioValue<T>(this T control, System.Double value) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._set(() => control.EndAspectRatioValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T EndAspectRatioValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T EndAspectRatioValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._setEx(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty, ps, () => control.EndAspectRatioValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EndAspectRatioValue<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EndAspectRatioValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayoutItem 
   => control._set(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T EndAspectRatioValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayoutItem 
=> control._setEx(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty, ps, () => control.EndAspectRatioValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // StartAspectRatioValue

/*ValueStyleSetterGenerator*/
public static Style<T> StartAspectRatioValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.AspectRatioLayoutItem 
=> style._addSetter(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StartAspectRatioValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.AspectRatioLayoutItem 
=> style._addSetter(Ursa.Controls.AspectRatioLayoutItem.StartAspectRatioValueProperty, binding);


 // EndAspectRatioValue

/*ValueStyleSetterGenerator*/
public static Style<T> EndAspectRatioValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.AspectRatioLayoutItem 
=> style._addSetter(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EndAspectRatioValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.AspectRatioLayoutItem 
=> style._addSetter(Ursa.Controls.AspectRatioLayoutItem.EndAspectRatioValueProperty, binding);



}
