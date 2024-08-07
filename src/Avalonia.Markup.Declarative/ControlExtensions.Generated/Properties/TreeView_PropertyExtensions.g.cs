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
public static TreeView AutoScrollToSelectedItem(this TreeView control, IBinding binding)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, binding);
public static TreeView AutoScrollToSelectedItem(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeView AutoScrollToSelectedItem(this TreeView control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, func, onChanged, expression);
public static TreeView AutoScrollToSelectedItem(this TreeView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static TreeView AutoScrollToSelectedItem<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectedItem(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectedItemProperty, binding);
public static TreeView SelectedItem(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeView.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeView SelectedItem(this TreeView control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectedItemProperty, func, onChanged, expression);
public static TreeView SelectedItem(this TreeView control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static TreeView SelectedItem<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectedItems(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectedItemsProperty, binding);
public static TreeView SelectedItems(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeView.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeView SelectedItems(this TreeView control, Func<IList> func, Action<IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectedItemsProperty, func, onChanged, expression);
public static TreeView SelectedItems(this TreeView control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static TreeView SelectedItems<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectionMode(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectionModeProperty, binding);
public static TreeView SelectionMode(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeView.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeView SelectionMode(this TreeView control, Func<SelectionMode> func, Action<SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectionModeProperty, func, onChanged, expression);
public static TreeView SelectionMode(this TreeView control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static TreeView SelectionMode<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

