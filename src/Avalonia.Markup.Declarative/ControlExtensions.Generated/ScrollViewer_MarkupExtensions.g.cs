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
public static partial class ScrollViewer_MarkupExtensions
{
//================= Properties ======================//
 // BringIntoViewOnFocusChange

/*BindFromExpressionSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T BringIntoViewOnFocusChange<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T BringIntoViewOnFocusChange<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Offset

/*BindFromExpressionSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Offset<T>(this T control,Avalonia.Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Offset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalScrollBarVisibility

/*BindFromExpressionSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalScrollBarVisibility<T>(this T control,Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalScrollBarVisibility<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalSnapPointsType

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalSnapPointsType<T>(this T control,Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalSnapPointsType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalSnapPointsType

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalSnapPointsType<T>(this T control,Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalSnapPointsType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalSnapPointsAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalSnapPointsAlignment<T>(this T control,Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalSnapPointsAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalSnapPointsAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalSnapPointsAlignment<T>(this T control,Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalSnapPointsAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalScrollBarVisibility

/*BindFromExpressionSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalScrollBarVisibility<T>(this T control,Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalScrollBarVisibility<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowAutoHide

/*BindFromExpressionSetterGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowAutoHide<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowAutoHide<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsScrollChainingEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsScrollChainingEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsScrollChainingEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsScrollInertiaEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsScrollInertiaEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsScrollInertiaEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDeferredScrollingEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDeferredScrollingEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDeferredScrollingEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ScrollViewer 
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // BringIntoViewOnFocusChange

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetBringIntoViewOnFocusChange(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, func, onChanged, expression);


 // HorizontalScrollBarVisibility

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalScrollBarVisibility(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, func, onChanged, expression);


 // HorizontalSnapPointsType

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsType(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, func, onChanged, expression);


 // VerticalSnapPointsType

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsType(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, func, onChanged, expression);


 // HorizontalSnapPointsAlignment

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsAlignment(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, func, onChanged, expression);


 // VerticalSnapPointsAlignment

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsAlignment(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, func, onChanged, expression);


 // VerticalScrollBarVisibility

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalScrollBarVisibility(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, func, onChanged, expression);


 // AllowAutoHide

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => Avalonia.Controls.ScrollViewer.SetAllowAutoHide(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, func, onChanged, expression);


 // IsScrollChainingEnabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsScrollChainingEnabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, func, onChanged, expression);


 // IsScrollInertiaEnabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsScrollInertiaEnabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, func, onChanged, expression);


 // IsDeferredScrollingEnabled

/*AttachedPropertyMagicalSetterGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsDeferredScrollingEnabled(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T ScrollViewer_IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.Control 
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, func, onChanged, expression);



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Avalonia.Controls.ScrollViewer 
{
  control.AddHandler(Avalonia.Controls.ScrollViewer.ScrollChangedEvent, (_, args) => action(args), routes ?? Avalonia.Controls.ScrollViewer.ScrollChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // BringIntoViewOnFocusChange

/*ValueStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);


 // VerticalScrollBarVisibility

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);


 // AllowAutoHide

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);


 // IsScrollInertiaEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);


 // IsDeferredScrollingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer 
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);



}
