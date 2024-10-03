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
public static partial class InlineUIContainer_MarkupExtensions
{
//================= Properties ======================//
 // Child

/*BindFromExpressionSetterGenerator*/
public static T Child<T>(this T control, Func<Avalonia.Controls.Control> func, Action<Avalonia.Controls.Control>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Child<T>(this T control,Avalonia.Controls.Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> control._setEx(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Child<T>(this T control, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Child<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
   => control._set(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Child<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> control._setEx(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Child

/*ValueStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, Avalonia.Controls.Control value) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Child<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Documents.InlineUIContainer 
=> style._addSetter(Avalonia.Controls.Documents.InlineUIContainer.ChildProperty, binding);



}
