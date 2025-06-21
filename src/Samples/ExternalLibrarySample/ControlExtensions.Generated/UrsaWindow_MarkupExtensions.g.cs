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
public static partial class UrsaWindow_MarkupExtensions
{
//================= Properties ======================//
 // IsFullScreenButtonVisible

/*ValueSetterGenerator*/
public static T IsFullScreenButtonVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsFullScreenButtonVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsFullScreenButtonVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsFullScreenButtonVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty, ps, () => control.IsFullScreenButtonVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsFullScreenButtonVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsFullScreenButtonVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsFullScreenButtonVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty, ps, () => control.IsFullScreenButtonVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsMinimizeButtonVisible

/*ValueSetterGenerator*/
public static T IsMinimizeButtonVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsMinimizeButtonVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsMinimizeButtonVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsMinimizeButtonVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty, ps, () => control.IsMinimizeButtonVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsMinimizeButtonVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsMinimizeButtonVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsMinimizeButtonVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty, ps, () => control.IsMinimizeButtonVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsRestoreButtonVisible

/*ValueSetterGenerator*/
public static T IsRestoreButtonVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsRestoreButtonVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsRestoreButtonVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsRestoreButtonVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty, ps, () => control.IsRestoreButtonVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsRestoreButtonVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsRestoreButtonVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsRestoreButtonVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty, ps, () => control.IsRestoreButtonVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsCloseButtonVisible

/*ValueSetterGenerator*/
public static T IsCloseButtonVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsCloseButtonVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsCloseButtonVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsCloseButtonVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty, ps, () => control.IsCloseButtonVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsCloseButtonVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsCloseButtonVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsCloseButtonVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty, ps, () => control.IsCloseButtonVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsTitleBarVisible

/*ValueSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsTitleBarVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTitleBarVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsTitleBarVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty, ps, () => control.IsTitleBarVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsManagedResizerVisible

/*ValueSetterGenerator*/
public static T IsManagedResizerVisible<T>(this T control, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.IsManagedResizerVisible = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsManagedResizerVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsManagedResizerVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty, ps, () => control.IsManagedResizerVisible = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsManagedResizerVisible<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsManagedResizerVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsManagedResizerVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty, ps, () => control.IsManagedResizerVisible = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarContent

/*ValueSetterGenerator*/
public static T TitleBarContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.TitleBarContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.TitleBarContentProperty, ps, () => control.TitleBarContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.TitleBarContentProperty, ps, () => control.TitleBarContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LeftContent

/*ValueSetterGenerator*/
public static T LeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.LeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T LeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.LeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.LeftContentProperty, ps, () => control.LeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.LeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.LeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.LeftContentProperty, ps, () => control.LeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // RightContent

/*ValueSetterGenerator*/
public static T RightContent<T>(this T control, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.RightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T RightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.RightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.RightContentProperty, ps, () => control.RightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.RightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.RightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.RightContentProperty, ps, () => control.RightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TitleBarMargin

/*ValueSetterGenerator*/
public static T TitleBarMargin<T>(this T control, Avalonia.Thickness value) where T : Ursa.Controls.UrsaWindow 
=> control._set(() => control.TitleBarMargin = value!);

/*BindFromExpressionSetterGenerator*/
public static T TitleBarMargin<T>(this T control, Func<Avalonia.Thickness> func, Action<Avalonia.Thickness>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarMarginProperty!, func, onChanged, expression);

/*ValueOverloadsSetterGenerator*/

public static T TitleBarMargin<T>(this T control, System.Double uniformLength = default!) where T : Ursa.Controls.UrsaWindow 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(uniformLength));
public static T TitleBarMargin<T>(this T control, System.Double horizontal = default!, System.Double vertical = default!) where T : Ursa.Controls.UrsaWindow 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(horizontal, vertical));
public static T TitleBarMargin<T>(this T control, System.Double left = default!, System.Double top = default!, System.Double right = default!, System.Double bottom = default!) where T : Ursa.Controls.UrsaWindow 
   => control._set(() => control.TitleBarMargin = new Avalonia.Thickness(left, top, right, bottom));

/*MagicalSetterGenerator*/
[Obsolete]
public static T TitleBarMargin<T>(this T control,Avalonia.Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, ps, () => control.TitleBarMargin = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TitleBarMargin<T>(this T control, IBinding binding) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TitleBarMargin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.UrsaWindow 
   => control._set(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TitleBarMargin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.UrsaWindow 
=> control._setEx(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, ps, () => control.TitleBarMargin = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsFullScreenButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsFullScreenButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsFullScreenButtonVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsFullScreenButtonVisibleProperty, binding);


 // IsMinimizeButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsMinimizeButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsMinimizeButtonVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsMinimizeButtonVisibleProperty, binding);


 // IsRestoreButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsRestoreButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsRestoreButtonVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsRestoreButtonVisibleProperty, binding);


 // IsCloseButtonVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsCloseButtonVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsCloseButtonVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsCloseButtonVisibleProperty, binding);


 // IsTitleBarVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTitleBarVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsTitleBarVisibleProperty, binding);


 // IsManagedResizerVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsManagedResizerVisible<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsManagedResizerVisible<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.IsManagedResizerVisibleProperty, binding);


 // TitleBarContent

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.TitleBarContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.TitleBarContentProperty, binding);


 // LeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> LeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.LeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.LeftContentProperty, binding);


 // RightContent

/*ValueStyleSetterGenerator*/
public static Style<T> RightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.RightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.RightContentProperty, binding);


 // TitleBarMargin

/*ValueStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, Avalonia.Thickness value) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.TitleBarMarginProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.UrsaWindow 
=> style._addSetter(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double uniformLength) where T : Ursa.Controls.UrsaWindow 
   => style._addSetter(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, new Avalonia.Thickness(uniformLength));public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double horizontal, System.Double vertical) where T : Ursa.Controls.UrsaWindow 
   => style._addSetter(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, new Avalonia.Thickness(horizontal, vertical));public static Style<T> TitleBarMargin<T>(this Style<T> style, System.Double left, System.Double top, System.Double right, System.Double bottom) where T : Ursa.Controls.UrsaWindow 
   => style._addSetter(Ursa.Controls.UrsaWindow.TitleBarMarginProperty, new Avalonia.Thickness(left, top, right, bottom));



}
