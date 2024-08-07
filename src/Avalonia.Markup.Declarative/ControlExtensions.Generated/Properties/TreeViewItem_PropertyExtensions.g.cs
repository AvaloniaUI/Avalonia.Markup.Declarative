#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TreeViewItemExtensions
{
public static TreeViewItem IsExpanded(this TreeViewItem control, IBinding binding)
   => control._set(TreeViewItem.IsExpandedProperty, binding);
public static TreeViewItem IsExpanded(this TreeViewItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeViewItem.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeViewItem IsExpanded(this TreeViewItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeViewItem.IsExpandedProperty, func, onChanged, expression);
public static TreeViewItem IsExpanded(this TreeViewItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static TreeViewItem IsExpanded<TValue>(this TreeViewItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeViewItem IsSelected(this TreeViewItem control, IBinding binding)
   => control._set(TreeViewItem.IsSelectedProperty, binding);
public static TreeViewItem IsSelected(this TreeViewItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TreeViewItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TreeViewItem IsSelected(this TreeViewItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeViewItem.IsSelectedProperty, func, onChanged, expression);
public static TreeViewItem IsSelected(this TreeViewItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static TreeViewItem IsSelected<TValue>(this TreeViewItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

