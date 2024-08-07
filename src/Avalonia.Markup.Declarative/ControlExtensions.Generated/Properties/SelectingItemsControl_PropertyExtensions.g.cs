#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControlExtensions
{
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AutoScrollToSelectedItem<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, func, onChanged, expression);
public static T AutoScrollToSelectedItem<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static T AutoScrollToSelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedIndex<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, binding);
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, func, onChanged, expression);
public static T SelectedIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = value, bindingMode, converter, bindingSource);
public static T SelectedIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItem<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, func, onChanged, expression);
public static T SelectedItem<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValue<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, binding);
public static T SelectedValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedValue<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, func, onChanged, expression);
public static T SelectedValue<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = value, bindingMode, converter, bindingSource);
public static T SelectedValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, binding);
public static T SelectedValueBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedValueBinding<T>(this T control, Func<IBinding> func, Action<IBinding>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, func, onChanged, expression);
public static T SelectedValueBinding<T>(this T control, IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = value, bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, binding);
public static T IsTextSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTextSearchEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, func, onChanged, expression);
public static T IsTextSearchEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = value, bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WrapSelection<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, binding);
public static T WrapSelection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WrapSelection<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, func, onChanged, expression);
public static T WrapSelection<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = value, bindingMode, converter, bindingSource);
public static T WrapSelection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

