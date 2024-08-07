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
public static DockPanel LastChildFill(this DockPanel control, IBinding binding)
   => control._set(DockPanel.LastChildFillProperty, binding);
public static DockPanel LastChildFill(this DockPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(DockPanel.LastChildFillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static DockPanel LastChildFill(this DockPanel control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DockPanel.LastChildFillProperty, func, onChanged, expression);
public static DockPanel LastChildFill(this DockPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = value, bindingMode, converter, bindingSource);
public static DockPanel LastChildFill<TValue>(this DockPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

