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
public static partial class PopConfirm_MarkupExtensions
{
//================= Properties ======================//
 // PopupHeader

/*ValueSetterGenerator*/
public static T PopupHeader<T>(this T control, System.Object value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.PopupHeader = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupHeader<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupHeader<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupHeaderProperty, ps, () => control.PopupHeader = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupHeader<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupHeader<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupHeader<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupHeaderProperty, ps, () => control.PopupHeader = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupHeaderTemplate

/*ValueSetterGenerator*/
public static T PopupHeaderTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.PopupHeaderTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupHeaderTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupHeaderTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty, ps, () => control.PopupHeaderTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupHeaderTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupHeaderTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupHeaderTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty, ps, () => control.PopupHeaderTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupContent

/*ValueSetterGenerator*/
public static T PopupContent<T>(this T control, System.Object value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.PopupContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupContentProperty, ps, () => control.PopupContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupContent<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupContentProperty, ps, () => control.PopupContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupContentTemplate

/*ValueSetterGenerator*/
public static T PopupContentTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.PopupContentTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupContentTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupContentTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupContentTemplateProperty, ps, () => control.PopupContentTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupContentTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PopupContentTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupContentTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PopupContentTemplateProperty, ps, () => control.PopupContentTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ConfirmCommand

/*ValueSetterGenerator*/
public static T ConfirmCommand<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.ConfirmCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T ConfirmCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ConfirmCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.ConfirmCommandProperty, ps, () => control.ConfirmCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ConfirmCommand<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ConfirmCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ConfirmCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.ConfirmCommandProperty, ps, () => control.ConfirmCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CancelCommand

/*ValueSetterGenerator*/
public static T CancelCommand<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.CancelCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T CancelCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CancelCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.CancelCommandProperty, ps, () => control.CancelCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CancelCommand<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CancelCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CancelCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.CancelCommandProperty, ps, () => control.CancelCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ConfirmCommandParameter

/*ValueSetterGenerator*/
public static T ConfirmCommandParameter<T>(this T control, System.Object value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.ConfirmCommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T ConfirmCommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ConfirmCommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty, ps, () => control.ConfirmCommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ConfirmCommandParameter<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ConfirmCommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ConfirmCommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty, ps, () => control.ConfirmCommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CancelCommandParameter

/*ValueSetterGenerator*/
public static T CancelCommandParameter<T>(this T control, System.Object value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.CancelCommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T CancelCommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CancelCommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.CancelCommandParameterProperty, ps, () => control.CancelCommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CancelCommandParameter<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CancelCommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.CancelCommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CancelCommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.CancelCommandParameterProperty, ps, () => control.CancelCommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TriggerMode

/*ValueSetterGenerator*/
public static T TriggerMode<T>(this T control, Ursa.Controls.PopConfirmTriggerMode value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.TriggerMode = value!);

/*BindFromExpressionSetterGenerator*/
public static T TriggerMode<T>(this T control, Func<Ursa.Controls.PopConfirmTriggerMode> func, Action<Ursa.Controls.PopConfirmTriggerMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.TriggerModeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TriggerMode<T>(this T control,Ursa.Controls.PopConfirmTriggerMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.TriggerModeProperty, ps, () => control.TriggerMode = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TriggerMode<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.TriggerModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TriggerMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.TriggerModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TriggerMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Ursa.Controls.PopConfirmTriggerMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.TriggerModeProperty, ps, () => control.TriggerMode = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HandleAsyncCommand

/*ValueSetterGenerator*/
public static T HandleAsyncCommand<T>(this T control, System.Boolean value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.HandleAsyncCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T HandleAsyncCommand<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HandleAsyncCommand<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty, ps, () => control.HandleAsyncCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HandleAsyncCommand<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HandleAsyncCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HandleAsyncCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty, ps, () => control.HandleAsyncCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDropdownOpen

/*ValueSetterGenerator*/
public static T IsDropdownOpen<T>(this T control, System.Boolean value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.IsDropdownOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDropdownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IsDropdownOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDropdownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.IsDropdownOpenProperty, ps, () => control.IsDropdownOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropdownOpen<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IsDropdownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropdownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IsDropdownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDropdownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.IsDropdownOpenProperty, ps, () => control.IsDropdownOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Placement

/*ValueSetterGenerator*/
public static T Placement<T>(this T control, Avalonia.Controls.PlacementMode value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.Placement = value!);

/*BindFromExpressionSetterGenerator*/
public static T Placement<T>(this T control, Func<Avalonia.Controls.PlacementMode> func, Action<Avalonia.Controls.PlacementMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PlacementProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Placement<T>(this T control,Avalonia.Controls.PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PlacementProperty, ps, () => control.Placement = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Placement<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PlacementProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.PlacementProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Placement<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Icon

/*ValueSetterGenerator*/
public static T Icon<T>(this T control, System.Object value) where T : Ursa.Controls.PopConfirm 
=> control._set(() => control.Icon = value!);

/*BindFromExpressionSetterGenerator*/
public static T Icon<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IconProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Icon<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.IconProperty, ps, () => control.Icon = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Icon<T>(this T control, IBinding binding) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IconProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Icon<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.PopConfirm 
   => control._set(Ursa.Controls.PopConfirm.IconProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Icon<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.PopConfirm 
=> control._setEx(Ursa.Controls.PopConfirm.IconProperty, ps, () => control.Icon = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // PopupHeader

/*ValueStyleSetterGenerator*/
public static Style<T> PopupHeader<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupHeaderProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupHeader<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupHeaderProperty, binding);


 // PopupHeaderTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PopupHeaderTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupHeaderTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupHeaderTemplateProperty, binding);


 // PopupContent

/*ValueStyleSetterGenerator*/
public static Style<T> PopupContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupContentProperty, binding);


 // PopupContentTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> PopupContentTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupContentTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupContentTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PopupContentTemplateProperty, binding);


 // ConfirmCommand

/*ValueStyleSetterGenerator*/
public static Style<T> ConfirmCommand<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.ConfirmCommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ConfirmCommand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.ConfirmCommandProperty, binding);


 // CancelCommand

/*ValueStyleSetterGenerator*/
public static Style<T> CancelCommand<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.CancelCommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CancelCommand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.CancelCommandProperty, binding);


 // ConfirmCommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> ConfirmCommandParameter<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ConfirmCommandParameter<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.ConfirmCommandParameterProperty, binding);


 // CancelCommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CancelCommandParameter<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.CancelCommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CancelCommandParameter<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.CancelCommandParameterProperty, binding);


 // TriggerMode

/*ValueStyleSetterGenerator*/
public static Style<T> TriggerMode<T>(this Style<T> style, Ursa.Controls.PopConfirmTriggerMode value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.TriggerModeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TriggerMode<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.TriggerModeProperty, binding);


 // HandleAsyncCommand

/*ValueStyleSetterGenerator*/
public static Style<T> HandleAsyncCommand<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HandleAsyncCommand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.HandleAsyncCommandProperty, binding);


 // IsDropdownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropdownOpen<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.IsDropdownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropdownOpen<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.IsDropdownOpenProperty, binding);


 // Placement

/*ValueStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, Avalonia.Controls.PlacementMode value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PlacementProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Placement<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.PlacementProperty, binding);


 // Icon

/*ValueStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.IconProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Icon<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.PopConfirm 
=> style._addSetter(Ursa.Controls.PopConfirm.IconProperty, binding);



}
