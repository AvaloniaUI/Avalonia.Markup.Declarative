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
public static partial class Form_MarkupExtensions
{
//================= Properties ======================//
 // LabelWidth

/*ValueSetterGenerator*/
public static T LabelWidth<T>(this T control, Avalonia.Controls.GridLength value) where T : Ursa.Controls.Form 
=> control._set(() => control.LabelWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T LabelWidth<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelWidthProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T LabelWidth<T>(this T control, System.Double value = default!) where T : Ursa.Controls.Form 
   => control._set(() => control.LabelWidth = new Avalonia.Controls.GridLength(value));
public static T LabelWidth<T>(this T control, System.Double value = default!, Avalonia.Controls.GridUnitType type = default!) where T : Ursa.Controls.Form 
   => control._set(() => control.LabelWidth = new Avalonia.Controls.GridLength(value, type));

/*MagicalSetterGenerator*/
[Obsolete]
public static T LabelWidth<T>(this T control,Avalonia.Controls.GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelWidthProperty, ps, () => control.LabelWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LabelWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LabelWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LabelWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelWidthProperty, ps, () => control.LabelWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LabelPosition

/*ValueSetterGenerator*/
public static T LabelPosition<T>(this T control, Ursa.Common.Position value) where T : Ursa.Controls.Form 
=> control._set(() => control.LabelPosition = value!);

/*BindFromExpressionSetterGenerator*/
public static T LabelPosition<T>(this T control, Func<Ursa.Common.Position> func, Action<Ursa.Common.Position>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelPositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LabelPosition<T>(this T control,Ursa.Common.Position value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelPositionProperty, ps, () => control.LabelPosition = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LabelPosition<T>(this T control, IBinding binding) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelPositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LabelPosition<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelPositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LabelPosition<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Common.Position> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelPositionProperty, ps, () => control.LabelPosition = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LabelAlignment

/*ValueSetterGenerator*/
public static T LabelAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.Form 
=> control._set(() => control.LabelAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T LabelAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LabelAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelAlignmentProperty, ps, () => control.LabelAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LabelAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LabelAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Form 
   => control._set(Ursa.Controls.Form.LabelAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LabelAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Form 
=> control._setEx(Ursa.Controls.Form.LabelAlignmentProperty, ps, () => control.LabelAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // LabelWidth

/*ValueStyleSetterGenerator*/
public static Style<T> LabelWidth<T>(this Style<T> style, Avalonia.Controls.GridLength value) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelWidthProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> LabelWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.Form 
   => style._addSetter(Ursa.Controls.Form.LabelWidthProperty, new Avalonia.Controls.GridLength(value));public static Style<T> LabelWidth<T>(this Style<T> style, System.Double value, Avalonia.Controls.GridUnitType type) where T : Ursa.Controls.Form 
   => style._addSetter(Ursa.Controls.Form.LabelWidthProperty, new Avalonia.Controls.GridLength(value, type));


 // LabelPosition

/*ValueStyleSetterGenerator*/
public static Style<T> LabelPosition<T>(this Style<T> style, Ursa.Common.Position value) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelPositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelPosition<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelPositionProperty, binding);


 // LabelAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> LabelAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Form 
=> style._addSetter(Ursa.Controls.Form.LabelAlignmentProperty, binding);



}
