#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
[global::System.CodeDom.Compiler.GeneratedCode("AvaloniaExtensionGenerator", "11.1.3.0")]
[global::System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverage]
public static partial class ToggleButton_MarkupExtensions
{
//================= Properties ======================//
 // IsChecked

/*BindFromExpressionSetterGenerator*/
public static T IsChecked<T>(this T control, Func<System.Nullable<System.Boolean>> func, Action<System.Nullable<System.Boolean>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsChecked<T>(this T control,System.Nullable<System.Boolean> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsChecked<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsChecked<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsChecked<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.Boolean>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsThreeState

/*BindFromExpressionSetterGenerator*/
public static T IsThreeState<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsThreeState<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsThreeState<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsThreeState<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.ToggleButton 
   => control._set(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsThreeState<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.ToggleButton 
=> control._setEx(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//
 // Checked

/*ActionToEventGenerator*/
    public static T OnChecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Primitives.ToggleButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Checked += h);


 // Unchecked

/*ActionToEventGenerator*/
    public static T OnUnchecked<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Primitives.ToggleButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Unchecked += h);


 // Indeterminate

/*ActionToEventGenerator*/
    public static T OnIndeterminate<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Primitives.ToggleButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Indeterminate += h);


 // IsCheckedChanged

/*ActionToEventGenerator*/
    public static T OnIsCheckedChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.Primitives.ToggleButton => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.IsCheckedChanged += h);



//================= Styles ======================//
 // IsChecked

/*ValueStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, System.Nullable<System.Boolean> value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsChecked<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsCheckedProperty, binding);


 // IsThreeState

/*ValueStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsThreeState<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.ToggleButton 
=> style._addSetter(Avalonia.Controls.Primitives.ToggleButton.IsThreeStateProperty, binding);



}
