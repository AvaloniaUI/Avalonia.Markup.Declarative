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
public static partial class RatingCharacter_MarkupExtensions
{
//================= Properties ======================//
 // AllowHalf

/*ValueSetterGenerator*/
public static T AllowHalf<T>(this T control, System.Boolean value) where T : Ursa.Controls.RatingCharacter 
=> control._set(() => control.AllowHalf = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowHalf<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.AllowHalfProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowHalf<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.AllowHalfProperty, ps, () => control.AllowHalf = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowHalf<T>(this T control, IBinding binding) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.AllowHalfProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowHalf<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.AllowHalfProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowHalf<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.AllowHalfProperty, ps, () => control.AllowHalf = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Character

/*ValueSetterGenerator*/
public static T Character<T>(this T control, System.Object value) where T : Ursa.Controls.RatingCharacter 
=> control._set(() => control.Character = value!);

/*BindFromExpressionSetterGenerator*/
public static T Character<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.CharacterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Character<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.CharacterProperty, ps, () => control.Character = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Character<T>(this T control, IBinding binding) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.CharacterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Character<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.CharacterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Character<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.CharacterProperty, ps, () => control.Character = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Size

/*ValueSetterGenerator*/
public static T Size<T>(this T control, System.Double value) where T : Ursa.Controls.RatingCharacter 
=> control._set(() => control.Size = value!);

/*BindFromExpressionSetterGenerator*/
public static T Size<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.SizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Size<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.SizeProperty, ps, () => control.Size = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Size<T>(this T control, IBinding binding) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.SizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Size<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.RatingCharacter 
   => control._set(Ursa.Controls.RatingCharacter.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Size<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.RatingCharacter 
=> control._setEx(Ursa.Controls.RatingCharacter.SizeProperty, ps, () => control.Size = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // AllowHalf

/*ValueStyleSetterGenerator*/
public static Style<T> AllowHalf<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.AllowHalfProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowHalf<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.AllowHalfProperty, binding);


 // Character

/*ValueStyleSetterGenerator*/
public static Style<T> Character<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.CharacterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Character<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.CharacterProperty, binding);


 // Size

/*ValueStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.SizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.RatingCharacter 
=> style._addSetter(Ursa.Controls.RatingCharacter.SizeProperty, binding);



}
