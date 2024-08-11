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
public static T CompactPaneLength<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.CompactPaneLengthProperty, binding);
public static T CompactPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CompactPaneLength<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.CompactPaneLengthProperty, func, onChanged, expression);
public static T CompactPaneLength<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value, bindingMode, converter, bindingSource);
public static T CompactPaneLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMode<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.DisplayModeProperty, binding);
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMode<T>(this T control, Func<SplitViewDisplayMode> func, Action<SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.DisplayModeProperty, func, onChanged, expression);
public static T DisplayMode<T>(this T control, SplitViewDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static T DisplayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SplitViewDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsPaneOpen<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.IsPaneOpenProperty, binding);
public static T IsPaneOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsPaneOpen<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.IsPaneOpenProperty, func, onChanged, expression);
public static T IsPaneOpen<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value, bindingMode, converter, bindingSource);
public static T IsPaneOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OpenPaneLength<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.OpenPaneLengthProperty, binding);
public static T OpenPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OpenPaneLength<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.OpenPaneLengthProperty, func, onChanged, expression);
public static T OpenPaneLength<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value, bindingMode, converter, bindingSource);
public static T OpenPaneLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PaneBackground<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.PaneBackgroundProperty, binding);
public static T PaneBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaneBackground<T>(this T control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.PaneBackgroundProperty, func, onChanged, expression);
public static T PaneBackground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value, bindingMode, converter, bindingSource);
public static T PaneBackground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PanePlacement<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.PanePlacementProperty, binding);
public static T PanePlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PanePlacement<T>(this T control, Func<SplitViewPanePlacement> func, Action<SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.PanePlacementProperty, func, onChanged, expression);
public static T PanePlacement<T>(this T control, SplitViewPanePlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value, bindingMode, converter, bindingSource);
public static T PanePlacement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, SplitViewPanePlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Pane<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.PaneProperty, binding);
public static T Pane<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.PaneProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Pane<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.PaneProperty, func, onChanged, expression);
public static T Pane<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = value, bindingMode, converter, bindingSource);
public static T Pane<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PaneTemplate<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.PaneTemplateProperty, binding);
public static T PaneTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaneTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.PaneTemplateProperty, func, onChanged, expression);
public static T PaneTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value, bindingMode, converter, bindingSource);
public static T PaneTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseLightDismissOverlayMode<T>(this T control, IBinding binding) where T : SplitView
   => control._set(SplitView.UseLightDismissOverlayModeProperty, binding);
public static T UseLightDismissOverlayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : SplitView
   => control._set(SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseLightDismissOverlayMode<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : SplitView
   => control._set(SplitView.UseLightDismissOverlayModeProperty, func, onChanged, expression);
public static T UseLightDismissOverlayMode<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value, bindingMode, converter, bindingSource);
public static T UseLightDismissOverlayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SplitView
=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

