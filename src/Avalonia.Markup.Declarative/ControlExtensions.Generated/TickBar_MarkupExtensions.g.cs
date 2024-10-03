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
public static partial class TickBar_MarkupExtensions
{
//================= Properties ======================//
 // Fill

/*BindFromExpressionSetterGenerator*/
public static T Fill<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Fill<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Fill<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Fill<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.FillProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Fill<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Minimum

/*BindFromExpressionSetterGenerator*/
public static T Minimum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Minimum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Minimum<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Minimum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MinimumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Minimum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Maximum

/*BindFromExpressionSetterGenerator*/
public static T Maximum<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Maximum<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Maximum<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Maximum<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.MaximumProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Maximum<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TickFrequency

/*BindFromExpressionSetterGenerator*/
public static T TickFrequency<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TickFrequency<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TickFrequency<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TickFrequency<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TickFrequencyProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TickFrequency<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Orientation

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Ticks

/*BindFromExpressionSetterGenerator*/
public static T Ticks<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Double>> func, Action<Avalonia.Collections.AvaloniaList<System.Double>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Ticks<T>(this T control,Avalonia.Collections.AvaloniaList<System.Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Ticks<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Ticks<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.TicksProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Ticks<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDirectionReversed

/*BindFromExpressionSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDirectionReversed<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDirectionReversed<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDirectionReversed<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Placement

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.TickBarPlacement> func, Action<Avalonia.Controls.TickBarPlacement>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Placement<T>(this T control,Avalonia.Controls.TickBarPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Placement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.TickBarPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ReservedSpace

/*BindFromExpressionSetterGenerator*/
public static T ReservedSpace<T>(this T control, Func<Avalonia.Rect> func, Action<Avalonia.Rect>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ReservedSpace<T>(this T control,Avalonia.Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T ReservedSpace<T>(this T control, System.Double x = default, System.Double y = default, System.Double width = default, System.Double height = default) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(x, y, width, height));
public static T ReservedSpace<T>(this T control, Avalonia.Size size = default) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(size));
public static T ReservedSpace<T>(this T control, Avalonia.Point position = default, Avalonia.Size size = default) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(position, size));
public static T ReservedSpace<T>(this T control, Avalonia.Point topLeft = default, Avalonia.Point bottomRight = default) where T : Avalonia.Controls.TickBar 
   => control._set(() => control.ReservedSpace = new Avalonia.Rect(topLeft, bottomRight));

/*BindSetterGenerator*/
public static T ReservedSpace<T>(this T control, IBinding binding) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ReservedSpace<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TickBar 
   => control._set(Avalonia.Controls.TickBar.ReservedSpaceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ReservedSpace<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TickBar 
=> control._setEx(Avalonia.Controls.TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Fill

/*ValueStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Fill<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.FillProperty, binding);


 // Minimum

/*ValueStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Minimum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MinimumProperty, binding);


 // Maximum

/*ValueStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Maximum<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.MaximumProperty, binding);


 // TickFrequency

/*ValueStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TickFrequency<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TickFrequencyProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.OrientationProperty, binding);


 // Ticks

/*ValueStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Double> value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Ticks<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.TicksProperty, binding);


 // IsDirectionReversed

/*ValueStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDirectionReversed<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.IsDirectionReversedProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.TickBarPlacement value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.PlacementProperty, binding);


 // ReservedSpace

/*ValueStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Rect value) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TickBar 
=> style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, binding);

/*ValueOverloadsStyleSetterGenerator*/
public static Style<T> ReservedSpace<T>(this Style<T> style, System.Double x, System.Double y, System.Double width, System.Double height) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(x, y, width, height));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point position, Avalonia.Size size) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(position, size));public static Style<T> ReservedSpace<T>(this Style<T> style, Avalonia.Point topLeft, Avalonia.Point bottomRight) where T : Avalonia.Controls.TickBar 
   => style._addSetter(Avalonia.Controls.TickBar.ReservedSpaceProperty, new Avalonia.Rect(topLeft, bottomRight));



}
