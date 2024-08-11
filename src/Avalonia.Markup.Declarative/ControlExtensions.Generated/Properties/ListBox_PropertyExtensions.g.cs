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
public static T SelectedItems<T>(this T control, IBinding binding) where T : ListBox
   => control._set(ListBox.SelectedItemsProperty, binding);
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ListBox
   => control._set(ListBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItems<T>(this T control, Func<IList> func, Action<IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ListBox
   => control._set(ListBox.SelectedItemsProperty, func, onChanged, expression);
public static T SelectedItems<T>(this T control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static T SelectedItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Selection<T>(this T control, IBinding binding) where T : ListBox
   => control._set(ListBox.SelectionProperty, binding);
public static T Selection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ListBox
   => control._set(ListBox.SelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Selection<T>(this T control, Func<ISelectionModel> func, Action<ISelectionModel>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ListBox
   => control._set(ListBox.SelectionProperty, func, onChanged, expression);
public static T Selection<T>(this T control, ISelectionModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = value, bindingMode, converter, bindingSource);
public static T Selection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ISelectionModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionMode<T>(this T control, IBinding binding) where T : ListBox
   => control._set(ListBox.SelectionModeProperty, binding);
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ListBox
   => control._set(ListBox.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionMode<T>(this T control, Func<SelectionMode> func, Action<SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ListBox
   => control._set(ListBox.SelectionModeProperty, func, onChanged, expression);
public static T SelectionMode<T>(this T control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ListBox
=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

