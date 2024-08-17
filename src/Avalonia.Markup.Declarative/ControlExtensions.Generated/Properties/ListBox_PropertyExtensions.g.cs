#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Selection;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ListBox = Avalonia.Controls.ListBox;
using System;
using System.Collections;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxExtensions
{
public static T SelectedItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty, binding);
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectedItemsProperty, func, onChanged, expression);
public static T SelectedItems<T>(this T control, System.Collections.IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static T SelectedItems<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Selection<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionProperty, binding);
public static T Selection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Selection<T>(this T control, Func<Avalonia.Controls.Selection.ISelectionModel> func, Action<Avalonia.Controls.Selection.ISelectionModel>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionProperty, func, onChanged, expression);
public static T Selection<T>(this T control, Avalonia.Controls.Selection.ISelectionModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectionProperty, ps, () => control.Selection = value, bindingMode, converter, bindingSource);
public static T Selection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Selection.ISelectionModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectionProperty, ps, () => control.Selection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty, binding);
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ListBox
   => control._set(Avalonia.Controls.ListBox.SelectionModeProperty, func, onChanged, expression);
public static T SelectionMode<T>(this T control, Avalonia.Controls.SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBox
=> control._setEx(Avalonia.Controls.ListBox.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

