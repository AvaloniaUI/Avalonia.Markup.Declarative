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
public static Style<SplitView> CompactPaneLength(this Style<SplitView> style, Double value)
=> style._addSetter(SplitView.CompactPaneLengthProperty, value);
public static Style<SplitView> CompactPaneLength(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.CompactPaneLengthProperty, binding);
public static Style<SplitView> DisplayMode(this Style<SplitView> style, SplitViewDisplayMode value)
=> style._addSetter(SplitView.DisplayModeProperty, value);
public static Style<SplitView> DisplayMode(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.DisplayModeProperty, binding);
public static Style<SplitView> IsPaneOpen(this Style<SplitView> style, Boolean value)
=> style._addSetter(SplitView.IsPaneOpenProperty, value);
public static Style<SplitView> IsPaneOpen(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.IsPaneOpenProperty, binding);
public static Style<SplitView> OpenPaneLength(this Style<SplitView> style, Double value)
=> style._addSetter(SplitView.OpenPaneLengthProperty, value);
public static Style<SplitView> OpenPaneLength(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.OpenPaneLengthProperty, binding);
public static Style<SplitView> PaneBackground(this Style<SplitView> style, IBrush value)
=> style._addSetter(SplitView.PaneBackgroundProperty, value);
public static Style<SplitView> PaneBackground(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.PaneBackgroundProperty, binding);
public static Style<SplitView> PanePlacement(this Style<SplitView> style, SplitViewPanePlacement value)
=> style._addSetter(SplitView.PanePlacementProperty, value);
public static Style<SplitView> PanePlacement(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.PanePlacementProperty, binding);
public static Style<SplitView> Pane(this Style<SplitView> style, Object value)
=> style._addSetter(SplitView.PaneProperty, value);
public static Style<SplitView> Pane(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.PaneProperty, binding);
public static Style<SplitView> PaneTemplate(this Style<SplitView> style, IDataTemplate value)
=> style._addSetter(SplitView.PaneTemplateProperty, value);
public static Style<SplitView> PaneTemplate(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.PaneTemplateProperty, binding);
public static Style<SplitView> UseLightDismissOverlayMode(this Style<SplitView> style, Boolean value)
=> style._addSetter(SplitView.UseLightDismissOverlayModeProperty, value);
public static Style<SplitView> UseLightDismissOverlayMode(this Style<SplitView> style, IBinding binding)
=> style._addSetter(SplitView.UseLightDismissOverlayModeProperty, binding);
}

