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
public static Style<T> CompactPaneLength<T>(this Style<T> style, Double value) where T : SplitView
=> style._addSetter(SplitView.CompactPaneLengthProperty, value);
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.CompactPaneLengthProperty, binding);
public static Style<T> DisplayMode<T>(this Style<T> style, SplitViewDisplayMode value) where T : SplitView
=> style._addSetter(SplitView.DisplayModeProperty, value);
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.DisplayModeProperty, binding);
public static Style<T> IsPaneOpen<T>(this Style<T> style, Boolean value) where T : SplitView
=> style._addSetter(SplitView.IsPaneOpenProperty, value);
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.IsPaneOpenProperty, binding);
public static Style<T> OpenPaneLength<T>(this Style<T> style, Double value) where T : SplitView
=> style._addSetter(SplitView.OpenPaneLengthProperty, value);
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.OpenPaneLengthProperty, binding);
public static Style<T> PaneBackground<T>(this Style<T> style, IBrush value) where T : SplitView
=> style._addSetter(SplitView.PaneBackgroundProperty, value);
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.PaneBackgroundProperty, binding);
public static Style<T> PanePlacement<T>(this Style<T> style, SplitViewPanePlacement value) where T : SplitView
=> style._addSetter(SplitView.PanePlacementProperty, value);
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.PanePlacementProperty, binding);
public static Style<T> Pane<T>(this Style<T> style, Object value) where T : SplitView
=> style._addSetter(SplitView.PaneProperty, value);
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.PaneProperty, binding);
public static Style<T> PaneTemplate<T>(this Style<T> style, IDataTemplate value) where T : SplitView
=> style._addSetter(SplitView.PaneTemplateProperty, value);
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.PaneTemplateProperty, binding);
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, Boolean value) where T : SplitView
=> style._addSetter(SplitView.UseLightDismissOverlayModeProperty, value);
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : SplitView
=> style._addSetter(SplitView.UseLightDismissOverlayModeProperty, binding);
}

