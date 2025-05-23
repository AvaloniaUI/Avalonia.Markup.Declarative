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
public static partial class VisualBrush_MarkupExtensions
{
//================= Properties ======================//
 // Visual

/*ValueSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Avalonia.Visual value)  
=> control._set(() => control.Visual = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, Func<Avalonia.Visual> func, Action<Avalonia.Visual>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control,Avalonia.Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, IBinding binding)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.VisualBrush Visual(this Avalonia.Media.VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.VisualBrush Visual<TValue>(this Avalonia.Media.VisualBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Visual> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.VisualBrush.VisualProperty, ps, () => control.Visual = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
