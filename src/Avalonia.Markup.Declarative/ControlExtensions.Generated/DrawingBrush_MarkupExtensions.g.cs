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
public static partial class DrawingBrush_MarkupExtensions
{
//================= Properties ======================//
 // Drawing

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, Func<Avalonia.Media.Drawing> func, Action<Avalonia.Media.Drawing>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control,Avalonia.Media.Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DrawingBrush.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, IBinding binding)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing(this Avalonia.Media.DrawingBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.DrawingBrush.DrawingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.DrawingBrush Drawing<TValue>(this Avalonia.Media.DrawingBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.DrawingBrush.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
