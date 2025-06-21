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
public static partial class UrsaView_MarkupExtensions
{
//================= Properties ======================//
 // IsTitleBarVisible

/*ValueSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaView 
=> control._set(() => control.IsTitleBarVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LeftContent

/*ValueSetterGenerator*/
public static T LeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaView 
=> control._set(() => control.LeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T LeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.LeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.LeftContentProperty, ps, () => control.LeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.LeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.LeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.LeftContentProperty, ps, () => control.LeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RightContent

/*ValueSetterGenerator*/
public static T RightContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaView 
=> control._set(() => control.RightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T RightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.RightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.RightContentProperty, ps, () => control.RightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.RightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.RightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.RightContentProperty, ps, () => control.RightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarContent

/*ValueSetterGenerator*/
public static T TitleBarContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaView 
=> control._set(() => control.TitleBarContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.TitleBarContentProperty, ps, () => control.TitleBarContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.TitleBarContentProperty, ps, () => control.TitleBarContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarMargin

/*ValueSetterGenerator*/
public static T TitleBarMargin<T>(this T control, Avalonia.Thickness value) where T : Ursa.Controls.UrsaView 
=> control._set(() => control.TitleBarMargin = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarMargin<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarMarginProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T TitleBarMargin<T>(this T control, System.Double uniformLength = default!) where T : Ursa.Controls.UrsaView 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(uniformLength));
public static T TitleBarMargin<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Ursa.Controls.UrsaView 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(horizontal, vertical));
public static T TitleBarMargin<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Ursa.Controls.UrsaView 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(left, top, right, bottom));

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarMargin<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.TitleBarMarginProperty, ps, () => control.TitleBarMargin = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarMargin<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarMarginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarMargin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaView 
   => control._set(Ursa.Controls.UrsaView.TitleBarMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarMargin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaView 
=> control._setEx(Ursa.Controls.UrsaView.TitleBarMarginProperty, ps, () => control.TitleBarMargin = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsTitleBarVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.IsTitleBarVisibleProperty, binding);


 // LeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> LeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.LeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.LeftContentProperty, binding);


 // RightContent

/*ValueStyleSetterGenerator*/
public static Style<T> RightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.RightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.RightContentProperty, binding);


 // TitleBarContent

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.TitleBarContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.TitleBarContentProperty, binding);


 // TitleBarMargin

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, Avalonia.Thickness value) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.TitleBarMarginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaView 
=> style._addSetter(Ursa.Controls.UrsaView.TitleBarMarginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double uniformLength) where T : Ursa.Controls.UrsaView 
   => style._addSetter(Ursa.Controls.UrsaView.TitleBarMarginProperty, new Avalonia.Thickness(uniformLength));public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Ursa.Controls.UrsaView 
   => style._addSetter(Ursa.Controls.UrsaView.TitleBarMarginProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Ursa.Controls.UrsaView 
   => style._addSetter(Ursa.Controls.UrsaView.TitleBarMarginProperty, new Avalonia.Thickness(left, top, right, bottom));



}
