#nullable enable
using Avalonia;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ScrollContentPresenterExtensions
{
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanHorizontallyScroll<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, func, onChanged, expression);
public static T CanHorizontallyScroll<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static T CanHorizontallyScroll<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CanVerticallyScroll<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, func, onChanged, expression);
public static T CanVerticallyScroll<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static T CanVerticallyScroll<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Offset<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.OffsetProperty, binding);
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Offset<T>(this T control, Func<Vector> func, Action<Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.OffsetProperty, func, onChanged, expression);
public static T Offset<T>(this T control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static T Offset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsType<T>(this T control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, func, onChanged, expression);
public static T HorizontalSnapPointsType<T>(this T control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsType<T>(this T control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, func, onChanged, expression);
public static T VerticalSnapPointsType<T>(this T control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsType<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T HorizontalSnapPointsAlignment<T>(this T control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalSnapPointsAlignment<T>(this T control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);
public static T VerticalSnapPointsAlignment<T>(this T control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalSnapPointsAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsScrollChainingEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ScrollContentPresenter
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, func, onChanged, expression);
public static T IsScrollChainingEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static T IsScrollChainingEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ScrollContentPresenter
=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

