#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxExtensions
{
public static ListBox SelectedItems(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectedItemsProperty, binding);
public static ListBox SelectedItems(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ListBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ListBox SelectedItems(this ListBox control, Func<IList> func, Action<IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectedItemsProperty, func, onChanged, expression);
public static ListBox SelectedItems(this ListBox control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static ListBox SelectedItems<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ListBox Selection(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectionProperty, binding);
public static ListBox Selection(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ListBox.SelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ListBox Selection(this ListBox control, Func<ISelectionModel> func, Action<ISelectionModel>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectionProperty, func, onChanged, expression);
public static ListBox Selection(this ListBox control, ISelectionModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = value, bindingMode, converter, bindingSource);
public static ListBox Selection<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, ISelectionModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ListBox SelectionMode(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectionModeProperty, binding);
public static ListBox SelectionMode(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ListBox.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ListBox SelectionMode(this ListBox control, Func<SelectionMode> func, Action<SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectionModeProperty, func, onChanged, expression);
public static ListBox SelectionMode(this ListBox control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static ListBox SelectionMode<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

