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
public static partial class Pagination_MarkupExtensions
{
//================= Properties ======================//
 // CurrentPage

/*ValueSetterGenerator*/
public static T CurrentPage<T>(this T control, System.Nullable<System.Int32> value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.CurrentPage = value!);

/*BindFromExpressionSetterGenerator*/
public static T CurrentPage<T>(this T control, Func<System.Nullable<System.Int32>> func, Action<System.Nullable<System.Int32>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CurrentPageProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CurrentPage<T>(this T control,System.Nullable<System.Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CurrentPageProperty, ps, () => control.CurrentPage = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CurrentPage<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CurrentPageProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CurrentPage<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CurrentPageProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CurrentPage<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CurrentPageProperty, ps, () => control.CurrentPage = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Command

/*ValueSetterGenerator*/
public static T Command<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.Command = value!);

/*BindFromExpressionSetterGenerator*/
public static T Command<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Command<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CommandProperty, ps, () => control.Command = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Command<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Command<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Command<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CommandProperty, ps, () => control.Command = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // CommandParameter

/*ValueSetterGenerator*/
public static T CommandParameter<T>(this T control, System.Object value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.CommandParameter = value!);

/*BindFromExpressionSetterGenerator*/
public static T CommandParameter<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandParameterProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T CommandParameter<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CommandParameterProperty, ps, () => control.CommandParameter = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CommandParameter<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandParameterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CommandParameter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.CommandParameterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T CommandParameter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // TotalCount

/*ValueSetterGenerator*/
public static T TotalCount<T>(this T control, System.Int32 value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.TotalCount = value!);

/*BindFromExpressionSetterGenerator*/
public static T TotalCount<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.TotalCountProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T TotalCount<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.TotalCountProperty, ps, () => control.TotalCount = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TotalCount<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.TotalCountProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TotalCount<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.TotalCountProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T TotalCount<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.TotalCountProperty, ps, () => control.TotalCount = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PageSize

/*ValueSetterGenerator*/
public static T PageSize<T>(this T control, System.Int32 value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.PageSize = value!);

/*BindFromExpressionSetterGenerator*/
public static T PageSize<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PageSize<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageSizeProperty, ps, () => control.PageSize = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageSize<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PageSize<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageSizeProperty, ps, () => control.PageSize = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PageSizeOptions

/*ValueSetterGenerator*/
public static T PageSizeOptions<T>(this T control, Avalonia.Collections.AvaloniaList<System.Int32> value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.PageSizeOptions = value!);

/*BindFromExpressionSetterGenerator*/
public static T PageSizeOptions<T>(this T control, Func<Avalonia.Collections.AvaloniaList<System.Int32>> func, Action<Avalonia.Collections.AvaloniaList<System.Int32>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeOptionsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PageSizeOptions<T>(this T control,Avalonia.Collections.AvaloniaList<System.Int32> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageSizeOptionsProperty, ps, () => control.PageSizeOptions = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageSizeOptions<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeOptionsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageSizeOptions<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageSizeOptionsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PageSizeOptions<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Collections.AvaloniaList<System.Int32>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageSizeOptionsProperty, ps, () => control.PageSizeOptions = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PageButtonTheme

/*ValueSetterGenerator*/
public static T PageButtonTheme<T>(this T control, Avalonia.Styling.ControlTheme value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.PageButtonTheme = value!);

/*BindFromExpressionSetterGenerator*/
public static T PageButtonTheme<T>(this T control, Func<Avalonia.Styling.ControlTheme> func, Action<Avalonia.Styling.ControlTheme>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageButtonThemeProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PageButtonTheme<T>(this T control,Avalonia.Styling.ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageButtonThemeProperty, ps, () => control.PageButtonTheme = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PageButtonTheme<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageButtonThemeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PageButtonTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.PageButtonThemeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PageButtonTheme<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Styling.ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.PageButtonThemeProperty, ps, () => control.PageButtonTheme = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowPageSizeSelector

/*ValueSetterGenerator*/
public static T ShowPageSizeSelector<T>(this T control, System.Boolean value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.ShowPageSizeSelector = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowPageSizeSelector<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowPageSizeSelector<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty, ps, () => control.ShowPageSizeSelector = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowPageSizeSelector<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowPageSizeSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowPageSizeSelector<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty, ps, () => control.ShowPageSizeSelector = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // ShowQuickJump

/*ValueSetterGenerator*/
public static T ShowQuickJump<T>(this T control, System.Boolean value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.ShowQuickJump = value!);

/*BindFromExpressionSetterGenerator*/
public static T ShowQuickJump<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowQuickJumpProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T ShowQuickJump<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.ShowQuickJumpProperty, ps, () => control.ShowQuickJump = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ShowQuickJump<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowQuickJumpProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ShowQuickJump<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.ShowQuickJumpProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T ShowQuickJump<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.ShowQuickJumpProperty, ps, () => control.ShowQuickJump = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // DisplayCurrentPageInQuickJumper

/*ValueSetterGenerator*/
public static T DisplayCurrentPageInQuickJumper<T>(this T control, System.Boolean value) where T : Ursa.Controls.Pagination 
=> control._set(() => control.DisplayCurrentPageInQuickJumper = value!);

/*BindFromExpressionSetterGenerator*/
public static T DisplayCurrentPageInQuickJumper<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T DisplayCurrentPageInQuickJumper<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty, ps, () => control.DisplayCurrentPageInQuickJumper = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayCurrentPageInQuickJumper<T>(this T control, IBinding binding) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayCurrentPageInQuickJumper<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.Pagination 
   => control._set(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T DisplayCurrentPageInQuickJumper<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.Pagination 
=> control._setEx(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty, ps, () => control.DisplayCurrentPageInQuickJumper = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // CurrentPageChanged

/*ActionToEventGenerator*/
public static T OnCurrentPageChanged<T>(this T control, Action<Ursa.Controls.ValueChangedEventArgs<System.Int32>> action, Avalonia.Interactivity.RoutingStrategies? routes = null) where T : Ursa.Controls.Pagination 
{
  control.AddHandler(Ursa.Controls.Pagination.CurrentPageChangedEvent, (_, args) => action(args), routes ?? Ursa.Controls.Pagination.CurrentPageChangedEvent.RoutingStrategies);
  return control;
}




//================= Styles ======================//
 // CurrentPage

/*ValueStyleSetterGenerator*/
public static Style<T> CurrentPage<T>(this Style<T> style, System.Nullable<System.Int32> value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CurrentPageProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CurrentPage<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CurrentPageProperty, binding);


 // Command

/*ValueStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Command<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CommandProperty, binding);


 // CommandParameter

/*ValueStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CommandParameterProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> CommandParameter<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.CommandParameterProperty, binding);


 // TotalCount

/*ValueStyleSetterGenerator*/
public static Style<T> TotalCount<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.TotalCountProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> TotalCount<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.TotalCountProperty, binding);


 // PageSize

/*ValueStyleSetterGenerator*/
public static Style<T> PageSize<T>(this Style<T> style, System.Int32 value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageSizeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageSize<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageSizeProperty, binding);


 // PageSizeOptions

/*ValueStyleSetterGenerator*/
public static Style<T> PageSizeOptions<T>(this Style<T> style, Avalonia.Collections.AvaloniaList<System.Int32> value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageSizeOptionsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageSizeOptions<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageSizeOptionsProperty, binding);


 // PageButtonTheme

/*ValueStyleSetterGenerator*/
public static Style<T> PageButtonTheme<T>(this Style<T> style, Avalonia.Styling.ControlTheme value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageButtonThemeProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PageButtonTheme<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.PageButtonThemeProperty, binding);


 // ShowPageSizeSelector

/*ValueStyleSetterGenerator*/
public static Style<T> ShowPageSizeSelector<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowPageSizeSelector<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.ShowPageSizeSelectorProperty, binding);


 // ShowQuickJump

/*ValueStyleSetterGenerator*/
public static Style<T> ShowQuickJump<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.ShowQuickJumpProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> ShowQuickJump<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.ShowQuickJumpProperty, binding);


 // DisplayCurrentPageInQuickJumper

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayCurrentPageInQuickJumper<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayCurrentPageInQuickJumper<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.Pagination 
=> style._addSetter(Ursa.Controls.Pagination.DisplayCurrentPageInQuickJumperProperty, binding);



}
