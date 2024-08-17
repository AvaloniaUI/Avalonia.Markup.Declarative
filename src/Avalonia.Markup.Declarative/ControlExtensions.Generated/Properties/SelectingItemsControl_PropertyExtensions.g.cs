#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Data;
using Avalonia.Data.Converters;
using SelectingItemsControl = Avalonia.Controls.Primitives.SelectingItemsControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControlExtensions
{
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, func, onChanged, expression);
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static T AutoScrollToSelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, binding);
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, func, onChanged, expression);
public static T SelectedIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = value, bindingMode, converter, bindingSource);
public static T SelectedIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, func, onChanged, expression);
public static T SelectedItem<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);
public static T SelectedValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedValue<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, func, onChanged, expression);
public static T SelectedValue<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = value, bindingMode, converter, bindingSource);
public static T SelectedValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, binding);
public static T SelectedValueBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedValueBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, func, onChanged, expression);
public static T SelectedValueBinding<T>(this T control, Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = value, bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);
public static T IsTextSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTextSearchEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, func, onChanged, expression);
public static T IsTextSearchEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = value, bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WrapSelection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);
public static T WrapSelection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T WrapSelection<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, func, onChanged, expression);
public static T WrapSelection<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = value, bindingMode, converter, bindingSource);
public static T WrapSelection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

