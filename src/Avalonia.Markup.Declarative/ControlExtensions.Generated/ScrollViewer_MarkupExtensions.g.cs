#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewer_MarkupExtensions
{
//================= Properties ======================//
 // BringIntoViewOnFocusChangeProperty

/*BindFromExpressionSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T BringIntoViewOnFocusChange<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OffsetProperty

/*BindFromExpressionSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Offset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalScrollBarVisibilityProperty

/*BindFromExpressionSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsTypeProperty

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsTypeProperty

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsAlignmentProperty

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalScrollBarVisibilityProperty

/*BindFromExpressionSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AllowAutoHideProperty

/*BindFromExpressionSetterGenerator*/
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AllowAutoHide<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsScrollChainingEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsScrollChainingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsScrollInertiaEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsScrollInertiaEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDeferredScrollingEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDeferredScrollingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
    public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action) where T : Avalonia.Controls.ScrollViewer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ScrollChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ScrollChanged += h);



//================= Styles ======================//
 // BringIntoViewOnFocusChangeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);


 // OffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibilityProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);


 // HorizontalSnapPointsTypeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsTypeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);


 // VerticalScrollBarVisibilityProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);


 // AllowAutoHideProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);


 // IsScrollChainingEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);


 // IsScrollInertiaEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);


 // IsDeferredScrollingEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);



}
