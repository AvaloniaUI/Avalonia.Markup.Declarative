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
public static partial class MaskedTextBox_MarkupExtensions
{
//================= Properties ======================//
 // AsciiOnly

/*BindFromExpressionSetterGenerator*/
public static T AsciiOnly<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AsciiOnly<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AsciiOnly<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AsciiOnly<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AsciiOnly<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Culture

/*BindFromExpressionSetterGenerator*/
public static T Culture<T>(this T control, Func<System.Globalization.CultureInfo> func, Action<System.Globalization.CultureInfo>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Culture<T>(this T control,System.Globalization.CultureInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.CultureProperty, ps, () => control.Culture = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Culture<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Culture<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Culture<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Globalization.CultureInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.CultureProperty, ps, () => control.Culture = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HidePromptOnLeave

/*BindFromExpressionSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HidePromptOnLeave<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HidePromptOnLeave<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Mask

/*BindFromExpressionSetterGenerator*/
public static T Mask<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Mask<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.MaskProperty, ps, () => control.Mask = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Mask<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Mask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Mask<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.MaskProperty, ps, () => control.Mask = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // PromptChar

/*BindFromExpressionSetterGenerator*/
public static T PromptChar<T>(this T control, Func<System.Char> func, Action<System.Char>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T PromptChar<T>(this T control,System.Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PromptChar<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PromptChar<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T PromptChar<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ResetOnPrompt

/*BindFromExpressionSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ResetOnPrompt<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResetOnPrompt<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ResetOnPrompt<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ResetOnSpace

/*BindFromExpressionSetterGenerator*/
public static T ResetOnSpace<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ResetOnSpace<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ResetOnSpace<T>(this T control, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ResetOnSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.MaskedTextBox 
   => control._set(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ResetOnSpace<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.MaskedTextBox 
=> control._setEx(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // AsciiOnly

/*ValueStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AsciiOnly<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.AsciiOnlyProperty, binding);


 // Culture

/*ValueStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, System.Globalization.CultureInfo value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Culture<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.CultureProperty, binding);


 // HidePromptOnLeave

/*ValueStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HidePromptOnLeave<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.HidePromptOnLeaveProperty, binding);


 // Mask

/*ValueStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Mask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.MaskProperty, binding);


 // PromptChar

/*ValueStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, System.Char value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> PromptChar<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.PromptCharProperty, binding);


 // ResetOnPrompt

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnPrompt<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnPromptProperty, binding);


 // ResetOnSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ResetOnSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.MaskedTextBox 
=> style._addSetter(Avalonia.Controls.MaskedTextBox.ResetOnSpaceProperty, binding);



}
