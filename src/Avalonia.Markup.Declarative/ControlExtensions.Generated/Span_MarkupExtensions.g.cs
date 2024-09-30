#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Span_MarkupExtensions
{
//================= Properties ======================//
 // Inlines

/*BindFromExpressionSetterGenerator*/
public static T Inlines<T>(this T control, Func<Avalonia.Controls.Documents.InlineCollection> func, Action<Avalonia.Controls.Documents.InlineCollection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Documents.Span Inlines<T>(this T control,Avalonia.Controls.Documents.InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Span=> control._setEx(Avalonia.Controls.Documents.Span.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Inlines<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Inlines<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.Span 
   => control._set(Avalonia.Controls.Documents.Span.InlinesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Inlines<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Documents.InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.Span=> control._setEx(Avalonia.Controls.Documents.Span.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // Inlines

/*ValueStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, Avalonia.Controls.Documents.InlineCollection value) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Inlines<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.Span 
=> style._addSetter(Avalonia.Controls.Documents.Span.InlinesProperty, binding);



}
