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
public static partial class WindowBase_MarkupExtensions
{
//================= Properties ======================//
 // Topmost

/*BindFromExpressionSetterGenerator*/
public static T Topmost<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Topmost<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WindowBase 
=> control._setEx(Avalonia.Controls.WindowBase.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Topmost<T>(this T control, IBinding binding) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Topmost<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.WindowBase 
   => control._set(Avalonia.Controls.WindowBase.TopmostProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Topmost<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.WindowBase 
=> control._setEx(Avalonia.Controls.WindowBase.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // Activated

/*ActionToEventGenerator*/
public static T OnActivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Activated += h);


 // Deactivated

/*ActionToEventGenerator*/
public static T OnDeactivated<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Deactivated += h);


 // PositionChanged

/*ActionToEventGenerator*/
public static T OnPositionChanged<T>(this T control, Action<Avalonia.Controls.PixelPointEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PixelPointEventArgs>) ((arg0, arg1) => action(arg1)), h => control.PositionChanged += h);


 // Resized

/*ActionToEventGenerator*/
public static T OnResized<T>(this T control, Action<Avalonia.Controls.WindowResizedEventArgs> action) where T : Avalonia.Controls.WindowBase  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.WindowResizedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Resized += h);



//================= Styles ======================//
 // Topmost

/*ValueStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Topmost<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.WindowBase 
=> style._addSetter(Avalonia.Controls.WindowBase.TopmostProperty, binding);



}
