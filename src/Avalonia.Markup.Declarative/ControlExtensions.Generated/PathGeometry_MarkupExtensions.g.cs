#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class PathGeometry_MarkupExtensions
{
//================= Properties ======================//
 // Figures

/*BindFromExpressionSetterGenerator*/
public static T Figures<T>(this T control, Func<Avalonia.Media.PathFigures> func, Action<Avalonia.Media.PathFigures>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Figures<T>(this T control,Avalonia.Media.PathFigures value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathGeometry 
=> control._setEx(Avalonia.Media.PathGeometry.FiguresProperty, ps, () => control.Figures = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Figures<T>(this T control, IBinding binding) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Figures<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FiguresProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Figures<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.PathFigures> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathGeometry 
=> control._setEx(Avalonia.Media.PathGeometry.FiguresProperty, ps, () => control.Figures = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FillRule

/*BindFromExpressionSetterGenerator*/
public static T FillRule<T>(this T control, Func<Avalonia.Media.FillRule> func, Action<Avalonia.Media.FillRule>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FillRule<T>(this T control,Avalonia.Media.FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathGeometry 
=> control._setEx(Avalonia.Media.PathGeometry.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FillRule<T>(this T control, IBinding binding) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FillRule<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Media.PathGeometry 
   => control._set(Avalonia.Media.PathGeometry.FillRuleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FillRule<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Media.PathGeometry 
=> control._setEx(Avalonia.Media.PathGeometry.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
