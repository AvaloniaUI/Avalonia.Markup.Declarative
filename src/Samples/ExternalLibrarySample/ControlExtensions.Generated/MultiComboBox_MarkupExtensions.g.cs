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
public static partial class MultiComboBox_MarkupExtensions
{
//================= Properties ======================//
 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDropDownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDropDownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.MaxDropDownHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // MaxSelectionBoxHeight

/*ValueSetterGenerator*/
public static T MaxSelectionBoxHeight<T>(this T control, System.Double value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.MaxSelectionBoxHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxSelectionBoxHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxSelectionBoxHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty, ps, () => control.MaxSelectionBoxHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxSelectionBoxHeight<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxSelectionBoxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxSelectionBoxHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty, ps, () => control.MaxSelectionBoxHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedItems

/*ValueSetterGenerator*/
public static T SelectedItems<T>(this T control, System.Collections.IList value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.SelectedItems = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemsProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItems<T>(this T control,System.Collections.IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.SelectedItemsProperty, ps, () => control.SelectedItems = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItems<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItems<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerLeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerRightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedItemTemplate

/*ValueSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.SelectedItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty, ps, () => control.SelectedItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty, ps, () => control.SelectedItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.Watermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.WatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.WatermarkProperty, ps, () => control.Watermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupInnerTopContent

/*ValueSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.PopupInnerTopContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupInnerTopContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty, ps, () => control.PopupInnerTopContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupInnerTopContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty, ps, () => control.PopupInnerTopContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupInnerBottomContent

/*ValueSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> control._set(() => control.PopupInnerBottomContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupInnerBottomContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty, ps, () => control.PopupInnerBottomContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, IBinding binding) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.MultiComboBox 
   => control._set(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupInnerBottomContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.MultiComboBox 
=> control._setEx(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty, ps, () => control.PopupInnerBottomContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.IsDropDownOpenProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.MaxDropDownHeightProperty, binding);


 // MaxSelectionBoxHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxSelectionBoxHeight<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxSelectionBoxHeight<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.MaxSelectionBoxHeightProperty, binding);


 // SelectedItems

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItems<T>(this Style<T> style, System.Collections.IList value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.SelectedItemsProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItems<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.SelectedItemsProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.InnerRightContentProperty, binding);


 // SelectedItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItemTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.SelectedItemTemplateProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.WatermarkProperty, binding);


 // PopupInnerTopContent

/*ValueStyleSetterGenerator*/
public static Style<T> PopupInnerTopContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupInnerTopContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.PopupInnerTopContentProperty, binding);


 // PopupInnerBottomContent

/*ValueStyleSetterGenerator*/
public static Style<T> PopupInnerBottomContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupInnerBottomContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.MultiComboBox 
=> style._addSetter(Ursa.Controls.MultiComboBox.PopupInnerBottomContentProperty, binding);



}
