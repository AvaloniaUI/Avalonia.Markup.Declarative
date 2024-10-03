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
public static partial class ToggleSplitButton_MarkupExtensions
{
//================= Properties ======================//
 // IsChecked

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsChecked<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSplitButton 
=> control._setEx(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ToggleSplitButton 
   => control._set(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsChecked<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ToggleSplitButton 
=> control._setEx(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // IsCheckedChanged

/*ActionToEventGenerator*/
    public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.ToggleSplitButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.IsCheckedChanged += h);



//================= Styles ======================//
 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ToggleSplitButton 
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ToggleSplitButton 
=> style._addSetter(Avalonia.Controls.ToggleSplitButton.IsCheckedProperty, binding);



}
