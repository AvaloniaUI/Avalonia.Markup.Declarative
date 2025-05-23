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
public static partial class TransformGroup_MarkupExtensions
{
//================= Properties ======================//
 // Children

/*ValueSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Avalonia.Media.Transforms value)  
=> control._set(() => control.Children = value!);

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, Func<Avalonia.Media.Transforms> func, Action<Avalonia.Media.Transforms>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control,Avalonia.Media.Transforms value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.TransformGroup.ChildrenProperty, ps, () => control.Children = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, IBinding binding)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Media.TransformGroup Children(this Avalonia.Media.TransformGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Media.TransformGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static Avalonia.Media.TransformGroup Children<TValue>(this Avalonia.Media.TransformGroup control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transforms> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null)  
=> control._setEx(Avalonia.Media.TransformGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



}
