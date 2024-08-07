#nullable enable
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Layout;
using Avalonia.Media;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ComboBoxExtensions
{
public static ComboBox IsDropDownOpen(this ComboBox control, IBinding binding)
   => control._set(ComboBox.IsDropDownOpenProperty, binding);
public static ComboBox IsDropDownOpen(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox IsDropDownOpen(this ComboBox control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.IsDropDownOpenProperty, func, onChanged, expression);
public static ComboBox IsDropDownOpen(this ComboBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static ComboBox IsDropDownOpen<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox MaxDropDownHeight(this ComboBox control, IBinding binding)
   => control._set(ComboBox.MaxDropDownHeightProperty, binding);
public static ComboBox MaxDropDownHeight(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox MaxDropDownHeight(this ComboBox control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.MaxDropDownHeightProperty, func, onChanged, expression);
public static ComboBox MaxDropDownHeight(this ComboBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static ComboBox MaxDropDownHeight<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox PlaceholderText(this ComboBox control, IBinding binding)
   => control._set(ComboBox.PlaceholderTextProperty, binding);
public static ComboBox PlaceholderText(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.PlaceholderTextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox PlaceholderText(this ComboBox control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.PlaceholderTextProperty, func, onChanged, expression);
public static ComboBox PlaceholderText(this ComboBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = value, bindingMode, converter, bindingSource);
public static ComboBox PlaceholderText<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox PlaceholderForeground(this ComboBox control, IBinding binding)
   => control._set(ComboBox.PlaceholderForegroundProperty, binding);
public static ComboBox PlaceholderForeground(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.PlaceholderForegroundProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox PlaceholderForeground(this ComboBox control, Func<IBrush> func, Action<IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.PlaceholderForegroundProperty, func, onChanged, expression);
public static ComboBox PlaceholderForeground(this ComboBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = value, bindingMode, converter, bindingSource);
public static ComboBox PlaceholderForeground<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox HorizontalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, binding);
public static ComboBox HorizontalContentAlignment(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox HorizontalContentAlignment(this ComboBox control, Func<HorizontalAlignment> func, Action<HorizontalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, func, onChanged, expression);
public static ComboBox HorizontalContentAlignment(this ComboBox control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static ComboBox HorizontalContentAlignment<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox VerticalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(ComboBox.VerticalContentAlignmentProperty, binding);
public static ComboBox VerticalContentAlignment(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox VerticalContentAlignment(this ComboBox control, Func<VerticalAlignment> func, Action<VerticalAlignment>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.VerticalContentAlignmentProperty, func, onChanged, expression);
public static ComboBox VerticalContentAlignment(this ComboBox control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static ComboBox VerticalContentAlignment<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox SelectionBoxItemTemplate(this ComboBox control, IBinding binding)
   => control._set(ComboBox.SelectionBoxItemTemplateProperty, binding);
public static ComboBox SelectionBoxItemTemplate(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)
   => control._set(ComboBox.SelectionBoxItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static ComboBox SelectionBoxItemTemplate(this ComboBox control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.SelectionBoxItemTemplateProperty, func, onChanged, expression);
public static ComboBox SelectionBoxItemTemplate(this ComboBox control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = value, bindingMode, converter, bindingSource);
public static ComboBox SelectionBoxItemTemplate<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.SelectionBoxItemTemplateProperty, ps, () => control.SelectionBoxItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

