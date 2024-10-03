#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
<<<<<<< HEAD
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
=======
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
>>>>>>> c1347bc81bdb20ad44b1fda7d31eecec56065f2f
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ScrollContentPresenter_MarkupExtensions
{
//================= Properties ======================//
 // CanHorizontallyScroll

/*BindFromExpressionSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanHorizontallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CanHorizontallyScroll<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // CanVerticallyScroll

/*BindFromExpressionSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanVerticallyScroll<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CanVerticallyScroll<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Offset

/*BindFromExpressionSetterGenerator*/
public static T Offset<T>(this T control, Func<Avalonia.Vector> func, Action<Avalonia.Vector>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Offset<T>(this T control,Avalonia.Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Offset<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Offset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Offset<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsType

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control,Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalSnapPointsType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsType

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsType> func, Action<Avalonia.Controls.Primitives.SnapPointsType>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control,Avalonia.Controls.Primitives.SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalSnapPointsType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HorizontalSnapPointsAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control,Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HorizontalSnapPointsAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // VerticalSnapPointsAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, Func<Avalonia.Controls.Primitives.SnapPointsAlignment> func, Action<Avalonia.Controls.Primitives.SnapPointsAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control,Avalonia.Controls.Primitives.SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalSnapPointsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T VerticalSnapPointsAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsScrollChainingEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsScrollChainingEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
   => control._set(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsScrollChainingEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> control._setEx(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // CanHorizontallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CanHorizontallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanHorizontallyScrollProperty, binding);


 // CanVerticallyScroll

/*ValueStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CanVerticallyScroll<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.CanVerticallyScrollProperty, binding);


 // Offset

/*ValueStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, Avalonia.Vector value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Offset<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.OffsetProperty, binding);


 // HorizontalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);


 // VerticalSnapPointsType

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsType value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsType<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);


 // HorizontalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);


 // VerticalSnapPointsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, Avalonia.Controls.Primitives.SnapPointsAlignment value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalSnapPointsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);


 // IsScrollChainingEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsScrollChainingEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Presenters.ScrollContentPresenter 
=> style._addSetter(Avalonia.Controls.Presenters.ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);



}
