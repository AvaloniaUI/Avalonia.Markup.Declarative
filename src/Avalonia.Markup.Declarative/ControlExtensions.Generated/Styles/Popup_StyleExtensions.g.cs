using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupExtensions
{
public static Style<Popup> WindowManagerAddShadowHint(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.WindowManagerAddShadowHintProperty, value);
public static Style<Popup> WindowManagerAddShadowHint(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.WindowManagerAddShadowHintProperty, binding);
public static Style<Popup> Child(this Style<Popup> style, Control value)
=> style._addSetter(Popup.ChildProperty, value);
public static Style<Popup> Child(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.ChildProperty, binding);
public static Style<Popup> InheritsTransform(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.InheritsTransformProperty, value);
public static Style<Popup> InheritsTransform(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.InheritsTransformProperty, binding);
public static Style<Popup> IsOpen(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.IsOpenProperty, value);
public static Style<Popup> IsOpen(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.IsOpenProperty, binding);
public static Style<Popup> PlacementAnchor(this Style<Popup> style, PopupAnchor value)
=> style._addSetter(Popup.PlacementAnchorProperty, value);
public static Style<Popup> PlacementAnchor(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementAnchorProperty, binding);
public static Style<Popup> PlacementConstraintAdjustment(this Style<Popup> style, PopupPositionerConstraintAdjustment value)
=> style._addSetter(Popup.PlacementConstraintAdjustmentProperty, value);
public static Style<Popup> PlacementConstraintAdjustment(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementConstraintAdjustmentProperty, binding);
public static Style<Popup> PlacementGravity(this Style<Popup> style, PopupGravity value)
=> style._addSetter(Popup.PlacementGravityProperty, value);
public static Style<Popup> PlacementGravity(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementGravityProperty, binding);
public static Style<Popup> Placement(this Style<Popup> style, PlacementMode value)
=> style._addSetter(Popup.PlacementProperty, value);
public static Style<Popup> Placement(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementProperty, binding);
public static Style<Popup> PlacementRect(this Style<Popup> style, Nullable<Rect> value)
=> style._addSetter(Popup.PlacementRectProperty, value);
public static Style<Popup> PlacementRect(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementRectProperty, binding);
public static Style<Popup> PlacementTarget(this Style<Popup> style, Control value)
=> style._addSetter(Popup.PlacementTargetProperty, value);
public static Style<Popup> PlacementTarget(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.PlacementTargetProperty, binding);
public static Style<Popup> OverlayDismissEventPassThrough(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.OverlayDismissEventPassThroughProperty, value);
public static Style<Popup> OverlayDismissEventPassThrough(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.OverlayDismissEventPassThroughProperty, binding);
public static Style<Popup> OverlayInputPassThroughElement(this Style<Popup> style, IInputElement value)
=> style._addSetter(Popup.OverlayInputPassThroughElementProperty, value);
public static Style<Popup> OverlayInputPassThroughElement(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.OverlayInputPassThroughElementProperty, binding);
public static Style<Popup> HorizontalOffset(this Style<Popup> style, Double value)
=> style._addSetter(Popup.HorizontalOffsetProperty, value);
public static Style<Popup> HorizontalOffset(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.HorizontalOffsetProperty, binding);
public static Style<Popup> IsLightDismissEnabled(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.IsLightDismissEnabledProperty, value);
public static Style<Popup> IsLightDismissEnabled(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.IsLightDismissEnabledProperty, binding);
public static Style<Popup> VerticalOffset(this Style<Popup> style, Double value)
=> style._addSetter(Popup.VerticalOffsetProperty, value);
public static Style<Popup> VerticalOffset(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.VerticalOffsetProperty, binding);
public static Style<Popup> Topmost(this Style<Popup> style, Boolean value)
=> style._addSetter(Popup.TopmostProperty, value);
public static Style<Popup> Topmost(this Style<Popup> style, IBinding binding)
=> style._addSetter(Popup.TopmostProperty, binding);
}

