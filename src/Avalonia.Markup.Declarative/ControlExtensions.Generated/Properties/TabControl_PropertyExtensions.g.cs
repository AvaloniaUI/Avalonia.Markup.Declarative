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
public static partial class TabControlExtensions
{
public static TabControl TabStripPlacement(this TabControl control, IBinding binding)
   => control._set(TabControl.TabStripPlacementProperty, binding);
public static TabControl TabStripPlacement(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TabControl.TabStripPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TabControl TabStripPlacement(this TabControl control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.TabStripPlacementProperty, func, onChanged, expression);
public static TabControl TabStripPlacement(this TabControl control, Avalonia.Controls.Dock value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = value, bindingMode, converter, bindingSource);
public static TabControl TabStripPlacement<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Dock> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl HorizontalContentAlignment(this TabControl control, IBinding binding)
   => control._set(TabControl.HorizontalContentAlignmentProperty, binding);
public static TabControl HorizontalContentAlignment(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TabControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TabControl HorizontalContentAlignment(this TabControl control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static TabControl HorizontalContentAlignment(this TabControl control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static TabControl HorizontalContentAlignment<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl VerticalContentAlignment(this TabControl control, IBinding binding)
   => control._set(TabControl.VerticalContentAlignmentProperty, binding);
public static TabControl VerticalContentAlignment(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TabControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TabControl VerticalContentAlignment(this TabControl control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.VerticalContentAlignmentProperty, func, onChanged, expression);
public static TabControl VerticalContentAlignment(this TabControl control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static TabControl VerticalContentAlignment<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl ContentTemplate(this TabControl control, IBinding binding)
   => control._set(TabControl.ContentTemplateProperty, binding);
public static TabControl ContentTemplate(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(TabControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static TabControl ContentTemplate(this TabControl control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.ContentTemplateProperty, func, onChanged, expression);
public static TabControl ContentTemplate(this TabControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static TabControl ContentTemplate<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

