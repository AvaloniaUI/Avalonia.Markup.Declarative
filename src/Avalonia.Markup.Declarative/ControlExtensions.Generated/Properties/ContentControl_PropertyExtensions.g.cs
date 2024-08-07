#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContentControlExtensions
{
public static T Content<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.ContentProperty, binding);
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContentControl
   => control._set(ContentControl.ContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Content<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.ContentProperty, func, onChanged, expression);
public static T Content<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static T Content<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContentTemplate<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, binding);
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ContentTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, func, onChanged, expression);
public static T ContentTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static T ContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HorizontalContentAlignment<T>(this T control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T VerticalContentAlignment<T>(this T control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, func, onChanged, expression);
public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

