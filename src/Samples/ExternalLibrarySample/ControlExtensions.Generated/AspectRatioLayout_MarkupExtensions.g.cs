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
public static partial class AspectRatioLayout_MarkupExtensions
{
//================= Properties ======================//
 // Items

/*ValueSetterGenerator*/
public static T Items<T>(this T control, System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem> value) where T : Ursa.Controls.AspectRatioLayout 
=> control._set(() => control.Items = value!);

/*BindFromExpressionSetterGenerator*/
public static T Items<T>(this T control, Func<System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem>> func, Action<System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.ItemsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Items<T>(this T control,System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.ItemsProperty, ps, () => control.Items = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Items<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.ItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Items<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.ItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Items<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.ItemsProperty, ps, () => control.Items = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AspectRatioTolerance

/*ValueSetterGenerator*/
public static T AspectRatioTolerance<T>(this T control, System.Double value) where T : Ursa.Controls.AspectRatioLayout 
=> control._set(() => control.AspectRatioTolerance = value!);

/*BindFromExpressionSetterGenerator*/
public static T AspectRatioTolerance<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AspectRatioTolerance<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty, ps, () => control.AspectRatioTolerance = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AspectRatioTolerance<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AspectRatioTolerance<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AspectRatioTolerance<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty, ps, () => control.AspectRatioTolerance = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CurrentAspectRatioMode

/*ValueSetterGenerator*/
public static T CurrentAspectRatioMode<T>(this T control, Ursa.Controls.AspectRatioMode value) where T : Ursa.Controls.AspectRatioLayout 
=> control._set(() => control.CurrentAspectRatioMode = value!);

/*BindFromExpressionSetterGenerator*/
public static T CurrentAspectRatioMode<T>(this T control, Func<Ursa.Controls.AspectRatioMode> func, Action<Ursa.Controls.AspectRatioMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.CurrentAspectRatioModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CurrentAspectRatioMode<T>(this T control,Ursa.Controls.AspectRatioMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.CurrentAspectRatioModeProperty, ps, () => control.CurrentAspectRatioMode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CurrentAspectRatioMode<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.CurrentAspectRatioModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CurrentAspectRatioMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.CurrentAspectRatioModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CurrentAspectRatioMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.AspectRatioMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.CurrentAspectRatioModeProperty, ps, () => control.CurrentAspectRatioMode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AspectRatioValue

/*ValueSetterGenerator*/
public static T AspectRatioValue<T>(this T control, System.Double value) where T : Ursa.Controls.AspectRatioLayout 
=> control._set(() => control.AspectRatioValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T AspectRatioValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AspectRatioValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty, ps, () => control.AspectRatioValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AspectRatioValue<T>(this T control, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AspectRatioValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.AspectRatioLayout 
   => control._set(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AspectRatioValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.AspectRatioLayout 
=> control._setEx(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty, ps, () => control.AspectRatioValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Items

/*ValueStyleSetterGenerator*/
public static Style<T> Items<T>(this Style<T> style, System.Collections.Generic.List<Ursa.Controls.AspectRatioLayoutItem> value) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.ItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Items<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.ItemsProperty, binding);


 // AspectRatioTolerance

/*ValueStyleSetterGenerator*/
public static Style<T> AspectRatioTolerance<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AspectRatioTolerance<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.AspectRatioToleranceProperty, binding);


 // AspectRatioValue

/*ValueStyleSetterGenerator*/
public static Style<T> AspectRatioValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AspectRatioValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.AspectRatioLayout 
=> style._addSetter(Ursa.Controls.AspectRatioLayout.AspectRatioValueProperty, binding);



}
