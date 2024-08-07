using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContextMenuExtensions
{
public static Style<Avalonia.Controls.ContextMenu> HorizontalOffset(this Style<Avalonia.Controls.ContextMenu> style, Double value)
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, value);
public static Style<Avalonia.Controls.ContextMenu> HorizontalOffset(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> VerticalOffset(this Style<Avalonia.Controls.ContextMenu> style, Double value)
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, value);
public static Style<Avalonia.Controls.ContextMenu> VerticalOffset(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> PlacementAnchor(this Style<Avalonia.Controls.ContextMenu> style, PopupAnchor value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, value);
public static Style<Avalonia.Controls.ContextMenu> PlacementAnchor(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> PlacementConstraintAdjustment(this Style<Avalonia.Controls.ContextMenu> style, PopupPositionerConstraintAdjustment value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, value);
public static Style<Avalonia.Controls.ContextMenu> PlacementConstraintAdjustment(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> PlacementGravity(this Style<Avalonia.Controls.ContextMenu> style, PopupGravity value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, value);
public static Style<Avalonia.Controls.ContextMenu> PlacementGravity(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> Placement(this Style<Avalonia.Controls.ContextMenu> style, PlacementMode value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, value);
public static Style<Avalonia.Controls.ContextMenu> Placement(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> PlacementRect(this Style<Avalonia.Controls.ContextMenu> style, Nullable<Rect> value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, value);
public static Style<Avalonia.Controls.ContextMenu> PlacementRect(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> WindowManagerAddShadowHint(this Style<Avalonia.Controls.ContextMenu> style, Boolean value)
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, value);
public static Style<Avalonia.Controls.ContextMenu> WindowManagerAddShadowHint(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static Style<Avalonia.Controls.ContextMenu> PlacementTarget(this Style<Avalonia.Controls.ContextMenu> style, Control value)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, value);
public static Style<Avalonia.Controls.ContextMenu> PlacementTarget(this Style<Avalonia.Controls.ContextMenu> style, IBinding binding)
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);
}

