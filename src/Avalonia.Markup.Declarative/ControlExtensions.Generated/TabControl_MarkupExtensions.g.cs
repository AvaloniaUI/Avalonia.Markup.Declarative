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
public static partial class TabControl_MarkupExtensions
{
//================= Properties ======================//
 // TabStripPlacement

/*BindFromExpressionSetterGenerator*/
public static T TabStripPlacement<T>(this T control, Func<Avalonia.Controls.Dock> func, Action<Avalonia.Controls.Dock>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TabStripPlacement<T>(this T control,Avalonia.Controls.Dock value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TabStripPlacement<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TabStripPlacement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.TabStripPlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TabStripPlacement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Dock> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ContentTemplate

/*BindFromExpressionSetterGenerator*/
public static T ContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TabControl 
   => control._set(Avalonia.Controls.TabControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.TabControl 
=> control._setEx(Avalonia.Controls.TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // TabStripPlacement

/*ValueStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, Avalonia.Controls.Dock value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TabStripPlacement<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.TabStripPlacementProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.VerticalContentAlignmentProperty, binding);


 // ContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TabControl 
=> style._addSetter(Avalonia.Controls.TabControl.ContentTemplateProperty, binding);



}
