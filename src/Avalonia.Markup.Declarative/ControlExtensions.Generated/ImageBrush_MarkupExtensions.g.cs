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
public static partial class ImageBrush_MarkupExtensions
{
//================= Properties ======================//
 // Source

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, Func<Avalonia.Media.IImageBrushSource> func, Action<Avalonia.Media.IImageBrushSource>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control,Avalonia.Media.IImageBrushSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ImageBrush.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, IBinding binding)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.ImageBrush Source(this Avalonia.Media.ImageBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.ImageBrush.SourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Media.ImageBrush Source<TValue>(this Avalonia.Media.ImageBrush control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IImageBrushSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.ImageBrush.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);



}
