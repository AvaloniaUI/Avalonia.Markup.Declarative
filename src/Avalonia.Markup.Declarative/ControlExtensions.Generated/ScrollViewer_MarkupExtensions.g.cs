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
public static partial class ScrollViewer_MarkupExtensions
{
//================= Properties ======================//
 // OffsetProperty

/*BindFromExpressionSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Offset<T>(this T control, Avalonia.Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ScrollViewer
   => control._set(Avalonia.Controls.ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Offset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ScrollViewer
=> control._setEx(Avalonia.Controls.ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // BringIntoViewOnFocusChangeProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T BringIntoViewOnFocusChange<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetBringIntoViewOnFocusChange(control, value), bindingMode, converter, bindingSource);


 // HorizontalScrollBarVisibilityProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T HorizontalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalScrollBarVisibility(control, value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsTypeProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsType(control, value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsTypeProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsType(control, value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsAlignmentProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => Avalonia.Controls.ScrollViewer.SetHorizontalSnapPointsAlignment(control, value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsAlignmentProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalSnapPointsAlignment(control, value), bindingMode, converter, bindingSource);


 // VerticalScrollBarVisibilityProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T VerticalScrollBarVisibility<T>(this T control, Avalonia.Controls.Primitives.ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => Avalonia.Controls.ScrollViewer.SetVerticalScrollBarVisibility(control, value), bindingMode, converter, bindingSource);


 // AllowAutoHideProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T AllowAutoHide<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, ps, () => Avalonia.Controls.ScrollViewer.SetAllowAutoHide(control, value), bindingMode, converter, bindingSource);


 // IsScrollChainingEnabledProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsScrollChainingEnabled(control, value), bindingMode, converter, bindingSource);


 // IsScrollInertiaEnabledProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T IsScrollInertiaEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsScrollInertiaEnabled(control, value), bindingMode, converter, bindingSource);


 // IsDeferredScrollingEnabledProperty

/*AttachedPropertyMagicalSetterGenerator*/
public static T IsDeferredScrollingEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Control
 => control._setEx(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, ps, () => Avalonia.Controls.ScrollViewer.SetIsDeferredScrollingEnabled(control, value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
    public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action) where T : Avalonia.Controls.ScrollViewer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ScrollChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ScrollChanged += h);



//================= Styles ======================//
 // BringIntoViewOnFocusChangeProperty


 // OffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibilityProperty


 // HorizontalSnapPointsTypeProperty


 // VerticalSnapPointsTypeProperty


 // HorizontalSnapPointsAlignmentProperty


 // VerticalSnapPointsAlignmentProperty


 // VerticalScrollBarVisibilityProperty


 // AllowAutoHideProperty


 // IsScrollChainingEnabledProperty


 // IsScrollInertiaEnabledProperty


 // IsDeferredScrollingEnabledProperty



}
