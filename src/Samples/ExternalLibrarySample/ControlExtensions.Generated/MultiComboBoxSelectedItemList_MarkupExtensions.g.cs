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
public static partial class MultiComboBoxSelectedItemList_MarkupExtensions
{
//================= Properties ======================//
 // RemoveCommand

/*ValueSetterGenerator*/
public static T RemoveCommand<T>(this T control, System.Windows.Input.ICommand value) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
=> control._set(() => control.RemoveCommand = value!);

/*BindFromExpressionSetterGenerator*/
public static T RemoveCommand<T>(this T control, Func<System.Windows.Input.ICommand> func, Action<System.Windows.Input.ICommand>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
   => control._set(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T RemoveCommand<T>(this T control,System.Windows.Input.ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
=> control._setEx(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty, ps, () => control.RemoveCommand = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T RemoveCommand<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
   => control._set(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T RemoveCommand<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
   => control._set(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T RemoveCommand<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Windows.Input.ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
=> control._setEx(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty, ps, () => control.RemoveCommand = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // RemoveCommand

/*ValueStyleSetterGenerator*/
public static Style<T> RemoveCommand<T>(this Style<T> style, System.Windows.Input.ICommand value) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
=> style._addSetter(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> RemoveCommand<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBoxSelectedItemList 
=> style._addSetter(Ursa.Controls.MultiComboBoxSelectedItemList.RemoveCommandProperty, binding);



}
