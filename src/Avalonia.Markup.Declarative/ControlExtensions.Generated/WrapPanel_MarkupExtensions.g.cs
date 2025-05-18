#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "1.0.0.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class WrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // ItemSpacing

/*ValueSetterGenerator*/
public static T ItemSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemSpacing = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemSpacingProperty, ps, () => control.ItemSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemSpacingProperty, ps, () => control.ItemSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LineSpacing

/*ValueSetterGenerator*/
public static T LineSpacing<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.LineSpacing = value!);

/*BindFromExpressionSetterGenerator*/
public static T LineSpacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LineSpacing<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.LineSpacingProperty, ps, () => control.LineSpacing = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LineSpacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LineSpacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.LineSpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LineSpacing<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.LineSpacingProperty, ps, () => control.LineSpacing = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Orientation

/*ValueSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.Orientation = value!);

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Orientation<T>(this T control,Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Orientation<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemsAlignment

/*ValueSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemsAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemsAlignment<T>(this T control, Func<Avalonia.Controls.WrapPanelItemsAlignment> func, Action<Avalonia.Controls.WrapPanelItemsAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemsAlignment<T>(this T control,Avalonia.Controls.WrapPanelItemsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, ps, () => control.ItemsAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemsAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.WrapPanelItemsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, ps, () => control.ItemsAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemWidth

/*ValueSetterGenerator*/
public static T ItemWidth<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemWidth = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemWidth<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemWidth<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemHeight

/*ValueSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> control._set(() => control.ItemHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel 
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.WrapPanel 
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // ItemSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemSpacingProperty, binding);


 // LineSpacing

/*ValueStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LineSpacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.LineSpacingProperty, binding);


 // Orientation

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);


 // ItemsAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, Avalonia.Controls.WrapPanelItemsAlignment value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemsAlignmentProperty, binding);


 // ItemWidth

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);


 // ItemHeight

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel 
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);



}
