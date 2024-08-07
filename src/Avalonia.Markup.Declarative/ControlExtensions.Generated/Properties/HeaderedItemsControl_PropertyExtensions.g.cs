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
public static partial class HeaderedItemsControlExtensions
{
public static HeaderedItemsControl Header(this HeaderedItemsControl control, IBinding binding)
   => control._set(HeaderedItemsControl.HeaderProperty, binding);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HeaderedItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedItemsControl.HeaderProperty, func, onChanged, expression);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static HeaderedItemsControl Header<TValue>(this HeaderedItemsControl control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, IBinding binding)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, binding);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, func, onChanged, expression);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static HeaderedItemsControl HeaderTemplate<TValue>(this HeaderedItemsControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

