#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class TabItemExtensions
{
public static TabItem IsSelected(this TabItem control, IBinding binding)
   => control._set(TabItem.IsSelectedProperty, binding);
public static TabItem IsSelected(this TabItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TabItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TabItem IsSelected(this TabItem control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabItem.IsSelectedProperty, func, onChanged, expression);
public static TabItem IsSelected(this TabItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static TabItem IsSelected<TValue>(this TabItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

