#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Media;
using SplitView = Avalonia.Controls.SplitView;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SplitViewExtensions
{
public static T CompactPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);
public static T CompactPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CompactPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.CompactPaneLengthProperty, func, onChanged, expression);
public static T CompactPaneLength<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value, bindingMode, converter, bindingSource);
public static T CompactPaneLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, binding);
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.SplitViewDisplayMode> func, Action<Avalonia.Controls.SplitViewDisplayMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.DisplayModeProperty, func, onChanged, expression);
public static T DisplayMode<T>(this T control, Avalonia.Controls.SplitViewDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static T DisplayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SplitViewDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsPaneOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);
public static T IsPaneOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsPaneOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.IsPaneOpenProperty, func, onChanged, expression);
public static T IsPaneOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value, bindingMode, converter, bindingSource);
public static T IsPaneOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OpenPaneLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);
public static T OpenPaneLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T OpenPaneLength<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.OpenPaneLengthProperty, func, onChanged, expression);
public static T OpenPaneLength<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value, bindingMode, converter, bindingSource);
public static T OpenPaneLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PaneBackground<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);
public static T PaneBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaneBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneBackgroundProperty, func, onChanged, expression);
public static T PaneBackground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value, bindingMode, converter, bindingSource);
public static T PaneBackground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PanePlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, binding);
public static T PanePlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PanePlacement<T>(this T control, Func<Avalonia.Controls.SplitViewPanePlacement> func, Action<Avalonia.Controls.SplitViewPanePlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PanePlacementProperty, func, onChanged, expression);
public static T PanePlacement<T>(this T control, Avalonia.Controls.SplitViewPanePlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value, bindingMode, converter, bindingSource);
public static T PanePlacement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SplitViewPanePlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PanePlacementProperty, ps, () => control.PanePlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Pane<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneProperty, binding);
public static T Pane<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Pane<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneProperty, func, onChanged, expression);
public static T Pane<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneProperty, ps, () => control.Pane = value, bindingMode, converter, bindingSource);
public static T Pane<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneProperty, ps, () => control.Pane = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PaneTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);
public static T PaneTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T PaneTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.PaneTemplateProperty, func, onChanged, expression);
public static T PaneTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value, bindingMode, converter, bindingSource);
public static T PaneTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseLightDismissOverlayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);
public static T UseLightDismissOverlayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T UseLightDismissOverlayMode<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.SplitView
   => control._set(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, func, onChanged, expression);
public static T UseLightDismissOverlayMode<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value, bindingMode, converter, bindingSource);
public static T UseLightDismissOverlayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.SplitView
=> control._setEx(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

