#nullable enable
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
public static T CaretIndex<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.CaretIndexProperty, binding);
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T CaretIndex<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.CaretIndexProperty, func, onChanged, expression);
public static T CaretIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static T CaretIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Watermark<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.WatermarkProperty, binding);
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Watermark<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.WatermarkProperty, func, onChanged, expression);
public static T Watermark<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static T Watermark<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinimumPrefixLength<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static T MinimumPrefixLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinimumPrefixLength<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, func, onChanged, expression);
public static T MinimumPrefixLength<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = value, bindingMode, converter, bindingSource);
public static T MinimumPrefixLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinimumPopulateDelay<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static T MinimumPopulateDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MinimumPopulateDelay<T>(this T control, Func<TimeSpan> func, Action<TimeSpan>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, func, onChanged, expression);
public static T MinimumPopulateDelay<T>(this T control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = value, bindingMode, converter, bindingSource);
public static T MinimumPopulateDelay<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxDropDownHeight<T>(this T control, Func<Double> func, Action<Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, func, onChanged, expression);
public static T MaxDropDownHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static T MaxDropDownHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTextCompletionEnabled<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static T IsTextCompletionEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsTextCompletionEnabled<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, func, onChanged, expression);
public static T IsTextCompletionEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = value, bindingMode, converter, bindingSource);
public static T IsTextCompletionEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemTemplate<T>(this T control, Func<IDataTemplate> func, Action<IDataTemplate>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemTemplateProperty, func, onChanged, expression);
public static T ItemTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, binding);
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T IsDropDownOpen<T>(this T control, Func<Boolean> func, Action<Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, func, onChanged, expression);
public static T IsDropDownOpen<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static T IsDropDownOpen<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T SelectedItem<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.SelectedItemProperty, func, onChanged, expression);
public static T SelectedItem<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Text<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextProperty, binding);
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T Text<T>(this T control, Func<String> func, Action<String>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextProperty, func, onChanged, expression);
public static T Text<T>(this T control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static T Text<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FilterMode<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.FilterModeProperty, binding);
public static T FilterMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.FilterModeProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T FilterMode<T>(this T control, Func<AutoCompleteFilterMode> func, Action<AutoCompleteFilterMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.FilterModeProperty, func, onChanged, expression);
public static T FilterMode<T>(this T control, AutoCompleteFilterMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = value, bindingMode, converter, bindingSource);
public static T FilterMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemFilter<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemFilterProperty, binding);
public static T ItemFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemFilter<T>(this T control, Func<AutoCompleteFilterPredicate<Object>> func, Action<AutoCompleteFilterPredicate<Object>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemFilterProperty, func, onChanged, expression);
public static T ItemFilter<T>(this T control, AutoCompleteFilterPredicate<Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = value, bindingMode, converter, bindingSource);
public static T ItemFilter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterPredicate<Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextFilter<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextFilterProperty, binding);
public static T TextFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextFilter<T>(this T control, Func<AutoCompleteFilterPredicate<String>> func, Action<AutoCompleteFilterPredicate<String>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextFilterProperty, func, onChanged, expression);
public static T TextFilter<T>(this T control, AutoCompleteFilterPredicate<String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = value, bindingMode, converter, bindingSource);
public static T TextFilter<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterPredicate<String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemSelector<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemSelectorProperty, binding);
public static T ItemSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemSelector<T>(this T control, Func<AutoCompleteSelector<Object>> func, Action<AutoCompleteSelector<Object>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemSelectorProperty, func, onChanged, expression);
public static T ItemSelector<T>(this T control, AutoCompleteSelector<Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = value, bindingMode, converter, bindingSource);
public static T ItemSelector<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AutoCompleteSelector<Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TextSelector<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextSelectorProperty, binding);
public static T TextSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T TextSelector<T>(this T control, Func<AutoCompleteSelector<String>> func, Action<AutoCompleteSelector<String>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.TextSelectorProperty, func, onChanged, expression);
public static T TextSelector<T>(this T control, AutoCompleteSelector<String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = value, bindingMode, converter, bindingSource);
public static T TextSelector<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, AutoCompleteSelector<String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsSource<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T ItemsSource<T>(this T control, Func<IEnumerable> func, Action<IEnumerable>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.ItemsSourceProperty, func, onChanged, expression);
public static T ItemsSource<T>(this T control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T AsyncPopulator<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, binding);
public static T AsyncPopulator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T AsyncPopulator<T>(this T control, Func<Func<String,CancellationToken,Task<IEnumerable<Object>>>> func, Action<Func<String,CancellationToken,Task<IEnumerable<Object>>>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, func, onChanged, expression);
public static T AsyncPopulator<T>(this T control, Func<String,CancellationToken,Task<IEnumerable<Object>>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = value, bindingMode, converter, bindingSource);
public static T AsyncPopulator<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Func<String,CancellationToken,Task<IEnumerable<Object>>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxLength<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxLengthProperty, binding);
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T MaxLength<T>(this T control, Func<Int32> func, Action<Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.MaxLengthProperty, func, onChanged, expression);
public static T MaxLength<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);
public static T MaxLength<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerLeftContentProperty, binding);
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerLeftContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerLeftContentProperty, func, onChanged, expression);
public static T InnerLeftContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static T InnerLeftContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T InnerRightContent<T>(this T control, IBinding binding) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerRightContentProperty, binding);
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);
public static T InnerRightContent<T>(this T control, Func<Object> func, Action<Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : AutoCompleteBox
   => control._set(AutoCompleteBox.InnerRightContentProperty, func, onChanged, expression);
public static T InnerRightContent<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static T InnerRightContent<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : AutoCompleteBox
=> control._setEx(AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

