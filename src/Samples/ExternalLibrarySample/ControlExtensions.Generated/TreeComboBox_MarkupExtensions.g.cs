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
public static partial class TreeComboBox_MarkupExtensions
{
//================= Properties ======================//
 // MaxDropDownHeight

/*ValueSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, System.Double value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.MaxDropDownHeight = value!);

/*BindFromExpressionSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T MaxDropDownHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // Watermark

/*ValueSetterGenerator*/
public static T Watermark<T>(this T control, System.String value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.Watermark = value!);

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.WatermarkProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.WatermarkProperty, ps, () => control.Watermark = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // IsDropDownOpen

/*ValueSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, System.Boolean value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.IsDropDownOpen = value!);

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T IsDropDownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T IsDropDownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // HorizontalContentAlignment

/*ValueSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.HorizontalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, Func<Avalonia.Layout.HorizontalAlignment> func, Action<Avalonia.Layout.HorizontalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<T>(this T control,Avalonia.Layout.HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T HorizontalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // VerticalContentAlignment

/*ValueSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Avalonia.Layout.VerticalAlignment value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.VerticalContentAlignment = value!);

/*BindFromExpressionSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, Func<Avalonia.Layout.VerticalAlignment> func, Action<Avalonia.Layout.VerticalAlignment>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<T>(this T control,Avalonia.Layout.VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T VerticalContentAlignment<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedItemTemplate

/*ValueSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.SelectedItemTemplate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty, ps, () => control.SelectedItemTemplate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty, ps, () => control.SelectedItemTemplate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedItem

/*ValueSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.SelectedItem = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedItem<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.SelectedItemProperty, ps, () => control.SelectedItem = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedItem<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerLeftContent

/*ValueSetterGenerator*/
public static T InnerLeftContent<T>(this T control, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.InnerLeftContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerLeftContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // InnerRightContent

/*ValueSetterGenerator*/
public static T InnerRightContent<T>(this T control, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.InnerRightContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerRightContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupInnerTopContent

/*ValueSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.PopupInnerTopContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupInnerTopContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty, ps, () => control.PopupInnerTopContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupInnerTopContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupInnerTopContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty, ps, () => control.PopupInnerTopContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // PopupInnerBottomContent

/*ValueSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> control._set(() => control.PopupInnerBottomContent = value!);

/*BindFromExpressionSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T PopupInnerBottomContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty, ps, () => control.PopupInnerBottomContent = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, IBinding binding) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T PopupInnerBottomContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.TreeComboBox 
   => control._set(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T PopupInnerBottomContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.TreeComboBox 
=> control._setEx(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty, ps, () => control.PopupInnerBottomContent = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.MaxDropDownHeightProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.WatermarkProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.WatermarkProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.IsDropDownOpenProperty, binding);


 // HorizontalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, Avalonia.Layout.HorizontalAlignment value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> HorizontalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.HorizontalContentAlignmentProperty, binding);


 // VerticalContentAlignment

/*ValueStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, Avalonia.Layout.VerticalAlignment value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> VerticalContentAlignment<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.VerticalContentAlignmentProperty, binding);


 // SelectedItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItemTemplate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.SelectedItemTemplateProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.InnerLeftContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.InnerRightContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.InnerRightContentProperty, binding);


 // PopupInnerTopContent

/*ValueStyleSetterGenerator*/
public static Style<T> PopupInnerTopContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupInnerTopContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.PopupInnerTopContentProperty, binding);


 // PopupInnerBottomContent

/*ValueStyleSetterGenerator*/
public static Style<T> PopupInnerBottomContent<T>(this Style<T> style, System.Object value) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> PopupInnerBottomContent<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.TreeComboBox 
=> style._addSetter(Ursa.Controls.TreeComboBox.PopupInnerBottomContentProperty, binding);



}
