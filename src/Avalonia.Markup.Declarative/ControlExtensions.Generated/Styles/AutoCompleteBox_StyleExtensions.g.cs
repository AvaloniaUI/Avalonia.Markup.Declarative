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
public static Style<T> CaretIndex<T>(this Style<T> style, Int32 value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.CaretIndexProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, String value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.WatermarkProperty, binding);
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, Int32 value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MinimumPrefixLengthProperty, value);
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, TimeSpan value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MinimumPopulateDelayProperty, value);
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, Double value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MaxDropDownHeightProperty, value);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, Boolean value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.IsTextCompletionEnabledProperty, value);
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static Style<T> ItemTemplate<T>(this Style<T> style, IDataTemplate value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemTemplateProperty, value);
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemTemplateProperty, binding);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, Boolean value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.IsDropDownOpenProperty, binding);
public static Style<T> SelectedItem<T>(this Style<T> style, Object value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.SelectedItemProperty, value);
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.SelectedItemProperty, binding);
public static Style<T> Text<T>(this Style<T> style, String value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextProperty, binding);
public static Style<T> FilterMode<T>(this Style<T> style, AutoCompleteFilterMode value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.FilterModeProperty, value);
public static Style<T> FilterMode<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.FilterModeProperty, binding);
public static Style<T> ItemFilter<T>(this Style<T> style, AutoCompleteFilterPredicate<Object> value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemFilterProperty, value);
public static Style<T> ItemFilter<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemFilterProperty, binding);
public static Style<T> TextFilter<T>(this Style<T> style, AutoCompleteFilterPredicate<String> value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextFilterProperty, value);
public static Style<T> TextFilter<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextFilterProperty, binding);
public static Style<T> ItemSelector<T>(this Style<T> style, AutoCompleteSelector<Object> value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemSelectorProperty, value);
public static Style<T> ItemSelector<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemSelectorProperty, binding);
public static Style<T> TextSelector<T>(this Style<T> style, AutoCompleteSelector<String> value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextSelectorProperty, value);
public static Style<T> TextSelector<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.TextSelectorProperty, binding);
public static Style<T> ItemsSource<T>(this Style<T> style, IEnumerable value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemsSourceProperty, value);
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.ItemsSourceProperty, binding);
public static Style<T> AsyncPopulator<T>(this Style<T> style, Func<String,CancellationToken,Task<IEnumerable<Object>>> value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.AsyncPopulatorProperty, value);
public static Style<T> AsyncPopulator<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.AsyncPopulatorProperty, binding);
public static Style<T> MaxLength<T>(this Style<T> style, Int32 value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MaxLengthProperty, value);
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.MaxLengthProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, Object value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, Object value) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : AutoCompleteBox
=> style._addSetter(AutoCompleteBox.InnerRightContentProperty, binding);
}

