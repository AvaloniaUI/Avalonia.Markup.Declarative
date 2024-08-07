#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ListBoxItemExtensions
{
public static ListBoxItem IsSelected(this ListBoxItem control, IBinding binding)
   => control._set(ListBoxItem.IsSelectedProperty, binding);
public static ListBoxItem IsSelected(this ListBoxItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ListBoxItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ListBoxItem IsSelected(this ListBoxItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBoxItem.IsSelectedProperty, func, onChanged, expression);
public static ListBoxItem IsSelected(this ListBoxItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static ListBoxItem IsSelected<TValue>(this ListBoxItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

