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
public static partial class PathSegment_MarkupExtensions
{
//================= Properties ======================//
 // IsStroked

/*BindFromExpressionSetterGenerator*/
public static T IsStroked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsStroked<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathSegment 
=> control._setEx(Avalonia.Media.PathSegment.IsStrokedProperty, ps, () => control.IsStroked = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsStroked<T>(this T control, IBinding binding) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsStroked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathSegment 
   => control._set(Avalonia.Media.PathSegment.IsStrokedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsStroked<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathSegment 
=> control._setEx(Avalonia.Media.PathSegment.IsStrokedProperty, ps, () => control.IsStroked = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
