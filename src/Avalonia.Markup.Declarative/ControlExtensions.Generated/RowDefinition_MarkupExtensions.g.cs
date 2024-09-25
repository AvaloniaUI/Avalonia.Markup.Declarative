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
public static partial class RowDefinition_MarkupExtensions
{
//================= Properties ======================//
 // MaxHeightProperty

/*BindFromExpressionSetterGenerator*/
public static T MaxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MaxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinHeightProperty

/*BindFromExpressionSetterGenerator*/
public static T MinHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.MinHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HeightProperty

/*BindFromExpressionSetterGenerator*/
public static T Height<T>(this T control, Func<Avalonia.Controls.GridLength> func, Action<Avalonia.Controls.GridLength>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Height<T>(this T control, Avalonia.Controls.GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);

/*ValueOverloadsSetterGenerator*/

public static T Height<T>(this T control, System.Double value = default) where T : Avalonia.Controls.RowDefinition
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value));
public static T Height<T>(this T control, System.Double value = default, Avalonia.Controls.GridUnitType type = default) where T : Avalonia.Controls.RowDefinition
   => control._set(() => control.Height = new Avalonia.Controls.GridLength(value, type));

/*BindSetterGenerator*/
public static T Height<T>(this T control, IBinding binding) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.RowDefinition
   => control._set(Avalonia.Controls.RowDefinition.HeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.RowDefinition
=> control._setEx(Avalonia.Controls.RowDefinition.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//

}
