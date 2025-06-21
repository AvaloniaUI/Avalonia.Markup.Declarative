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
public static partial class KeyGestureInput_MarkupExtensions
{
//================= Properties ======================//
 // Gesture

/*ValueSetterGenerator*/
public static T Gesture<T>(this T control, Avalonia.Input.KeyGesture value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.Gesture = value!);

/*BindFromExpressionSetterGenerator*/
public static T Gesture<T>(this T control, Func<Avalonia.Input.KeyGesture> func, Action<Avalonia.Input.KeyGesture>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.GestureProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Gesture<T>(this T control,Avalonia.Input.KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.GestureProperty, ps, () => control.Gesture = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Gesture<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.GestureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Gesture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.GestureProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Gesture<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Input.KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AcceptableKeys

/*ValueSetterGenerator*/
public static T AcceptableKeys<T>(this T control, System.Collections.Generic.IList<Avalonia.Input.Key> value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.AcceptableKeys = value!);

/*BindFromExpressionSetterGenerator*/
public static T AcceptableKeys<T>(this T control, Func<System.Collections.Generic.IList<Avalonia.Input.Key>> func, Action<System.Collections.Generic.IList<Avalonia.Input.Key>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AcceptableKeys<T>(this T control,System.Collections.Generic.IList<Avalonia.Input.Key> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty, ps, () => control.AcceptableKeys = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptableKeys<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptableKeys<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AcceptableKeys<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<Avalonia.Input.Key>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty, ps, () => control.AcceptableKeys = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ConsiderKeyModifiers

/*ValueSetterGenerator*/
public static T ConsiderKeyModifiers<T>(this T control, System.Boolean value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.ConsiderKeyModifiers = value!);

/*BindFromExpressionSetterGenerator*/
public static T ConsiderKeyModifiers<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ConsiderKeyModifiers<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty, ps, () => control.ConsiderKeyModifiers = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ConsiderKeyModifiers<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ConsiderKeyModifiers<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ConsiderKeyModifiers<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty, ps, () => control.ConsiderKeyModifiers = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Ursa.Controls.KeyGestureInput 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerRightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.InnerRightContentProperty, ps, () => control.InnerRightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.KeyGestureInput 
   => control._set(Ursa.Controls.KeyGestureInput.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.KeyGestureInput 
=> control._setEx(Ursa.Controls.KeyGestureInput.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Gesture

/*ValueStyleSetterGenerator*/
public static Style<T> Gesture<T>(this Style<T> style, Avalonia.Input.KeyGesture value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.GestureProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Gesture<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.GestureProperty, binding);


 // AcceptableKeys

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptableKeys<T>(this Style<T> style, System.Collections.Generic.IList<Avalonia.Input.Key> value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptableKeys<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.AcceptableKeysProperty, binding);


 // ConsiderKeyModifiers

/*ValueStyleSetterGenerator*/
public static Style<T> ConsiderKeyModifiers<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ConsiderKeyModifiers<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.ConsiderKeyModifiersProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.VerticalContentAlignmentProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.KeyGestureInput 
=> style._addSetter(Ursa.Controls.KeyGestureInput.InnerRightContentProperty, binding);



}
