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
public static partial class LayoutTransformControl_MarkupExtensions
{
//================= Properties ======================//
 // LayoutTransform

/*ValueSetterGenerator*/
public static T LayoutTransform<T>(this T control, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl 
=> control._set(() => control.LayoutTransform = value!);

/*BindFromExpressionSetterGenerator*/
public static T LayoutTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LayoutTransform<T>(this T control,Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl 
=> control._setEx(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LayoutTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LayoutTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LayoutTransform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl 
=> control._setEx(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UseRenderTransform

/*ValueSetterGenerator*/
public static T UseRenderTransform<T>(this T control, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
=> control._set(() => control.UseRenderTransform = value!);

/*BindFromExpressionSetterGenerator*/
public static T UseRenderTransform<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UseRenderTransform<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl 
=> control._setEx(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UseRenderTransform<T>(this T control, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UseRenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.LayoutTransformControl 
   => control._set(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UseRenderTransform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.LayoutTransformControl 
=> control._setEx(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // LayoutTransform

/*ValueStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LayoutTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.LayoutTransformProperty, binding);


 // UseRenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UseRenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.LayoutTransformControl 
=> style._addSetter(Avalonia.Controls.LayoutTransformControl.UseRenderTransformProperty, binding);



}
