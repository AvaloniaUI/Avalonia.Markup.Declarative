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
public static partial class ToggleSwitch_MarkupExtensions
{
//================= Properties ======================//
 // OffContent

/*BindFromExpressionSetterGenerator*/
public static T OffContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OffContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentProperty, ps, () => control.OffContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OffContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OffContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OffContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentProperty, ps, () => control.OffContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OffContentTemplate

/*BindFromExpressionSetterGenerator*/
public static T OffContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OffContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OffContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OffContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OffContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OnContent

/*BindFromExpressionSetterGenerator*/
public static T OnContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OnContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentProperty, ps, () => control.OnContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OnContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OnContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OnContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentProperty, ps, () => control.OnContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // OnContentTemplate

/*BindFromExpressionSetterGenerator*/
public static T OnContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T OnContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T OnContentTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T OnContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T OnContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // KnobTransitions

/*BindFromExpressionSetterGenerator*/
public static T KnobTransitions<T>(this T control, Func<Avalonia.Animation.Transitions> func, Action<Avalonia.Animation.Transitions>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T KnobTransitions<T>(this T control,Avalonia.Animation.Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T KnobTransitions<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T KnobTransitions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSwitch 
   => control._set(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T KnobTransitions<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Animation.Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ToggleSwitch 
=> control._setEx(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // OffContent

/*ValueStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentProperty, binding);


 // OffContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OffContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OffContentTemplateProperty, binding);


 // OnContent

/*ValueStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentProperty, binding);


 // OnContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> OnContentTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.OnContentTemplateProperty, binding);


 // KnobTransitions

/*ValueStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, Avalonia.Animation.Transitions value) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> KnobTransitions<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSwitch 
=> style._addSetter(Avalonia.Controls.ToggleSwitch.KnobTransitionsProperty, binding);



}
