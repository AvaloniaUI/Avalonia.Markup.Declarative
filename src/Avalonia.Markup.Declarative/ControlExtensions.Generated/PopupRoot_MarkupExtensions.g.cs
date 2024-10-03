#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.2.999.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class PopupRoot_MarkupExtensions
{
//================= Properties ======================//
 // Transform

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, Func<Avalonia.Media.Transform> func, Action<Avalonia.Media.Transform>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control,Avalonia.Media.Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot Transform<TValue>(this Avalonia.Controls.Primitives.PopupRoot control, TValue value, FuncValueConverter<TValue, Avalonia.Media.Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // WindowManagerAddShadowHint

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint(this Avalonia.Controls.Primitives.PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Controls.Primitives.PopupRoot WindowManagerAddShadowHint<TValue>(this Avalonia.Controls.Primitives.PopupRoot control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // Transform

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, Avalonia.Media.Transform value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> Transform(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.TransformProperty, binding);


 // WindowManagerAddShadowHint

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, System.Boolean value)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.PopupRoot> WindowManagerAddShadowHint(this Style<Avalonia.Controls.Primitives.PopupRoot> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.PopupRoot.WindowManagerAddShadowHintProperty, binding);



}
