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
public static partial class Timeline_MarkupExtensions
{
//================= Properties ======================//
 // IconMemberBinding

/*ValueSetterGenerator*/
public static T IconMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.IconMemberBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.IconMemberBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconMemberBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.IconMemberBindingProperty, ps, () => control.IconMemberBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.IconMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconMemberBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.IconMemberBindingProperty, ps, () => control.IconMemberBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HeaderMemberBinding

/*ValueSetterGenerator*/
public static T HeaderMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.HeaderMemberBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T HeaderMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.HeaderMemberBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HeaderMemberBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.HeaderMemberBindingProperty, ps, () => control.HeaderMemberBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.HeaderMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HeaderMemberBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.HeaderMemberBindingProperty, ps, () => control.HeaderMemberBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ContentMemberBinding

/*ValueSetterGenerator*/
public static T ContentMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.ContentMemberBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T ContentMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.ContentMemberBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ContentMemberBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.ContentMemberBindingProperty, ps, () => control.ContentMemberBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ContentMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.ContentMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ContentMemberBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.ContentMemberBindingProperty, ps, () => control.ContentMemberBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IconTemplate

/*ValueSetterGenerator*/
public static T IconTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.IconTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T IconTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.IconTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IconTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.IconTemplateProperty, ps, () => control.IconTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IconTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.IconTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IconTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.IconTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IconTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.IconTemplateProperty, ps, () => control.IconTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DescriptionTemplate

/*ValueSetterGenerator*/
public static T DescriptionTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.DescriptionTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T DescriptionTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.DescriptionTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DescriptionTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.DescriptionTemplateProperty, ps, () => control.DescriptionTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DescriptionTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.DescriptionTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DescriptionTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.DescriptionTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DescriptionTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.DescriptionTemplateProperty, ps, () => control.DescriptionTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TimeMemberBinding

/*ValueSetterGenerator*/
public static T TimeMemberBinding<T>(this T control, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.TimeMemberBinding = value!);

/*BindFromExpressionSetterGenerator*/
public static T TimeMemberBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.TimeMemberBindingProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TimeMemberBinding<T>(this T control,Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.TimeMemberBindingProperty, ps, () => control.TimeMemberBinding = value!, bindingMode, converter, bindingSource);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TimeMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.TimeMemberBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TimeMemberBinding<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.TimeMemberBindingProperty, ps, () => control.TimeMemberBinding = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TimeFormat

/*ValueSetterGenerator*/
public static T TimeFormat<T>(this T control, System.String value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.TimeFormat = value!);

/*BindFromExpressionSetterGenerator*/
public static T TimeFormat<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.TimeFormatProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TimeFormat<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.TimeFormatProperty, ps, () => control.TimeFormat = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TimeFormat<T>(this T control, IBinding binding) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.TimeFormatProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TimeFormat<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.TimeFormatProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TimeFormat<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.TimeFormatProperty, ps, () => control.TimeFormat = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Mode

/*ValueSetterGenerator*/
public static T Mode<T>(this T control, Ursa.Controls.TimelineDisplayMode value) where T : Ursa.Controls.Timeline 
=> control._set(() => control.Mode = value!);

/*BindFromExpressionSetterGenerator*/
public static T Mode<T>(this T control, Func<Ursa.Controls.TimelineDisplayMode> func, Action<Ursa.Controls.TimelineDisplayMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.ModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Mode<T>(this T control,Ursa.Controls.TimelineDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.ModeProperty, ps, () => control.Mode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Mode<T>(this T control, IBinding binding) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.ModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Mode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Timeline 
   => control._set(Ursa.Controls.Timeline.ModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Mode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.TimelineDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Timeline 
=> control._setEx(Ursa.Controls.Timeline.ModeProperty, ps, () => control.Mode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IconMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> IconMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.IconMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped IconMemberBinding because already exist in value setters


 // HeaderMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.HeaderMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped HeaderMemberBinding because already exist in value setters


 // ContentMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> ContentMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.ContentMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped ContentMemberBinding because already exist in value setters


 // IconTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.IconTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IconTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.IconTemplateProperty, binding);


 // DescriptionTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> DescriptionTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.DescriptionTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DescriptionTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.DescriptionTemplateProperty, binding);


 // TimeMemberBinding

/*ValueStyleSetterGenerator*/
public static Style<T> TimeMemberBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.TimeMemberBindingProperty!, value!);

/*BindingStyleSetterGenerator*/
//Skipped TimeMemberBinding because already exist in value setters


 // TimeFormat

/*ValueStyleSetterGenerator*/
public static Style<T> TimeFormat<T>(this Style<T> style, System.String value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.TimeFormatProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TimeFormat<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.TimeFormatProperty, binding);


 // Mode

/*ValueStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, Ursa.Controls.TimelineDisplayMode value) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.ModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Mode<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Timeline 
=> style._addSetter(Ursa.Controls.Timeline.ModeProperty, binding);



}
