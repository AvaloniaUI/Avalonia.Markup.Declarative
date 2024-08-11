#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerExtensions
{
public static T BringIntoViewOnFocusChange<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static T BringIntoViewOnFocusChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BringIntoViewOnFocusChange<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, func, onChanged, expression);
public static T BringIntoViewOnFocusChange<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value, bindingMode, converter, bindingSource);
public static T BringIntoViewOnFocusChange<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Offset<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.OffsetProperty, binding);
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Offset<T>(this T control, Func<Vector> func, Action<Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.OffsetProperty, func, onChanged, expression);
public static T Offset<T>(this T control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static T Offset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalScrollBarVisibility<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static T HorizontalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalScrollBarVisibility<T>(this T control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, func, onChanged, expression);
public static T HorizontalScrollBarVisibility<T>(this T control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static T HorizontalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsType<T>(this T control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, func, onChanged, expression);
public static T HorizontalSnapPointsType<T>(this T control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsType<T>(this T control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, func, onChanged, expression);
public static T VerticalSnapPointsType<T>(this T control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T HorizontalSnapPointsAlignment<T>(this T control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsAlignment<T>(this T control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T VerticalSnapPointsAlignment<T>(this T control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalScrollBarVisibility<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static T VerticalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalScrollBarVisibility<T>(this T control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, func, onChanged, expression);
public static T VerticalScrollBarVisibility<T>(this T control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static T VerticalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.AllowAutoHideProperty, binding);
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowAutoHide<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.AllowAutoHideProperty, func, onChanged, expression);
public static T AllowAutoHide<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static T AllowAutoHide<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollChainingEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, func, onChanged, expression);
public static T IsScrollChainingEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollInertiaEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, func, onChanged, expression);
public static T IsScrollInertiaEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDeferredScrollingEnabled<T>(this T control, IBinding binding) where T : ScrollViewer
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, binding);
public static T IsDeferredScrollingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDeferredScrollingEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollViewer
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, func, onChanged, expression);
public static T IsDeferredScrollingEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = value, bindingMode, converter, bindingSource);
public static T IsDeferredScrollingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollViewer
=> control._setEx(ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

