#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ToolTip_MarkupExtensions
{
//================= Properties ======================//

//================= Attached Properties ======================//
 // TipProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Tip<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.TipProperty, ps, () => Avalonia.Controls.ToolTip.SetTip(control, value), bindingMode, converter, bindingSource);


 // IsOpenProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.IsOpenProperty, ps, () => Avalonia.Controls.ToolTip.SetIsOpen(control, value), bindingMode, converter, bindingSource);


 // PlacementProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.PlacementProperty, ps, () => Avalonia.Controls.ToolTip.SetPlacement(control, value), bindingMode, converter, bindingSource);


 // HorizontalOffsetProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T HorizontalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.HorizontalOffsetProperty, ps, () => Avalonia.Controls.ToolTip.SetHorizontalOffset(control, value), bindingMode, converter, bindingSource);


 // VerticalOffsetProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T VerticalOffset<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.VerticalOffsetProperty, ps, () => Avalonia.Controls.ToolTip.SetVerticalOffset(control, value), bindingMode, converter, bindingSource);


 // ShowDelayProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T ShowDelay<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ShowDelayProperty, ps, () => Avalonia.Controls.ToolTip.SetShowDelay(control, value), bindingMode, converter, bindingSource);


 // BetweenShowDelayProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T BetweenShowDelay<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.BetweenShowDelayProperty, ps, () => Avalonia.Controls.ToolTip.SetBetweenShowDelay(control, value), bindingMode, converter, bindingSource);


 // ShowOnDisabledProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T ShowOnDisabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ShowOnDisabledProperty, ps, () => Avalonia.Controls.ToolTip.SetShowOnDisabled(control, value), bindingMode, converter, bindingSource);


 // ServiceEnabledProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T ServiceEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ToolTip.ServiceEnabledProperty, ps, () => Avalonia.Controls.ToolTip.SetServiceEnabled(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//

//================= Styles ======================//

}
