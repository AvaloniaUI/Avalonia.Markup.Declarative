using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Popup = Avalonia.Controls.Primitives.Popup;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class PopupExtensions
{
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, value);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.WindowManagerAddShadowHintProperty, binding);
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.ChildProperty, binding);
public static Style<T> InheritsTransform<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, value);
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.InheritsTransformProperty, binding);
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, value);
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsOpenProperty, binding);
public static Style<T> PlacementAnchor<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupAnchor value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, value);
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementAnchorProperty, binding);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupPositionerConstraintAdjustment value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, value);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementConstraintAdjustmentProperty, binding);
public static Style<T> PlacementGravity<T>(this Style<T> style, Avalonia.Controls.Primitives.PopupPositioning.PopupGravity value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, value);
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementGravityProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementProperty, binding);
public static Style<T> PlacementRect<T>(this Style<T> style, System.Nullable<Avalonia.Rect> value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, value);
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementRectProperty, binding);
public static Style<T> PlacementTarget<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, value);
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.PlacementTargetProperty, binding);
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, value);
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayDismissEventPassThroughProperty, binding);
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, Avalonia.Input.IInputElement value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, value);
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.OverlayInputPassThroughElementProperty, binding);
public static Style<T> HorizontalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, value);
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.HorizontalOffsetProperty, binding);
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, value);
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.IsLightDismissEnabledProperty, binding);
public static Style<T> VerticalOffset<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, value);
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.VerticalOffsetProperty, binding);
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, value);
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Popup
=> style._addSetter(Avalonia.Controls.Primitives.Popup.TopmostProperty, binding);
}

