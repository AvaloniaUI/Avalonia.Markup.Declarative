using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using ContextMenu = Avalonia.Controls.ContextMenu;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContextMenuExtensions
{
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, value);
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, value);
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, value);
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, value);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, value);
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementProperty, binding);
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, value);
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, value);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, value);
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ContextMenu
=> style._addSetter(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);
}

