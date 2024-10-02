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
public static partial class Panel_MarkupExtensions
{
//================= Properties ======================//
 // Background

/*BindFromExpressionSetterGenerator*/
public static T Background<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Background<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Panel 
=> control._setEx(Avalonia.Controls.Panel.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Background<T>(this T control, IBinding binding) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Panel 
   => control._set(Avalonia.Controls.Panel.BackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Background<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Panel 
=> control._setEx(Avalonia.Controls.Panel.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // Background

/*ValueStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Background<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Panel 
=> style._addSetter(Avalonia.Controls.Panel.BackgroundProperty, binding);



}
