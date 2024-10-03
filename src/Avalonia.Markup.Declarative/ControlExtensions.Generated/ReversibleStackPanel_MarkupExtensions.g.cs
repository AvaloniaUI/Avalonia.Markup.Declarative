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
public static partial class ReversibleStackPanel_MarkupExtensions
{
//================= Properties ======================//
 // ReverseOrder

/*BindFromExpressionSetterGenerator*/
public static T ReverseOrder<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ReverseOrder<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ReversibleStackPanel 
=> control._setEx(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ReverseOrder<T>(this T control, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ReverseOrder<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ReversibleStackPanel 
   => control._set(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ReverseOrder<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ReversibleStackPanel 
=> control._setEx(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // ReverseOrder

/*ValueStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ReverseOrder<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ReversibleStackPanel 
=> style._addSetter(Avalonia.Controls.ReversibleStackPanel.ReverseOrderProperty, binding);



}
