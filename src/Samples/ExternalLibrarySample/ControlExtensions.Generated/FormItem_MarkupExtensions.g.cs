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
public static partial class FormItem_MarkupExtensions
{
//================= Properties ======================//
 // LabelWidth

/*ValueSetterGenerator*/
public static T LabelWidth<T>(this T control, System.Double value) where T : Ursa.Controls.FormItem 
=> control._set(() => control.LabelWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T LabelWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LabelWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.FormItem 
=> control._setEx(Ursa.Controls.FormItem.LabelWidthProperty, ps, () => control.LabelWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LabelWidth<T>(this T control, IBinding binding) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LabelWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LabelWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.FormItem 
=> control._setEx(Ursa.Controls.FormItem.LabelWidthProperty, ps, () => control.LabelWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LabelAlignment

/*ValueSetterGenerator*/
public static T LabelAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.FormItem 
=> control._set(() => control.LabelAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T LabelAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LabelAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.FormItem 
=> control._setEx(Ursa.Controls.FormItem.LabelAlignmentProperty, ps, () => control.LabelAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LabelAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LabelAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.FormItem 
   => control._set(Ursa.Controls.FormItem.LabelAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LabelAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.FormItem 
=> control._setEx(Ursa.Controls.FormItem.LabelAlignmentProperty, ps, () => control.LabelAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // Label

/*AttachedPropertyMagicalSetterGenerator*/
public static T FormItem_Label<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.FormItem.LabelProperty, ps, () => Ursa.Controls.FormItem.SetLabel(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T FormItem_Label<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.FormItem.LabelProperty!, func, onChanged, expression);


 // IsRequired

/*AttachedPropertyMagicalSetterGenerator*/
public static T FormItem_IsRequired<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.FormItem.IsRequiredProperty, ps, () => Ursa.Controls.FormItem.SetIsRequired(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T FormItem_IsRequired<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.FormItem.IsRequiredProperty!, func, onChanged, expression);


 // NoLabel

/*AttachedPropertyMagicalSetterGenerator*/
public static T FormItem_NoLabel<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.FormItem.NoLabelProperty, ps, () => Ursa.Controls.FormItem.SetNoLabel(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T FormItem_NoLabel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.FormItem.NoLabelProperty!, func, onChanged, expression);



//================= Styles ======================//
 // LabelWidth

/*ValueStyleSetterGenerator*/
public static Style<T> LabelWidth<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.FormItem 
=> style._addSetter(Ursa.Controls.FormItem.LabelWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelWidth<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.FormItem 
=> style._addSetter(Ursa.Controls.FormItem.LabelWidthProperty, binding);


 // LabelAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> LabelAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.FormItem 
=> style._addSetter(Ursa.Controls.FormItem.LabelAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LabelAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.FormItem 
=> style._addSetter(Ursa.Controls.FormItem.LabelAlignmentProperty, binding);



}
