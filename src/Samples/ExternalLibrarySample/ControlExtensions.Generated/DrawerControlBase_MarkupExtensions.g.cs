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
public static partial class DrawerControlBase_MarkupExtensions
{
//================= Properties ======================//
 // Position

/*ValueSetterGenerator*/
public static T Position<T>(this T control, Ursa.Common.Position value) where T : Ursa.Controls.DrawerControlBase 
=> control._set(() => control.Position = value!);

/*BindFromExpressionSetterGenerator*/
public static T Position<T>(this T control, Func<Ursa.Common.Position> func, Action<Ursa.Common.Position>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.PositionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Position<T>(this T control,Ursa.Common.Position value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.PositionProperty, ps, () => control.Position = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Position<T>(this T control, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.PositionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Position<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.PositionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Position<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Common.Position> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.PositionProperty, ps, () => control.Position = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CanResize

/*ValueSetterGenerator*/
public static T CanResize<T>(this T control, System.Boolean value) where T : Ursa.Controls.DrawerControlBase 
=> control._set(() => control.CanResize = value!);

/*BindFromExpressionSetterGenerator*/
public static T CanResize<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.CanResizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CanResize<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.CanResizeProperty, ps, () => control.CanResize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CanResize<T>(this T control, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.CanResizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CanResize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.CanResizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CanResize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsOpen

/*ValueSetterGenerator*/
public static T IsOpen<T>(this T control, System.Boolean value) where T : Ursa.Controls.DrawerControlBase 
=> control._set(() => control.IsOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.IsOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.IsOpenProperty, ps, () => control.IsOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOpen<T>(this T control, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.IsOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DrawerControlBase 
   => control._set(Ursa.Controls.DrawerControlBase.IsOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DrawerControlBase 
=> control._setEx(Ursa.Controls.DrawerControlBase.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Position

/*ValueStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, Ursa.Common.Position value) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.PositionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Position<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.PositionProperty, binding);


 // CanResize

/*ValueStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.CanResizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CanResize<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.CanResizeProperty, binding);


 // IsOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.IsOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOpen<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DrawerControlBase 
=> style._addSetter(Ursa.Controls.DrawerControlBase.IsOpenProperty, binding);



}
