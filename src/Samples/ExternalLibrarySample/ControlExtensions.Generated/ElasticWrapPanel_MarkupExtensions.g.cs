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
public static partial class ElasticWrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // IsFillHorizontal

/*ValueSetterGenerator*/
public static T IsFillHorizontal<T>(this T control, System.Boolean value) where T : Ursa.Controls.ElasticWrapPanel 
=> control._set(() => control.IsFillHorizontal = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsFillHorizontal<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsFillHorizontal<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ElasticWrapPanel 
=> control._setEx(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty, ps, () => control.IsFillHorizontal = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsFillHorizontal<T>(this T control, IBinding binding) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFillHorizontal<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsFillHorizontal<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ElasticWrapPanel 
=> control._setEx(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty, ps, () => control.IsFillHorizontal = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsFillVertical

/*ValueSetterGenerator*/
public static T IsFillVertical<T>(this T control, System.Boolean value) where T : Ursa.Controls.ElasticWrapPanel 
=> control._set(() => control.IsFillVertical = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsFillVertical<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsFillVertical<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ElasticWrapPanel 
=> control._setEx(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty, ps, () => control.IsFillVertical = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsFillVertical<T>(this T control, IBinding binding) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFillVertical<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.ElasticWrapPanel 
   => control._set(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsFillVertical<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.ElasticWrapPanel 
=> control._setEx(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty, ps, () => control.IsFillVertical = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // FixToRB

/*AttachedPropertyMagicalSetterGenerator*/
public static T ElasticWrapPanel_FixToRB<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Ursa.Controls.ElasticWrapPanel.FixToRBProperty, ps, () => Ursa.Controls.ElasticWrapPanel.SetFixToRB(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ElasticWrapPanel_FixToRB<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Ursa.Controls.ElasticWrapPanel.FixToRBProperty!, func, onChanged, expression);



//================= Styles ======================//
 // IsFillHorizontal

/*ValueStyleSetterGenerator*/
public static Style<T> IsFillHorizontal<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.ElasticWrapPanel 
=> style._addSetter(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsFillHorizontal<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ElasticWrapPanel 
=> style._addSetter(Ursa.Controls.ElasticWrapPanel.IsFillHorizontalProperty, binding);


 // IsFillVertical

/*ValueStyleSetterGenerator*/
public static Style<T> IsFillVertical<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.ElasticWrapPanel 
=> style._addSetter(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsFillVertical<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.ElasticWrapPanel 
=> style._addSetter(Ursa.Controls.ElasticWrapPanel.IsFillVerticalProperty, binding);



}
