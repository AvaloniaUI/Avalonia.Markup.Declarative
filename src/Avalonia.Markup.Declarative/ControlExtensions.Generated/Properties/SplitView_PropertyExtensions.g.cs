#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SplitViewExtensions
{
public static SplitView CompactPaneLength(this SplitView control, IBinding binding)
   => control._set(SplitView.CompactPaneLengthProperty, binding);
public static SplitView CompactPaneLength(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView CompactPaneLength(this SplitView control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.CompactPaneLengthProperty, func, onChanged, expression);
public static SplitView CompactPaneLength(this SplitView control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value, bindingMode, converter, bindingSource);
public static SplitView CompactPaneLength<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView DisplayMode(this SplitView control, IBinding binding)
   => control._set(SplitView.DisplayModeProperty, binding);
public static SplitView DisplayMode(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView DisplayMode(this SplitView control, Func<SplitViewDisplayMode> func, Action<SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.DisplayModeProperty, func, onChanged, expression);
public static SplitView DisplayMode(this SplitView control, SplitViewDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static SplitView DisplayMode<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, SplitViewDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView IsPaneOpen(this SplitView control, IBinding binding)
   => control._set(SplitView.IsPaneOpenProperty, binding);
public static SplitView IsPaneOpen(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView IsPaneOpen(this SplitView control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.IsPaneOpenProperty, func, onChanged, expression);
public static SplitView IsPaneOpen(this SplitView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value, bindingMode, converter, bindingSource);
public static SplitView IsPaneOpen<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView OpenPaneLength(this SplitView control, IBinding binding)
   => control._set(SplitView.OpenPaneLengthProperty, binding);
public static SplitView OpenPaneLength(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView OpenPaneLength(this SplitView control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.OpenPaneLengthProperty, func, onChanged, expression);
public static SplitView OpenPaneLength(this SplitView control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value, bindingMode, converter, bindingSource);
public static SplitView OpenPaneLength<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PaneBackground(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneBackgroundProperty, binding);
public static SplitView PaneBackground(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView PaneBackground(this SplitView control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneBackgroundProperty, func, onChanged, expression);
public static SplitView PaneBackground(this SplitView control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value, bindingMode, converter, bindingSource);
public static SplitView PaneBackground<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PanePlacement(this SplitView control, IBinding binding)
   => control._set(SplitView.PanePlacementProperty, binding);
public static SplitView PanePlacement(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView PanePlacement(this SplitView control, Func<SplitViewPanePlacement> func, Action<SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PanePlacementProperty, func, onChanged, expression);
public static SplitView PanePlacement(this SplitView control, SplitViewPanePlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value, bindingMode, converter, bindingSource);
public static SplitView PanePlacement<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, SplitViewPanePlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView Pane(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneProperty, binding);
public static SplitView Pane(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.PaneProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView Pane(this SplitView control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneProperty, func, onChanged, expression);
public static SplitView Pane(this SplitView control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = value, bindingMode, converter, bindingSource);
public static SplitView Pane<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PaneTemplate(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneTemplateProperty, binding);
public static SplitView PaneTemplate(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView PaneTemplate(this SplitView control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneTemplateProperty, func, onChanged, expression);
public static SplitView PaneTemplate(this SplitView control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value, bindingMode, converter, bindingSource);
public static SplitView PaneTemplate<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView UseLightDismissOverlayMode(this SplitView control, IBinding binding)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, binding);
public static SplitView UseLightDismissOverlayMode(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static SplitView UseLightDismissOverlayMode(this SplitView control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, func, onChanged, expression);
public static SplitView UseLightDismissOverlayMode(this SplitView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value, bindingMode, converter, bindingSource);
public static SplitView UseLightDismissOverlayMode<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

