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
public static Style<T> CompactPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, value);
public static Style<T> CompactPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.CompactPaneLengthProperty, binding);
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.SplitViewDisplayMode value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, value);
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.DisplayModeProperty, binding);
public static Style<T> IsPaneOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, value);
public static Style<T> IsPaneOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.IsPaneOpenProperty, binding);
public static Style<T> OpenPaneLength<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, value);
public static Style<T> OpenPaneLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.OpenPaneLengthProperty, binding);
public static Style<T> PaneBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, value);
public static Style<T> PaneBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneBackgroundProperty, binding);
public static Style<T> PanePlacement<T>(this Style<T> style, Avalonia.Controls.SplitViewPanePlacement value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, value);
public static Style<T> PanePlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PanePlacementProperty, binding);
public static Style<T> Pane<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, value);
public static Style<T> Pane<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneProperty, binding);
public static Style<T> PaneTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, value);
public static Style<T> PaneTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.PaneTemplateProperty, binding);
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, value);
public static Style<T> UseLightDismissOverlayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.SplitView
=> style._addSetter(Avalonia.Controls.SplitView.UseLightDismissOverlayModeProperty, binding);
}

