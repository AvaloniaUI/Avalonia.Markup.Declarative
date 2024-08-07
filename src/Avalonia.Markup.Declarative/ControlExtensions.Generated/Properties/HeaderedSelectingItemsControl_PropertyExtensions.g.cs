#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedSelectingItemsControlExtensions
{
public static T Header<T>(this T control, IBinding binding) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, binding);
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Header<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, func, onChanged, expression);
public static T Header<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : HeaderedSelectingItemsControl
=> control._setEx(HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static T Header<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : HeaderedSelectingItemsControl
=> control._setEx(HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HeaderTemplate<T>(this T control, IBinding binding) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);
public static T HeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HeaderTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : HeaderedSelectingItemsControl
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, func, onChanged, expression);
public static T HeaderTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : HeaderedSelectingItemsControl
=> control._setEx(HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static T HeaderTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : HeaderedSelectingItemsControl
=> control._setEx(HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

