#nullable enable
using AutoCompleteBox = Avalonia.Controls.AutoCompleteBox;
using Avalonia.Controls;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;

namespace Avalonia.Markup.Declarative;
public static partial class AutoCompleteBoxExtensions
{
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, func, onChanged, expression);
public static T CaretIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinimumPrefixLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static T MinimumPrefixLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinimumPrefixLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, func, onChanged, expression);
public static T MinimumPrefixLength<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = value, bindingMode, converter, bindingSource);
public static T MinimumPrefixLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinimumPopulateDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static T MinimumPopulateDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinimumPopulateDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, func, onChanged, expression);
public static T MinimumPopulateDelay<T>(this T control, System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = value, bindingMode, converter, bindingSource);
public static T MinimumPopulateDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, func, onChanged, expression);
public static T MaxDropDownHeight<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTextCompletionEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static T IsTextCompletionEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTextCompletionEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, func, onChanged, expression);
public static T IsTextCompletionEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = value, bindingMode, converter, bindingSource);
public static T IsTextCompletionEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, func, onChanged, expression);
public static T ItemTemplate<T>(this T control, Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, func, onChanged, expression);
public static T IsDropDownOpen<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, func, onChanged, expression);
public static T SelectedItem<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FilterMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);
public static T FilterMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FilterMode<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterMode> func, Action<Avalonia.Controls.AutoCompleteFilterMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, func, onChanged, expression);
public static T FilterMode<T>(this T control, Avalonia.Controls.AutoCompleteFilterMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = value, bindingMode, converter, bindingSource);
public static T FilterMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemFilter<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);
public static T ItemFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, func, onChanged, expression);
public static T ItemFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = value, bindingMode, converter, bindingSource);
public static T ItemFilter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextFilter<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);
public static T TextFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, func, onChanged, expression);
public static T TextFilter<T>(this T control, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = value, bindingMode, converter, bindingSource);
public static T TextFilter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemSelector<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);
public static T ItemSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.Object>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.Object>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, func, onChanged, expression);
public static T ItemSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = value, bindingMode, converter, bindingSource);
public static T ItemSelector<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteSelector<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextSelector<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);
public static T TextSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.String>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.String>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, func, onChanged, expression);
public static T TextSelector<T>(this T control, Avalonia.Controls.AutoCompleteSelector<System.String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = value, bindingMode, converter, bindingSource);
public static T TextSelector<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteSelector<System.String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, func, onChanged, expression);
public static T ItemsSource<T>(this T control, System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AsyncPopulator<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);
public static T AsyncPopulator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AsyncPopulator<T>(this T control, Func<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> func, Action<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, func, onChanged, expression);
public static T AsyncPopulator<T>(this T control, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = value, bindingMode, converter, bindingSource);
public static T AsyncPopulator<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, func, onChanged, expression);
public static T MaxLength<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);
public static T MaxLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, func, onChanged, expression);
public static T InnerLeftContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static T InnerLeftContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, func, onChanged, expression);
public static T InnerRightContent<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static T InnerRightContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

