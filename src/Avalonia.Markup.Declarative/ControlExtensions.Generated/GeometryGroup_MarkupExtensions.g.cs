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
public static partial class GeometryGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*BindFromExpressionSetterGenerator*/
public static T Children<T>(this T control, Func<Avalonia.Media.GeometryCollection> func, Action<Avalonia.Media.GeometryCollection>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Children<T>(this T control,Avalonia.Media.GeometryCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.GeometryGroup 
=> control._setEx(Avalonia.Media.GeometryGroup.ChildrenProperty, ps, () => control.Children = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Children<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Children<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Children<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.GeometryCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.GeometryGroup 
=> control._setEx(Avalonia.Media.GeometryGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FillRule

/*BindFromExpressionSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FillRule<T>(this T control,Avalonia.Media.FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.GeometryGroup 
=> control._setEx(Avalonia.Media.GeometryGroup.FillRuleProperty, ps, () => control.FillRule = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FillRule<T>(this T control, IBinding binding) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.GeometryGroup 
   => control._set(Avalonia.Media.GeometryGroup.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FillRule<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Media.GeometryGroup 
=> control._setEx(Avalonia.Media.GeometryGroup.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
