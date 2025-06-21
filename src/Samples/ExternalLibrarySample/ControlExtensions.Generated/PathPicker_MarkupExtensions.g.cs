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
public static partial class PathPicker_MarkupExtensions
{
//================= Properties ======================//
 // SuggestedStartPath

/*ValueSetterGenerator*/
public static T SuggestedStartPath<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.SuggestedStartPath = value!);

/*BindFromExpressionSetterGenerator*/
public static T SuggestedStartPath<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedStartPathProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SuggestedStartPath<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SuggestedStartPathProperty, ps, () => control.SuggestedStartPath = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SuggestedStartPath<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedStartPathProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SuggestedStartPath<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedStartPathProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SuggestedStartPath<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SuggestedStartPathProperty, ps, () => control.SuggestedStartPath = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // UsePickerType

/*ValueSetterGenerator*/
public static T UsePickerType<T>(this T control, Ursa.Controls.UsePickerTypes value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.UsePickerType = value!);

/*BindFromExpressionSetterGenerator*/
public static T UsePickerType<T>(this T control, Func<Ursa.Controls.UsePickerTypes> func, Action<Ursa.Controls.UsePickerTypes>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.UsePickerTypeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T UsePickerType<T>(this T control,Ursa.Controls.UsePickerTypes value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.UsePickerTypeProperty, ps, () => control.UsePickerType = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T UsePickerType<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.UsePickerTypeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T UsePickerType<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.UsePickerTypeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T UsePickerType<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.UsePickerTypes> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.UsePickerTypeProperty, ps, () => control.UsePickerType = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SuggestedFileName

/*ValueSetterGenerator*/
public static T SuggestedFileName<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.SuggestedFileName = value!);

/*BindFromExpressionSetterGenerator*/
public static T SuggestedFileName<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedFileNameProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SuggestedFileName<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SuggestedFileNameProperty, ps, () => control.SuggestedFileName = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SuggestedFileName<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedFileNameProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SuggestedFileName<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SuggestedFileNameProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SuggestedFileName<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SuggestedFileNameProperty, ps, () => control.SuggestedFileName = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // FileFilter

/*ValueSetterGenerator*/
public static T FileFilter<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.FileFilter = value!);

/*BindFromExpressionSetterGenerator*/
public static T FileFilter<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.FileFilterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T FileFilter<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.FileFilterProperty, ps, () => control.FileFilter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FileFilter<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.FileFilterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FileFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.FileFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T FileFilter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.FileFilterProperty, ps, () => control.FileFilter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Title

/*ValueSetterGenerator*/
public static T Title<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.Title = value!);

/*BindFromExpressionSetterGenerator*/
public static T Title<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.TitleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Title<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.TitleProperty, ps, () => control.Title = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Title<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.TitleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Title<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.TitleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Title<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.TitleProperty, ps, () => control.Title = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DefaultFileExtension

/*ValueSetterGenerator*/
public static T DefaultFileExtension<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.DefaultFileExtension = value!);

/*BindFromExpressionSetterGenerator*/
public static T DefaultFileExtension<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.DefaultFileExtensionProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DefaultFileExtension<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.DefaultFileExtensionProperty, ps, () => control.DefaultFileExtension = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DefaultFileExtension<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.DefaultFileExtensionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DefaultFileExtension<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.DefaultFileExtensionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DefaultFileExtension<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.DefaultFileExtensionProperty, ps, () => control.DefaultFileExtension = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.Command = value!);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.CommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.CommandProperty, ps, () => control.Command = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.CommandProperty, ps, () => control.Command = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // AllowMultiple

/*ValueSetterGenerator*/
public static T AllowMultiple<T>(this T control, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.AllowMultiple = value!);

/*BindFromExpressionSetterGenerator*/
public static T AllowMultiple<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.AllowMultipleProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T AllowMultiple<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.AllowMultipleProperty, ps, () => control.AllowMultiple = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AllowMultiple<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.AllowMultipleProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AllowMultiple<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.AllowMultipleProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T AllowMultiple<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.AllowMultipleProperty, ps, () => control.AllowMultiple = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedPathsText

/*ValueSetterGenerator*/
public static T SelectedPathsText<T>(this T control, System.String value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.SelectedPathsText = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedPathsText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SelectedPathsTextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedPathsText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SelectedPathsTextProperty, ps, () => control.SelectedPathsText = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedPathsText<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SelectedPathsTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedPathsText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.SelectedPathsTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedPathsText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.SelectedPathsTextProperty, ps, () => control.SelectedPathsText = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsOmitCommandOnCancel

/*ValueSetterGenerator*/
public static T IsOmitCommandOnCancel<T>(this T control, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.IsOmitCommandOnCancel = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsOmitCommandOnCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsOmitCommandOnCancel<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty, ps, () => control.IsOmitCommandOnCancel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsOmitCommandOnCancel<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsOmitCommandOnCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsOmitCommandOnCancel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty, ps, () => control.IsOmitCommandOnCancel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsClearSelectionOnCancel

/*ValueSetterGenerator*/
public static T IsClearSelectionOnCancel<T>(this T control, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> control._set(() => control.IsClearSelectionOnCancel = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsClearSelectionOnCancel<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsClearSelectionOnCancel<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty, ps, () => control.IsClearSelectionOnCancel = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsClearSelectionOnCancel<T>(this T control, IBinding binding) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsClearSelectionOnCancel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PathPicker 
   => control._set(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsClearSelectionOnCancel<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PathPicker 
=> control._setEx(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty, ps, () => control.IsClearSelectionOnCancel = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // SuggestedStartPath

/*ValueStyleSetterGenerator*/
public static Style<T> SuggestedStartPath<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SuggestedStartPathProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SuggestedStartPath<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SuggestedStartPathProperty, binding);


 // UsePickerType

/*ValueStyleSetterGenerator*/
public static Style<T> UsePickerType<T>(this Style<T> style, Ursa.Controls.UsePickerTypes value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.UsePickerTypeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> UsePickerType<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.UsePickerTypeProperty, binding);


 // SuggestedFileName

/*ValueStyleSetterGenerator*/
public static Style<T> SuggestedFileName<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SuggestedFileNameProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SuggestedFileName<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SuggestedFileNameProperty, binding);


 // FileFilter

/*ValueStyleSetterGenerator*/
public static Style<T> FileFilter<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.FileFilterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> FileFilter<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.FileFilterProperty, binding);


 // Title

/*ValueStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.TitleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Title<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.TitleProperty, binding);


 // DefaultFileExtension

/*ValueStyleSetterGenerator*/
public static Style<T> DefaultFileExtension<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.DefaultFileExtensionProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DefaultFileExtension<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.DefaultFileExtensionProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.CommandProperty, binding);


 // AllowMultiple

/*ValueStyleSetterGenerator*/
public static Style<T> AllowMultiple<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.AllowMultipleProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> AllowMultiple<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.AllowMultipleProperty, binding);


 // SelectedPathsText

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedPathsText<T>(this Style<T> style, System.String value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SelectedPathsTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedPathsText<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.SelectedPathsTextProperty, binding);


 // IsOmitCommandOnCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsOmitCommandOnCancel<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsOmitCommandOnCancel<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.IsOmitCommandOnCancelProperty, binding);


 // IsClearSelectionOnCancel

/*ValueStyleSetterGenerator*/
public static Style<T> IsClearSelectionOnCancel<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsClearSelectionOnCancel<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PathPicker 
=> style._addSetter(Ursa.Controls.PathPicker.IsClearSelectionOnCancelProperty, binding);



}
