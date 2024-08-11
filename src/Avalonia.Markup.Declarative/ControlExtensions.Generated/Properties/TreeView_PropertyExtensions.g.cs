#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewExtensions
{
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : TreeView
   => control._set(TreeView.AutoScrollToSelectedItemProperty, binding);
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TreeView
   => control._set(TreeView.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AutoScrollToSelectedItem<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TreeView
   => control._set(TreeView.AutoScrollToSelectedItemProperty, func, onChanged, expression);
public static T AutoScrollToSelectedItem<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static T AutoScrollToSelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : TreeView
   => control._set(TreeView.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TreeView
   => control._set(TreeView.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItem<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TreeView
   => control._set(TreeView.SelectedItemProperty, func, onChanged, expression);
public static T SelectedItem<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItems<T>(this T control, IBinding binding) where T : TreeView
   => control._set(TreeView.SelectedItemsProperty, binding);
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TreeView
   => control._set(TreeView.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItems<T>(this T control, Func<IList> func, Action<IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TreeView
   => control._set(TreeView.SelectedItemsProperty, func, onChanged, expression);
public static T SelectedItems<T>(this T control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static T SelectedItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionMode<T>(this T control, IBinding binding) where T : TreeView
   => control._set(TreeView.SelectionModeProperty, binding);
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : TreeView
   => control._set(TreeView.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionMode<T>(this T control, Func<SelectionMode> func, Action<SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : TreeView
   => control._set(TreeView.SelectionModeProperty, func, onChanged, expression);
public static T SelectionMode<T>(this T control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TreeView
=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

