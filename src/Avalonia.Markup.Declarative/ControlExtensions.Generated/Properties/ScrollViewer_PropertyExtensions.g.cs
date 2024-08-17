#nullable enable
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ScrollViewer = Avalonia.Controls.ScrollViewer;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollViewerExtensions
{
public static T BringIntoViewOnFocusChange<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static T BringIntoViewOnFocusChange<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T BringIntoViewOnFocusChange<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, func, onChanged, expression);
public static T BringIntoViewOnFocusChange<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value, bindingMode, converter, bindingSource);
public static T BringIntoViewOnFocusChange<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, func, onChanged, expression);
public static T Offset<T>(this T control, Avalonia.Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static T Offset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static T HorizontalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, func, onChanged, expression);
public static T HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static T HorizontalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, func, onChanged, expression);
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, func, onChanged, expression);
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalScrollBarVisibility<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static T VerticalScrollBarVisibility<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalScrollBarVisibility<T>(this T control, Func<Avalonia.Controls.Primitives.ScrollBarVisibility> func, Action<Avalonia.Controls.Primitives.ScrollBarVisibility>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, func, onChanged, expression);
public static T VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static T VerticalScrollBarVisibility<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AllowAutoHide<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);
public static T AllowAutoHide<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AllowAutoHide<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, func, onChanged, expression);
public static T AllowAutoHide<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static T AllowAutoHide<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, func, onChanged, expression);
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static T IsScrollInertiaEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollInertiaEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, func, onChanged, expression);
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollInertiaEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDeferredScrollingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);
public static T IsDeferredScrollingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDeferredScrollingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, func, onChanged, expression);
public static T IsDeferredScrollingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = value, bindingMode, converter, bindingSource);
public static T IsDeferredScrollingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => control.IsDeferredScrollingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

