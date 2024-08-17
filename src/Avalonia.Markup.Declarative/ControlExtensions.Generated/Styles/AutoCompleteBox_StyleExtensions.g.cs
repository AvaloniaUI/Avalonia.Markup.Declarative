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
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, value);
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, value);
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, value);
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, value);
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, value);
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, value);
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, value);
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, value);
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);
public static Style<T> SelectedItem<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, value);
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, value);
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);
public static Style<T> FilterMode<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, value);
public static Style<T> FilterMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);
public static Style<T> ItemFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, value);
public static Style<T> ItemFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);
public static Style<T> TextFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, value);
public static Style<T> TextFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);
public static Style<T> ItemSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, value);
public static Style<T> ItemSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);
public static Style<T> TextSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, value);
public static Style<T> TextSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, value);
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);
public static Style<T> AsyncPopulator<T>(this Style<T> style, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, value);
public static Style<T> AsyncPopulator<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, value);
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, value);
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, value);
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);
}

