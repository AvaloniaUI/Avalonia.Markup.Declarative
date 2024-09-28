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
public static partial class DataValidationErrors_MarkupExtensions
{
//================= Properties ======================//
 // ErrorTemplateProperty

/*BindFromExpressionSetterGenerator*/
public static T ErrorTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ErrorTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ErrorTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ErrorTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ErrorTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OwnerProperty

/*BindFromExpressionSetterGenerator*/
public static T Owner<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Owner<T>(this T control, Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.OwnerProperty, ps, () => control.Owner = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Owner<T>(this T control, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Owner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DataValidationErrors
   => control._set(Avalonia.Controls.DataValidationErrors.OwnerProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Owner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DataValidationErrors
=> control._setEx(Avalonia.Controls.DataValidationErrors.OwnerProperty, ps, () => control.Owner = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // ErrorsProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T DataValidationErrors_Errors<T>(this T control, System.Collections.Generic.IEnumerable<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.DataValidationErrors.ErrorsProperty, ps, () => Avalonia.Controls.DataValidationErrors.SetErrors(control, value), bindingMode, converter, bindingSource);


 // ErrorConverterProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T DataValidationErrors_ErrorConverter<T>(this T control, System.Func<System.Object,System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.DataValidationErrors.ErrorConverterProperty, ps, () => Avalonia.Controls.DataValidationErrors.SetErrorConverter(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//
 // ErrorTemplateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.DataValidationErrors
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ErrorTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.DataValidationErrors
=> style._addSetter(Avalonia.Controls.DataValidationErrors.ErrorTemplateProperty, binding);



}
