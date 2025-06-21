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
public static partial class TreeComboBoxItem_MarkupExtensions
{
//================= Properties ======================//
 // IsSelected

/*ValueSetterGenerator*/
public static T IsSelected<T>(this T control, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> control._set(() => control.IsSelected = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSelected<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSelected<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty, ps, () => control.IsSelected = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSelected<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelected<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSelected<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsExpanded

/*ValueSetterGenerator*/
public static T IsExpanded<T>(this T control, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> control._set(() => control.IsExpanded = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsExpanded<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsExpanded<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty, ps, () => control.IsExpanded = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsExpanded<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsExpanded<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsExpanded<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsSelectable

/*ValueSetterGenerator*/
public static T IsSelectable<T>(this T control, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> control._set(() => control.IsSelectable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsSelectable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsSelectable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty, ps, () => control.IsSelectable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsSelectable<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsSelectable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBoxItem 
   => control._set(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsSelectable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBoxItem 
=> control._setEx(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty, ps, () => control.IsSelectable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsSelected

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelected<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsSelectedProperty, binding);


 // IsExpanded

/*ValueStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsExpanded<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsExpandedProperty, binding);


 // IsSelectable

/*ValueStyleSetterGenerator*/
public static Style<T> IsSelectable<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsSelectable<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBoxItem 
=> style._addSetter(Ursa.Controls.TreeComboBoxItem.IsSelectableProperty, binding);



}
