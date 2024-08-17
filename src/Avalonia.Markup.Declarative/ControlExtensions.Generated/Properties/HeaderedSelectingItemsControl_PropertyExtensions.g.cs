#nullable enable
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using HeaderedSelectingItemsControl = Avalonia.Controls.Primitives.HeaderedSelectingItemsControl;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class HeaderedSelectingItemsControlExtensions
{
public static T Header<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, binding);
public static T Header<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Header<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, func, onChanged, expression);
public static T Header<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static T Header<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HeaderTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);
public static T HeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T HeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, func, onChanged, expression);
public static T HeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static T HeaderTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.HeaderedSelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

