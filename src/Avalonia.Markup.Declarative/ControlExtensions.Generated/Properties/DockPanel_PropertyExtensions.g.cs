#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DockPanelExtensions
{
public static T LastChildFill<T>(this T control, IBinding binding) where T : DockPanel
   => control._set(DockPanel.LastChildFillProperty, binding);
public static T LastChildFill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : DockPanel
   => control._set(DockPanel.LastChildFillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LastChildFill<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : DockPanel
   => control._set(DockPanel.LastChildFillProperty, func, onChanged, expression);
public static T LastChildFill<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DockPanel
=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = value, bindingMode, converter, bindingSource);
public static T LastChildFill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : DockPanel
=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

