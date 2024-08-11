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
public static Style<T> HorizontalOffset<T>(this Style<T> style, Double value) where T : ContextMenu
=> style._addSetter(ContextMenu.HorizontalOffsetProperty, value);
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.HorizontalOffsetProperty, binding);
public static Style<T> VerticalOffset<T>(this Style<T> style, Double value) where T : ContextMenu
=> style._addSetter(ContextMenu.VerticalOffsetProperty, value);
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.VerticalOffsetProperty, binding);
public static Style<T> PlacementAnchor<T>(this Style<T> style, PopupAnchor value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementAnchorProperty, value);
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementAnchorProperty, binding);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, PopupPositionerConstraintAdjustment value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementConstraintAdjustmentProperty, value);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static Style<T> PlacementGravity<T>(this Style<T> style, PopupGravity value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementGravityProperty, value);
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementGravityProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, PlacementMode value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementProperty, binding);
public static Style<T> PlacementRect<T>(this Style<T> style, Nullable<Rect> value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementRectProperty, value);
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementRectProperty, binding);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, Boolean value) where T : ContextMenu
=> style._addSetter(ContextMenu.WindowManagerAddShadowHintProperty, value);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static Style<T> PlacementTarget<T>(this Style<T> style, Control value) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementTargetProperty, value);
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : ContextMenu
=> style._addSetter(ContextMenu.PlacementTargetProperty, binding);
}

