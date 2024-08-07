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
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, func, onChanged, expression);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanHorizontallyScroll<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, func, onChanged, expression);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanVerticallyScroll<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.OffsetProperty, binding);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Func<Vector> func, Action<Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.OffsetProperty, func, onChanged, expression);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter Offset<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, func, onChanged, expression);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsType<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, Func<SnapPointsType> func, Action<SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, func, onChanged, expression);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsType<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsAlignment<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, Func<SnapPointsAlignment> func, Action<SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsAlignment<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, func, onChanged, expression);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter IsScrollChainingEnabled<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

