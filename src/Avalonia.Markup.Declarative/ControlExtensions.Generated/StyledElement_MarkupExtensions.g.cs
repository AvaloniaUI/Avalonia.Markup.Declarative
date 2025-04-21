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
public static partial class StyledElement_MarkupExtensions
{
//================= Properties ======================//
 // DataContext

/*BindFromExpressionSetterGenerator*/
public static T DataContext<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DataContext<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DataContext<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DataContext<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.DataContextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DataContext<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Name

/*BindFromExpressionSetterGenerator*/
public static T Name<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Name<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Name<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Name<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.NameProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Name<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Theme

/*BindFromExpressionSetterGenerator*/
public static T Theme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Theme<T>(this T control,Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.ThemeProperty, ps, () => control.Theme = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Theme<T>(this T control, IBinding binding) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Theme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.StyledElement 
   => control._set(Avalonia.StyledElement.ThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Theme<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.StyledElement 
=> control._setEx(Avalonia.StyledElement.ThemeProperty, ps, () => control.Theme = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // AttachedToLogicalTree

/*ActionToEventGenerator*/
public static T OnAttachedToLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.AttachedToLogicalTree += h);


 // DetachedFromLogicalTree

/*ActionToEventGenerator*/
public static T OnDetachedFromLogicalTree<T>(this T control, Action<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.LogicalTree.LogicalTreeAttachmentEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DetachedFromLogicalTree += h);


 // DataContextChanged

/*ActionToEventGenerator*/
public static T OnDataContextChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DataContextChanged += h);


 // Initialized

/*ActionToEventGenerator*/
public static T OnInitialized<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.Initialized += h);


 // ResourcesChanged

/*ActionToEventGenerator*/
public static T OnResourcesChanged<T>(this T control, Action<Avalonia.Controls.ResourcesChangedEventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.ResourcesChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.ResourcesChanged += h);


 // ActualThemeVariantChanged

/*ActionToEventGenerator*/
public static T OnActualThemeVariantChanged<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.StyledElement  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.ActualThemeVariantChanged += h);



//================= Styles ======================//
 // DataContext

/*ValueStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, System.Object value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DataContext<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.DataContextProperty, binding);


 // Theme

/*ValueStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Theme<T>(this Style<T> style, IBinding binding) where T : Avalonia.StyledElement 
=> style._addSetter(Avalonia.StyledElement.ThemeProperty, binding);



}
