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
public static partial class ListBoxItem_MarkupExtensions
{
//================= Properties ======================//
 // IsSelected

/*BindFromExpressionSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.ListBoxItem 
   => control._set(Avalonia.Controls.ListBoxItem.IsSelectedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.ListBoxItem IsSelected<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBoxItem=> control._setEx(Avalonia.Controls.ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSelected<T>(this T control, IBinding binding) where T : Avalonia.Controls.ListBoxItem 
   => control._set(Avalonia.Controls.ListBoxItem.IsSelectedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelected<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ListBoxItem 
   => control._set(Avalonia.Controls.ListBoxItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsSelected<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.ListBoxItem=> control._setEx(Avalonia.Controls.ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Attached Properties ======================//

//================= Events ======================//

//================= Styles ======================//
 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ListBoxItem 
=> style._addSetter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ListBoxItem 
=> style._addSetter(Avalonia.Controls.ListBoxItem.IsSelectedProperty, binding);



}
