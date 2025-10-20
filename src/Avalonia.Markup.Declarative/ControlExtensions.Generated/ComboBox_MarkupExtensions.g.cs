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
public static partial class ComboBox_MarkupExtensions
{
//================= Properties ======================//
 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDropDownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDropDownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsEditable

/*ValueSetterGenerator*/
public static T IsEditable<T>(this T control, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.IsEditable = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsEditable<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsEditable<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.IsEditableProperty, ps, () => control.IsEditable = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsEditable<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsEditable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.IsEditableProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsEditable<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.IsEditableProperty, ps, () => control.IsEditable = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.MaxDropDownHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PlaceholderText

/*ValueSetterGenerator*/
public static T PlaceholderText<T>(this T control, System.String value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderText = value!);

/*BindFromExpressionSetterGenerator*/
public static T PlaceholderText<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PlaceholderText<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlaceholderText<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlaceholderText<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderTextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PlaceholderText<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PlaceholderForeground

/*ValueSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.PlaceholderForeground = value!);

/*BindFromExpressionSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PlaceholderForeground<T>(this T control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PlaceholderForeground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PlaceholderForeground<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Text

/*ValueSetterGenerator*/
public static T Text<T>(this T control, System.String value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.Text = value!);

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.TextProperty, ps, () => control.Text = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.TextProperty, ps, () => control.Text = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectionBoxItemTemplate

/*ValueSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
=> control._set(() => control.SelectionBoxItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectionBoxItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionBoxItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.ComboBox 
   => control._set(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectionBoxItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.ComboBox 
=> control._setEx(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Events ======================//
 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.ComboBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);



//================= Styles ======================//
 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsDropDownOpenProperty, binding);


 // IsEditable

/*ValueStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsEditable<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.IsEditableProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.MaxDropDownHeightProperty, binding);


 // PlaceholderText

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderText<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderTextProperty, binding);


 // PlaceholderForeground

/*ValueStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PlaceholderForeground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.PlaceholderForegroundProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.VerticalContentAlignmentProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.TextProperty, binding);


 // SelectionBoxItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionBoxItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.ComboBox 
=> style._addSetter(Avalonia.Controls.ComboBox.SelectionBoxItemTemplateProperty, binding);



}
