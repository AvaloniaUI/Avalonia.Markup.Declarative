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
public static partial class Visual_MarkupExtensions
{
//================= Properties ======================//
 // ClipToBounds

/*BindFromExpressionSetterGenerator*/
public static T ClipToBounds<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ClipToBounds<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ClipToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipToBoundsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ClipToBounds<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Clip

/*BindFromExpressionSetterGenerator*/
public static T Clip<T>(this T control, Func<Avalonia.Media.Geometry> func, Action<Avalonia.Media.Geometry>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Clip<T>(this T control,Avalonia.Media.Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ClipProperty, ps, () => control.Clip = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Clip<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Clip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ClipProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Clip<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ClipProperty, ps, () => control.Clip = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsVisible

/*BindFromExpressionSetterGenerator*/
public static T IsVisible<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsVisible<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsVisible<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.IsVisibleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsVisible<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Opacity

/*BindFromExpressionSetterGenerator*/
public static T Opacity<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Opacity<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Opacity<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Opacity<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OpacityMask

/*BindFromExpressionSetterGenerator*/
public static T OpacityMask<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T OpacityMask<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OpacityMask<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OpacityMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.OpacityMaskProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T OpacityMask<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Effect

/*BindFromExpressionSetterGenerator*/
public static T Effect<T>(this T control, Func<Avalonia.Media.IEffect> func, Action<Avalonia.Media.IEffect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Effect<T>(this T control,Avalonia.Media.IEffect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.EffectProperty, ps, () => control.Effect = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Effect<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Effect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.EffectProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Effect<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IEffect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.EffectProperty, ps, () => control.Effect = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RenderTransform

/*BindFromExpressionSetterGenerator*/
public static T RenderTransform<T>(this T control, Func<Avalonia.Media.ITransform> func, Action<Avalonia.Media.ITransform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RenderTransform<T>(this T control,Avalonia.Media.ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.RenderTransformProperty, ps, () => control.RenderTransform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RenderTransform<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RenderTransform<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.RenderTransformProperty, ps, () => control.RenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // RenderTransformOrigin

/*BindFromExpressionSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, Func<Avalonia.RelativePoint> func, Action<Avalonia.RelativePoint>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control,Avalonia.RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T RenderTransformOrigin<T>(this T control, System.Double x = default, System.Double y = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Avalonia.Point point = default, Avalonia.RelativeUnit unit = default) where T : Avalonia.Visual 
   => control._set(() => control.RenderTransformOrigin = new Avalonia.RelativePoint(point, unit));

/*BindSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RenderTransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.RenderTransformOriginProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T RenderTransformOrigin<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FlowDirection

/*BindFromExpressionSetterGenerator*/
public static T FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FlowDirection<T>(this T control,Avalonia.Media.FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => control.FlowDirection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FlowDirection<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FlowDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FlowDirection<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.FlowDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => control.FlowDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ZIndex

/*BindFromExpressionSetterGenerator*/
public static T ZIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ZIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ZIndexProperty, ps, () => control.ZIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ZIndex<T>(this T control, IBinding binding) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ZIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.ZIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ZIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual 
=> control._setEx(Avalonia.Visual.ZIndexProperty, ps, () => control.ZIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//
 // FlowDirection

/*AttachedPropertyMagicalSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, Avalonia.Media.FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Visual
 => control._setEx(Avalonia.Visual.FlowDirectionProperty, ps, () => Avalonia.Visual.SetFlowDirection(control, value), bindingMode, converter, bindingSource);

/*AttachedPropertyBindFromExpressionSetterGenerator*/
public static T Visual_FlowDirection<T>(this T control, Func<Avalonia.Media.FlowDirection> func, Action<Avalonia.Media.FlowDirection>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Visual 
   => control._set(Avalonia.Visual.FlowDirectionProperty, func, onChanged, expression);



//================= Events ======================//
 // AttachedToVisualTree

/*ActionToEventGenerator*/
public static T OnAttachedToVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToVisualTree += h);


 // DetachedFromVisualTree

/*ActionToEventGenerator*/
public static T OnDetachedFromVisualTree<T>(this T control, Action<Avalonia.VisualTreeAttachmentEventArgs> action) where T : Avalonia.Visual  => 
 control._setEvent((System.EventHandler<Avalonia.VisualTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromVisualTree += h);



//================= Styles ======================//
 // ClipToBounds

/*ValueStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ClipToBounds<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipToBoundsProperty, binding);


 // Clip

/*ValueStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, Avalonia.Media.Geometry value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Clip<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ClipProperty, binding);


 // IsVisible

/*ValueStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsVisible<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.IsVisibleProperty, binding);


 // Opacity

/*ValueStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, System.Double value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Opacity<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityProperty, binding);


 // OpacityMask

/*ValueStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> OpacityMask<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.OpacityMaskProperty, binding);


 // Effect

/*ValueStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, Avalonia.Media.IEffect value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Effect<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.EffectProperty, binding);


 // RenderTransform

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, Avalonia.Media.ITransform value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransform<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformProperty, binding);


 // RenderTransformOrigin

/*ValueStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.RelativePoint value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> RenderTransformOrigin<T>(this Style<T> style, System.Double x, System.Double y, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(x, y, unit));public static Style<T> RenderTransformOrigin<T>(this Style<T> style, Avalonia.Point point, Avalonia.RelativeUnit unit) where T : Avalonia.Visual 
   => style._addSetter(Avalonia.Visual.RenderTransformOriginProperty, new Avalonia.RelativePoint(point, unit));


 // FlowDirection

/*ValueStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, Avalonia.Media.FlowDirection value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FlowDirection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.FlowDirectionProperty, binding);


 // ZIndex

/*ValueStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ZIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Visual 
=> style._addSetter(Avalonia.Visual.ZIndexProperty, binding);



}
