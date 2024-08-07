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
public static partial class HeaderedContentControlExtensions
{
public static HeaderedContentControl Header(this HeaderedContentControl control, IBinding binding)
   => control._set(HeaderedContentControl.HeaderProperty, binding);
public static HeaderedContentControl Header(this HeaderedContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HeaderedContentControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HeaderedContentControl Header(this HeaderedContentControl control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedContentControl.HeaderProperty, func, onChanged, expression);
public static HeaderedContentControl Header(this HeaderedContentControl control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static HeaderedContentControl Header<TValue>(this HeaderedContentControl control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IBinding binding)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, binding);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, func, onChanged, expression);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static HeaderedContentControl HeaderTemplate<TValue>(this HeaderedContentControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

