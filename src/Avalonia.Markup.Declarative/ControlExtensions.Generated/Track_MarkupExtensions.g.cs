#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class Track_MarkupExtensions
{
//================= Properties ======================//
 // Minimum

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Minimum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Maximum

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Maximum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Value

/*BindFromExpressionSetterGenerator*/
public static T Value<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Value<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Value<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Value<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Value<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ViewportSize

/*BindFromExpressionSetterGenerator*/
public static T ViewportSize<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ViewportSize<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ViewportSize<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ViewportSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ViewportSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Orientation

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Thumb

/*BindFromExpressionSetterGenerator*/
public static T Thumb<T>(this T control, Func<Avalonia.Controls.Primitives.Thumb> func, Action<Avalonia.Controls.Primitives.Thumb>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Thumb<T>(this T control,Avalonia.Controls.Primitives.Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ThumbProperty, ps, () => control.Thumb = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Thumb<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Thumb<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.ThumbProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Thumb<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Primitives.Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.ThumbProperty, ps, () => control.Thumb = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IncreaseButton

/*BindFromExpressionSetterGenerator*/
public static T IncreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IncreaseButton<T>(this T control,Avalonia.Controls.Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IncreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IncreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IncreaseButton<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DecreaseButton

/*BindFromExpressionSetterGenerator*/
public static T DecreaseButton<T>(this T control, Func<Avalonia.Controls.Button> func, Action<Avalonia.Controls.Button>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DecreaseButton<T>(this T control,Avalonia.Controls.Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DecreaseButton<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DecreaseButton<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DecreaseButton<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDirectionReversed

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDirectionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IgnoreThumbDrag

/*BindFromExpressionSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IgnoreThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IgnoreThumbDrag<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DeferThumbDrag

/*BindFromExpressionSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DeferThumbDrag<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DeferThumbDrag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.Track 
   => control._set(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DeferThumbDrag<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.Track 
=> control._setEx(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, ps, () => control.DeferThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.MaximumProperty, binding);


 // Value

/*ValueStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Value<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ValueProperty, binding);


 // ViewportSize

/*ValueStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ViewportSize<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ViewportSizeProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.OrientationProperty, binding);


 // Thumb

/*ValueStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, Avalonia.Controls.Primitives.Thumb value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Thumb<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.ThumbProperty, binding);


 // IncreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IncreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IncreaseButtonProperty, binding);


 // DecreaseButton

/*ValueStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, Avalonia.Controls.Button value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DecreaseButton<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DecreaseButtonProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IsDirectionReversedProperty, binding);


 // IgnoreThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IgnoreThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.IgnoreThumbDragProperty, binding);


 // DeferThumbDrag

/*ValueStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DeferThumbDrag<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.Track 
=> style._addSetter(Avalonia.Controls.Primitives.Track.DeferThumbDragProperty, binding);



}
