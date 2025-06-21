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
public static partial class PaginationButton_MarkupExtensions
{
//================= Properties ======================//
 // Page

/*ValueSetterGenerator*/
public static T Page<T>(this T control, System.Int32 value) where T : Ursa.Controls.PaginationButton 
=> control._set(() => control.Page = value!);

/*BindFromExpressionSetterGenerator*/
public static T Page<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PaginationButton 
   => control._set(Ursa.Controls.PaginationButton.PageProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Page<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PaginationButton 
=> control._setEx(Ursa.Controls.PaginationButton.PageProperty, ps, () => control.Page = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Page<T>(this T control, IBinding binding) where T : Ursa.Controls.PaginationButton 
   => control._set(Ursa.Controls.PaginationButton.PageProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Page<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PaginationButton 
   => control._set(Ursa.Controls.PaginationButton.PageProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Page<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PaginationButton 
=> control._setEx(Ursa.Controls.PaginationButton.PageProperty, ps, () => control.Page = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Page

/*ValueStyleSetterGenerator*/
public static Style<T> Page<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.PaginationButton 
=> style._addSetter(Ursa.Controls.PaginationButton.PageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Page<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PaginationButton 
=> style._addSetter(Ursa.Controls.PaginationButton.PageProperty, binding);



}
