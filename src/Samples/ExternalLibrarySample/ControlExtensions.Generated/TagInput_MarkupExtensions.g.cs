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
public static partial class TagInput_MarkupExtensions
{
//================= Properties ======================//
 // Tags

/*ValueSetterGenerator*/
public static T Tags<T>(this T control, System.Collections.Generic.IList<System.String> value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.Tags = value!);

/*BindFromExpressionSetterGenerator*/
public static T Tags<T>(this T control, Func<System.Collections.Generic.IList<System.String>> func, Action<System.Collections.Generic.IList<System.String>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.TagsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Tags<T>(this T control,System.Collections.Generic.IList<System.String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.TagsProperty, ps, () => control.Tags = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Tags<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.TagsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Tags<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.TagsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Tags<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.Generic.IList<System.String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.TagsProperty, ps, () => control.Tags = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.Watermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.WatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.WatermarkProperty, ps, () => control.Watermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AcceptsReturn

/*ValueSetterGenerator*/
public static T AcceptsReturn<T>(this T control, System.Boolean value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.AcceptsReturn = value!);

/*BindFromExpressionSetterGenerator*/
public static T AcceptsReturn<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AcceptsReturnProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AcceptsReturn<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AcceptsReturnProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AcceptsReturn<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AcceptsReturn<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxCount

/*ValueSetterGenerator*/
public static T MaxCount<T>(this T control, System.Int32 value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.MaxCount = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxCount<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.MaxCountProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxCount<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.MaxCountProperty, ps, () => control.MaxCount = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxCount<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.MaxCountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxCount<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.MaxCountProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxCount<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.MaxCountProperty, ps, () => control.MaxCount = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InputTheme

/*ValueSetterGenerator*/
public static T InputTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.InputTheme = value!);

/*BindFromExpressionSetterGenerator*/
public static T InputTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InputThemeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InputTheme<T>(this T control,Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InputThemeProperty, ps, () => control.InputTheme = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InputTheme<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InputThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InputTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InputThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InputTheme<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InputThemeProperty, ps, () => control.InputTheme = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ItemTemplate

/*ValueSetterGenerator*/
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.ItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.ItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.ItemTemplateProperty, ps, () => control.ItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Separator

/*ValueSetterGenerator*/
public static T Separator<T>(this T control, System.String value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.Separator = value!);

/*BindFromExpressionSetterGenerator*/
public static T Separator<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.SeparatorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Separator<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.SeparatorProperty, ps, () => control.Separator = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Separator<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.SeparatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Separator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.SeparatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Separator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.SeparatorProperty, ps, () => control.Separator = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // LostFocusBehavior

/*ValueSetterGenerator*/
public static T LostFocusBehavior<T>(this T control, Ursa.Controls.LostFocusBehavior value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.LostFocusBehavior = value!);

/*BindFromExpressionSetterGenerator*/
public static T LostFocusBehavior<T>(this T control, Func<Ursa.Controls.LostFocusBehavior> func, Action<Ursa.Controls.LostFocusBehavior>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.LostFocusBehaviorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T LostFocusBehavior<T>(this T control,Ursa.Controls.LostFocusBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.LostFocusBehaviorProperty, ps, () => control.LostFocusBehavior = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T LostFocusBehavior<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.LostFocusBehaviorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T LostFocusBehavior<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.LostFocusBehaviorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T LostFocusBehavior<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.LostFocusBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.LostFocusBehaviorProperty, ps, () => control.LostFocusBehavior = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowDuplicates

/*ValueSetterGenerator*/
public static T AllowDuplicates<T>(this T control, System.Boolean value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.AllowDuplicates = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowDuplicates<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AllowDuplicatesProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowDuplicates<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.AllowDuplicatesProperty, ps, () => control.AllowDuplicates = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowDuplicates<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AllowDuplicatesProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowDuplicates<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.AllowDuplicatesProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowDuplicates<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.AllowDuplicatesProperty, ps, () => control.AllowDuplicates = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerLeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Ursa.Controls.TagInput 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerRightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InnerRightContentProperty, ps, () => control.InnerRightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TagInput 
   => control._set(Ursa.Controls.TagInput.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TagInput 
=> control._setEx(Ursa.Controls.TagInput.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // Tags

/*ValueStyleSetterGenerator*/
public static Style<T> Tags<T>(this Style<T> style, System.Collections.Generic.IList<System.String> value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.TagsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Tags<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.TagsProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.WatermarkProperty, binding);


 // AcceptsReturn

/*ValueStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.AcceptsReturnProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AcceptsReturn<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.AcceptsReturnProperty, binding);


 // MaxCount

/*ValueStyleSetterGenerator*/
public static Style<T> MaxCount<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.MaxCountProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxCount<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.MaxCountProperty, binding);


 // InputTheme

/*ValueStyleSetterGenerator*/
public static Style<T> InputTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InputThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InputTheme<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InputThemeProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.ItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.ItemTemplateProperty, binding);


 // Separator

/*ValueStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.SeparatorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Separator<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.SeparatorProperty, binding);


 // LostFocusBehavior

/*ValueStyleSetterGenerator*/
public static Style<T> LostFocusBehavior<T>(this Style<T> style, Ursa.Controls.LostFocusBehavior value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.LostFocusBehaviorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> LostFocusBehavior<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.LostFocusBehaviorProperty, binding);


 // AllowDuplicates

/*ValueStyleSetterGenerator*/
public static Style<T> AllowDuplicates<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.AllowDuplicatesProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowDuplicates<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.AllowDuplicatesProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TagInput 
=> style._addSetter(Ursa.Controls.TagInput.InnerRightContentProperty, binding);



}
