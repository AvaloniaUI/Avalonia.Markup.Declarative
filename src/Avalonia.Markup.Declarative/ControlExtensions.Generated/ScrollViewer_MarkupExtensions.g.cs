#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
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



//================= Events ======================//
 // ScrollChanged

/*ActionToEventGenerator*/
    public static T OnScrollChanged<T>(this T control, Action<Avalonia.Controls.ScrollChangedEventArgs> action) where T : Avalonia.Controls.ScrollViewer => 
        control._setEvent((System.EventHandler<Avalonia.Controls.ScrollChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ScrollChanged += h);



//================= Styles ======================//
 // BringIntoViewOnFocusChangeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> BringIntoViewOnFocusChange<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);


 // OffsetProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.OffsetProperty, binding);


 // HorizontalScrollBarVisibilityProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);


 // HorizontalSnapPointsTypeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsTypeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignmentProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);


 // VerticalScrollBarVisibilityProperty

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, Avalonia.Controls.Primitives.ScrollBarVisibility value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalScrollBarVisibility<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.VerticalScrollBarVisibilityProperty, binding);


 // AllowAutoHideProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowAutoHide<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.AllowAutoHideProperty, binding);


 // IsScrollChainingEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollChainingEnabledProperty, binding);


 // IsScrollInertiaEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollInertiaEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsScrollInertiaEnabledProperty, binding);


 // IsDeferredScrollingEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDeferredScrollingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ScrollViewer
=> style._addSetter(Avalonia.Controls.ScrollViewer.IsDeferredScrollingEnabledProperty, binding);



}
