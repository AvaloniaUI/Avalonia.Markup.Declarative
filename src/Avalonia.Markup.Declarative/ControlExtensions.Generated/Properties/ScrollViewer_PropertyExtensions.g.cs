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
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, func, onChanged, expression);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value, bindingMode, converter, bindingSource);
public static ScrollViewer BringIntoViewOnFocusChange<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer Offset(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.OffsetProperty, binding);
public static ScrollViewer Offset(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer Offset(this ScrollViewer control, Func<Vector> func, Action<Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.OffsetProperty, func, onChanged, expression);
public static ScrollViewer Offset(this ScrollViewer control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static ScrollViewer Offset<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, func, onChanged, expression);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalScrollBarVisibility<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, func, onChanged, expression);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsType<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, func, onChanged, expression);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsType<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsAlignment<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsAlignment<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, Func<ScrollBarVisibility> func, Action<ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, func, onChanged, expression);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalScrollBarVisibility<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.AllowAutoHideProperty, binding);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.AllowAutoHideProperty, func, onChanged, expression);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static ScrollViewer AllowAutoHide<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, func, onChanged, expression);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollChainingEnabled<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, func, onChanged, expression);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollInertiaEnabled<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, binding);
public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.IsDeferredScrollingEnabledProperty, func, onChanged, expression);
public static ScrollViewer IsDeferredScrollingEnabled(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = value, bindingMode, converter, bindingSource);
public static ScrollViewer IsDeferredScrollingEnabled<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

