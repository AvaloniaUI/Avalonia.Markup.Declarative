#nullable enable
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using DockPanel = Avalonia.Controls.DockPanel;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class DockPanelExtensions
{
public static T LastChildFill<T>(this T control, IBinding binding) where T : Avalonia.Controls.DockPanel
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty, binding);
public static T LastChildFill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.DockPanel
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T LastChildFill<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.DockPanel
   => control._set(Avalonia.Controls.DockPanel.LastChildFillProperty, func, onChanged, expression);
public static T LastChildFill<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DockPanel
=> control._setEx(Avalonia.Controls.DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = value, bindingMode, converter, bindingSource);
public static T LastChildFill<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.DockPanel
=> control._setEx(Avalonia.Controls.DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

