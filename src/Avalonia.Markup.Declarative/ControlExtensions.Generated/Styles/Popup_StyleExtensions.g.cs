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
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.WindowManagerAddShadowHintProperty, value);
public static Style<T> WindowManagerAddShadowHint<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.WindowManagerAddShadowHintProperty, binding);
public static Style<T> Child<T>(this Style<T> style, Control value) where T : Popup
=> style._addSetter(Popup.ChildProperty, value);
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.ChildProperty, binding);
public static Style<T> InheritsTransform<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.InheritsTransformProperty, value);
public static Style<T> InheritsTransform<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.InheritsTransformProperty, binding);
public static Style<T> IsOpen<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.IsOpenProperty, value);
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.IsOpenProperty, binding);
public static Style<T> PlacementAnchor<T>(this Style<T> style, PopupAnchor value) where T : Popup
=> style._addSetter(Popup.PlacementAnchorProperty, value);
public static Style<T> PlacementAnchor<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementAnchorProperty, binding);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, PopupPositionerConstraintAdjustment value) where T : Popup
=> style._addSetter(Popup.PlacementConstraintAdjustmentProperty, value);
public static Style<T> PlacementConstraintAdjustment<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementConstraintAdjustmentProperty, binding);
public static Style<T> PlacementGravity<T>(this Style<T> style, PopupGravity value) where T : Popup
=> style._addSetter(Popup.PlacementGravityProperty, value);
public static Style<T> PlacementGravity<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementGravityProperty, binding);
public static Style<T> Placement<T>(this Style<T> style, PlacementMode value) where T : Popup
=> style._addSetter(Popup.PlacementProperty, value);
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementProperty, binding);
public static Style<T> PlacementRect<T>(this Style<T> style, Nullable<Rect> value) where T : Popup
=> style._addSetter(Popup.PlacementRectProperty, value);
public static Style<T> PlacementRect<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementRectProperty, binding);
public static Style<T> PlacementTarget<T>(this Style<T> style, Control value) where T : Popup
=> style._addSetter(Popup.PlacementTargetProperty, value);
public static Style<T> PlacementTarget<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.PlacementTargetProperty, binding);
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.OverlayDismissEventPassThroughProperty, value);
public static Style<T> OverlayDismissEventPassThrough<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.OverlayDismissEventPassThroughProperty, binding);
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IInputElement value) where T : Popup
=> style._addSetter(Popup.OverlayInputPassThroughElementProperty, value);
public static Style<T> OverlayInputPassThroughElement<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.OverlayInputPassThroughElementProperty, binding);
public static Style<T> HorizontalOffset<T>(this Style<T> style, Double value) where T : Popup
=> style._addSetter(Popup.HorizontalOffsetProperty, value);
public static Style<T> HorizontalOffset<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.HorizontalOffsetProperty, binding);
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.IsLightDismissEnabledProperty, value);
public static Style<T> IsLightDismissEnabled<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.IsLightDismissEnabledProperty, binding);
public static Style<T> VerticalOffset<T>(this Style<T> style, Double value) where T : Popup
=> style._addSetter(Popup.VerticalOffsetProperty, value);
public static Style<T> VerticalOffset<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.VerticalOffsetProperty, binding);
public static Style<T> Topmost<T>(this Style<T> style, Boolean value) where T : Popup
=> style._addSetter(Popup.TopmostProperty, value);
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Popup
=> style._addSetter(Popup.TopmostProperty, binding);
}

