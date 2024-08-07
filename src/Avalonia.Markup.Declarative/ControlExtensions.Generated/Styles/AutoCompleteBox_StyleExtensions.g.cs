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
public static Style<AutoCompleteBox> CaretIndex(this Style<AutoCompleteBox> style, Int32 value)
=> style._addSetter(AutoCompleteBox.CaretIndexProperty, value);
public static Style<AutoCompleteBox> CaretIndex(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.CaretIndexProperty, binding);
public static Style<AutoCompleteBox> Watermark(this Style<AutoCompleteBox> style, String value)
=> style._addSetter(AutoCompleteBox.WatermarkProperty, value);
public static Style<AutoCompleteBox> Watermark(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.WatermarkProperty, binding);
public static Style<AutoCompleteBox> MinimumPrefixLength(this Style<AutoCompleteBox> style, Int32 value)
=> style._addSetter(AutoCompleteBox.MinimumPrefixLengthProperty, value);
public static Style<AutoCompleteBox> MinimumPrefixLength(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static Style<AutoCompleteBox> MinimumPopulateDelay(this Style<AutoCompleteBox> style, TimeSpan value)
=> style._addSetter(AutoCompleteBox.MinimumPopulateDelayProperty, value);
public static Style<AutoCompleteBox> MinimumPopulateDelay(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static Style<AutoCompleteBox> MaxDropDownHeight(this Style<AutoCompleteBox> style, Double value)
=> style._addSetter(AutoCompleteBox.MaxDropDownHeightProperty, value);
public static Style<AutoCompleteBox> MaxDropDownHeight(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static Style<AutoCompleteBox> IsTextCompletionEnabled(this Style<AutoCompleteBox> style, Boolean value)
=> style._addSetter(AutoCompleteBox.IsTextCompletionEnabledProperty, value);
public static Style<AutoCompleteBox> IsTextCompletionEnabled(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static Style<AutoCompleteBox> ItemTemplate(this Style<AutoCompleteBox> style, IDataTemplate value)
=> style._addSetter(AutoCompleteBox.ItemTemplateProperty, value);
public static Style<AutoCompleteBox> ItemTemplate(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.ItemTemplateProperty, binding);
public static Style<AutoCompleteBox> IsDropDownOpen(this Style<AutoCompleteBox> style, Boolean value)
=> style._addSetter(AutoCompleteBox.IsDropDownOpenProperty, value);
public static Style<AutoCompleteBox> IsDropDownOpen(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.IsDropDownOpenProperty, binding);
public static Style<AutoCompleteBox> SelectedItem(this Style<AutoCompleteBox> style, Object value)
=> style._addSetter(AutoCompleteBox.SelectedItemProperty, value);
public static Style<AutoCompleteBox> SelectedItem(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.SelectedItemProperty, binding);
public static Style<AutoCompleteBox> Text(this Style<AutoCompleteBox> style, String value)
=> style._addSetter(AutoCompleteBox.TextProperty, value);
public static Style<AutoCompleteBox> Text(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.TextProperty, binding);
public static Style<AutoCompleteBox> FilterMode(this Style<AutoCompleteBox> style, AutoCompleteFilterMode value)
=> style._addSetter(AutoCompleteBox.FilterModeProperty, value);
public static Style<AutoCompleteBox> FilterMode(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.FilterModeProperty, binding);
public static Style<AutoCompleteBox> ItemFilter(this Style<AutoCompleteBox> style, AutoCompleteFilterPredicate<Object> value)
=> style._addSetter(AutoCompleteBox.ItemFilterProperty, value);
public static Style<AutoCompleteBox> ItemFilter(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.ItemFilterProperty, binding);
public static Style<AutoCompleteBox> TextFilter(this Style<AutoCompleteBox> style, AutoCompleteFilterPredicate<String> value)
=> style._addSetter(AutoCompleteBox.TextFilterProperty, value);
public static Style<AutoCompleteBox> TextFilter(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.TextFilterProperty, binding);
public static Style<AutoCompleteBox> ItemSelector(this Style<AutoCompleteBox> style, AutoCompleteSelector<Object> value)
=> style._addSetter(AutoCompleteBox.ItemSelectorProperty, value);
public static Style<AutoCompleteBox> ItemSelector(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.ItemSelectorProperty, binding);
public static Style<AutoCompleteBox> TextSelector(this Style<AutoCompleteBox> style, AutoCompleteSelector<String> value)
=> style._addSetter(AutoCompleteBox.TextSelectorProperty, value);
public static Style<AutoCompleteBox> TextSelector(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.TextSelectorProperty, binding);
public static Style<AutoCompleteBox> ItemsSource(this Style<AutoCompleteBox> style, IEnumerable value)
=> style._addSetter(AutoCompleteBox.ItemsSourceProperty, value);
public static Style<AutoCompleteBox> ItemsSource(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.ItemsSourceProperty, binding);
public static Style<AutoCompleteBox> AsyncPopulator(this Style<AutoCompleteBox> style, Func<String,CancellationToken,Task<IEnumerable<Object>>> value)
=> style._addSetter(AutoCompleteBox.AsyncPopulatorProperty, value);
public static Style<AutoCompleteBox> AsyncPopulator(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.AsyncPopulatorProperty, binding);
public static Style<AutoCompleteBox> MaxLength(this Style<AutoCompleteBox> style, Int32 value)
=> style._addSetter(AutoCompleteBox.MaxLengthProperty, value);
public static Style<AutoCompleteBox> MaxLength(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.MaxLengthProperty, binding);
public static Style<AutoCompleteBox> InnerLeftContent(this Style<AutoCompleteBox> style, Object value)
=> style._addSetter(AutoCompleteBox.InnerLeftContentProperty, value);
public static Style<AutoCompleteBox> InnerLeftContent(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.InnerLeftContentProperty, binding);
public static Style<AutoCompleteBox> InnerRightContent(this Style<AutoCompleteBox> style, Object value)
=> style._addSetter(AutoCompleteBox.InnerRightContentProperty, value);
public static Style<AutoCompleteBox> InnerRightContent(this Style<AutoCompleteBox> style, IBinding binding)
=> style._addSetter(AutoCompleteBox.InnerRightContentProperty, binding);
}

