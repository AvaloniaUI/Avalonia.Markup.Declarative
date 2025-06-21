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
public static partial class Skeleton_MarkupExtensions
{
//================= Properties ======================//
 // IsActive

/*ValueSetterGenerator*/
public static T IsActive<T>(this T control, System.Boolean value) where T : Ursa.Controls.Skeleton 
=> control._set(() => control.IsActive = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsActive<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsActiveProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsActive<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Skeleton 
=> control._setEx(Ursa.Controls.Skeleton.IsActiveProperty, ps, () => control.IsActive = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsActive<T>(this T control, IBinding binding) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsActiveProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsActive<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsActiveProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsActive<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Skeleton 
=> control._setEx(Ursa.Controls.Skeleton.IsActiveProperty, ps, () => control.IsActive = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsLoading

/*ValueSetterGenerator*/
public static T IsLoading<T>(this T control, System.Boolean value) where T : Ursa.Controls.Skeleton 
=> control._set(() => control.IsLoading = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsLoading<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsLoadingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsLoading<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Skeleton 
=> control._setEx(Ursa.Controls.Skeleton.IsLoadingProperty, ps, () => control.IsLoading = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsLoading<T>(this T control, IBinding binding) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsLoadingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsLoading<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Skeleton 
   => control._set(Ursa.Controls.Skeleton.IsLoadingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsLoading<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Skeleton 
=> control._setEx(Ursa.Controls.Skeleton.IsLoadingProperty, ps, () => control.IsLoading = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsActive

/*ValueStyleSetterGenerator*/
public static Style<T> IsActive<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Skeleton 
=> style._addSetter(Ursa.Controls.Skeleton.IsActiveProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsActive<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Skeleton 
=> style._addSetter(Ursa.Controls.Skeleton.IsActiveProperty, binding);


 // IsLoading

/*ValueStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Skeleton 
=> style._addSetter(Ursa.Controls.Skeleton.IsLoadingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsLoading<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Skeleton 
=> style._addSetter(Ursa.Controls.Skeleton.IsLoadingProperty, binding);



}
