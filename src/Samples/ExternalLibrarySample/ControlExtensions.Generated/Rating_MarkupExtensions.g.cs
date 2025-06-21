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
public static partial class Rating_MarkupExtensions
{
//================= Properties ======================//
 // Value

/*ValueSetterGenerator*/
public static T Value<T>(this T control, System.Double value) where T : Ursa.Controls.Rating 
=> control._set(() => control.Value = value!);

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Value<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.ValueProperty, ps, () => control.Value = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.ValueProperty, ps, () => control.Value = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowClear

/*ValueSetterGenerator*/
public static T AllowClear<T>(this T control, System.Boolean value) where T : Ursa.Controls.Rating 
=> control._set(() => control.AllowClear = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowClear<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowClearProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowClear<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.AllowClearProperty, ps, () => control.AllowClear = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowClear<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowClearProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowClear<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowClearProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowClear<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.AllowClearProperty, ps, () => control.AllowClear = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowHalf

/*ValueSetterGenerator*/
public static T AllowHalf<T>(this T control, System.Boolean value) where T : Ursa.Controls.Rating 
=> control._set(() => control.AllowHalf = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowHalf<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowHalfProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowHalf<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.AllowHalfProperty, ps, () => control.AllowHalf = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowHalf<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowHalfProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowHalf<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.AllowHalfProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowHalf<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.AllowHalfProperty, ps, () => control.AllowHalf = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Character

/*ValueSetterGenerator*/
public static T Character<T>(this T control, System.Object value) where T : Ursa.Controls.Rating 
=> control._set(() => control.Character = value!);

/*BindFromExpressionSetterGenerator*/
public static T Character<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CharacterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Character<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.CharacterProperty, ps, () => control.Character = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Character<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CharacterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Character<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CharacterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Character<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.CharacterProperty, ps, () => control.Character = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Count

/*ValueSetterGenerator*/
public static T Count<T>(this T control, System.Int32 value) where T : Ursa.Controls.Rating 
=> control._set(() => control.Count = value!);

/*BindFromExpressionSetterGenerator*/
public static T Count<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CountProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Count<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.CountProperty, ps, () => control.Count = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Count<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Count<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.CountProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Count<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.CountProperty, ps, () => control.Count = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DefaultValue

/*ValueSetterGenerator*/
public static T DefaultValue<T>(this T control, System.Double value) where T : Ursa.Controls.Rating 
=> control._set(() => control.DefaultValue = value!);

/*BindFromExpressionSetterGenerator*/
public static T DefaultValue<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.DefaultValueProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DefaultValue<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.DefaultValueProperty, ps, () => control.DefaultValue = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultValue<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.DefaultValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.DefaultValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DefaultValue<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.DefaultValueProperty, ps, () => control.DefaultValue = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Size

/*ValueSetterGenerator*/
public static T Size<T>(this T control, System.Double value) where T : Ursa.Controls.Rating 
=> control._set(() => control.Size = value!);

/*BindFromExpressionSetterGenerator*/
public static T Size<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.SizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Size<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.SizeProperty, ps, () => control.Size = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Size<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.SizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Size<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.SizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Size<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.SizeProperty, ps, () => control.Size = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Rating 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.ItemTemplateProperty, ps, () => control.ItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Rating 
   => control._set(Ursa.Controls.Rating.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Rating 
=> control._setEx(Ursa.Controls.Rating.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.ValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.ValueProperty, binding);


 // AllowClear

/*ValueStyleSetterGenerator*/
public static Style<T> AllowClear<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.AllowClearProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowClear<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.AllowClearProperty, binding);


 // AllowHalf

/*ValueStyleSetterGenerator*/
public static Style<T> AllowHalf<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.AllowHalfProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowHalf<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.AllowHalfProperty, binding);


 // Character

/*ValueStyleSetterGenerator*/
public static Style<T> Character<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.CharacterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Character<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.CharacterProperty, binding);


 // Count

/*ValueStyleSetterGenerator*/
public static Style<T> Count<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.CountProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Count<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.CountProperty, binding);


 // DefaultValue

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultValue<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.DefaultValueProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultValue<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.DefaultValueProperty, binding);


 // Size

/*ValueStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.SizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Size<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.SizeProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Rating 
=> style._addSetter(Ursa.Controls.Rating.ItemTemplateProperty, binding);



}
