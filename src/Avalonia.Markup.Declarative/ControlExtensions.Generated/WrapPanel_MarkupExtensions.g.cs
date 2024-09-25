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
public static partial class WrapPanel_MarkupExtensions
{
//================= Properties ======================//
 // OrientationProperty

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemWidthProperty

/*BindFromExpressionSetterGenerator*/
public static T ItemWidth<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemWidth<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemWidth<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemHeightProperty

/*BindFromExpressionSetterGenerator*/
public static T ItemHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WrapPanel
   => control._set(Avalonia.Controls.WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WrapPanel
=> control._setEx(Avalonia.Controls.WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // OrientationProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.OrientationProperty, binding);


 // ItemWidthProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemWidth<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemWidthProperty, binding);


 // ItemHeightProperty

/*ValueStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WrapPanel
=> style._addSetter(Avalonia.Controls.WrapPanel.ItemHeightProperty, binding);



}
