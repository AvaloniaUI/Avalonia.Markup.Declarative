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
public static partial class Inline_MarkupExtensions
{
//================= Properties ======================//
 // TextDecorations

/*BindFromExpressionSetterGenerator*/
public static T TextDecorations<T>(this T control, Func<Avalonia.Media.TextDecorationCollection> func, Action<Avalonia.Media.TextDecorationCollection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextDecorations<T>(this T control,Avalonia.Media.TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Documents.Inline 
=> control._setEx(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextDecorations<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextDecorations<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextDecorations<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Documents.Inline 
=> control._setEx(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // BaselineAlignment

/*BindFromExpressionSetterGenerator*/
public static T BaselineAlignment<T>(this T control, Func<Avalonia.Media.BaselineAlignment> func, Action<Avalonia.Media.BaselineAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BaselineAlignment<T>(this T control,Avalonia.Media.BaselineAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Documents.Inline 
=> control._setEx(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BaselineAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BaselineAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Inline 
   => control._set(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BaselineAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.BaselineAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Documents.Inline 
=> control._setEx(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // TextDecorations

/*ValueStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, Avalonia.Media.TextDecorationCollection value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextDecorations<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.TextDecorationsProperty, binding);


 // BaselineAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, Avalonia.Media.BaselineAlignment value) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BaselineAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Inline 
=> style._addSetter(Avalonia.Controls.Documents.Inline.BaselineAlignmentProperty, binding);



}
