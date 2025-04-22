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
public static partial class DefinitionBase_MarkupExtensions
{
//================= Properties ======================//
 // SharedSizeGroup

/*BindFromExpressionSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SharedSizeGroup<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DefinitionBase 
=> control._setEx(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, IBinding binding) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SharedSizeGroup<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DefinitionBase 
   => control._set(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SharedSizeGroup<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.DefinitionBase 
=> control._setEx(Avalonia.Controls.DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
