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
public static partial class TwoTonePathIcon_MarkupExtensions
{
//================= Properties ======================//
 // StrokeBrush

/*ValueSetterGenerator*/
public static T StrokeBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.StrokeBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T StrokeBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StrokeBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty, ps, () => control.StrokeBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StrokeBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty, ps, () => control.StrokeBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Data

/*ValueSetterGenerator*/
public static T Data<T>(this T control, Avalonia.Media.Geometry value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.Data = value!);

/*BindFromExpressionSetterGenerator*/
public static T Data<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.DataProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Data<T>(this T control,Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.DataProperty, ps, () => control.Data = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Data<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.DataProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Data<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.DataProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Data<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.DataProperty, ps, () => control.Data = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsActive

/*ValueSetterGenerator*/
public static T IsActive<T>(this T control, System.Boolean value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.IsActive = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsActive<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.IsActiveProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsActive<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.IsActiveProperty, ps, () => control.IsActive = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsActive<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.IsActiveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsActive<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.IsActiveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsActive<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.IsActiveProperty, ps, () => control.IsActive = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActiveForeground

/*ValueSetterGenerator*/
public static T ActiveForeground<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.ActiveForeground = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActiveForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActiveForeground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty, ps, () => control.ActiveForeground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActiveForeground<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActiveForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActiveForeground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty, ps, () => control.ActiveForeground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ActiveStrokeBrush

/*ValueSetterGenerator*/
public static T ActiveStrokeBrush<T>(this T control, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.ActiveStrokeBrush = value!);

/*BindFromExpressionSetterGenerator*/
public static T ActiveStrokeBrush<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ActiveStrokeBrush<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty, ps, () => control.ActiveStrokeBrush = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ActiveStrokeBrush<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ActiveStrokeBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ActiveStrokeBrush<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty, ps, () => control.ActiveStrokeBrush = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // StrokeThickness

/*ValueSetterGenerator*/
public static T StrokeThickness<T>(this T control, System.Double value) where T : Ursa.Controls.TwoTonePathIcon 
=> control._set(() => control.StrokeThickness = value!);

/*BindFromExpressionSetterGenerator*/
public static T StrokeThickness<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T StrokeThickness<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty, ps, () => control.StrokeThickness = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T StrokeThickness<T>(this T control, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T StrokeThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TwoTonePathIcon 
   => control._set(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T StrokeThickness<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TwoTonePathIcon 
=> control._setEx(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // StrokeBrush

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.StrokeBrushProperty, binding);


 // Data

/*ValueStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.DataProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Data<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.DataProperty, binding);


 // IsActive

/*ValueStyleSetterGenerator*/
public static Style<T> IsActive<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.IsActiveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsActive<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.IsActiveProperty, binding);


 // ActiveForeground

/*ValueStyleSetterGenerator*/
public static Style<T> ActiveForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ActiveForeground<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.ActiveForegroundProperty, binding);


 // ActiveStrokeBrush

/*ValueStyleSetterGenerator*/
public static Style<T> ActiveStrokeBrush<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ActiveStrokeBrush<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.ActiveStrokeBrushProperty, binding);


 // StrokeThickness

/*ValueStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> StrokeThickness<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TwoTonePathIcon 
=> style._addSetter(Ursa.Controls.TwoTonePathIcon.StrokeThicknessProperty, binding);



}
