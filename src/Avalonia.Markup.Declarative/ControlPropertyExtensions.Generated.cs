#nullable enable
using Avalonia;
using Avalonia.Animation;
using Avalonia.Animation.Easings;
using Avalonia.Collections;
using Avalonia.Controls;
using Avalonia.Controls.Documents;
using Avalonia.Controls.Notifications;
using Avalonia.Controls.Presenters;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Primitives.PopupPositioning;
using Avalonia.Controls.Selection;
using Avalonia.Controls.Shapes;
using Avalonia.Controls.Templates;
using Avalonia.Data;
using Avalonia.Data.Converters;
using Avalonia.Input;
using Avalonia.Input.GestureRecognizers;
using Avalonia.Layout;
using Avalonia.Media;
using Avalonia.Media.Imaging;
using Avalonia.Platform;
using Avalonia.Styling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Avalonia.Markup.Declarative;
public static partial class ApplicationExtensions
{
public static Application DataContext(this Application control, IBinding binding)
   => control._set(Application.DataContextProperty, binding);
public static Application DataContext(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Application.DataContextProperty, avaloniaProperty, bindingMode, converter);
public static Application DataContext(this Application control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.DataContextProperty, func, expression);
public static Application DataContext(this Application control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static Application DataContext<TValue>(this Application control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Application RequestedThemeVariant(this Application control, IBinding binding)
   => control._set(Application.RequestedThemeVariantProperty, binding);
public static Application RequestedThemeVariant(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Application.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter);
public static Application RequestedThemeVariant(this Application control, Func<ThemeVariant> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.RequestedThemeVariantProperty, func, expression);
public static Application RequestedThemeVariant(this Application control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static Application RequestedThemeVariant<TValue>(this Application control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Application Name(this Application control, IBinding binding)
   => control._set(Application.NameProperty, binding);
public static Application Name(this Application control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Application.NameProperty, avaloniaProperty, bindingMode, converter);
public static Application Name(this Application control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Application.NameProperty, func, expression);
public static Application Name(this Application control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static Application Name<TValue>(this Application control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Application.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class AutoCompleteBoxExtensions
{
public static AutoCompleteBox Watermark(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.WatermarkProperty, binding);
public static AutoCompleteBox Watermark(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.WatermarkProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox Watermark(this AutoCompleteBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.WatermarkProperty, func, expression);
public static AutoCompleteBox Watermark(this AutoCompleteBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox Watermark<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, binding);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.MinimumPrefixLengthProperty, func, expression);
public static AutoCompleteBox MinimumPrefixLength(this AutoCompleteBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox MinimumPrefixLength<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, binding);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.MinimumPopulateDelayProperty, func, expression);
public static AutoCompleteBox MinimumPopulateDelay(this AutoCompleteBox control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox MinimumPopulateDelay<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, binding);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.MaxDropDownHeightProperty, func, expression);
public static AutoCompleteBox MaxDropDownHeight(this AutoCompleteBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox MaxDropDownHeight<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, binding);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.IsTextCompletionEnabledProperty, func, expression);
public static AutoCompleteBox IsTextCompletionEnabled(this AutoCompleteBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox IsTextCompletionEnabled<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.ItemTemplateProperty, binding);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.ItemTemplateProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.ItemTemplateProperty, func, expression);
public static AutoCompleteBox ItemTemplate(this AutoCompleteBox control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemTemplate<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, binding);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.IsDropDownOpenProperty, func, expression);
public static AutoCompleteBox IsDropDownOpen(this AutoCompleteBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox IsDropDownOpen<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.SelectedItemProperty, binding);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.SelectedItemProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.SelectedItemProperty, func, expression);
public static AutoCompleteBox SelectedItem(this AutoCompleteBox control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox SelectedItem<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox Text(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.TextProperty, binding);
public static AutoCompleteBox Text(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.TextProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox Text(this AutoCompleteBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.TextProperty, func, expression);
public static AutoCompleteBox Text(this AutoCompleteBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox Text<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.FilterModeProperty, binding);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.FilterModeProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, Func<AutoCompleteFilterMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.FilterModeProperty, func, expression);
public static AutoCompleteBox FilterMode(this AutoCompleteBox control, AutoCompleteFilterMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox FilterMode<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.ItemFilterProperty, binding);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.ItemFilterProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, Func<AutoCompleteFilterPredicate<Object>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.ItemFilterProperty, func, expression);
public static AutoCompleteBox ItemFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemFilter<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterPredicate<Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.TextFilterProperty, binding);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.TextFilterProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, Func<AutoCompleteFilterPredicate<String>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.TextFilterProperty, func, expression);
public static AutoCompleteBox TextFilter(this AutoCompleteBox control, AutoCompleteFilterPredicate<String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox TextFilter<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, AutoCompleteFilterPredicate<String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.ItemSelectorProperty, binding);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.ItemSelectorProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, Func<AutoCompleteSelector<Object>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.ItemSelectorProperty, func, expression);
public static AutoCompleteBox ItemSelector(this AutoCompleteBox control, AutoCompleteSelector<Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemSelector<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, AutoCompleteSelector<Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.TextSelectorProperty, binding);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.TextSelectorProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, Func<AutoCompleteSelector<String>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.TextSelectorProperty, func, expression);
public static AutoCompleteBox TextSelector(this AutoCompleteBox control, AutoCompleteSelector<String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox TextSelector<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, AutoCompleteSelector<String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemsSource(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.ItemsSourceProperty, binding);
public static AutoCompleteBox ItemsSource(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.ItemsSourceProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox ItemsSource(this AutoCompleteBox control, Func<IEnumerable> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.ItemsSourceProperty, func, expression);
public static AutoCompleteBox ItemsSource(this AutoCompleteBox control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox ItemsSource<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, IBinding binding)
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, binding);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, avaloniaProperty, bindingMode, converter);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, Func<Func<String,CancellationToken,Task<IEnumerable<Object>>>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AutoCompleteBox.AsyncPopulatorProperty, func, expression);
public static AutoCompleteBox AsyncPopulator(this AutoCompleteBox control, Func<String,CancellationToken,Task<IEnumerable<Object>>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = value, bindingMode, converter, bindingSource);
public static AutoCompleteBox AsyncPopulator<TValue>(this AutoCompleteBox control, TValue value, FuncValueConverter<TValue, Func<String,CancellationToken,Task<IEnumerable<Object>>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class BorderExtensions
{
public static Border Background(this Border control, IBinding binding)
   => control._set(Border.BackgroundProperty, binding);
public static Border Background(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Border.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static Border Background(this Border control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BackgroundProperty, func, expression);
public static Border Background(this Border control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static Border Background<TValue>(this Border control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Border BorderBrush(this Border control, IBinding binding)
   => control._set(Border.BorderBrushProperty, binding);
public static Border BorderBrush(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Border.BorderBrushProperty, avaloniaProperty, bindingMode, converter);
public static Border BorderBrush(this Border control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BorderBrushProperty, func, expression);
public static Border BorderBrush(this Border control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static Border BorderBrush<TValue>(this Border control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Border BorderThickness(this Border control, IBinding binding)
   => control._set(Border.BorderThicknessProperty, binding);
public static Border BorderThickness(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Border.BorderThicknessProperty, avaloniaProperty, bindingMode, converter);
public static Border BorderThickness(this Border control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BorderThicknessProperty, func, expression);
public static Border BorderThickness(this Border control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static Border BorderThickness<TValue>(this Border control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border BorderThickness(this Border control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static Border BorderThickness(this Border control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static Border BorderThickness(this Border control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static Border CornerRadius(this Border control, IBinding binding)
   => control._set(Border.CornerRadiusProperty, binding);
public static Border CornerRadius(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Border.CornerRadiusProperty, avaloniaProperty, bindingMode, converter);
public static Border CornerRadius(this Border control, Func<CornerRadius> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.CornerRadiusProperty, func, expression);
public static Border CornerRadius(this Border control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static Border CornerRadius<TValue>(this Border control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border CornerRadius(this Border control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static Border CornerRadius(this Border control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static Border CornerRadius(this Border control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static Border BoxShadow(this Border control, IBinding binding)
   => control._set(Border.BoxShadowProperty, binding);
public static Border BoxShadow(this Border control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Border.BoxShadowProperty, avaloniaProperty, bindingMode, converter);
public static Border BoxShadow(this Border control, Func<BoxShadows> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Border.BoxShadowProperty, func, expression);
public static Border BoxShadow(this Border control, BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static Border BoxShadow<TValue>(this Border control, TValue value, FuncValueConverter<TValue, BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Border.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Border BoxShadow(this Border control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static Border BoxShadow(this Border control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
}
public static partial class ButtonExtensions
{
public static Button ClickMode(this Button control, IBinding binding)
   => control._set(Button.ClickModeProperty, binding);
public static Button ClickMode(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.ClickModeProperty, avaloniaProperty, bindingMode, converter);
public static Button ClickMode(this Button control, Func<ClickMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.ClickModeProperty, func, expression);
public static Button ClickMode(this Button control, ClickMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = value, bindingMode, converter, bindingSource);
public static Button ClickMode<TValue>(this Button control, TValue value, FuncValueConverter<TValue, ClickMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.ClickModeProperty, ps, () => control.ClickMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button Command(this Button control, IBinding binding)
   => control._set(Button.CommandProperty, binding);
public static Button Command(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.CommandProperty, avaloniaProperty, bindingMode, converter);
public static Button Command(this Button control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.CommandProperty, func, expression);
public static Button Command(this Button control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static Button Command<TValue>(this Button control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button HotKey(this Button control, IBinding binding)
   => control._set(Button.HotKeyProperty, binding);
public static Button HotKey(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.HotKeyProperty, avaloniaProperty, bindingMode, converter);
public static Button HotKey(this Button control, Func<KeyGesture> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.HotKeyProperty, func, expression);
public static Button HotKey(this Button control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static Button HotKey<TValue>(this Button control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button CommandParameter(this Button control, IBinding binding)
   => control._set(Button.CommandParameterProperty, binding);
public static Button CommandParameter(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static Button CommandParameter(this Button control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.CommandParameterProperty, func, expression);
public static Button CommandParameter(this Button control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static Button CommandParameter<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button IsDefault(this Button control, IBinding binding)
   => control._set(Button.IsDefaultProperty, binding);
public static Button IsDefault(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.IsDefaultProperty, avaloniaProperty, bindingMode, converter);
public static Button IsDefault(this Button control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.IsDefaultProperty, func, expression);
public static Button IsDefault(this Button control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = value, bindingMode, converter, bindingSource);
public static Button IsDefault<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsDefaultProperty, ps, () => control.IsDefault = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button IsCancel(this Button control, IBinding binding)
   => control._set(Button.IsCancelProperty, binding);
public static Button IsCancel(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.IsCancelProperty, avaloniaProperty, bindingMode, converter);
public static Button IsCancel(this Button control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.IsCancelProperty, func, expression);
public static Button IsCancel(this Button control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = value, bindingMode, converter, bindingSource);
public static Button IsCancel<TValue>(this Button control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.IsCancelProperty, ps, () => control.IsCancel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Button Flyout(this Button control, IBinding binding)
   => control._set(Button.FlyoutProperty, binding);
public static Button Flyout(this Button control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Button.FlyoutProperty, avaloniaProperty, bindingMode, converter);
public static Button Flyout(this Button control, Func<FlyoutBase> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Button.FlyoutProperty, func, expression);
public static Button Flyout(this Button control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static Button Flyout<TValue>(this Button control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Button.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ButtonSpinnerExtensions
{
public static ButtonSpinner AllowSpin(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.AllowSpinProperty, binding);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ButtonSpinner.AllowSpinProperty, avaloniaProperty, bindingMode, converter);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.AllowSpinProperty, func, expression);
public static ButtonSpinner AllowSpin(this ButtonSpinner control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static ButtonSpinner AllowSpin<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, binding);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.ShowButtonSpinnerProperty, func, expression);
public static ButtonSpinner ShowButtonSpinner(this ButtonSpinner control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static ButtonSpinner ShowButtonSpinner<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, IBinding binding)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, binding);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Func<Location> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ButtonSpinner.ButtonSpinnerLocationProperty, func, expression);
public static ButtonSpinner ButtonSpinnerLocation(this ButtonSpinner control, Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static ButtonSpinner ButtonSpinnerLocation<TValue>(this ButtonSpinner control, TValue value, FuncValueConverter<TValue, Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ButtonSpinner.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CalendarDatePickerExtensions
{
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateProperty, binding);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.DisplayDateProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, Func<DateTime> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateProperty, func, expression);
public static CalendarDatePicker DisplayDate(this CalendarDatePicker control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDate<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, binding);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateStartProperty, func, expression);
public static CalendarDatePicker DisplayDateStart(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateStart<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, binding);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.DisplayDateEndProperty, func, expression);
public static CalendarDatePicker DisplayDateEnd(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker DisplayDateEnd<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, binding);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, Func<DayOfWeek> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.FirstDayOfWeekProperty, func, expression);
public static CalendarDatePicker FirstDayOfWeek(this CalendarDatePicker control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker FirstDayOfWeek<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, binding);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.IsDropDownOpenProperty, func, expression);
public static CalendarDatePicker IsDropDownOpen(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker IsDropDownOpen<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, binding);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.IsTodayHighlightedProperty, func, expression);
public static CalendarDatePicker IsTodayHighlighted(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker IsTodayHighlighted<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.SelectedDateProperty, binding);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.SelectedDateProperty, func, expression);
public static CalendarDatePicker SelectedDate(this CalendarDatePicker control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDate<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, binding);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, Func<CalendarDatePickerFormat> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.SelectedDateFormatProperty, func, expression);
public static CalendarDatePicker SelectedDateFormat(this CalendarDatePicker control, CalendarDatePickerFormat value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker SelectedDateFormat<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, CalendarDatePickerFormat> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.SelectedDateFormatProperty, ps, () => control.SelectedDateFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, binding);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.CustomDateFormatStringProperty, func, expression);
public static CalendarDatePicker CustomDateFormatString(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker CustomDateFormatString<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.CustomDateFormatStringProperty, ps, () => control.CustomDateFormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker Text(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.TextProperty, binding);
public static CalendarDatePicker Text(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.TextProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker Text(this CalendarDatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.TextProperty, func, expression);
public static CalendarDatePicker Text(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker Text<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.WatermarkProperty, binding);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.WatermarkProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.WatermarkProperty, func, expression);
public static CalendarDatePicker Watermark(this CalendarDatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker Watermark<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, binding);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.UseFloatingWatermarkProperty, func, expression);
public static CalendarDatePicker UseFloatingWatermark(this CalendarDatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker UseFloatingWatermark<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, binding);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.HorizontalContentAlignmentProperty, func, expression);
public static CalendarDatePicker HorizontalContentAlignment(this CalendarDatePicker control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker HorizontalContentAlignment<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, IBinding binding)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, binding);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarDatePicker.VerticalContentAlignmentProperty, func, expression);
public static CalendarDatePicker VerticalContentAlignment(this CalendarDatePicker control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static CalendarDatePicker VerticalContentAlignment<TValue>(this CalendarDatePicker control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarDatePicker.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CalendarExtensions
{
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, Func<DayOfWeek> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, func, expression);
public static Avalonia.Controls.Calendar FirstDayOfWeek(this Avalonia.Controls.Calendar control, DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar FirstDayOfWeek<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, func, expression);
public static Avalonia.Controls.Calendar IsTodayHighlighted(this Avalonia.Controls.Calendar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar IsTodayHighlighted<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, func, expression);
public static Avalonia.Controls.Calendar HeaderBackground(this Avalonia.Controls.Calendar control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar HeaderBackground<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, binding);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, Func<CalendarMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, func, expression);
public static Avalonia.Controls.Calendar DisplayMode(this Avalonia.Controls.Calendar control, CalendarMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayMode<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, CalendarMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, binding);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, Func<CalendarSelectionMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, func, expression);
public static Avalonia.Controls.Calendar SelectionMode(this Avalonia.Controls.Calendar control, CalendarSelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectionMode<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, CalendarSelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, binding);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, func, expression);
public static Avalonia.Controls.Calendar SelectedDate(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar SelectedDate<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, binding);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, Func<DateTime> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, func, expression);
public static Avalonia.Controls.Calendar DisplayDate(this Avalonia.Controls.Calendar control, DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDate<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, func, expression);
public static Avalonia.Controls.Calendar DisplayDateStart(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateStart<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, IBinding binding)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Func<Nullable<DateTime>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, func, expression);
public static Avalonia.Controls.Calendar DisplayDateEnd(this Avalonia.Controls.Calendar control, Nullable<DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.Calendar DisplayDateEnd<TValue>(this Avalonia.Controls.Calendar control, TValue value, FuncValueConverter<TValue, Nullable<DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CarouselExtensions
{
public static Carousel PageTransition(this Carousel control, IBinding binding)
   => control._set(Carousel.PageTransitionProperty, binding);
public static Carousel PageTransition(this Carousel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Carousel.PageTransitionProperty, avaloniaProperty, bindingMode, converter);
public static Carousel PageTransition(this Carousel control, Func<IPageTransition> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Carousel.PageTransitionProperty, func, expression);
public static Carousel PageTransition(this Carousel control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static Carousel PageTransition<TValue>(this Carousel control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Carousel.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ColumnDefinitionExtensions
{
public static ColumnDefinition MaxWidth(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.MaxWidthProperty, binding);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ColumnDefinition.MaxWidthProperty, avaloniaProperty, bindingMode, converter);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.MaxWidthProperty, func, expression);
public static ColumnDefinition MaxWidth(this ColumnDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static ColumnDefinition MaxWidth<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ColumnDefinition MinWidth(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.MinWidthProperty, binding);
public static ColumnDefinition MinWidth(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ColumnDefinition.MinWidthProperty, avaloniaProperty, bindingMode, converter);
public static ColumnDefinition MinWidth(this ColumnDefinition control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.MinWidthProperty, func, expression);
public static ColumnDefinition MinWidth(this ColumnDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static ColumnDefinition MinWidth<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ColumnDefinition Width(this ColumnDefinition control, IBinding binding)
   => control._set(ColumnDefinition.WidthProperty, binding);
public static ColumnDefinition Width(this ColumnDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ColumnDefinition.WidthProperty, avaloniaProperty, bindingMode, converter);
public static ColumnDefinition Width(this ColumnDefinition control, Func<GridLength> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ColumnDefinition.WidthProperty, func, expression);
public static ColumnDefinition Width(this ColumnDefinition control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static ColumnDefinition Width<TValue>(this ColumnDefinition control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ColumnDefinition.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ColumnDefinition Width(this ColumnDefinition control, Double value)
   => control._set(() => control.Width = new GridLength(value));
public static ColumnDefinition Width(this ColumnDefinition control, Double value, GridUnitType type)
   => control._set(() => control.Width = new GridLength(value, type));
}
public static partial class ComboBoxExtensions
{
public static ComboBox IsDropDownOpen(this ComboBox control, IBinding binding)
   => control._set(ComboBox.IsDropDownOpenProperty, binding);
public static ComboBox IsDropDownOpen(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox IsDropDownOpen(this ComboBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.IsDropDownOpenProperty, func, expression);
public static ComboBox IsDropDownOpen(this ComboBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);
public static ComboBox IsDropDownOpen<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox MaxDropDownHeight(this ComboBox control, IBinding binding)
   => control._set(ComboBox.MaxDropDownHeightProperty, binding);
public static ComboBox MaxDropDownHeight(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox MaxDropDownHeight(this ComboBox control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.MaxDropDownHeightProperty, func, expression);
public static ComboBox MaxDropDownHeight(this ComboBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);
public static ComboBox MaxDropDownHeight<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox PlaceholderText(this ComboBox control, IBinding binding)
   => control._set(ComboBox.PlaceholderTextProperty, binding);
public static ComboBox PlaceholderText(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.PlaceholderTextProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox PlaceholderText(this ComboBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.PlaceholderTextProperty, func, expression);
public static ComboBox PlaceholderText(this ComboBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = value, bindingMode, converter, bindingSource);
public static ComboBox PlaceholderText<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderTextProperty, ps, () => control.PlaceholderText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox PlaceholderForeground(this ComboBox control, IBinding binding)
   => control._set(ComboBox.PlaceholderForegroundProperty, binding);
public static ComboBox PlaceholderForeground(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.PlaceholderForegroundProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox PlaceholderForeground(this ComboBox control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.PlaceholderForegroundProperty, func, expression);
public static ComboBox PlaceholderForeground(this ComboBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = value, bindingMode, converter, bindingSource);
public static ComboBox PlaceholderForeground<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.PlaceholderForegroundProperty, ps, () => control.PlaceholderForeground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox HorizontalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, binding);
public static ComboBox HorizontalContentAlignment(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox HorizontalContentAlignment(this ComboBox control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.HorizontalContentAlignmentProperty, func, expression);
public static ComboBox HorizontalContentAlignment(this ComboBox control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static ComboBox HorizontalContentAlignment<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ComboBox VerticalContentAlignment(this ComboBox control, IBinding binding)
   => control._set(ComboBox.VerticalContentAlignmentProperty, binding);
public static ComboBox VerticalContentAlignment(this ComboBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ComboBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ComboBox VerticalContentAlignment(this ComboBox control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ComboBox.VerticalContentAlignmentProperty, func, expression);
public static ComboBox VerticalContentAlignment(this ComboBox control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static ComboBox VerticalContentAlignment<TValue>(this ComboBox control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ComboBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ContentControlExtensions
{
public static T Content<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.ContentProperty, binding);
public static T Content<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ContentControl
   => control._set(ContentControl.ContentProperty, avaloniaProperty, bindingMode, converter);
public static T Content<T>(this T control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.ContentProperty, func, expression);
public static T Content<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static T Content<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContentTemplate<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, binding);
public static T ContentTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter);
public static T ContentTemplate<T>(this T control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.ContentTemplateProperty, func, expression);
public static T ContentTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static T ContentTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, binding);
public static T HorizontalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static T HorizontalContentAlignment<T>(this T control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.HorizontalContentAlignmentProperty, func, expression);
public static T HorizontalContentAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T>(this T control, IBinding binding) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, binding);
public static T VerticalContentAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static T VerticalContentAlignment<T>(this T control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null) where T : ContentControl
   => control._set(ContentControl.VerticalContentAlignmentProperty, func, expression);
public static T VerticalContentAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalContentAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ContentControl
=> control._setEx(ContentControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ContextMenuExtensions
{
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, binding);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, func, expression);
public static Avalonia.Controls.ContextMenu HorizontalOffset(this Avalonia.Controls.ContextMenu control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu HorizontalOffset<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, binding);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, func, expression);
public static Avalonia.Controls.ContextMenu VerticalOffset(this Avalonia.Controls.ContextMenu control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu VerticalOffset<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, Func<PopupAnchor> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, func, expression);
public static Avalonia.Controls.ContextMenu PlacementAnchor(this Avalonia.Controls.ContextMenu control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementAnchor<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, Func<PopupPositionerConstraintAdjustment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, func, expression);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment(this Avalonia.Controls.ContextMenu control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementConstraintAdjustment<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, Func<PopupGravity> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementGravityProperty, func, expression);
public static Avalonia.Controls.ContextMenu PlacementGravity(this Avalonia.Controls.ContextMenu control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementGravity<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, binding);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, Func<PlacementMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementProperty, func, expression);
public static Avalonia.Controls.ContextMenu Placement(this Avalonia.Controls.ContextMenu control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu Placement<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Func<Nullable<Rect>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementRectProperty, func, expression);
public static Avalonia.Controls.ContextMenu PlacementRect(this Avalonia.Controls.ContextMenu control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementRect<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, binding);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, func, expression);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint(this Avalonia.Controls.ContextMenu control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu WindowManagerAddShadowHint<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, IBinding binding)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, binding);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Controls.ContextMenu.PlacementTargetProperty, func, expression);
public static Avalonia.Controls.ContextMenu PlacementTarget(this Avalonia.Controls.ContextMenu control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static Avalonia.Controls.ContextMenu PlacementTarget<TValue>(this Avalonia.Controls.ContextMenu control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Controls.ContextMenu.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ControlExtensions
{
public static T FocusAdorner<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.FocusAdornerProperty, binding);
public static T FocusAdorner<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Control
   => control._set(Control.FocusAdornerProperty, avaloniaProperty, bindingMode, converter);
public static T FocusAdorner<T>(this T control, Func<ITemplate<Control>> func, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.FocusAdornerProperty, func, expression);
public static T FocusAdorner<T>(this T control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = value, bindingMode, converter, bindingSource);
public static T FocusAdorner<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.FocusAdornerProperty, ps, () => control.FocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Tag<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.TagProperty, binding);
public static T Tag<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Control
   => control._set(Control.TagProperty, avaloniaProperty, bindingMode, converter);
public static T Tag<T>(this T control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.TagProperty, func, expression);
public static T Tag<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.TagProperty, ps, () => control.Tag = value, bindingMode, converter, bindingSource);
public static T Tag<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.TagProperty, ps, () => control.Tag = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextMenu<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.ContextMenuProperty, binding);
public static T ContextMenu<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Control
   => control._set(Control.ContextMenuProperty, avaloniaProperty, bindingMode, converter);
public static T ContextMenu<T>(this T control, Func<Avalonia.Controls.ContextMenu> func, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.ContextMenuProperty, func, expression);
public static T ContextMenu<T>(this T control, Avalonia.Controls.ContextMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextMenuProperty, ps, () => control.ContextMenu = value, bindingMode, converter, bindingSource);
public static T ContextMenu<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ContextMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextMenuProperty, ps, () => control.ContextMenu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ContextFlyout<T>(this T control, IBinding binding) where T : Control
   => control._set(Control.ContextFlyoutProperty, binding);
public static T ContextFlyout<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Control
   => control._set(Control.ContextFlyoutProperty, avaloniaProperty, bindingMode, converter);
public static T ContextFlyout<T>(this T control, Func<FlyoutBase> func, [CallerArgumentExpression("func")] string? expression = null) where T : Control
   => control._set(Control.ContextFlyoutProperty, func, expression);
public static T ContextFlyout<T>(this T control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = value, bindingMode, converter, bindingSource);
public static T ContextFlyout<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Control
=> control._setEx(Control.ContextFlyoutProperty, ps, () => control.ContextFlyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DataValidationErrorsExtensions
{
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IBinding binding)
   => control._set(DataValidationErrors.ErrorTemplateProperty, binding);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DataValidationErrors.ErrorTemplateProperty, avaloniaProperty, bindingMode, converter);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DataValidationErrors.ErrorTemplateProperty, func, expression);
public static DataValidationErrors ErrorTemplate(this DataValidationErrors control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = value, bindingMode, converter, bindingSource);
public static DataValidationErrors ErrorTemplate<TValue>(this DataValidationErrors control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.ErrorTemplateProperty, ps, () => control.ErrorTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DataValidationErrors Owner(this DataValidationErrors control, IBinding binding)
   => control._set(DataValidationErrors.OwnerProperty, binding);
public static DataValidationErrors Owner(this DataValidationErrors control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DataValidationErrors.OwnerProperty, avaloniaProperty, bindingMode, converter);
public static DataValidationErrors Owner(this DataValidationErrors control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DataValidationErrors.OwnerProperty, func, expression);
public static DataValidationErrors Owner(this DataValidationErrors control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = value, bindingMode, converter, bindingSource);
public static DataValidationErrors Owner<TValue>(this DataValidationErrors control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DataValidationErrors.OwnerProperty, ps, () => control.Owner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DatePickerExtensions
{
public static DatePicker DayFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.DayFormatProperty, binding);
public static DatePicker DayFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.DayFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker DayFormat(this DatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.DayFormatProperty, func, expression);
public static DatePicker DayFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static DatePicker DayFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker DayVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.DayVisibleProperty, binding);
public static DatePicker DayVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.DayVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker DayVisible(this DatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.DayVisibleProperty, func, expression);
public static DatePicker DayVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static DatePicker DayVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MaxYear(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MaxYearProperty, binding);
public static DatePicker MaxYear(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.MaxYearProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker MaxYear(this DatePicker control, Func<DateTimeOffset> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MaxYearProperty, func, expression);
public static DatePicker MaxYear(this DatePicker control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static DatePicker MaxYear<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MinYear(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MinYearProperty, binding);
public static DatePicker MinYear(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.MinYearProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker MinYear(this DatePicker control, Func<DateTimeOffset> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MinYearProperty, func, expression);
public static DatePicker MinYear(this DatePicker control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static DatePicker MinYear<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MonthFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MonthFormatProperty, binding);
public static DatePicker MonthFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.MonthFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker MonthFormat(this DatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MonthFormatProperty, func, expression);
public static DatePicker MonthFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static DatePicker MonthFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker MonthVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.MonthVisibleProperty, binding);
public static DatePicker MonthVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.MonthVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker MonthVisible(this DatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.MonthVisibleProperty, func, expression);
public static DatePicker MonthVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static DatePicker MonthVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker YearFormat(this DatePicker control, IBinding binding)
   => control._set(DatePicker.YearFormatProperty, binding);
public static DatePicker YearFormat(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.YearFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker YearFormat(this DatePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.YearFormatProperty, func, expression);
public static DatePicker YearFormat(this DatePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static DatePicker YearFormat<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker YearVisible(this DatePicker control, IBinding binding)
   => control._set(DatePicker.YearVisibleProperty, binding);
public static DatePicker YearVisible(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.YearVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker YearVisible(this DatePicker control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.YearVisibleProperty, func, expression);
public static DatePicker YearVisible(this DatePicker control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static DatePicker YearVisible<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePicker SelectedDate(this DatePicker control, IBinding binding)
   => control._set(DatePicker.SelectedDateProperty, binding);
public static DatePicker SelectedDate(this DatePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePicker.SelectedDateProperty, avaloniaProperty, bindingMode, converter);
public static DatePicker SelectedDate(this DatePicker control, Func<Nullable<DateTimeOffset>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePicker.SelectedDateProperty, func, expression);
public static DatePicker SelectedDate(this DatePicker control, Nullable<DateTimeOffset> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);
public static DatePicker SelectedDate<TValue>(this DatePicker control, TValue value, FuncValueConverter<TValue, Nullable<DateTimeOffset>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePicker.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DatePickerPresenterExtensions
{
public static DatePickerPresenter Date(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DateProperty, binding);
public static DatePickerPresenter Date(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.DateProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter Date(this DatePickerPresenter control, Func<DateTimeOffset> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DateProperty, func, expression);
public static DatePickerPresenter Date(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter Date<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DateProperty, ps, () => control.Date = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DayFormatProperty, binding);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.DayFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DayFormatProperty, func, expression);
public static DatePickerPresenter DayFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter DayFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayFormatProperty, ps, () => control.DayFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.DayVisibleProperty, binding);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.DayVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.DayVisibleProperty, func, expression);
public static DatePickerPresenter DayVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter DayVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.DayVisibleProperty, ps, () => control.DayVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MaxYearProperty, binding);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.MaxYearProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, Func<DateTimeOffset> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MaxYearProperty, func, expression);
public static DatePickerPresenter MaxYear(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MaxYear<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MaxYearProperty, ps, () => control.MaxYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MinYearProperty, binding);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.MinYearProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, Func<DateTimeOffset> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MinYearProperty, func, expression);
public static DatePickerPresenter MinYear(this DatePickerPresenter control, DateTimeOffset value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MinYear<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, DateTimeOffset> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MinYearProperty, ps, () => control.MinYear = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MonthFormatProperty, binding);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.MonthFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MonthFormatProperty, func, expression);
public static DatePickerPresenter MonthFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthFormatProperty, ps, () => control.MonthFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.MonthVisibleProperty, binding);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.MonthVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.MonthVisibleProperty, func, expression);
public static DatePickerPresenter MonthVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter MonthVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.MonthVisibleProperty, ps, () => control.MonthVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.YearFormatProperty, binding);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.YearFormatProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.YearFormatProperty, func, expression);
public static DatePickerPresenter YearFormat(this DatePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter YearFormat<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearFormatProperty, ps, () => control.YearFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, IBinding binding)
   => control._set(DatePickerPresenter.YearVisibleProperty, binding);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DatePickerPresenter.YearVisibleProperty, avaloniaProperty, bindingMode, converter);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DatePickerPresenter.YearVisibleProperty, func, expression);
public static DatePickerPresenter YearVisible(this DatePickerPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = value, bindingMode, converter, bindingSource);
public static DatePickerPresenter YearVisible<TValue>(this DatePickerPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DatePickerPresenter.YearVisibleProperty, ps, () => control.YearVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TimePickerExtensions
{
public static TimePicker MinuteIncrement(this TimePicker control, IBinding binding)
   => control._set(TimePicker.MinuteIncrementProperty, binding);
public static TimePicker MinuteIncrement(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePicker.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter);
public static TimePicker MinuteIncrement(this TimePicker control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.MinuteIncrementProperty, func, expression);
public static TimePicker MinuteIncrement(this TimePicker control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static TimePicker MinuteIncrement<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePicker ClockIdentifier(this TimePicker control, IBinding binding)
   => control._set(TimePicker.ClockIdentifierProperty, binding);
public static TimePicker ClockIdentifier(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePicker.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter);
public static TimePicker ClockIdentifier(this TimePicker control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.ClockIdentifierProperty, func, expression);
public static TimePicker ClockIdentifier(this TimePicker control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static TimePicker ClockIdentifier<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePicker SelectedTime(this TimePicker control, IBinding binding)
   => control._set(TimePicker.SelectedTimeProperty, binding);
public static TimePicker SelectedTime(this TimePicker control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePicker.SelectedTimeProperty, avaloniaProperty, bindingMode, converter);
public static TimePicker SelectedTime(this TimePicker control, Func<Nullable<TimeSpan>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePicker.SelectedTimeProperty, func, expression);
public static TimePicker SelectedTime(this TimePicker control, Nullable<TimeSpan> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = value, bindingMode, converter, bindingSource);
public static TimePicker SelectedTime<TValue>(this TimePicker control, TValue value, FuncValueConverter<TValue, Nullable<TimeSpan>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePicker.SelectedTimeProperty, ps, () => control.SelectedTime = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TimePickerPresenterExtensions
{
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, binding);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, avaloniaProperty, bindingMode, converter);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.MinuteIncrementProperty, func, expression);
public static TimePickerPresenter MinuteIncrement(this TimePickerPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter MinuteIncrement<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.MinuteIncrementProperty, ps, () => control.MinuteIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, binding);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, avaloniaProperty, bindingMode, converter);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.ClockIdentifierProperty, func, expression);
public static TimePickerPresenter ClockIdentifier(this TimePickerPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter ClockIdentifier<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.ClockIdentifierProperty, ps, () => control.ClockIdentifier = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TimePickerPresenter Time(this TimePickerPresenter control, IBinding binding)
   => control._set(TimePickerPresenter.TimeProperty, binding);
public static TimePickerPresenter Time(this TimePickerPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TimePickerPresenter.TimeProperty, avaloniaProperty, bindingMode, converter);
public static TimePickerPresenter Time(this TimePickerPresenter control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TimePickerPresenter.TimeProperty, func, expression);
public static TimePickerPresenter Time(this TimePickerPresenter control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = value, bindingMode, converter, bindingSource);
public static TimePickerPresenter Time<TValue>(this TimePickerPresenter control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TimePickerPresenter.TimeProperty, ps, () => control.Time = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DecoratorExtensions
{
public static Decorator Child(this Decorator control, IBinding binding)
   => control._set(Decorator.ChildProperty, binding);
public static Decorator Child(this Decorator control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Decorator.ChildProperty, avaloniaProperty, bindingMode, converter);
public static Decorator Child(this Decorator control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Decorator.ChildProperty, func, expression);
public static Decorator Child(this Decorator control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Decorator Child<TValue>(this Decorator control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Decorator Padding(this Decorator control, IBinding binding)
   => control._set(Decorator.PaddingProperty, binding);
public static Decorator Padding(this Decorator control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Decorator.PaddingProperty, avaloniaProperty, bindingMode, converter);
public static Decorator Padding(this Decorator control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Decorator.PaddingProperty, func, expression);
public static Decorator Padding(this Decorator control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static Decorator Padding<TValue>(this Decorator control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Decorator.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Decorator Padding(this Decorator control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static Decorator Padding(this Decorator control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static Decorator Padding(this Decorator control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
}
public static partial class DefinitionBaseExtensions
{
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, IBinding binding)
   => control._set(DefinitionBase.SharedSizeGroupProperty, binding);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DefinitionBase.SharedSizeGroupProperty, avaloniaProperty, bindingMode, converter);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DefinitionBase.SharedSizeGroupProperty, func, expression);
public static DefinitionBase SharedSizeGroup(this DefinitionBase control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = value, bindingMode, converter, bindingSource);
public static DefinitionBase SharedSizeGroup<TValue>(this DefinitionBase control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DefinitionBase.SharedSizeGroupProperty, ps, () => control.SharedSizeGroup = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DockPanelExtensions
{
public static DockPanel LastChildFill(this DockPanel control, IBinding binding)
   => control._set(DockPanel.LastChildFillProperty, binding);
public static DockPanel LastChildFill(this DockPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DockPanel.LastChildFillProperty, avaloniaProperty, bindingMode, converter);
public static DockPanel LastChildFill(this DockPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DockPanel.LastChildFillProperty, func, expression);
public static DockPanel LastChildFill(this DockPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = value, bindingMode, converter, bindingSource);
public static DockPanel LastChildFill<TValue>(this DockPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DockPanel.LastChildFillProperty, ps, () => control.LastChildFill = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ExpanderExtensions
{
public static Expander ContentTransition(this Expander control, IBinding binding)
   => control._set(Expander.ContentTransitionProperty, binding);
public static Expander ContentTransition(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Expander.ContentTransitionProperty, avaloniaProperty, bindingMode, converter);
public static Expander ContentTransition(this Expander control, Func<IPageTransition> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.ContentTransitionProperty, func, expression);
public static Expander ContentTransition(this Expander control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = value, bindingMode, converter, bindingSource);
public static Expander ContentTransition<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ContentTransitionProperty, ps, () => control.ContentTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Expander ExpandDirection(this Expander control, IBinding binding)
   => control._set(Expander.ExpandDirectionProperty, binding);
public static Expander ExpandDirection(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Expander.ExpandDirectionProperty, avaloniaProperty, bindingMode, converter);
public static Expander ExpandDirection(this Expander control, Func<ExpandDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.ExpandDirectionProperty, func, expression);
public static Expander ExpandDirection(this Expander control, ExpandDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = value, bindingMode, converter, bindingSource);
public static Expander ExpandDirection<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, ExpandDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.ExpandDirectionProperty, ps, () => control.ExpandDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Expander IsExpanded(this Expander control, IBinding binding)
   => control._set(Expander.IsExpandedProperty, binding);
public static Expander IsExpanded(this Expander control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Expander.IsExpandedProperty, avaloniaProperty, bindingMode, converter);
public static Expander IsExpanded(this Expander control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Expander.IsExpandedProperty, func, expression);
public static Expander IsExpanded(this Expander control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static Expander IsExpanded<TValue>(this Expander control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Expander.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ExperimentalAcrylicBorderExtensions
{
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, binding);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Func<CornerRadius> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicBorder.CornerRadiusProperty, func, expression);
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicBorder CornerRadius<TValue>(this ExperimentalAcrylicBorder control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ExperimentalAcrylicBorder CornerRadius(this ExperimentalAcrylicBorder control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, IBinding binding)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, binding);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, Func<ExperimentalAcrylicMaterial> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicBorder.MaterialProperty, func, expression);
public static ExperimentalAcrylicBorder Material(this ExperimentalAcrylicBorder control, ExperimentalAcrylicMaterial value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicBorder Material<TValue>(this ExperimentalAcrylicBorder control, TValue value, FuncValueConverter<TValue, ExperimentalAcrylicMaterial> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicBorder.MaterialProperty, ps, () => control.Material = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class FlyoutExtensions
{
public static Flyout Content(this Flyout control, IBinding binding)
   => control._set(Flyout.ContentProperty, binding);
public static Flyout Content(this Flyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Flyout.ContentProperty, avaloniaProperty, bindingMode, converter);
public static Flyout Content(this Flyout control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Flyout.ContentProperty, func, expression);
public static Flyout Content(this Flyout control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Flyout.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static Flyout Content<TValue>(this Flyout control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Flyout.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Flyout FlyoutPresenterTheme(this Flyout control, IBinding binding)
   => control._set(Flyout.FlyoutPresenterThemeProperty, binding);
public static Flyout FlyoutPresenterTheme(this Flyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Flyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter);
public static Flyout FlyoutPresenterTheme(this Flyout control, Func<ControlTheme> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Flyout.FlyoutPresenterThemeProperty, func, expression);
public static Flyout FlyoutPresenterTheme(this Flyout control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value, bindingMode, converter, bindingSource);
public static Flyout FlyoutPresenterTheme<TValue>(this Flyout control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Flyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class MenuFlyoutExtensions
{
public static MenuFlyout ItemsSource(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemsSourceProperty, binding);
public static MenuFlyout ItemsSource(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuFlyout.ItemsSourceProperty, avaloniaProperty, bindingMode, converter);
public static MenuFlyout ItemsSource(this MenuFlyout control, Func<IEnumerable> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemsSourceProperty, func, expression);
public static MenuFlyout ItemsSource(this MenuFlyout control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemsSource<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout ItemTemplate(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemTemplateProperty, binding);
public static MenuFlyout ItemTemplate(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuFlyout.ItemTemplateProperty, avaloniaProperty, bindingMode, converter);
public static MenuFlyout ItemTemplate(this MenuFlyout control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemTemplateProperty, func, expression);
public static MenuFlyout ItemTemplate(this MenuFlyout control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemTemplate<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.ItemContainerThemeProperty, binding);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuFlyout.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, Func<ControlTheme> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.ItemContainerThemeProperty, func, expression);
public static MenuFlyout ItemContainerTheme(this MenuFlyout control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static MenuFlyout ItemContainerTheme<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, IBinding binding)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, binding);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, avaloniaProperty, bindingMode, converter);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, Func<ControlTheme> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuFlyout.FlyoutPresenterThemeProperty, func, expression);
public static MenuFlyout FlyoutPresenterTheme(this MenuFlyout control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = value, bindingMode, converter, bindingSource);
public static MenuFlyout FlyoutPresenterTheme<TValue>(this MenuFlyout control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuFlyout.FlyoutPresenterThemeProperty, ps, () => control.FlyoutPresenterTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GridExtensions
{
public static Grid ShowGridLines(this Grid control, IBinding binding)
   => control._set(Grid.ShowGridLinesProperty, binding);
public static Grid ShowGridLines(this Grid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Grid.ShowGridLinesProperty, avaloniaProperty, bindingMode, converter);
public static Grid ShowGridLines(this Grid control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Grid.ShowGridLinesProperty, func, expression);
public static Grid ShowGridLines(this Grid control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = value, bindingMode, converter, bindingSource);
public static Grid ShowGridLines<TValue>(this Grid control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Grid.ShowGridLinesProperty, ps, () => control.ShowGridLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GridSplitterExtensions
{
public static GridSplitter ResizeDirection(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.ResizeDirectionProperty, binding);
public static GridSplitter ResizeDirection(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.ResizeDirectionProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter ResizeDirection(this GridSplitter control, Func<GridResizeDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.ResizeDirectionProperty, func, expression);
public static GridSplitter ResizeDirection(this GridSplitter control, GridResizeDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = value, bindingMode, converter, bindingSource);
public static GridSplitter ResizeDirection<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, GridResizeDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ResizeDirectionProperty, ps, () => control.ResizeDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GridSplitter ResizeBehavior(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.ResizeBehaviorProperty, binding);
public static GridSplitter ResizeBehavior(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.ResizeBehaviorProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter ResizeBehavior(this GridSplitter control, Func<GridResizeBehavior> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.ResizeBehaviorProperty, func, expression);
public static GridSplitter ResizeBehavior(this GridSplitter control, GridResizeBehavior value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = value, bindingMode, converter, bindingSource);
public static GridSplitter ResizeBehavior<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, GridResizeBehavior> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ResizeBehaviorProperty, ps, () => control.ResizeBehavior = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GridSplitter ShowsPreview(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.ShowsPreviewProperty, binding);
public static GridSplitter ShowsPreview(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.ShowsPreviewProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter ShowsPreview(this GridSplitter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.ShowsPreviewProperty, func, expression);
public static GridSplitter ShowsPreview(this GridSplitter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = value, bindingMode, converter, bindingSource);
public static GridSplitter ShowsPreview<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.ShowsPreviewProperty, ps, () => control.ShowsPreview = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GridSplitter KeyboardIncrement(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.KeyboardIncrementProperty, binding);
public static GridSplitter KeyboardIncrement(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.KeyboardIncrementProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter KeyboardIncrement(this GridSplitter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.KeyboardIncrementProperty, func, expression);
public static GridSplitter KeyboardIncrement(this GridSplitter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = value, bindingMode, converter, bindingSource);
public static GridSplitter KeyboardIncrement<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.KeyboardIncrementProperty, ps, () => control.KeyboardIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GridSplitter DragIncrement(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.DragIncrementProperty, binding);
public static GridSplitter DragIncrement(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.DragIncrementProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter DragIncrement(this GridSplitter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.DragIncrementProperty, func, expression);
public static GridSplitter DragIncrement(this GridSplitter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = value, bindingMode, converter, bindingSource);
public static GridSplitter DragIncrement<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.DragIncrementProperty, ps, () => control.DragIncrement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GridSplitter PreviewContent(this GridSplitter control, IBinding binding)
   => control._set(GridSplitter.PreviewContentProperty, binding);
public static GridSplitter PreviewContent(this GridSplitter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GridSplitter.PreviewContentProperty, avaloniaProperty, bindingMode, converter);
public static GridSplitter PreviewContent(this GridSplitter control, Func<ITemplate<Control>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GridSplitter.PreviewContentProperty, func, expression);
public static GridSplitter PreviewContent(this GridSplitter control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = value, bindingMode, converter, bindingSource);
public static GridSplitter PreviewContent<TValue>(this GridSplitter control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GridSplitter.PreviewContentProperty, ps, () => control.PreviewContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ImageExtensions
{
public static Image Source(this Image control, IBinding binding)
   => control._set(Image.SourceProperty, binding);
public static Image Source(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Image.SourceProperty, avaloniaProperty, bindingMode, converter);
public static Image Source(this Image control, Func<IImage> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.SourceProperty, func, expression);
public static Image Source(this Image control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static Image Source<TValue>(this Image control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Image Stretch(this Image control, IBinding binding)
   => control._set(Image.StretchProperty, binding);
public static Image Stretch(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Image.StretchProperty, avaloniaProperty, bindingMode, converter);
public static Image Stretch(this Image control, Func<Stretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.StretchProperty, func, expression);
public static Image Stretch(this Image control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Image Stretch<TValue>(this Image control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Image StretchDirection(this Image control, IBinding binding)
   => control._set(Image.StretchDirectionProperty, binding);
public static Image StretchDirection(this Image control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Image.StretchDirectionProperty, avaloniaProperty, bindingMode, converter);
public static Image StretchDirection(this Image control, Func<StretchDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Image.StretchDirectionProperty, func, expression);
public static Image StretchDirection(this Image control, StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchDirectionProperty, ps, () => control.StretchDirection = value, bindingMode, converter, bindingSource);
public static Image StretchDirection<TValue>(this Image control, TValue value, FuncValueConverter<TValue, StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Image.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ItemsControlExtensions
{
public static T ItemContainerTheme<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, binding);
public static T ItemContainerTheme<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, avaloniaProperty, bindingMode, converter);
public static T ItemContainerTheme<T>(this T control, Func<ControlTheme> func, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemContainerThemeProperty, func, expression);
public static T ItemContainerTheme<T>(this T control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = value, bindingMode, converter, bindingSource);
public static T ItemContainerTheme<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemContainerThemeProperty, ps, () => control.ItemContainerTheme = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsPanel<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, binding);
public static T ItemsPanel<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, avaloniaProperty, bindingMode, converter);
public static T ItemsPanel<T>(this T control, Func<ITemplate<Panel>> func, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsPanelProperty, func, expression);
public static T ItemsPanel<T>(this T control, ITemplate<Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static T ItemsPanel<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITemplate<Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemsSource<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, binding);
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, avaloniaProperty, bindingMode, converter);
public static T ItemsSource<T>(this T control, Func<IEnumerable> func, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemsSourceProperty, func, expression);
public static T ItemsSource<T>(this T control, IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);
public static T ItemsSource<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ItemTemplate<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, binding);
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, avaloniaProperty, bindingMode, converter);
public static T ItemTemplate<T>(this T control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.ItemTemplateProperty, func, expression);
public static T ItemTemplate<T>(this T control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);
public static T ItemTemplate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T>(this T control, IBinding binding) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, binding);
public static T DisplayMemberBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, avaloniaProperty, bindingMode, converter);
public static T DisplayMemberBinding<T>(this T control, Func<IBinding> func, [CallerArgumentExpression("func")] string? expression = null) where T : ItemsControl
   => control._set(ItemsControl.DisplayMemberBindingProperty, func, expression);
public static T DisplayMemberBinding<T>(this T control, IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = value, bindingMode, converter, bindingSource);
public static T DisplayMemberBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : ItemsControl
=> control._setEx(ItemsControl.DisplayMemberBindingProperty, ps, () => control.DisplayMemberBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class LabelExtensions
{
public static Label Target(this Label control, IBinding binding)
   => control._set(Label.TargetProperty, binding);
public static Label Target(this Label control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Label.TargetProperty, avaloniaProperty, bindingMode, converter);
public static Label Target(this Label control, Func<IInputElement> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Label.TargetProperty, func, expression);
public static Label Target(this Label control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Label.TargetProperty, ps, () => control.Target = value, bindingMode, converter, bindingSource);
public static Label Target<TValue>(this Label control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Label.TargetProperty, ps, () => control.Target = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class LayoutTransformControlExtensions
{
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(LayoutTransformControl.LayoutTransformProperty, binding);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LayoutTransformControl.LayoutTransformProperty, avaloniaProperty, bindingMode, converter);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, Func<ITransform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LayoutTransformControl.LayoutTransformProperty, func, expression);
public static LayoutTransformControl LayoutTransform(this LayoutTransformControl control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = value, bindingMode, converter, bindingSource);
public static LayoutTransformControl LayoutTransform<TValue>(this LayoutTransformControl control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LayoutTransformControl.LayoutTransformProperty, ps, () => control.LayoutTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, IBinding binding)
   => control._set(LayoutTransformControl.UseRenderTransformProperty, binding);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LayoutTransformControl.UseRenderTransformProperty, avaloniaProperty, bindingMode, converter);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LayoutTransformControl.UseRenderTransformProperty, func, expression);
public static LayoutTransformControl UseRenderTransform(this LayoutTransformControl control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = value, bindingMode, converter, bindingSource);
public static LayoutTransformControl UseRenderTransform<TValue>(this LayoutTransformControl control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LayoutTransformControl.UseRenderTransformProperty, ps, () => control.UseRenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ListBoxExtensions
{
public static ListBox SelectedItems(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectedItemsProperty, binding);
public static ListBox SelectedItems(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ListBox.SelectedItemsProperty, avaloniaProperty, bindingMode, converter);
public static ListBox SelectedItems(this ListBox control, Func<IList> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectedItemsProperty, func, expression);
public static ListBox SelectedItems(this ListBox control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static ListBox SelectedItems<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ListBox Selection(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectionProperty, binding);
public static ListBox Selection(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ListBox.SelectionProperty, avaloniaProperty, bindingMode, converter);
public static ListBox Selection(this ListBox control, Func<ISelectionModel> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectionProperty, func, expression);
public static ListBox Selection(this ListBox control, ISelectionModel value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = value, bindingMode, converter, bindingSource);
public static ListBox Selection<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, ISelectionModel> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionProperty, ps, () => control.Selection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ListBox SelectionMode(this ListBox control, IBinding binding)
   => control._set(ListBox.SelectionModeProperty, binding);
public static ListBox SelectionMode(this ListBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ListBox.SelectionModeProperty, avaloniaProperty, bindingMode, converter);
public static ListBox SelectionMode(this ListBox control, Func<SelectionMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBox.SelectionModeProperty, func, expression);
public static ListBox SelectionMode(this ListBox control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static ListBox SelectionMode<TValue>(this ListBox control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBox.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ListBoxItemExtensions
{
public static ListBoxItem IsSelected(this ListBoxItem control, IBinding binding)
   => control._set(ListBoxItem.IsSelectedProperty, binding);
public static ListBoxItem IsSelected(this ListBoxItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ListBoxItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter);
public static ListBoxItem IsSelected(this ListBoxItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ListBoxItem.IsSelectedProperty, func, expression);
public static ListBoxItem IsSelected(this ListBoxItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static ListBoxItem IsSelected<TValue>(this ListBoxItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ListBoxItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class MaskedTextBoxExtensions
{
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.AsciiOnlyProperty, binding);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.AsciiOnlyProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.AsciiOnlyProperty, func, expression);
public static MaskedTextBox AsciiOnly(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = value, bindingMode, converter, bindingSource);
public static MaskedTextBox AsciiOnly<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.AsciiOnlyProperty, ps, () => control.AsciiOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox Culture(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.CultureProperty, binding);
public static MaskedTextBox Culture(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.CultureProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox Culture(this MaskedTextBox control, Func<CultureInfo> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.CultureProperty, func, expression);
public static MaskedTextBox Culture(this MaskedTextBox control, CultureInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = value, bindingMode, converter, bindingSource);
public static MaskedTextBox Culture<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, CultureInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.CultureProperty, ps, () => control.Culture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, binding);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.HidePromptOnLeaveProperty, func, expression);
public static MaskedTextBox HidePromptOnLeave(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = value, bindingMode, converter, bindingSource);
public static MaskedTextBox HidePromptOnLeave<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.HidePromptOnLeaveProperty, ps, () => control.HidePromptOnLeave = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox Mask(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.MaskProperty, binding);
public static MaskedTextBox Mask(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.MaskProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox Mask(this MaskedTextBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.MaskProperty, func, expression);
public static MaskedTextBox Mask(this MaskedTextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = value, bindingMode, converter, bindingSource);
public static MaskedTextBox Mask<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.MaskProperty, ps, () => control.Mask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox PromptChar(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.PromptCharProperty, binding);
public static MaskedTextBox PromptChar(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.PromptCharProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox PromptChar(this MaskedTextBox control, Func<Char> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.PromptCharProperty, func, expression);
public static MaskedTextBox PromptChar(this MaskedTextBox control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = value, bindingMode, converter, bindingSource);
public static MaskedTextBox PromptChar<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.PromptCharProperty, ps, () => control.PromptChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.ResetOnPromptProperty, binding);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.ResetOnPromptProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.ResetOnPromptProperty, func, expression);
public static MaskedTextBox ResetOnPrompt(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = value, bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnPrompt<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnPromptProperty, ps, () => control.ResetOnPrompt = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, IBinding binding)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, binding);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, avaloniaProperty, bindingMode, converter);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MaskedTextBox.ResetOnSpaceProperty, func, expression);
public static MaskedTextBox ResetOnSpace(this MaskedTextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = value, bindingMode, converter, bindingSource);
public static MaskedTextBox ResetOnSpace<TValue>(this MaskedTextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MaskedTextBox.ResetOnSpaceProperty, ps, () => control.ResetOnSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class MenuItemExtensions
{
public static MenuItem Command(this MenuItem control, IBinding binding)
   => control._set(MenuItem.CommandProperty, binding);
public static MenuItem Command(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.CommandProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem Command(this MenuItem control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.CommandProperty, func, expression);
public static MenuItem Command(this MenuItem control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static MenuItem Command<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem HotKey(this MenuItem control, IBinding binding)
   => control._set(MenuItem.HotKeyProperty, binding);
public static MenuItem HotKey(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.HotKeyProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem HotKey(this MenuItem control, Func<KeyGesture> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.HotKeyProperty, func, expression);
public static MenuItem HotKey(this MenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = value, bindingMode, converter, bindingSource);
public static MenuItem HotKey<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.HotKeyProperty, ps, () => control.HotKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem CommandParameter(this MenuItem control, IBinding binding)
   => control._set(MenuItem.CommandParameterProperty, binding);
public static MenuItem CommandParameter(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem CommandParameter(this MenuItem control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.CommandParameterProperty, func, expression);
public static MenuItem CommandParameter(this MenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static MenuItem CommandParameter<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem Icon(this MenuItem control, IBinding binding)
   => control._set(MenuItem.IconProperty, binding);
public static MenuItem Icon(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.IconProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem Icon(this MenuItem control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.IconProperty, func, expression);
public static MenuItem Icon(this MenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static MenuItem Icon<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem InputGesture(this MenuItem control, IBinding binding)
   => control._set(MenuItem.InputGestureProperty, binding);
public static MenuItem InputGesture(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.InputGestureProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem InputGesture(this MenuItem control, Func<KeyGesture> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.InputGestureProperty, func, expression);
public static MenuItem InputGesture(this MenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = value, bindingMode, converter, bindingSource);
public static MenuItem InputGesture<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.InputGestureProperty, ps, () => control.InputGesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem IsSubMenuOpen(this MenuItem control, IBinding binding)
   => control._set(MenuItem.IsSubMenuOpenProperty, binding);
public static MenuItem IsSubMenuOpen(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.IsSubMenuOpenProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem IsSubMenuOpen(this MenuItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.IsSubMenuOpenProperty, func, expression);
public static MenuItem IsSubMenuOpen(this MenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = value, bindingMode, converter, bindingSource);
public static MenuItem IsSubMenuOpen<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.IsSubMenuOpenProperty, ps, () => control.IsSubMenuOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static MenuItem StaysOpenOnClick(this MenuItem control, IBinding binding)
   => control._set(MenuItem.StaysOpenOnClickProperty, binding);
public static MenuItem StaysOpenOnClick(this MenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MenuItem.StaysOpenOnClickProperty, avaloniaProperty, bindingMode, converter);
public static MenuItem StaysOpenOnClick(this MenuItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MenuItem.StaysOpenOnClickProperty, func, expression);
public static MenuItem StaysOpenOnClick(this MenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = value, bindingMode, converter, bindingSource);
public static MenuItem StaysOpenOnClick<TValue>(this MenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MenuItem.StaysOpenOnClickProperty, ps, () => control.StaysOpenOnClick = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class NativeMenuItemExtensions
{
public static NativeMenuItem Menu(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.MenuProperty, binding);
public static NativeMenuItem Menu(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.MenuProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem Menu(this NativeMenuItem control, Func<NativeMenu> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.MenuProperty, func, expression);
public static NativeMenuItem Menu(this NativeMenuItem control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Menu<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Icon(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IconProperty, binding);
public static NativeMenuItem Icon(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.IconProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem Icon(this NativeMenuItem control, Func<Bitmap> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IconProperty, func, expression);
public static NativeMenuItem Icon(this NativeMenuItem control, Bitmap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Icon<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Bitmap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Header(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.HeaderProperty, binding);
public static NativeMenuItem Header(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.HeaderProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem Header(this NativeMenuItem control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.HeaderProperty, func, expression);
public static NativeMenuItem Header(this NativeMenuItem control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Header<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Gesture(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.GestureProperty, binding);
public static NativeMenuItem Gesture(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.GestureProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem Gesture(this NativeMenuItem control, Func<KeyGesture> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.GestureProperty, func, expression);
public static NativeMenuItem Gesture(this NativeMenuItem control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Gesture<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem IsChecked(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IsCheckedProperty, binding);
public static NativeMenuItem IsChecked(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.IsCheckedProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem IsChecked(this NativeMenuItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IsCheckedProperty, func, expression);
public static NativeMenuItem IsChecked(this NativeMenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static NativeMenuItem IsChecked<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem ToggleType(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.ToggleTypeProperty, binding);
public static NativeMenuItem ToggleType(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.ToggleTypeProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem ToggleType(this NativeMenuItem control, Func<NativeMenuItemToggleType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.ToggleTypeProperty, func, expression);
public static NativeMenuItem ToggleType(this NativeMenuItem control, NativeMenuItemToggleType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = value, bindingMode, converter, bindingSource);
public static NativeMenuItem ToggleType<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, NativeMenuItemToggleType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.ToggleTypeProperty, ps, () => control.ToggleType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem Command(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.CommandProperty, binding);
public static NativeMenuItem Command(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.CommandProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem Command(this NativeMenuItem control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.CommandProperty, func, expression);
public static NativeMenuItem Command(this NativeMenuItem control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static NativeMenuItem Command<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.CommandParameterProperty, binding);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.CommandParameterProperty, func, expression);
public static NativeMenuItem CommandParameter(this NativeMenuItem control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static NativeMenuItem CommandParameter<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, IBinding binding)
   => control._set(NativeMenuItem.IsEnabledProperty, binding);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NativeMenuItem.IsEnabledProperty, avaloniaProperty, bindingMode, converter);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NativeMenuItem.IsEnabledProperty, func, expression);
public static NativeMenuItem IsEnabled(this NativeMenuItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static NativeMenuItem IsEnabled<TValue>(this NativeMenuItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NativeMenuItem.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ReversibleStackPanelExtensions
{
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, IBinding binding)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, binding);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, avaloniaProperty, bindingMode, converter);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ReversibleStackPanel.ReverseOrderProperty, func, expression);
public static ReversibleStackPanel ReverseOrder(this ReversibleStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = value, bindingMode, converter, bindingSource);
public static ReversibleStackPanel ReverseOrder<TValue>(this ReversibleStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ReversibleStackPanel.ReverseOrderProperty, ps, () => control.ReverseOrder = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class NumericUpDownExtensions
{
public static NumericUpDown AllowSpin(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.AllowSpinProperty, binding);
public static NumericUpDown AllowSpin(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.AllowSpinProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown AllowSpin(this NumericUpDown control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.AllowSpinProperty, func, expression);
public static NumericUpDown AllowSpin(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = value, bindingMode, converter, bindingSource);
public static NumericUpDown AllowSpin<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.AllowSpinProperty, ps, () => control.AllowSpin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, binding);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Func<Location> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ButtonSpinnerLocationProperty, func, expression);
public static NumericUpDown ButtonSpinnerLocation(this NumericUpDown control, Location value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = value, bindingMode, converter, bindingSource);
public static NumericUpDown ButtonSpinnerLocation<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Location> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ButtonSpinnerLocationProperty, ps, () => control.ButtonSpinnerLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, binding);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ShowButtonSpinnerProperty, func, expression);
public static NumericUpDown ShowButtonSpinner(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = value, bindingMode, converter, bindingSource);
public static NumericUpDown ShowButtonSpinner<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ShowButtonSpinnerProperty, ps, () => control.ShowButtonSpinner = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, binding);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ClipValueToMinMaxProperty, func, expression);
public static NumericUpDown ClipValueToMinMax(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = value, bindingMode, converter, bindingSource);
public static NumericUpDown ClipValueToMinMax<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ClipValueToMinMaxProperty, ps, () => control.ClipValueToMinMax = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown NumberFormat(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.NumberFormatProperty, binding);
public static NumericUpDown NumberFormat(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.NumberFormatProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown NumberFormat(this NumericUpDown control, Func<NumberFormatInfo> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.NumberFormatProperty, func, expression);
public static NumericUpDown NumberFormat(this NumericUpDown control, NumberFormatInfo value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = value, bindingMode, converter, bindingSource);
public static NumericUpDown NumberFormat<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, NumberFormatInfo> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.NumberFormatProperty, ps, () => control.NumberFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown FormatString(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.FormatStringProperty, binding);
public static NumericUpDown FormatString(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.FormatStringProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown FormatString(this NumericUpDown control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.FormatStringProperty, func, expression);
public static NumericUpDown FormatString(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.FormatStringProperty, ps, () => control.FormatString = value, bindingMode, converter, bindingSource);
public static NumericUpDown FormatString<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.FormatStringProperty, ps, () => control.FormatString = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Increment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.IncrementProperty, binding);
public static NumericUpDown Increment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.IncrementProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Increment(this NumericUpDown control, Func<Decimal> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.IncrementProperty, func, expression);
public static NumericUpDown Increment(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IncrementProperty, ps, () => control.Increment = value, bindingMode, converter, bindingSource);
public static NumericUpDown Increment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IncrementProperty, ps, () => control.Increment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown IsReadOnly(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.IsReadOnlyProperty, binding);
public static NumericUpDown IsReadOnly(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown IsReadOnly(this NumericUpDown control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.IsReadOnlyProperty, func, expression);
public static NumericUpDown IsReadOnly(this NumericUpDown control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static NumericUpDown IsReadOnly<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Maximum(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.MaximumProperty, binding);
public static NumericUpDown Maximum(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.MaximumProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Maximum(this NumericUpDown control, Func<Decimal> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.MaximumProperty, func, expression);
public static NumericUpDown Maximum(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static NumericUpDown Maximum<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Minimum(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.MinimumProperty, binding);
public static NumericUpDown Minimum(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.MinimumProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Minimum(this NumericUpDown control, Func<Decimal> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.MinimumProperty, func, expression);
public static NumericUpDown Minimum(this NumericUpDown control, Decimal value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static NumericUpDown Minimum<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Decimal> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, binding);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, Func<NumberStyles> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ParsingNumberStyleProperty, func, expression);
public static NumericUpDown ParsingNumberStyle(this NumericUpDown control, NumberStyles value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = value, bindingMode, converter, bindingSource);
public static NumericUpDown ParsingNumberStyle<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, NumberStyles> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ParsingNumberStyleProperty, ps, () => control.ParsingNumberStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Text(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.TextProperty, binding);
public static NumericUpDown Text(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.TextProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Text(this NumericUpDown control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.TextProperty, func, expression);
public static NumericUpDown Text(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static NumericUpDown Text<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown TextConverter(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.TextConverterProperty, binding);
public static NumericUpDown TextConverter(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.TextConverterProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown TextConverter(this NumericUpDown control, Func<IValueConverter> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.TextConverterProperty, func, expression);
public static NumericUpDown TextConverter(this NumericUpDown control, IValueConverter value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = value, bindingMode, converter, bindingSource);
public static NumericUpDown TextConverter<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, IValueConverter> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.TextConverterProperty, ps, () => control.TextConverter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Value(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.ValueProperty, binding);
public static NumericUpDown Value(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.ValueProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Value(this NumericUpDown control, Func<Nullable<Decimal>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.ValueProperty, func, expression);
public static NumericUpDown Value(this NumericUpDown control, Nullable<Decimal> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static NumericUpDown Value<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, Nullable<Decimal>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown Watermark(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.WatermarkProperty, binding);
public static NumericUpDown Watermark(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.WatermarkProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown Watermark(this NumericUpDown control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.WatermarkProperty, func, expression);
public static NumericUpDown Watermark(this NumericUpDown control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static NumericUpDown Watermark<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, binding);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.HorizontalContentAlignmentProperty, func, expression);
public static NumericUpDown HorizontalContentAlignment(this NumericUpDown control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static NumericUpDown HorizontalContentAlignment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, IBinding binding)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, binding);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NumericUpDown.VerticalContentAlignmentProperty, func, expression);
public static NumericUpDown VerticalContentAlignment(this NumericUpDown control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static NumericUpDown VerticalContentAlignment<TValue>(this NumericUpDown control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NumericUpDown.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PanelExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : Panel
   => control._set(Panel.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Panel
   => control._set(Panel.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static T Background<T>(this T control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null) where T : Panel
   => control._set(Panel.BackgroundProperty, func, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Panel
=> control._setEx(Panel.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Panel
=> control._setEx(Panel.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PathIconExtensions
{
public static PathIcon Data(this PathIcon control, IBinding binding)
   => control._set(PathIcon.DataProperty, binding);
public static PathIcon Data(this PathIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathIcon.DataProperty, avaloniaProperty, bindingMode, converter);
public static PathIcon Data(this PathIcon control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathIcon.DataProperty, func, expression);
public static PathIcon Data(this PathIcon control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathIcon.DataProperty, ps, () => control.Data = value, bindingMode, converter, bindingSource);
public static PathIcon Data<TValue>(this PathIcon control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathIcon.DataProperty, ps, () => control.Data = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ProgressBarExtensions
{
public static ProgressBar IsIndeterminate(this ProgressBar control, IBinding binding)
   => control._set(ProgressBar.IsIndeterminateProperty, binding);
public static ProgressBar IsIndeterminate(this ProgressBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ProgressBar.IsIndeterminateProperty, avaloniaProperty, bindingMode, converter);
public static ProgressBar IsIndeterminate(this ProgressBar control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ProgressBar.IsIndeterminateProperty, func, expression);
public static ProgressBar IsIndeterminate(this ProgressBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = value, bindingMode, converter, bindingSource);
public static ProgressBar IsIndeterminate<TValue>(this ProgressBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.IsIndeterminateProperty, ps, () => control.IsIndeterminate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ProgressBar ShowProgressText(this ProgressBar control, IBinding binding)
   => control._set(ProgressBar.ShowProgressTextProperty, binding);
public static ProgressBar ShowProgressText(this ProgressBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ProgressBar.ShowProgressTextProperty, avaloniaProperty, bindingMode, converter);
public static ProgressBar ShowProgressText(this ProgressBar control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ProgressBar.ShowProgressTextProperty, func, expression);
public static ProgressBar ShowProgressText(this ProgressBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = value, bindingMode, converter, bindingSource);
public static ProgressBar ShowProgressText<TValue>(this ProgressBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.ShowProgressTextProperty, ps, () => control.ShowProgressText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ProgressBar ProgressTextFormat(this ProgressBar control, IBinding binding)
   => control._set(ProgressBar.ProgressTextFormatProperty, binding);
public static ProgressBar ProgressTextFormat(this ProgressBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ProgressBar.ProgressTextFormatProperty, avaloniaProperty, bindingMode, converter);
public static ProgressBar ProgressTextFormat(this ProgressBar control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ProgressBar.ProgressTextFormatProperty, func, expression);
public static ProgressBar ProgressTextFormat(this ProgressBar control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = value, bindingMode, converter, bindingSource);
public static ProgressBar ProgressTextFormat<TValue>(this ProgressBar control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.ProgressTextFormatProperty, ps, () => control.ProgressTextFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ProgressBar Orientation(this ProgressBar control, IBinding binding)
   => control._set(ProgressBar.OrientationProperty, binding);
public static ProgressBar Orientation(this ProgressBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ProgressBar.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static ProgressBar Orientation(this ProgressBar control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ProgressBar.OrientationProperty, func, expression);
public static ProgressBar Orientation(this ProgressBar control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static ProgressBar Orientation<TValue>(this ProgressBar control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ProgressBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RefreshContainerExtensions
{
public static RefreshContainer Visualizer(this RefreshContainer control, IBinding binding)
   => control._set(RefreshContainer.VisualizerProperty, binding);
public static RefreshContainer Visualizer(this RefreshContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RefreshContainer.VisualizerProperty, avaloniaProperty, bindingMode, converter);
public static RefreshContainer Visualizer(this RefreshContainer control, Func<RefreshVisualizer> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshContainer.VisualizerProperty, func, expression);
public static RefreshContainer Visualizer(this RefreshContainer control, RefreshVisualizer value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = value, bindingMode, converter, bindingSource);
public static RefreshContainer Visualizer<TValue>(this RefreshContainer control, TValue value, FuncValueConverter<TValue, RefreshVisualizer> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.VisualizerProperty, ps, () => control.Visualizer = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RefreshContainer PullDirection(this RefreshContainer control, IBinding binding)
   => control._set(RefreshContainer.PullDirectionProperty, binding);
public static RefreshContainer PullDirection(this RefreshContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RefreshContainer.PullDirectionProperty, avaloniaProperty, bindingMode, converter);
public static RefreshContainer PullDirection(this RefreshContainer control, Func<PullDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshContainer.PullDirectionProperty, func, expression);
public static RefreshContainer PullDirection(this RefreshContainer control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static RefreshContainer PullDirection<TValue>(this RefreshContainer control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshContainer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RefreshVisualizerExtensions
{
public static RefreshVisualizer Orientation(this RefreshVisualizer control, IBinding binding)
   => control._set(RefreshVisualizer.OrientationProperty, binding);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RefreshVisualizer.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, Func<RefreshVisualizerOrientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RefreshVisualizer.OrientationProperty, func, expression);
public static RefreshVisualizer Orientation(this RefreshVisualizer control, RefreshVisualizerOrientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static RefreshVisualizer Orientation<TValue>(this RefreshVisualizer control, TValue value, FuncValueConverter<TValue, RefreshVisualizerOrientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RefreshVisualizer.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RadioButtonExtensions
{
public static RadioButton GroupName(this RadioButton control, IBinding binding)
   => control._set(RadioButton.GroupNameProperty, binding);
public static RadioButton GroupName(this RadioButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RadioButton.GroupNameProperty, avaloniaProperty, bindingMode, converter);
public static RadioButton GroupName(this RadioButton control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadioButton.GroupNameProperty, func, expression);
public static RadioButton GroupName(this RadioButton control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadioButton.GroupNameProperty, ps, () => control.GroupName = value, bindingMode, converter, bindingSource);
public static RadioButton GroupName<TValue>(this RadioButton control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadioButton.GroupNameProperty, ps, () => control.GroupName = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RepeatButtonExtensions
{
public static RepeatButton Interval(this RepeatButton control, IBinding binding)
   => control._set(RepeatButton.IntervalProperty, binding);
public static RepeatButton Interval(this RepeatButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RepeatButton.IntervalProperty, avaloniaProperty, bindingMode, converter);
public static RepeatButton Interval(this RepeatButton control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RepeatButton.IntervalProperty, func, expression);
public static RepeatButton Interval(this RepeatButton control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = value, bindingMode, converter, bindingSource);
public static RepeatButton Interval<TValue>(this RepeatButton control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.IntervalProperty, ps, () => control.Interval = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RepeatButton Delay(this RepeatButton control, IBinding binding)
   => control._set(RepeatButton.DelayProperty, binding);
public static RepeatButton Delay(this RepeatButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RepeatButton.DelayProperty, avaloniaProperty, bindingMode, converter);
public static RepeatButton Delay(this RepeatButton control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RepeatButton.DelayProperty, func, expression);
public static RepeatButton Delay(this RepeatButton control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static RepeatButton Delay<TValue>(this RepeatButton control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RepeatButton.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RowDefinitionExtensions
{
public static RowDefinition MaxHeight(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.MaxHeightProperty, binding);
public static RowDefinition MaxHeight(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RowDefinition.MaxHeightProperty, avaloniaProperty, bindingMode, converter);
public static RowDefinition MaxHeight(this RowDefinition control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.MaxHeightProperty, func, expression);
public static RowDefinition MaxHeight(this RowDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static RowDefinition MaxHeight<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RowDefinition MinHeight(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.MinHeightProperty, binding);
public static RowDefinition MinHeight(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RowDefinition.MinHeightProperty, avaloniaProperty, bindingMode, converter);
public static RowDefinition MinHeight(this RowDefinition control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.MinHeightProperty, func, expression);
public static RowDefinition MinHeight(this RowDefinition control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static RowDefinition MinHeight<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RowDefinition Height(this RowDefinition control, IBinding binding)
   => control._set(RowDefinition.HeightProperty, binding);
public static RowDefinition Height(this RowDefinition control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RowDefinition.HeightProperty, avaloniaProperty, bindingMode, converter);
public static RowDefinition Height(this RowDefinition control, Func<GridLength> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RowDefinition.HeightProperty, func, expression);
public static RowDefinition Height(this RowDefinition control, GridLength value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static RowDefinition Height<TValue>(this RowDefinition control, TValue value, FuncValueConverter<TValue, GridLength> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RowDefinition.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RowDefinition Height(this RowDefinition control, Double value)
   => control._set(() => control.Height = new GridLength(value));
public static RowDefinition Height(this RowDefinition control, Double value, GridUnitType type)
   => control._set(() => control.Height = new GridLength(value, type));
}
public static partial class ScrollViewerExtensions
{
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, binding);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.BringIntoViewOnFocusChangeProperty, func, expression);
public static ScrollViewer BringIntoViewOnFocusChange(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = value, bindingMode, converter, bindingSource);
public static ScrollViewer BringIntoViewOnFocusChange<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.BringIntoViewOnFocusChangeProperty, ps, () => control.BringIntoViewOnFocusChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer Offset(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.OffsetProperty, binding);
public static ScrollViewer Offset(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.OffsetProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer Offset(this ScrollViewer control, Func<Vector> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.OffsetProperty, func, expression);
public static ScrollViewer Offset(this ScrollViewer control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static ScrollViewer Offset<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, binding);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, Func<ScrollBarVisibility> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalScrollBarVisibilityProperty, func, expression);
public static ScrollViewer HorizontalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalScrollBarVisibility<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalScrollBarVisibilityProperty, ps, () => control.HorizontalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, binding);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, Func<SnapPointsType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalSnapPointsTypeProperty, func, expression);
public static ScrollViewer HorizontalSnapPointsType(this ScrollViewer control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsType<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, binding);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, Func<SnapPointsType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalSnapPointsTypeProperty, func, expression);
public static ScrollViewer VerticalSnapPointsType(this ScrollViewer control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsType<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, binding);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, Func<SnapPointsAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.HorizontalSnapPointsAlignmentProperty, func, expression);
public static ScrollViewer HorizontalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollViewer HorizontalSnapPointsAlignment<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, binding);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, Func<SnapPointsAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalSnapPointsAlignmentProperty, func, expression);
public static ScrollViewer VerticalSnapPointsAlignment(this ScrollViewer control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalSnapPointsAlignment<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, binding);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, Func<ScrollBarVisibility> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.VerticalScrollBarVisibilityProperty, func, expression);
public static ScrollViewer VerticalScrollBarVisibility(this ScrollViewer control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = value, bindingMode, converter, bindingSource);
public static ScrollViewer VerticalScrollBarVisibility<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.VerticalScrollBarVisibilityProperty, ps, () => control.VerticalScrollBarVisibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.AllowAutoHideProperty, binding);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.AllowAutoHideProperty, func, expression);
public static ScrollViewer AllowAutoHide(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static ScrollViewer AllowAutoHide<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, binding);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.IsScrollChainingEnabledProperty, func, expression);
public static ScrollViewer IsScrollChainingEnabled(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollChainingEnabled<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, IBinding binding)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, binding);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollViewer.IsScrollInertiaEnabledProperty, func, expression);
public static ScrollViewer IsScrollInertiaEnabled(this ScrollViewer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static ScrollViewer IsScrollInertiaEnabled<TValue>(this ScrollViewer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollViewer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SelectableTextBlockExtensions
{
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionStartProperty, binding);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SelectableTextBlock.SelectionStartProperty, avaloniaProperty, bindingMode, converter);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionStartProperty, func, expression);
public static SelectableTextBlock SelectionStart(this SelectableTextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionStart<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionEndProperty, binding);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SelectableTextBlock.SelectionEndProperty, avaloniaProperty, bindingMode, converter);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionEndProperty, func, expression);
public static SelectableTextBlock SelectionEnd(this SelectableTextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionEnd<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, IBinding binding)
   => control._set(SelectableTextBlock.SelectionBrushProperty, binding);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SelectableTextBlock.SelectionBrushProperty, avaloniaProperty, bindingMode, converter);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SelectableTextBlock.SelectionBrushProperty, func, expression);
public static SelectableTextBlock SelectionBrush(this SelectableTextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static SelectableTextBlock SelectionBrush<TValue>(this SelectableTextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SelectableTextBlock.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SliderExtensions
{
public static Slider Orientation(this Slider control, IBinding binding)
   => control._set(Slider.OrientationProperty, binding);
public static Slider Orientation(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static Slider Orientation(this Slider control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.OrientationProperty, func, expression);
public static Slider Orientation(this Slider control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static Slider Orientation<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider IsDirectionReversed(this Slider control, IBinding binding)
   => control._set(Slider.IsDirectionReversedProperty, binding);
public static Slider IsDirectionReversed(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter);
public static Slider IsDirectionReversed(this Slider control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.IsDirectionReversedProperty, func, expression);
public static Slider IsDirectionReversed(this Slider control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static Slider IsDirectionReversed<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider IsSnapToTickEnabled(this Slider control, IBinding binding)
   => control._set(Slider.IsSnapToTickEnabledProperty, binding);
public static Slider IsSnapToTickEnabled(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.IsSnapToTickEnabledProperty, avaloniaProperty, bindingMode, converter);
public static Slider IsSnapToTickEnabled(this Slider control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.IsSnapToTickEnabledProperty, func, expression);
public static Slider IsSnapToTickEnabled(this Slider control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = value, bindingMode, converter, bindingSource);
public static Slider IsSnapToTickEnabled<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.IsSnapToTickEnabledProperty, ps, () => control.IsSnapToTickEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider TickFrequency(this Slider control, IBinding binding)
   => control._set(Slider.TickFrequencyProperty, binding);
public static Slider TickFrequency(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.TickFrequencyProperty, avaloniaProperty, bindingMode, converter);
public static Slider TickFrequency(this Slider control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TickFrequencyProperty, func, expression);
public static Slider TickFrequency(this Slider control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static Slider TickFrequency<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider TickPlacement(this Slider control, IBinding binding)
   => control._set(Slider.TickPlacementProperty, binding);
public static Slider TickPlacement(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.TickPlacementProperty, avaloniaProperty, bindingMode, converter);
public static Slider TickPlacement(this Slider control, Func<TickPlacement> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TickPlacementProperty, func, expression);
public static Slider TickPlacement(this Slider control, TickPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickPlacementProperty, ps, () => control.TickPlacement = value, bindingMode, converter, bindingSource);
public static Slider TickPlacement<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, TickPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TickPlacementProperty, ps, () => control.TickPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Slider Ticks(this Slider control, IBinding binding)
   => control._set(Slider.TicksProperty, binding);
public static Slider Ticks(this Slider control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Slider.TicksProperty, avaloniaProperty, bindingMode, converter);
public static Slider Ticks(this Slider control, Func<AvaloniaList<Double>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Slider.TicksProperty, func, expression);
public static Slider Ticks(this Slider control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static Slider Ticks<TValue>(this Slider control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Slider.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SpinnerExtensions
{
public static Spinner ValidSpinDirection(this Spinner control, IBinding binding)
   => control._set(Spinner.ValidSpinDirectionProperty, binding);
public static Spinner ValidSpinDirection(this Spinner control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Spinner.ValidSpinDirectionProperty, avaloniaProperty, bindingMode, converter);
public static Spinner ValidSpinDirection(this Spinner control, Func<ValidSpinDirections> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Spinner.ValidSpinDirectionProperty, func, expression);
public static Spinner ValidSpinDirection(this Spinner control, ValidSpinDirections value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = value, bindingMode, converter, bindingSource);
public static Spinner ValidSpinDirection<TValue>(this Spinner control, TValue value, FuncValueConverter<TValue, ValidSpinDirections> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Spinner.ValidSpinDirectionProperty, ps, () => control.ValidSpinDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SplitButtonExtensions
{
public static SplitButton Command(this SplitButton control, IBinding binding)
   => control._set(SplitButton.CommandProperty, binding);
public static SplitButton Command(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitButton.CommandProperty, avaloniaProperty, bindingMode, converter);
public static SplitButton Command(this SplitButton control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.CommandProperty, func, expression);
public static SplitButton Command(this SplitButton control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static SplitButton Command<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitButton CommandParameter(this SplitButton control, IBinding binding)
   => control._set(SplitButton.CommandParameterProperty, binding);
public static SplitButton CommandParameter(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitButton.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static SplitButton CommandParameter(this SplitButton control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.CommandParameterProperty, func, expression);
public static SplitButton CommandParameter(this SplitButton control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static SplitButton CommandParameter<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitButton Flyout(this SplitButton control, IBinding binding)
   => control._set(SplitButton.FlyoutProperty, binding);
public static SplitButton Flyout(this SplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitButton.FlyoutProperty, avaloniaProperty, bindingMode, converter);
public static SplitButton Flyout(this SplitButton control, Func<FlyoutBase> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitButton.FlyoutProperty, func, expression);
public static SplitButton Flyout(this SplitButton control, FlyoutBase value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = value, bindingMode, converter, bindingSource);
public static SplitButton Flyout<TValue>(this SplitButton control, TValue value, FuncValueConverter<TValue, FlyoutBase> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitButton.FlyoutProperty, ps, () => control.Flyout = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ToggleSplitButtonExtensions
{
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, IBinding binding)
   => control._set(ToggleSplitButton.IsCheckedProperty, binding);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSplitButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSplitButton.IsCheckedProperty, func, expression);
public static ToggleSplitButton IsChecked(this ToggleSplitButton control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static ToggleSplitButton IsChecked<TValue>(this ToggleSplitButton control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSplitButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SplitViewExtensions
{
public static SplitView CompactPaneLength(this SplitView control, IBinding binding)
   => control._set(SplitView.CompactPaneLengthProperty, binding);
public static SplitView CompactPaneLength(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.CompactPaneLengthProperty, avaloniaProperty, bindingMode, converter);
public static SplitView CompactPaneLength(this SplitView control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.CompactPaneLengthProperty, func, expression);
public static SplitView CompactPaneLength(this SplitView control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = value, bindingMode, converter, bindingSource);
public static SplitView CompactPaneLength<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.CompactPaneLengthProperty, ps, () => control.CompactPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView DisplayMode(this SplitView control, IBinding binding)
   => control._set(SplitView.DisplayModeProperty, binding);
public static SplitView DisplayMode(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.DisplayModeProperty, avaloniaProperty, bindingMode, converter);
public static SplitView DisplayMode(this SplitView control, Func<SplitViewDisplayMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.DisplayModeProperty, func, expression);
public static SplitView DisplayMode(this SplitView control, SplitViewDisplayMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);
public static SplitView DisplayMode<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, SplitViewDisplayMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView IsPaneOpen(this SplitView control, IBinding binding)
   => control._set(SplitView.IsPaneOpenProperty, binding);
public static SplitView IsPaneOpen(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.IsPaneOpenProperty, avaloniaProperty, bindingMode, converter);
public static SplitView IsPaneOpen(this SplitView control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.IsPaneOpenProperty, func, expression);
public static SplitView IsPaneOpen(this SplitView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = value, bindingMode, converter, bindingSource);
public static SplitView IsPaneOpen<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.IsPaneOpenProperty, ps, () => control.IsPaneOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView OpenPaneLength(this SplitView control, IBinding binding)
   => control._set(SplitView.OpenPaneLengthProperty, binding);
public static SplitView OpenPaneLength(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.OpenPaneLengthProperty, avaloniaProperty, bindingMode, converter);
public static SplitView OpenPaneLength(this SplitView control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.OpenPaneLengthProperty, func, expression);
public static SplitView OpenPaneLength(this SplitView control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = value, bindingMode, converter, bindingSource);
public static SplitView OpenPaneLength<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.OpenPaneLengthProperty, ps, () => control.OpenPaneLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PaneBackground(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneBackgroundProperty, binding);
public static SplitView PaneBackground(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.PaneBackgroundProperty, avaloniaProperty, bindingMode, converter);
public static SplitView PaneBackground(this SplitView control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneBackgroundProperty, func, expression);
public static SplitView PaneBackground(this SplitView control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = value, bindingMode, converter, bindingSource);
public static SplitView PaneBackground<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneBackgroundProperty, ps, () => control.PaneBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PanePlacement(this SplitView control, IBinding binding)
   => control._set(SplitView.PanePlacementProperty, binding);
public static SplitView PanePlacement(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.PanePlacementProperty, avaloniaProperty, bindingMode, converter);
public static SplitView PanePlacement(this SplitView control, Func<SplitViewPanePlacement> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PanePlacementProperty, func, expression);
public static SplitView PanePlacement(this SplitView control, SplitViewPanePlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = value, bindingMode, converter, bindingSource);
public static SplitView PanePlacement<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, SplitViewPanePlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PanePlacementProperty, ps, () => control.PanePlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView Pane(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneProperty, binding);
public static SplitView Pane(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.PaneProperty, avaloniaProperty, bindingMode, converter);
public static SplitView Pane(this SplitView control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneProperty, func, expression);
public static SplitView Pane(this SplitView control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = value, bindingMode, converter, bindingSource);
public static SplitView Pane<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneProperty, ps, () => control.Pane = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView PaneTemplate(this SplitView control, IBinding binding)
   => control._set(SplitView.PaneTemplateProperty, binding);
public static SplitView PaneTemplate(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.PaneTemplateProperty, avaloniaProperty, bindingMode, converter);
public static SplitView PaneTemplate(this SplitView control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.PaneTemplateProperty, func, expression);
public static SplitView PaneTemplate(this SplitView control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = value, bindingMode, converter, bindingSource);
public static SplitView PaneTemplate<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.PaneTemplateProperty, ps, () => control.PaneTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SplitView UseLightDismissOverlayMode(this SplitView control, IBinding binding)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, binding);
public static SplitView UseLightDismissOverlayMode(this SplitView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, avaloniaProperty, bindingMode, converter);
public static SplitView UseLightDismissOverlayMode(this SplitView control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SplitView.UseLightDismissOverlayModeProperty, func, expression);
public static SplitView UseLightDismissOverlayMode(this SplitView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = value, bindingMode, converter, bindingSource);
public static SplitView UseLightDismissOverlayMode<TValue>(this SplitView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SplitView.UseLightDismissOverlayModeProperty, ps, () => control.UseLightDismissOverlayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class StackPanelExtensions
{
public static StackPanel Spacing(this StackPanel control, IBinding binding)
   => control._set(StackPanel.SpacingProperty, binding);
public static StackPanel Spacing(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StackPanel.SpacingProperty, avaloniaProperty, bindingMode, converter);
public static StackPanel Spacing(this StackPanel control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.SpacingProperty, func, expression);
public static StackPanel Spacing(this StackPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.SpacingProperty, ps, () => control.Spacing = value, bindingMode, converter, bindingSource);
public static StackPanel Spacing<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.SpacingProperty, ps, () => control.Spacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel Orientation(this StackPanel control, IBinding binding)
   => control._set(StackPanel.OrientationProperty, binding);
public static StackPanel Orientation(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static StackPanel Orientation(this StackPanel control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.OrientationProperty, func, expression);
public static StackPanel Orientation(this StackPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static StackPanel Orientation<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, IBinding binding)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.AreHorizontalSnapPointsRegularProperty, func, expression);
public static StackPanel AreHorizontalSnapPointsRegular(this StackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static StackPanel AreHorizontalSnapPointsRegular<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, IBinding binding)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, binding);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StackPanel.AreVerticalSnapPointsRegularProperty, func, expression);
public static StackPanel AreVerticalSnapPointsRegular(this StackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static StackPanel AreVerticalSnapPointsRegular<TValue>(this StackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TabControlExtensions
{
public static TabControl TabStripPlacement(this TabControl control, IBinding binding)
   => control._set(TabControl.TabStripPlacementProperty, binding);
public static TabControl TabStripPlacement(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TabControl.TabStripPlacementProperty, avaloniaProperty, bindingMode, converter);
public static TabControl TabStripPlacement(this TabControl control, Func<Avalonia.Controls.Dock> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.TabStripPlacementProperty, func, expression);
public static TabControl TabStripPlacement(this TabControl control, Avalonia.Controls.Dock value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = value, bindingMode, converter, bindingSource);
public static TabControl TabStripPlacement<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Dock> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.TabStripPlacementProperty, ps, () => control.TabStripPlacement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl HorizontalContentAlignment(this TabControl control, IBinding binding)
   => control._set(TabControl.HorizontalContentAlignmentProperty, binding);
public static TabControl HorizontalContentAlignment(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TabControl.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TabControl HorizontalContentAlignment(this TabControl control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.HorizontalContentAlignmentProperty, func, expression);
public static TabControl HorizontalContentAlignment(this TabControl control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static TabControl HorizontalContentAlignment<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl VerticalContentAlignment(this TabControl control, IBinding binding)
   => control._set(TabControl.VerticalContentAlignmentProperty, binding);
public static TabControl VerticalContentAlignment(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TabControl.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TabControl VerticalContentAlignment(this TabControl control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.VerticalContentAlignmentProperty, func, expression);
public static TabControl VerticalContentAlignment(this TabControl control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static TabControl VerticalContentAlignment<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TabControl ContentTemplate(this TabControl control, IBinding binding)
   => control._set(TabControl.ContentTemplateProperty, binding);
public static TabControl ContentTemplate(this TabControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TabControl.ContentTemplateProperty, avaloniaProperty, bindingMode, converter);
public static TabControl ContentTemplate(this TabControl control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabControl.ContentTemplateProperty, func, expression);
public static TabControl ContentTemplate(this TabControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static TabControl ContentTemplate<TValue>(this TabControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabControl.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TabItemExtensions
{
public static TabItem IsSelected(this TabItem control, IBinding binding)
   => control._set(TabItem.IsSelectedProperty, binding);
public static TabItem IsSelected(this TabItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TabItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter);
public static TabItem IsSelected(this TabItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TabItem.IsSelectedProperty, func, expression);
public static TabItem IsSelected(this TabItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static TabItem IsSelected<TValue>(this TabItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TabItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TextBlockExtensions
{
public static TextBlock Background(this TextBlock control, IBinding binding)
   => control._set(TextBlock.BackgroundProperty, binding);
public static TextBlock Background(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock Background(this TextBlock control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.BackgroundProperty, func, expression);
public static TextBlock Background(this TextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextBlock Background<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Padding(this TextBlock control, IBinding binding)
   => control._set(TextBlock.PaddingProperty, binding);
public static TextBlock Padding(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.PaddingProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock Padding(this TextBlock control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.PaddingProperty, func, expression);
public static TextBlock Padding(this TextBlock control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static TextBlock Padding<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TextBlock Padding(this TextBlock control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static TextBlock Padding(this TextBlock control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static TextBlock Padding(this TextBlock control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static TextBlock FontFamily(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontFamilyProperty, binding);
public static TextBlock FontFamily(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.FontFamilyProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock FontFamily(this TextBlock control, Func<FontFamily> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontFamilyProperty, func, expression);
public static TextBlock FontFamily(this TextBlock control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static TextBlock FontFamily<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontSize(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontSizeProperty, binding);
public static TextBlock FontSize(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.FontSizeProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock FontSize(this TextBlock control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontSizeProperty, func, expression);
public static TextBlock FontSize(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static TextBlock FontSize<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontStyle(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontStyleProperty, binding);
public static TextBlock FontStyle(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.FontStyleProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock FontStyle(this TextBlock control, Func<FontStyle> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontStyleProperty, func, expression);
public static TextBlock FontStyle(this TextBlock control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static TextBlock FontStyle<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontWeight(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontWeightProperty, binding);
public static TextBlock FontWeight(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.FontWeightProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock FontWeight(this TextBlock control, Func<FontWeight> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontWeightProperty, func, expression);
public static TextBlock FontWeight(this TextBlock control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static TextBlock FontWeight<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock FontStretch(this TextBlock control, IBinding binding)
   => control._set(TextBlock.FontStretchProperty, binding);
public static TextBlock FontStretch(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.FontStretchProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock FontStretch(this TextBlock control, Func<FontStretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.FontStretchProperty, func, expression);
public static TextBlock FontStretch(this TextBlock control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static TextBlock FontStretch<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Foreground(this TextBlock control, IBinding binding)
   => control._set(TextBlock.ForegroundProperty, binding);
public static TextBlock Foreground(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.ForegroundProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock Foreground(this TextBlock control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.ForegroundProperty, func, expression);
public static TextBlock Foreground(this TextBlock control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static TextBlock Foreground<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock BaselineOffset(this TextBlock control, IBinding binding)
   => control._set(TextBlock.BaselineOffsetProperty, binding);
public static TextBlock BaselineOffset(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.BaselineOffsetProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock BaselineOffset(this TextBlock control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.BaselineOffsetProperty, func, expression);
public static TextBlock BaselineOffset(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = value, bindingMode, converter, bindingSource);
public static TextBlock BaselineOffset<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.BaselineOffsetProperty, ps, () => control.BaselineOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock LineHeight(this TextBlock control, IBinding binding)
   => control._set(TextBlock.LineHeightProperty, binding);
public static TextBlock LineHeight(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.LineHeightProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock LineHeight(this TextBlock control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.LineHeightProperty, func, expression);
public static TextBlock LineHeight(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextBlock LineHeight<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock LetterSpacing(this TextBlock control, IBinding binding)
   => control._set(TextBlock.LetterSpacingProperty, binding);
public static TextBlock LetterSpacing(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.LetterSpacingProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock LetterSpacing(this TextBlock control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.LetterSpacingProperty, func, expression);
public static TextBlock LetterSpacing(this TextBlock control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextBlock LetterSpacing<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock MaxLines(this TextBlock control, IBinding binding)
   => control._set(TextBlock.MaxLinesProperty, binding);
public static TextBlock MaxLines(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.MaxLinesProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock MaxLines(this TextBlock control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.MaxLinesProperty, func, expression);
public static TextBlock MaxLines(this TextBlock control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static TextBlock MaxLines<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Text(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextProperty, binding);
public static TextBlock Text(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.TextProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock Text(this TextBlock control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextProperty, func, expression);
public static TextBlock Text(this TextBlock control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextBlock Text<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextAlignment(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextAlignmentProperty, binding);
public static TextBlock TextAlignment(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.TextAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock TextAlignment(this TextBlock control, Func<TextAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextAlignmentProperty, func, expression);
public static TextBlock TextAlignment(this TextBlock control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextBlock TextAlignment<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextWrapping(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextWrappingProperty, binding);
public static TextBlock TextWrapping(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.TextWrappingProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock TextWrapping(this TextBlock control, Func<TextWrapping> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextWrappingProperty, func, expression);
public static TextBlock TextWrapping(this TextBlock control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextBlock TextWrapping<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextTrimming(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextTrimmingProperty, binding);
public static TextBlock TextTrimming(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.TextTrimmingProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock TextTrimming(this TextBlock control, Func<TextTrimming> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextTrimmingProperty, func, expression);
public static TextBlock TextTrimming(this TextBlock control, TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static TextBlock TextTrimming<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock TextDecorations(this TextBlock control, IBinding binding)
   => control._set(TextBlock.TextDecorationsProperty, binding);
public static TextBlock TextDecorations(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.TextDecorationsProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock TextDecorations(this TextBlock control, Func<TextDecorationCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.TextDecorationsProperty, func, expression);
public static TextBlock TextDecorations(this TextBlock control, TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static TextBlock TextDecorations<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBlock Inlines(this TextBlock control, IBinding binding)
   => control._set(TextBlock.InlinesProperty, binding);
public static TextBlock Inlines(this TextBlock control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBlock.InlinesProperty, avaloniaProperty, bindingMode, converter);
public static TextBlock Inlines(this TextBlock control, Func<InlineCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBlock.InlinesProperty, func, expression);
public static TextBlock Inlines(this TextBlock control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static TextBlock Inlines<TValue>(this TextBlock control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBlock.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TextBoxExtensions
{
public static TextBox AcceptsReturn(this TextBox control, IBinding binding)
   => control._set(TextBox.AcceptsReturnProperty, binding);
public static TextBox AcceptsReturn(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.AcceptsReturnProperty, avaloniaProperty, bindingMode, converter);
public static TextBox AcceptsReturn(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.AcceptsReturnProperty, func, expression);
public static TextBox AcceptsReturn(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = value, bindingMode, converter, bindingSource);
public static TextBox AcceptsReturn<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsReturnProperty, ps, () => control.AcceptsReturn = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox AcceptsTab(this TextBox control, IBinding binding)
   => control._set(TextBox.AcceptsTabProperty, binding);
public static TextBox AcceptsTab(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.AcceptsTabProperty, avaloniaProperty, bindingMode, converter);
public static TextBox AcceptsTab(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.AcceptsTabProperty, func, expression);
public static TextBox AcceptsTab(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = value, bindingMode, converter, bindingSource);
public static TextBox AcceptsTab<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.AcceptsTabProperty, ps, () => control.AcceptsTab = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox CaretIndex(this TextBox control, IBinding binding)
   => control._set(TextBox.CaretIndexProperty, binding);
public static TextBox CaretIndex(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter);
public static TextBox CaretIndex(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.CaretIndexProperty, func, expression);
public static TextBox CaretIndex(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static TextBox CaretIndex<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox IsReadOnly(this TextBox control, IBinding binding)
   => control._set(TextBox.IsReadOnlyProperty, binding);
public static TextBox IsReadOnly(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.IsReadOnlyProperty, avaloniaProperty, bindingMode, converter);
public static TextBox IsReadOnly(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.IsReadOnlyProperty, func, expression);
public static TextBox IsReadOnly(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = value, bindingMode, converter, bindingSource);
public static TextBox IsReadOnly<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsReadOnlyProperty, ps, () => control.IsReadOnly = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox PasswordChar(this TextBox control, IBinding binding)
   => control._set(TextBox.PasswordCharProperty, binding);
public static TextBox PasswordChar(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.PasswordCharProperty, avaloniaProperty, bindingMode, converter);
public static TextBox PasswordChar(this TextBox control, Func<Char> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.PasswordCharProperty, func, expression);
public static TextBox PasswordChar(this TextBox control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static TextBox PasswordChar<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionBrushProperty, binding);
public static TextBox SelectionBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.SelectionBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextBox SelectionBrush(this TextBox control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionBrushProperty, func, expression);
public static TextBox SelectionBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static TextBox SelectionBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionForegroundBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionForegroundBrushProperty, binding);
public static TextBox SelectionForegroundBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextBox SelectionForegroundBrush(this TextBox control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionForegroundBrushProperty, func, expression);
public static TextBox SelectionForegroundBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static TextBox SelectionForegroundBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox CaretBrush(this TextBox control, IBinding binding)
   => control._set(TextBox.CaretBrushProperty, binding);
public static TextBox CaretBrush(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.CaretBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextBox CaretBrush(this TextBox control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.CaretBrushProperty, func, expression);
public static TextBox CaretBrush(this TextBox control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static TextBox CaretBrush<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionStart(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionStartProperty, binding);
public static TextBox SelectionStart(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.SelectionStartProperty, avaloniaProperty, bindingMode, converter);
public static TextBox SelectionStart(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionStartProperty, func, expression);
public static TextBox SelectionStart(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static TextBox SelectionStart<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox SelectionEnd(this TextBox control, IBinding binding)
   => control._set(TextBox.SelectionEndProperty, binding);
public static TextBox SelectionEnd(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.SelectionEndProperty, avaloniaProperty, bindingMode, converter);
public static TextBox SelectionEnd(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.SelectionEndProperty, func, expression);
public static TextBox SelectionEnd(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static TextBox SelectionEnd<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox MaxLength(this TextBox control, IBinding binding)
   => control._set(TextBox.MaxLengthProperty, binding);
public static TextBox MaxLength(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter);
public static TextBox MaxLength(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.MaxLengthProperty, func, expression);
public static TextBox MaxLength(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);
public static TextBox MaxLength<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox MaxLines(this TextBox control, IBinding binding)
   => control._set(TextBox.MaxLinesProperty, binding);
public static TextBox MaxLines(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.MaxLinesProperty, avaloniaProperty, bindingMode, converter);
public static TextBox MaxLines(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.MaxLinesProperty, func, expression);
public static TextBox MaxLines(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static TextBox MaxLines<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox Text(this TextBox control, IBinding binding)
   => control._set(TextBox.TextProperty, binding);
public static TextBox Text(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.TextProperty, avaloniaProperty, bindingMode, converter);
public static TextBox Text(this TextBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextProperty, func, expression);
public static TextBox Text(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextBox Text<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox TextAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.TextAlignmentProperty, binding);
public static TextBox TextAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.TextAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TextBox TextAlignment(this TextBox control, Func<TextAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextAlignmentProperty, func, expression);
public static TextBox TextAlignment(this TextBox control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextBox TextAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox HorizontalContentAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.HorizontalContentAlignmentProperty, binding);
public static TextBox HorizontalContentAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TextBox HorizontalContentAlignment(this TextBox control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.HorizontalContentAlignmentProperty, func, expression);
public static TextBox HorizontalContentAlignment(this TextBox control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static TextBox HorizontalContentAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox VerticalContentAlignment(this TextBox control, IBinding binding)
   => control._set(TextBox.VerticalContentAlignmentProperty, binding);
public static TextBox VerticalContentAlignment(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TextBox VerticalContentAlignment(this TextBox control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.VerticalContentAlignmentProperty, func, expression);
public static TextBox VerticalContentAlignment(this TextBox control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static TextBox VerticalContentAlignment<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox TextWrapping(this TextBox control, IBinding binding)
   => control._set(TextBox.TextWrappingProperty, binding);
public static TextBox TextWrapping(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.TextWrappingProperty, avaloniaProperty, bindingMode, converter);
public static TextBox TextWrapping(this TextBox control, Func<TextWrapping> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.TextWrappingProperty, func, expression);
public static TextBox TextWrapping(this TextBox control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextBox TextWrapping<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox LineHeight(this TextBox control, IBinding binding)
   => control._set(TextBox.LineHeightProperty, binding);
public static TextBox LineHeight(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.LineHeightProperty, avaloniaProperty, bindingMode, converter);
public static TextBox LineHeight(this TextBox control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.LineHeightProperty, func, expression);
public static TextBox LineHeight(this TextBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextBox LineHeight<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox LetterSpacing(this TextBox control, IBinding binding)
   => control._set(TextBox.LetterSpacingProperty, binding);
public static TextBox LetterSpacing(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.LetterSpacingProperty, avaloniaProperty, bindingMode, converter);
public static TextBox LetterSpacing(this TextBox control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.LetterSpacingProperty, func, expression);
public static TextBox LetterSpacing(this TextBox control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextBox LetterSpacing<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox Watermark(this TextBox control, IBinding binding)
   => control._set(TextBox.WatermarkProperty, binding);
public static TextBox Watermark(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.WatermarkProperty, avaloniaProperty, bindingMode, converter);
public static TextBox Watermark(this TextBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.WatermarkProperty, func, expression);
public static TextBox Watermark(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);
public static TextBox Watermark<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox UseFloatingWatermark(this TextBox control, IBinding binding)
   => control._set(TextBox.UseFloatingWatermarkProperty, binding);
public static TextBox UseFloatingWatermark(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.UseFloatingWatermarkProperty, avaloniaProperty, bindingMode, converter);
public static TextBox UseFloatingWatermark(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.UseFloatingWatermarkProperty, func, expression);
public static TextBox UseFloatingWatermark(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = value, bindingMode, converter, bindingSource);
public static TextBox UseFloatingWatermark<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UseFloatingWatermarkProperty, ps, () => control.UseFloatingWatermark = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox NewLine(this TextBox control, IBinding binding)
   => control._set(TextBox.NewLineProperty, binding);
public static TextBox NewLine(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.NewLineProperty, avaloniaProperty, bindingMode, converter);
public static TextBox NewLine(this TextBox control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.NewLineProperty, func, expression);
public static TextBox NewLine(this TextBox control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = value, bindingMode, converter, bindingSource);
public static TextBox NewLine<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.NewLineProperty, ps, () => control.NewLine = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox InnerLeftContent(this TextBox control, IBinding binding)
   => control._set(TextBox.InnerLeftContentProperty, binding);
public static TextBox InnerLeftContent(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter);
public static TextBox InnerLeftContent(this TextBox control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.InnerLeftContentProperty, func, expression);
public static TextBox InnerLeftContent(this TextBox control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);
public static TextBox InnerLeftContent<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox InnerRightContent(this TextBox control, IBinding binding)
   => control._set(TextBox.InnerRightContentProperty, binding);
public static TextBox InnerRightContent(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter);
public static TextBox InnerRightContent(this TextBox control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.InnerRightContentProperty, func, expression);
public static TextBox InnerRightContent(this TextBox control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);
public static TextBox InnerRightContent<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox RevealPassword(this TextBox control, IBinding binding)
   => control._set(TextBox.RevealPasswordProperty, binding);
public static TextBox RevealPassword(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.RevealPasswordProperty, avaloniaProperty, bindingMode, converter);
public static TextBox RevealPassword(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.RevealPasswordProperty, func, expression);
public static TextBox RevealPassword(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static TextBox RevealPassword<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox IsUndoEnabled(this TextBox control, IBinding binding)
   => control._set(TextBox.IsUndoEnabledProperty, binding);
public static TextBox IsUndoEnabled(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.IsUndoEnabledProperty, avaloniaProperty, bindingMode, converter);
public static TextBox IsUndoEnabled(this TextBox control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.IsUndoEnabledProperty, func, expression);
public static TextBox IsUndoEnabled(this TextBox control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = value, bindingMode, converter, bindingSource);
public static TextBox IsUndoEnabled<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.IsUndoEnabledProperty, ps, () => control.IsUndoEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextBox UndoLimit(this TextBox control, IBinding binding)
   => control._set(TextBox.UndoLimitProperty, binding);
public static TextBox UndoLimit(this TextBox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextBox.UndoLimitProperty, avaloniaProperty, bindingMode, converter);
public static TextBox UndoLimit(this TextBox control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextBox.UndoLimitProperty, func, expression);
public static TextBox UndoLimit(this TextBox control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = value, bindingMode, converter, bindingSource);
public static TextBox UndoLimit<TValue>(this TextBox control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextBox.UndoLimitProperty, ps, () => control.UndoLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ThemeVariantScopeExtensions
{
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, IBinding binding)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, binding);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, Func<ThemeVariant> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ThemeVariantScope.RequestedThemeVariantProperty, func, expression);
public static ThemeVariantScope RequestedThemeVariant(this ThemeVariantScope control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static ThemeVariantScope RequestedThemeVariant<TValue>(this ThemeVariantScope control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ThemeVariantScope.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TickBarExtensions
{
public static TickBar Fill(this TickBar control, IBinding binding)
   => control._set(TickBar.FillProperty, binding);
public static TickBar Fill(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.FillProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Fill(this TickBar control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.FillProperty, func, expression);
public static TickBar Fill(this TickBar control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static TickBar Fill<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Minimum(this TickBar control, IBinding binding)
   => control._set(TickBar.MinimumProperty, binding);
public static TickBar Minimum(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.MinimumProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Minimum(this TickBar control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.MinimumProperty, func, expression);
public static TickBar Minimum(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static TickBar Minimum<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Maximum(this TickBar control, IBinding binding)
   => control._set(TickBar.MaximumProperty, binding);
public static TickBar Maximum(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.MaximumProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Maximum(this TickBar control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.MaximumProperty, func, expression);
public static TickBar Maximum(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static TickBar Maximum<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar TickFrequency(this TickBar control, IBinding binding)
   => control._set(TickBar.TickFrequencyProperty, binding);
public static TickBar TickFrequency(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.TickFrequencyProperty, avaloniaProperty, bindingMode, converter);
public static TickBar TickFrequency(this TickBar control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.TickFrequencyProperty, func, expression);
public static TickBar TickFrequency(this TickBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = value, bindingMode, converter, bindingSource);
public static TickBar TickFrequency<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TickFrequencyProperty, ps, () => control.TickFrequency = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Orientation(this TickBar control, IBinding binding)
   => control._set(TickBar.OrientationProperty, binding);
public static TickBar Orientation(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Orientation(this TickBar control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.OrientationProperty, func, expression);
public static TickBar Orientation(this TickBar control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static TickBar Orientation<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Ticks(this TickBar control, IBinding binding)
   => control._set(TickBar.TicksProperty, binding);
public static TickBar Ticks(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.TicksProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Ticks(this TickBar control, Func<AvaloniaList<Double>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.TicksProperty, func, expression);
public static TickBar Ticks(this TickBar control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TicksProperty, ps, () => control.Ticks = value, bindingMode, converter, bindingSource);
public static TickBar Ticks<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.TicksProperty, ps, () => control.Ticks = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar IsDirectionReversed(this TickBar control, IBinding binding)
   => control._set(TickBar.IsDirectionReversedProperty, binding);
public static TickBar IsDirectionReversed(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter);
public static TickBar IsDirectionReversed(this TickBar control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.IsDirectionReversedProperty, func, expression);
public static TickBar IsDirectionReversed(this TickBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static TickBar IsDirectionReversed<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar Placement(this TickBar control, IBinding binding)
   => control._set(TickBar.PlacementProperty, binding);
public static TickBar Placement(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.PlacementProperty, avaloniaProperty, bindingMode, converter);
public static TickBar Placement(this TickBar control, Func<TickBarPlacement> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.PlacementProperty, func, expression);
public static TickBar Placement(this TickBar control, TickBarPlacement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static TickBar Placement<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, TickBarPlacement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TickBar ReservedSpace(this TickBar control, IBinding binding)
   => control._set(TickBar.ReservedSpaceProperty, binding);
public static TickBar ReservedSpace(this TickBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TickBar.ReservedSpaceProperty, avaloniaProperty, bindingMode, converter);
public static TickBar ReservedSpace(this TickBar control, Func<Rect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TickBar.ReservedSpaceProperty, func, expression);
public static TickBar ReservedSpace(this TickBar control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = value, bindingMode, converter, bindingSource);
public static TickBar ReservedSpace<TValue>(this TickBar control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TickBar.ReservedSpaceProperty, ps, () => control.ReservedSpace = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TickBar ReservedSpace(this TickBar control, Double x, Double y, Double width, Double height)
   => control._set(() => control.ReservedSpace = new Rect(x, y, width, height));
public static TickBar ReservedSpace(this TickBar control, Size size)
   => control._set(() => control.ReservedSpace = new Rect(size));
public static TickBar ReservedSpace(this TickBar control, Point position, Size size)
   => control._set(() => control.ReservedSpace = new Rect(position, size));
public static TickBar ReservedSpace(this TickBar control, Point topLeft, Point bottomRight)
   => control._set(() => control.ReservedSpace = new Rect(topLeft, bottomRight));
}
public static partial class ToggleSwitchExtensions
{
public static ToggleSwitch OffContent(this ToggleSwitch control, IBinding binding)
   => control._set(ToggleSwitch.OffContentProperty, binding);
public static ToggleSwitch OffContent(this ToggleSwitch control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSwitch.OffContentProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSwitch OffContent(this ToggleSwitch control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSwitch.OffContentProperty, func, expression);
public static ToggleSwitch OffContent(this ToggleSwitch control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OffContentProperty, ps, () => control.OffContent = value, bindingMode, converter, bindingSource);
public static ToggleSwitch OffContent<TValue>(this ToggleSwitch control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OffContentProperty, ps, () => control.OffContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(ToggleSwitch.OffContentTemplateProperty, binding);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSwitch.OffContentTemplateProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSwitch.OffContentTemplateProperty, func, expression);
public static ToggleSwitch OffContentTemplate(this ToggleSwitch control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = value, bindingMode, converter, bindingSource);
public static ToggleSwitch OffContentTemplate<TValue>(this ToggleSwitch control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OffContentTemplateProperty, ps, () => control.OffContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleSwitch OnContent(this ToggleSwitch control, IBinding binding)
   => control._set(ToggleSwitch.OnContentProperty, binding);
public static ToggleSwitch OnContent(this ToggleSwitch control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSwitch.OnContentProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSwitch OnContent(this ToggleSwitch control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSwitch.OnContentProperty, func, expression);
public static ToggleSwitch OnContent(this ToggleSwitch control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OnContentProperty, ps, () => control.OnContent = value, bindingMode, converter, bindingSource);
public static ToggleSwitch OnContent<TValue>(this ToggleSwitch control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OnContentProperty, ps, () => control.OnContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IBinding binding)
   => control._set(ToggleSwitch.OnContentTemplateProperty, binding);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSwitch.OnContentTemplateProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSwitch.OnContentTemplateProperty, func, expression);
public static ToggleSwitch OnContentTemplate(this ToggleSwitch control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = value, bindingMode, converter, bindingSource);
public static ToggleSwitch OnContentTemplate<TValue>(this ToggleSwitch control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.OnContentTemplateProperty, ps, () => control.OnContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleSwitch KnobTransitions(this ToggleSwitch control, IBinding binding)
   => control._set(ToggleSwitch.KnobTransitionsProperty, binding);
public static ToggleSwitch KnobTransitions(this ToggleSwitch control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleSwitch.KnobTransitionsProperty, avaloniaProperty, bindingMode, converter);
public static ToggleSwitch KnobTransitions(this ToggleSwitch control, Func<Transitions> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleSwitch.KnobTransitionsProperty, func, expression);
public static ToggleSwitch KnobTransitions(this ToggleSwitch control, Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = value, bindingMode, converter, bindingSource);
public static ToggleSwitch KnobTransitions<TValue>(this ToggleSwitch control, TValue value, FuncValueConverter<TValue, Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleSwitch.KnobTransitionsProperty, ps, () => control.KnobTransitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TopLevelExtensions
{
public static TopLevel TransparencyLevelHint(this TopLevel control, IBinding binding)
   => control._set(TopLevel.TransparencyLevelHintProperty, binding);
public static TopLevel TransparencyLevelHint(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TopLevel.TransparencyLevelHintProperty, avaloniaProperty, bindingMode, converter);
public static TopLevel TransparencyLevelHint(this TopLevel control, Func<IReadOnlyList<WindowTransparencyLevel>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.TransparencyLevelHintProperty, func, expression);
public static TopLevel TransparencyLevelHint(this TopLevel control, IReadOnlyList<WindowTransparencyLevel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = value, bindingMode, converter, bindingSource);
public static TopLevel TransparencyLevelHint<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, IReadOnlyList<WindowTransparencyLevel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyLevelHintProperty, ps, () => control.TransparencyLevelHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBinding binding)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, binding);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, avaloniaProperty, bindingMode, converter);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.TransparencyBackgroundFallbackProperty, func, expression);
public static TopLevel TransparencyBackgroundFallback(this TopLevel control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = value, bindingMode, converter, bindingSource);
public static TopLevel TransparencyBackgroundFallback<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.TransparencyBackgroundFallbackProperty, ps, () => control.TransparencyBackgroundFallback = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TopLevel RequestedThemeVariant(this TopLevel control, IBinding binding)
   => control._set(TopLevel.RequestedThemeVariantProperty, binding);
public static TopLevel RequestedThemeVariant(this TopLevel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TopLevel.RequestedThemeVariantProperty, avaloniaProperty, bindingMode, converter);
public static TopLevel RequestedThemeVariant(this TopLevel control, Func<ThemeVariant> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TopLevel.RequestedThemeVariantProperty, func, expression);
public static TopLevel RequestedThemeVariant(this TopLevel control, ThemeVariant value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = value, bindingMode, converter, bindingSource);
public static TopLevel RequestedThemeVariant<TValue>(this TopLevel control, TValue value, FuncValueConverter<TValue, ThemeVariant> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TopLevel.RequestedThemeVariantProperty, ps, () => control.RequestedThemeVariant = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TransitioningContentControlExtensions
{
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, IBinding binding)
   => control._set(TransitioningContentControl.PageTransitionProperty, binding);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TransitioningContentControl.PageTransitionProperty, avaloniaProperty, bindingMode, converter);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, Func<IPageTransition> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransitioningContentControl.PageTransitionProperty, func, expression);
public static TransitioningContentControl PageTransition(this TransitioningContentControl control, IPageTransition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = value, bindingMode, converter, bindingSource);
public static TransitioningContentControl PageTransition<TValue>(this TransitioningContentControl control, TValue value, FuncValueConverter<TValue, IPageTransition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransitioningContentControl.PageTransitionProperty, ps, () => control.PageTransition = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TrayIconExtensions
{
public static TrayIcon Command(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.CommandProperty, binding);
public static TrayIcon Command(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.CommandProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon Command(this TrayIcon control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.CommandProperty, func, expression);
public static TrayIcon Command(this TrayIcon control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static TrayIcon Command<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon CommandParameter(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.CommandParameterProperty, binding);
public static TrayIcon CommandParameter(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon CommandParameter(this TrayIcon control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.CommandParameterProperty, func, expression);
public static TrayIcon CommandParameter(this TrayIcon control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static TrayIcon CommandParameter<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon Menu(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.MenuProperty, binding);
public static TrayIcon Menu(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.MenuProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon Menu(this TrayIcon control, Func<NativeMenu> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.MenuProperty, func, expression);
public static TrayIcon Menu(this TrayIcon control, NativeMenu value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = value, bindingMode, converter, bindingSource);
public static TrayIcon Menu<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, NativeMenu> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.MenuProperty, ps, () => control.Menu = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon Icon(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.IconProperty, binding);
public static TrayIcon Icon(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.IconProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon Icon(this TrayIcon control, Func<WindowIcon> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.IconProperty, func, expression);
public static TrayIcon Icon(this TrayIcon control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static TrayIcon Icon<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon ToolTipText(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.ToolTipTextProperty, binding);
public static TrayIcon ToolTipText(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.ToolTipTextProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon ToolTipText(this TrayIcon control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.ToolTipTextProperty, func, expression);
public static TrayIcon ToolTipText(this TrayIcon control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = value, bindingMode, converter, bindingSource);
public static TrayIcon ToolTipText<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.ToolTipTextProperty, ps, () => control.ToolTipText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TrayIcon IsVisible(this TrayIcon control, IBinding binding)
   => control._set(TrayIcon.IsVisibleProperty, binding);
public static TrayIcon IsVisible(this TrayIcon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TrayIcon.IsVisibleProperty, avaloniaProperty, bindingMode, converter);
public static TrayIcon IsVisible(this TrayIcon control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TrayIcon.IsVisibleProperty, func, expression);
public static TrayIcon IsVisible(this TrayIcon control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static TrayIcon IsVisible<TValue>(this TrayIcon control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TrayIcon.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TreeViewExtensions
{
public static TreeView AutoScrollToSelectedItem(this TreeView control, IBinding binding)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, binding);
public static TreeView AutoScrollToSelectedItem(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter);
public static TreeView AutoScrollToSelectedItem(this TreeView control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.AutoScrollToSelectedItemProperty, func, expression);
public static TreeView AutoScrollToSelectedItem(this TreeView control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static TreeView AutoScrollToSelectedItem<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectedItem(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectedItemProperty, binding);
public static TreeView SelectedItem(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeView.SelectedItemProperty, avaloniaProperty, bindingMode, converter);
public static TreeView SelectedItem(this TreeView control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectedItemProperty, func, expression);
public static TreeView SelectedItem(this TreeView control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static TreeView SelectedItem<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectedItems(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectedItemsProperty, binding);
public static TreeView SelectedItems(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeView.SelectedItemsProperty, avaloniaProperty, bindingMode, converter);
public static TreeView SelectedItems(this TreeView control, Func<IList> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectedItemsProperty, func, expression);
public static TreeView SelectedItems(this TreeView control, IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);
public static TreeView SelectedItems<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeView SelectionMode(this TreeView control, IBinding binding)
   => control._set(TreeView.SelectionModeProperty, binding);
public static TreeView SelectionMode(this TreeView control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeView.SelectionModeProperty, avaloniaProperty, bindingMode, converter);
public static TreeView SelectionMode(this TreeView control, Func<SelectionMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeView.SelectionModeProperty, func, expression);
public static TreeView SelectionMode(this TreeView control, SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);
public static TreeView SelectionMode<TValue>(this TreeView control, TValue value, FuncValueConverter<TValue, SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeView.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TreeViewItemExtensions
{
public static TreeViewItem IsExpanded(this TreeViewItem control, IBinding binding)
   => control._set(TreeViewItem.IsExpandedProperty, binding);
public static TreeViewItem IsExpanded(this TreeViewItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeViewItem.IsExpandedProperty, avaloniaProperty, bindingMode, converter);
public static TreeViewItem IsExpanded(this TreeViewItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeViewItem.IsExpandedProperty, func, expression);
public static TreeViewItem IsExpanded(this TreeViewItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = value, bindingMode, converter, bindingSource);
public static TreeViewItem IsExpanded<TValue>(this TreeViewItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsExpandedProperty, ps, () => control.IsExpanded = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TreeViewItem IsSelected(this TreeViewItem control, IBinding binding)
   => control._set(TreeViewItem.IsSelectedProperty, binding);
public static TreeViewItem IsSelected(this TreeViewItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TreeViewItem.IsSelectedProperty, avaloniaProperty, bindingMode, converter);
public static TreeViewItem IsSelected(this TreeViewItem control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TreeViewItem.IsSelectedProperty, func, expression);
public static TreeViewItem IsSelected(this TreeViewItem control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = value, bindingMode, converter, bindingSource);
public static TreeViewItem IsSelected<TValue>(this TreeViewItem control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TreeViewItem.IsSelectedProperty, ps, () => control.IsSelected = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ViewboxExtensions
{
public static Viewbox Stretch(this Viewbox control, IBinding binding)
   => control._set(Viewbox.StretchProperty, binding);
public static Viewbox Stretch(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Viewbox.StretchProperty, avaloniaProperty, bindingMode, converter);
public static Viewbox Stretch(this Viewbox control, Func<Stretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.StretchProperty, func, expression);
public static Viewbox Stretch(this Viewbox control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Viewbox Stretch<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Viewbox StretchDirection(this Viewbox control, IBinding binding)
   => control._set(Viewbox.StretchDirectionProperty, binding);
public static Viewbox StretchDirection(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Viewbox.StretchDirectionProperty, avaloniaProperty, bindingMode, converter);
public static Viewbox StretchDirection(this Viewbox control, Func<StretchDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.StretchDirectionProperty, func, expression);
public static Viewbox StretchDirection(this Viewbox control, StretchDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = value, bindingMode, converter, bindingSource);
public static Viewbox StretchDirection<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, StretchDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.StretchDirectionProperty, ps, () => control.StretchDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Viewbox Child(this Viewbox control, IBinding binding)
   => control._set(Viewbox.ChildProperty, binding);
public static Viewbox Child(this Viewbox control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Viewbox.ChildProperty, avaloniaProperty, bindingMode, converter);
public static Viewbox Child(this Viewbox control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Viewbox.ChildProperty, func, expression);
public static Viewbox Child(this Viewbox control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Viewbox Child<TValue>(this Viewbox control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Viewbox.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class VirtualizingStackPanelExtensions
{
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.OrientationProperty, binding);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(VirtualizingStackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.OrientationProperty, func, expression);
public static VirtualizingStackPanel Orientation(this VirtualizingStackPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel Orientation<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, binding);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, func, expression);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular(this VirtualizingStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreHorizontalSnapPointsRegular<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, IBinding binding)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, binding);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, func, expression);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular(this VirtualizingStackPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);
public static VirtualizingStackPanel AreVerticalSnapPointsRegular<TValue>(this VirtualizingStackPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VirtualizingStackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class WindowExtensions
{
public static Window SizeToContent(this Window control, IBinding binding)
   => control._set(Window.SizeToContentProperty, binding);
public static Window SizeToContent(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.SizeToContentProperty, avaloniaProperty, bindingMode, converter);
public static Window SizeToContent(this Window control, Func<SizeToContent> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.SizeToContentProperty, func, expression);
public static Window SizeToContent(this Window control, SizeToContent value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = value, bindingMode, converter, bindingSource);
public static Window SizeToContent<TValue>(this Window control, TValue value, FuncValueConverter<TValue, SizeToContent> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SizeToContentProperty, ps, () => control.SizeToContent = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaToDecorationsHint(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, binding);
public static Window ExtendClientAreaToDecorationsHint(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, avaloniaProperty, bindingMode, converter);
public static Window ExtendClientAreaToDecorationsHint(this Window control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaToDecorationsHintProperty, func, expression);
public static Window ExtendClientAreaToDecorationsHint(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaToDecorationsHint<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaToDecorationsHintProperty, ps, () => control.ExtendClientAreaToDecorationsHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaChromeHints(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, binding);
public static Window ExtendClientAreaChromeHints(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, avaloniaProperty, bindingMode, converter);
public static Window ExtendClientAreaChromeHints(this Window control, Func<ExtendClientAreaChromeHints> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaChromeHintsProperty, func, expression);
public static Window ExtendClientAreaChromeHints(this Window control, ExtendClientAreaChromeHints value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaChromeHints<TValue>(this Window control, TValue value, FuncValueConverter<TValue, ExtendClientAreaChromeHints> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaChromeHintsProperty, ps, () => control.ExtendClientAreaChromeHints = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, IBinding binding)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, binding);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, avaloniaProperty, bindingMode, converter);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ExtendClientAreaTitleBarHeightHintProperty, func, expression);
public static Window ExtendClientAreaTitleBarHeightHint(this Window control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = value, bindingMode, converter, bindingSource);
public static Window ExtendClientAreaTitleBarHeightHint<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ExtendClientAreaTitleBarHeightHintProperty, ps, () => control.ExtendClientAreaTitleBarHeightHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window SystemDecorations(this Window control, IBinding binding)
   => control._set(Window.SystemDecorationsProperty, binding);
public static Window SystemDecorations(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.SystemDecorationsProperty, avaloniaProperty, bindingMode, converter);
public static Window SystemDecorations(this Window control, Func<SystemDecorations> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.SystemDecorationsProperty, func, expression);
public static Window SystemDecorations(this Window control, SystemDecorations value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = value, bindingMode, converter, bindingSource);
public static Window SystemDecorations<TValue>(this Window control, TValue value, FuncValueConverter<TValue, SystemDecorations> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.SystemDecorationsProperty, ps, () => control.SystemDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ShowActivated(this Window control, IBinding binding)
   => control._set(Window.ShowActivatedProperty, binding);
public static Window ShowActivated(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.ShowActivatedProperty, avaloniaProperty, bindingMode, converter);
public static Window ShowActivated(this Window control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ShowActivatedProperty, func, expression);
public static Window ShowActivated(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = value, bindingMode, converter, bindingSource);
public static Window ShowActivated<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowActivatedProperty, ps, () => control.ShowActivated = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window ShowInTaskbar(this Window control, IBinding binding)
   => control._set(Window.ShowInTaskbarProperty, binding);
public static Window ShowInTaskbar(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.ShowInTaskbarProperty, avaloniaProperty, bindingMode, converter);
public static Window ShowInTaskbar(this Window control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.ShowInTaskbarProperty, func, expression);
public static Window ShowInTaskbar(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = value, bindingMode, converter, bindingSource);
public static Window ShowInTaskbar<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.ShowInTaskbarProperty, ps, () => control.ShowInTaskbar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window WindowState(this Window control, IBinding binding)
   => control._set(Window.WindowStateProperty, binding);
public static Window WindowState(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.WindowStateProperty, avaloniaProperty, bindingMode, converter);
public static Window WindowState(this Window control, Func<WindowState> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.WindowStateProperty, func, expression);
public static Window WindowState(this Window control, WindowState value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = value, bindingMode, converter, bindingSource);
public static Window WindowState<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowState> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStateProperty, ps, () => control.WindowState = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window Title(this Window control, IBinding binding)
   => control._set(Window.TitleProperty, binding);
public static Window Title(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.TitleProperty, avaloniaProperty, bindingMode, converter);
public static Window Title(this Window control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.TitleProperty, func, expression);
public static Window Title(this Window control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.TitleProperty, ps, () => control.Title = value, bindingMode, converter, bindingSource);
public static Window Title<TValue>(this Window control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.TitleProperty, ps, () => control.Title = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window Icon(this Window control, IBinding binding)
   => control._set(Window.IconProperty, binding);
public static Window Icon(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.IconProperty, avaloniaProperty, bindingMode, converter);
public static Window Icon(this Window control, Func<WindowIcon> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.IconProperty, func, expression);
public static Window Icon(this Window control, WindowIcon value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.IconProperty, ps, () => control.Icon = value, bindingMode, converter, bindingSource);
public static Window Icon<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowIcon> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.IconProperty, ps, () => control.Icon = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window WindowStartupLocation(this Window control, IBinding binding)
   => control._set(Window.WindowStartupLocationProperty, binding);
public static Window WindowStartupLocation(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.WindowStartupLocationProperty, avaloniaProperty, bindingMode, converter);
public static Window WindowStartupLocation(this Window control, Func<WindowStartupLocation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.WindowStartupLocationProperty, func, expression);
public static Window WindowStartupLocation(this Window control, WindowStartupLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = value, bindingMode, converter, bindingSource);
public static Window WindowStartupLocation<TValue>(this Window control, TValue value, FuncValueConverter<TValue, WindowStartupLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.WindowStartupLocationProperty, ps, () => control.WindowStartupLocation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Window CanResize(this Window control, IBinding binding)
   => control._set(Window.CanResizeProperty, binding);
public static Window CanResize(this Window control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Window.CanResizeProperty, avaloniaProperty, bindingMode, converter);
public static Window CanResize(this Window control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Window.CanResizeProperty, func, expression);
public static Window CanResize(this Window control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = value, bindingMode, converter, bindingSource);
public static Window CanResize<TValue>(this Window control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Window.CanResizeProperty, ps, () => control.CanResize = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class WindowBaseExtensions
{
public static WindowBase Topmost(this WindowBase control, IBinding binding)
   => control._set(WindowBase.TopmostProperty, binding);
public static WindowBase Topmost(this WindowBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WindowBase.TopmostProperty, avaloniaProperty, bindingMode, converter);
public static WindowBase Topmost(this WindowBase control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowBase.TopmostProperty, func, expression);
public static WindowBase Topmost(this WindowBase control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowBase.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static WindowBase Topmost<TValue>(this WindowBase control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowBase.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class WrapPanelExtensions
{
public static WrapPanel Orientation(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.OrientationProperty, binding);
public static WrapPanel Orientation(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WrapPanel.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static WrapPanel Orientation(this WrapPanel control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.OrientationProperty, func, expression);
public static WrapPanel Orientation(this WrapPanel control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static WrapPanel Orientation<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WrapPanel ItemWidth(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.ItemWidthProperty, binding);
public static WrapPanel ItemWidth(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WrapPanel.ItemWidthProperty, avaloniaProperty, bindingMode, converter);
public static WrapPanel ItemWidth(this WrapPanel control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.ItemWidthProperty, func, expression);
public static WrapPanel ItemWidth(this WrapPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = value, bindingMode, converter, bindingSource);
public static WrapPanel ItemWidth<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemWidthProperty, ps, () => control.ItemWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WrapPanel ItemHeight(this WrapPanel control, IBinding binding)
   => control._set(WrapPanel.ItemHeightProperty, binding);
public static WrapPanel ItemHeight(this WrapPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WrapPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter);
public static WrapPanel ItemHeight(this WrapPanel control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WrapPanel.ItemHeightProperty, func, expression);
public static WrapPanel ItemHeight(this WrapPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static WrapPanel ItemHeight<TValue>(this WrapPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WrapPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ArcExtensions
{
public static Arc StartAngle(this Arc control, IBinding binding)
   => control._set(Arc.StartAngleProperty, binding);
public static Arc StartAngle(this Arc control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Arc.StartAngleProperty, avaloniaProperty, bindingMode, converter);
public static Arc StartAngle(this Arc control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Arc.StartAngleProperty, func, expression);
public static Arc StartAngle(this Arc control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static Arc StartAngle<TValue>(this Arc control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Arc SweepAngle(this Arc control, IBinding binding)
   => control._set(Arc.SweepAngleProperty, binding);
public static Arc SweepAngle(this Arc control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Arc.SweepAngleProperty, avaloniaProperty, bindingMode, converter);
public static Arc SweepAngle(this Arc control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Arc.SweepAngleProperty, func, expression);
public static Arc SweepAngle(this Arc control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static Arc SweepAngle<TValue>(this Arc control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Arc.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class LineExtensions
{
public static Line StartPoint(this Line control, IBinding binding)
   => control._set(Line.StartPointProperty, binding);
public static Line StartPoint(this Line control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Line.StartPointProperty, avaloniaProperty, bindingMode, converter);
public static Line StartPoint(this Line control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Line.StartPointProperty, func, expression);
public static Line StartPoint(this Line control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Line.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static Line StartPoint<TValue>(this Line control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Line.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Line EndPoint(this Line control, IBinding binding)
   => control._set(Line.EndPointProperty, binding);
public static Line EndPoint(this Line control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Line.EndPointProperty, avaloniaProperty, bindingMode, converter);
public static Line EndPoint(this Line control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Line.EndPointProperty, func, expression);
public static Line EndPoint(this Line control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Line.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static Line EndPoint<TValue>(this Line control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Line.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PathExtensions
{
public static Path Data(this Path control, IBinding binding)
   => control._set(Path.DataProperty, binding);
public static Path Data(this Path control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Path.DataProperty, avaloniaProperty, bindingMode, converter);
public static Path Data(this Path control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Path.DataProperty, func, expression);
public static Path Data(this Path control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Path.DataProperty, ps, () => control.Data = value, bindingMode, converter, bindingSource);
public static Path Data<TValue>(this Path control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Path.DataProperty, ps, () => control.Data = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PolygonExtensions
{
public static Polygon Points(this Polygon control, IBinding binding)
   => control._set(Polygon.PointsProperty, binding);
public static Polygon Points(this Polygon control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Polygon.PointsProperty, avaloniaProperty, bindingMode, converter);
public static Polygon Points(this Polygon control, Func<IList<Point>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Polygon.PointsProperty, func, expression);
public static Polygon Points(this Polygon control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polygon.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static Polygon Points<TValue>(this Polygon control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polygon.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PolylineExtensions
{
public static Polyline Points(this Polyline control, IBinding binding)
   => control._set(Polyline.PointsProperty, binding);
public static Polyline Points(this Polyline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Polyline.PointsProperty, avaloniaProperty, bindingMode, converter);
public static Polyline Points(this Polyline control, Func<IList<Point>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Polyline.PointsProperty, func, expression);
public static Polyline Points(this Polyline control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polyline.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static Polyline Points<TValue>(this Polyline control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Polyline.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RectangleExtensions
{
public static Rectangle RadiusX(this Rectangle control, IBinding binding)
   => control._set(Rectangle.RadiusXProperty, binding);
public static Rectangle RadiusX(this Rectangle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rectangle.RadiusXProperty, avaloniaProperty, bindingMode, converter);
public static Rectangle RadiusX(this Rectangle control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rectangle.RadiusXProperty, func, expression);
public static Rectangle RadiusX(this Rectangle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static Rectangle RadiusX<TValue>(this Rectangle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rectangle RadiusY(this Rectangle control, IBinding binding)
   => control._set(Rectangle.RadiusYProperty, binding);
public static Rectangle RadiusY(this Rectangle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rectangle.RadiusYProperty, avaloniaProperty, bindingMode, converter);
public static Rectangle RadiusY(this Rectangle control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rectangle.RadiusYProperty, func, expression);
public static Rectangle RadiusY(this Rectangle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static Rectangle RadiusY<TValue>(this Rectangle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rectangle.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SectorExtensions
{
public static Sector StartAngle(this Sector control, IBinding binding)
   => control._set(Sector.StartAngleProperty, binding);
public static Sector StartAngle(this Sector control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Sector.StartAngleProperty, avaloniaProperty, bindingMode, converter);
public static Sector StartAngle(this Sector control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Sector.StartAngleProperty, func, expression);
public static Sector StartAngle(this Sector control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = value, bindingMode, converter, bindingSource);
public static Sector StartAngle<TValue>(this Sector control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.StartAngleProperty, ps, () => control.StartAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Sector SweepAngle(this Sector control, IBinding binding)
   => control._set(Sector.SweepAngleProperty, binding);
public static Sector SweepAngle(this Sector control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Sector.SweepAngleProperty, avaloniaProperty, bindingMode, converter);
public static Sector SweepAngle(this Sector control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Sector.SweepAngleProperty, func, expression);
public static Sector SweepAngle(this Sector control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = value, bindingMode, converter, bindingSource);
public static Sector SweepAngle<TValue>(this Sector control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Sector.SweepAngleProperty, ps, () => control.SweepAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ShapeExtensions
{
public static Shape Fill(this Shape control, IBinding binding)
   => control._set(Shape.FillProperty, binding);
public static Shape Fill(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.FillProperty, avaloniaProperty, bindingMode, converter);
public static Shape Fill(this Shape control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.FillProperty, func, expression);
public static Shape Fill(this Shape control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.FillProperty, ps, () => control.Fill = value, bindingMode, converter, bindingSource);
public static Shape Fill<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.FillProperty, ps, () => control.Fill = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape Stretch(this Shape control, IBinding binding)
   => control._set(Shape.StretchProperty, binding);
public static Shape Stretch(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StretchProperty, avaloniaProperty, bindingMode, converter);
public static Shape Stretch(this Shape control, Func<Stretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StretchProperty, func, expression);
public static Shape Stretch(this Shape control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static Shape Stretch<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape Stroke(this Shape control, IBinding binding)
   => control._set(Shape.StrokeProperty, binding);
public static Shape Stroke(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeProperty, avaloniaProperty, bindingMode, converter);
public static Shape Stroke(this Shape control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeProperty, func, expression);
public static Shape Stroke(this Shape control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static Shape Stroke<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeDashArray(this Shape control, IBinding binding)
   => control._set(Shape.StrokeDashArrayProperty, binding);
public static Shape StrokeDashArray(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter);
public static Shape StrokeDashArray(this Shape control, Func<AvaloniaList<Double>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeDashArrayProperty, func, expression);
public static Shape StrokeDashArray(this Shape control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static Shape StrokeDashArray<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeDashOffset(this Shape control, IBinding binding)
   => control._set(Shape.StrokeDashOffsetProperty, binding);
public static Shape StrokeDashOffset(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter);
public static Shape StrokeDashOffset(this Shape control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeDashOffsetProperty, func, expression);
public static Shape StrokeDashOffset(this Shape control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static Shape StrokeDashOffset<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeThickness(this Shape control, IBinding binding)
   => control._set(Shape.StrokeThicknessProperty, binding);
public static Shape StrokeThickness(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter);
public static Shape StrokeThickness(this Shape control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeThicknessProperty, func, expression);
public static Shape StrokeThickness(this Shape control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static Shape StrokeThickness<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeLineCap(this Shape control, IBinding binding)
   => control._set(Shape.StrokeLineCapProperty, binding);
public static Shape StrokeLineCap(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter);
public static Shape StrokeLineCap(this Shape control, Func<PenLineCap> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeLineCapProperty, func, expression);
public static Shape StrokeLineCap(this Shape control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static Shape StrokeLineCap<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Shape StrokeJoin(this Shape control, IBinding binding)
   => control._set(Shape.StrokeJoinProperty, binding);
public static Shape StrokeJoin(this Shape control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Shape.StrokeJoinProperty, avaloniaProperty, bindingMode, converter);
public static Shape StrokeJoin(this Shape control, Func<PenLineJoin> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Shape.StrokeJoinProperty, func, expression);
public static Shape StrokeJoin(this Shape control, PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = value, bindingMode, converter, bindingSource);
public static Shape StrokeJoin<TValue>(this Shape control, TValue value, FuncValueConverter<TValue, PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Shape.StrokeJoinProperty, ps, () => control.StrokeJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ContentPresenterExtensions
{
public static ContentPresenter Background(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BackgroundProperty, binding);
public static ContentPresenter Background(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter Background(this ContentPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BackgroundProperty, func, expression);
public static ContentPresenter Background(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static ContentPresenter Background<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BorderBrushProperty, binding);
public static ContentPresenter BorderBrush(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.BorderBrushProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter BorderBrush(this ContentPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BorderBrushProperty, func, expression);
public static ContentPresenter BorderBrush(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static ContentPresenter BorderBrush<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter BorderThickness(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BorderThicknessProperty, binding);
public static ContentPresenter BorderThickness(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.BorderThicknessProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter BorderThickness(this ContentPresenter control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BorderThicknessProperty, func, expression);
public static ContentPresenter BorderThickness(this ContentPresenter control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static ContentPresenter BorderThickness<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter BorderThickness(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static ContentPresenter BorderThickness(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.CornerRadiusProperty, binding);
public static ContentPresenter CornerRadius(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.CornerRadiusProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter CornerRadius(this ContentPresenter control, Func<CornerRadius> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.CornerRadiusProperty, func, expression);
public static ContentPresenter CornerRadius(this ContentPresenter control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static ContentPresenter CornerRadius<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter CornerRadius(this ContentPresenter control, Double uniformRadius)
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double top, Double bottom)
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static ContentPresenter CornerRadius(this ContentPresenter control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft)
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static ContentPresenter BoxShadow(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.BoxShadowProperty, binding);
public static ContentPresenter BoxShadow(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.BoxShadowProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter BoxShadow(this ContentPresenter control, Func<BoxShadows> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.BoxShadowProperty, func, expression);
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadows value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = value, bindingMode, converter, bindingSource);
public static ContentPresenter BoxShadow<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, BoxShadows> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.BoxShadowProperty, ps, () => control.BoxShadow = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow shadow)
   => control._set(() => control.BoxShadow = new BoxShadows(shadow));
public static ContentPresenter BoxShadow(this ContentPresenter control, BoxShadow first, BoxShadow[] rest)
   => control._set(() => control.BoxShadow = new BoxShadows(first, rest));
public static ContentPresenter Foreground(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ForegroundProperty, binding);
public static ContentPresenter Foreground(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.ForegroundProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter Foreground(this ContentPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ForegroundProperty, func, expression);
public static ContentPresenter Foreground(this ContentPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static ContentPresenter Foreground<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontFamily(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontFamilyProperty, binding);
public static ContentPresenter FontFamily(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.FontFamilyProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter FontFamily(this ContentPresenter control, Func<FontFamily> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontFamilyProperty, func, expression);
public static ContentPresenter FontFamily(this ContentPresenter control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontFamily<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontSize(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontSizeProperty, binding);
public static ContentPresenter FontSize(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.FontSizeProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter FontSize(this ContentPresenter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontSizeProperty, func, expression);
public static ContentPresenter FontSize(this ContentPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontSize<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontStyle(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontStyleProperty, binding);
public static ContentPresenter FontStyle(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.FontStyleProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter FontStyle(this ContentPresenter control, Func<FontStyle> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontStyleProperty, func, expression);
public static ContentPresenter FontStyle(this ContentPresenter control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontStyle<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontWeight(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontWeightProperty, binding);
public static ContentPresenter FontWeight(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.FontWeightProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter FontWeight(this ContentPresenter control, Func<FontWeight> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontWeightProperty, func, expression);
public static ContentPresenter FontWeight(this ContentPresenter control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontWeight<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter FontStretch(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.FontStretchProperty, binding);
public static ContentPresenter FontStretch(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.FontStretchProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter FontStretch(this ContentPresenter control, Func<FontStretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.FontStretchProperty, func, expression);
public static ContentPresenter FontStretch(this ContentPresenter control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static ContentPresenter FontStretch<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextAlignmentProperty, binding);
public static ContentPresenter TextAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter TextAlignment(this ContentPresenter control, Func<TextAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextAlignmentProperty, func, expression);
public static ContentPresenter TextAlignment(this ContentPresenter control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextWrapping(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextWrappingProperty, binding);
public static ContentPresenter TextWrapping(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter TextWrapping(this ContentPresenter control, Func<TextWrapping> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextWrappingProperty, func, expression);
public static ContentPresenter TextWrapping(this ContentPresenter control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextWrapping<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter TextTrimming(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.TextTrimmingProperty, binding);
public static ContentPresenter TextTrimming(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.TextTrimmingProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter TextTrimming(this ContentPresenter control, Func<TextTrimming> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.TextTrimmingProperty, func, expression);
public static ContentPresenter TextTrimming(this ContentPresenter control, TextTrimming value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = value, bindingMode, converter, bindingSource);
public static ContentPresenter TextTrimming<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, TextTrimming> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.TextTrimmingProperty, ps, () => control.TextTrimming = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter LineHeight(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.LineHeightProperty, binding);
public static ContentPresenter LineHeight(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter LineHeight(this ContentPresenter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.LineHeightProperty, func, expression);
public static ContentPresenter LineHeight(this ContentPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static ContentPresenter LineHeight<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter MaxLines(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.MaxLinesProperty, binding);
public static ContentPresenter MaxLines(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.MaxLinesProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter MaxLines(this ContentPresenter control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.MaxLinesProperty, func, expression);
public static ContentPresenter MaxLines(this ContentPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = value, bindingMode, converter, bindingSource);
public static ContentPresenter MaxLines<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.MaxLinesProperty, ps, () => control.MaxLines = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter Content(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ContentProperty, binding);
public static ContentPresenter Content(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.ContentProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter Content(this ContentPresenter control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ContentProperty, func, expression);
public static ContentPresenter Content(this ContentPresenter control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentProperty, ps, () => control.Content = value, bindingMode, converter, bindingSource);
public static ContentPresenter Content<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentProperty, ps, () => control.Content = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.ContentTemplateProperty, binding);
public static ContentPresenter ContentTemplate(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.ContentTemplateProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter ContentTemplate(this ContentPresenter control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.ContentTemplateProperty, func, expression);
public static ContentPresenter ContentTemplate(this ContentPresenter control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = value, bindingMode, converter, bindingSource);
public static ContentPresenter ContentTemplate<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.ContentTemplateProperty, ps, () => control.ContentTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, binding);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.HorizontalContentAlignmentProperty, func, expression);
public static ContentPresenter HorizontalContentAlignment(this ContentPresenter control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter HorizontalContentAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.HorizontalContentAlignmentProperty, ps, () => control.HorizontalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, binding);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.VerticalContentAlignmentProperty, func, expression);
public static ContentPresenter VerticalContentAlignment(this ContentPresenter control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = value, bindingMode, converter, bindingSource);
public static ContentPresenter VerticalContentAlignment<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.VerticalContentAlignmentProperty, ps, () => control.VerticalContentAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ContentPresenter Padding(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.PaddingProperty, binding);
public static ContentPresenter Padding(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.PaddingProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter Padding(this ContentPresenter control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.PaddingProperty, func, expression);
public static ContentPresenter Padding(this ContentPresenter control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static ContentPresenter Padding<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ContentPresenter Padding(this ContentPresenter control, Double uniformLength)
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static ContentPresenter Padding(this ContentPresenter control, Double horizontal, Double vertical)
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static ContentPresenter Padding(this ContentPresenter control, Double left, Double top, Double right, Double bottom)
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, IBinding binding)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, binding);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, avaloniaProperty, bindingMode, converter);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ContentPresenter.RecognizesAccessKeyProperty, func, expression);
public static ContentPresenter RecognizesAccessKey(this ContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = value, bindingMode, converter, bindingSource);
public static ContentPresenter RecognizesAccessKey<TValue>(this ContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ContentPresenter.RecognizesAccessKeyProperty, ps, () => control.RecognizesAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ItemsPresenterExtensions
{
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, IBinding binding)
   => control._set(ItemsPresenter.ItemsPanelProperty, binding);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ItemsPresenter.ItemsPanelProperty, avaloniaProperty, bindingMode, converter);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, Func<ITemplate<Panel>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ItemsPresenter.ItemsPanelProperty, func, expression);
public static ItemsPresenter ItemsPanel(this ItemsPresenter control, ITemplate<Panel> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = value, bindingMode, converter, bindingSource);
public static ItemsPresenter ItemsPanel<TValue>(this ItemsPresenter control, TValue value, FuncValueConverter<TValue, ITemplate<Panel>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ItemsPresenter.ItemsPanelProperty, ps, () => control.ItemsPanel = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ScrollContentPresenterExtensions
{
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, binding);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.CanHorizontallyScrollProperty, func, expression);
public static ScrollContentPresenter CanHorizontallyScroll(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanHorizontallyScroll<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, binding);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.CanVerticallyScrollProperty, func, expression);
public static ScrollContentPresenter CanVerticallyScroll(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter CanVerticallyScroll<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.OffsetProperty, binding);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.OffsetProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Func<Vector> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.OffsetProperty, func, expression);
public static ScrollContentPresenter Offset(this ScrollContentPresenter control, Vector value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter Offset<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Vector> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, binding);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, Func<SnapPointsType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, func, expression);
public static ScrollContentPresenter HorizontalSnapPointsType(this ScrollContentPresenter control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsType<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsTypeProperty, ps, () => control.HorizontalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, binding);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, Func<SnapPointsType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsTypeProperty, func, expression);
public static ScrollContentPresenter VerticalSnapPointsType(this ScrollContentPresenter control, SnapPointsType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsType<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsTypeProperty, ps, () => control.VerticalSnapPointsType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, binding);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, Func<SnapPointsAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, func, expression);
public static ScrollContentPresenter HorizontalSnapPointsAlignment(this ScrollContentPresenter control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter HorizontalSnapPointsAlignment<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.HorizontalSnapPointsAlignmentProperty, ps, () => control.HorizontalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, binding);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, Func<SnapPointsAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, func, expression);
public static ScrollContentPresenter VerticalSnapPointsAlignment(this ScrollContentPresenter control, SnapPointsAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter VerticalSnapPointsAlignment<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, SnapPointsAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.VerticalSnapPointsAlignmentProperty, ps, () => control.VerticalSnapPointsAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, IBinding binding)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, binding);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, avaloniaProperty, bindingMode, converter);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollContentPresenter.IsScrollChainingEnabledProperty, func, expression);
public static ScrollContentPresenter IsScrollChainingEnabled(this ScrollContentPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = value, bindingMode, converter, bindingSource);
public static ScrollContentPresenter IsScrollChainingEnabled<TValue>(this ScrollContentPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollContentPresenter.IsScrollChainingEnabledProperty, ps, () => control.IsScrollChainingEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TextPresenterExtensions
{
public static TextPresenter CaretIndex(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.CaretIndexProperty, binding);
public static TextPresenter CaretIndex(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.CaretIndexProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter CaretIndex(this TextPresenter control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.CaretIndexProperty, func, expression);
public static TextPresenter CaretIndex(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);
public static TextPresenter CaretIndex<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter RevealPassword(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.RevealPasswordProperty, binding);
public static TextPresenter RevealPassword(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.RevealPasswordProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter RevealPassword(this TextPresenter control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.RevealPasswordProperty, func, expression);
public static TextPresenter RevealPassword(this TextPresenter control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = value, bindingMode, converter, bindingSource);
public static TextPresenter RevealPassword<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.RevealPasswordProperty, ps, () => control.RevealPassword = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter PasswordChar(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.PasswordCharProperty, binding);
public static TextPresenter PasswordChar(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.PasswordCharProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter PasswordChar(this TextPresenter control, Func<Char> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.PasswordCharProperty, func, expression);
public static TextPresenter PasswordChar(this TextPresenter control, Char value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = value, bindingMode, converter, bindingSource);
public static TextPresenter PasswordChar<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Char> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PasswordCharProperty, ps, () => control.PasswordChar = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionBrushProperty, binding);
public static TextPresenter SelectionBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.SelectionBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter SelectionBrush(this TextPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionBrushProperty, func, expression);
public static TextPresenter SelectionBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionBrushProperty, ps, () => control.SelectionBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, binding);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionForegroundBrushProperty, func, expression);
public static TextPresenter SelectionForegroundBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionForegroundBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionForegroundBrushProperty, ps, () => control.SelectionForegroundBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter CaretBrush(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.CaretBrushProperty, binding);
public static TextPresenter CaretBrush(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.CaretBrushProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter CaretBrush(this TextPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.CaretBrushProperty, func, expression);
public static TextPresenter CaretBrush(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = value, bindingMode, converter, bindingSource);
public static TextPresenter CaretBrush<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.CaretBrushProperty, ps, () => control.CaretBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionStart(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionStartProperty, binding);
public static TextPresenter SelectionStart(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.SelectionStartProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter SelectionStart(this TextPresenter control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionStartProperty, func, expression);
public static TextPresenter SelectionStart(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionStart<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionStartProperty, ps, () => control.SelectionStart = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter SelectionEnd(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.SelectionEndProperty, binding);
public static TextPresenter SelectionEnd(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.SelectionEndProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter SelectionEnd(this TextPresenter control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.SelectionEndProperty, func, expression);
public static TextPresenter SelectionEnd(this TextPresenter control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = value, bindingMode, converter, bindingSource);
public static TextPresenter SelectionEnd<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.SelectionEndProperty, ps, () => control.SelectionEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter Text(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextProperty, binding);
public static TextPresenter Text(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.TextProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter Text(this TextPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextProperty, func, expression);
public static TextPresenter Text(this TextPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static TextPresenter Text<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter PreeditText(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.PreeditTextProperty, binding);
public static TextPresenter PreeditText(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.PreeditTextProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter PreeditText(this TextPresenter control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.PreeditTextProperty, func, expression);
public static TextPresenter PreeditText(this TextPresenter control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = value, bindingMode, converter, bindingSource);
public static TextPresenter PreeditText<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.PreeditTextProperty, ps, () => control.PreeditText = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter TextAlignment(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextAlignmentProperty, binding);
public static TextPresenter TextAlignment(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.TextAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter TextAlignment(this TextPresenter control, Func<TextAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextAlignmentProperty, func, expression);
public static TextPresenter TextAlignment(this TextPresenter control, TextAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = value, bindingMode, converter, bindingSource);
public static TextPresenter TextAlignment<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, TextAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextAlignmentProperty, ps, () => control.TextAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter TextWrapping(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.TextWrappingProperty, binding);
public static TextPresenter TextWrapping(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.TextWrappingProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter TextWrapping(this TextPresenter control, Func<TextWrapping> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.TextWrappingProperty, func, expression);
public static TextPresenter TextWrapping(this TextPresenter control, TextWrapping value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = value, bindingMode, converter, bindingSource);
public static TextPresenter TextWrapping<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, TextWrapping> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.TextWrappingProperty, ps, () => control.TextWrapping = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter LineHeight(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.LineHeightProperty, binding);
public static TextPresenter LineHeight(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.LineHeightProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter LineHeight(this TextPresenter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.LineHeightProperty, func, expression);
public static TextPresenter LineHeight(this TextPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = value, bindingMode, converter, bindingSource);
public static TextPresenter LineHeight<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LineHeightProperty, ps, () => control.LineHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter LetterSpacing(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.LetterSpacingProperty, binding);
public static TextPresenter LetterSpacing(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.LetterSpacingProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter LetterSpacing(this TextPresenter control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.LetterSpacingProperty, func, expression);
public static TextPresenter LetterSpacing(this TextPresenter control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = value, bindingMode, converter, bindingSource);
public static TextPresenter LetterSpacing<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.LetterSpacingProperty, ps, () => control.LetterSpacing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextPresenter Background(this TextPresenter control, IBinding binding)
   => control._set(TextPresenter.BackgroundProperty, binding);
public static TextPresenter Background(this TextPresenter control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextPresenter.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static TextPresenter Background(this TextPresenter control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextPresenter.BackgroundProperty, func, expression);
public static TextPresenter Background(this TextPresenter control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextPresenter Background<TValue>(this TextPresenter control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextPresenter.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class NotificationCardExtensions
{
public static NotificationCard IsClosed(this NotificationCard control, IBinding binding)
   => control._set(NotificationCard.IsClosedProperty, binding);
public static NotificationCard IsClosed(this NotificationCard control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(NotificationCard.IsClosedProperty, avaloniaProperty, bindingMode, converter);
public static NotificationCard IsClosed(this NotificationCard control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(NotificationCard.IsClosedProperty, func, expression);
public static NotificationCard IsClosed(this NotificationCard control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static NotificationCard IsClosed<TValue>(this NotificationCard control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(NotificationCard.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class WindowNotificationManagerExtensions
{
public static WindowNotificationManager Position(this WindowNotificationManager control, IBinding binding)
   => control._set(WindowNotificationManager.PositionProperty, binding);
public static WindowNotificationManager Position(this WindowNotificationManager control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WindowNotificationManager.PositionProperty, avaloniaProperty, bindingMode, converter);
public static WindowNotificationManager Position(this WindowNotificationManager control, Func<NotificationPosition> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowNotificationManager.PositionProperty, func, expression);
public static WindowNotificationManager Position(this WindowNotificationManager control, NotificationPosition value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = value, bindingMode, converter, bindingSource);
public static WindowNotificationManager Position<TValue>(this WindowNotificationManager control, TValue value, FuncValueConverter<TValue, NotificationPosition> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.PositionProperty, ps, () => control.Position = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, IBinding binding)
   => control._set(WindowNotificationManager.MaxItemsProperty, binding);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(WindowNotificationManager.MaxItemsProperty, avaloniaProperty, bindingMode, converter);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(WindowNotificationManager.MaxItemsProperty, func, expression);
public static WindowNotificationManager MaxItems(this WindowNotificationManager control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = value, bindingMode, converter, bindingSource);
public static WindowNotificationManager MaxItems<TValue>(this WindowNotificationManager control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(WindowNotificationManager.MaxItemsProperty, ps, () => control.MaxItems = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class InlineExtensions
{
public static Inline TextDecorations(this Inline control, IBinding binding)
   => control._set(Inline.TextDecorationsProperty, binding);
public static Inline TextDecorations(this Inline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Inline.TextDecorationsProperty, avaloniaProperty, bindingMode, converter);
public static Inline TextDecorations(this Inline control, Func<TextDecorationCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Inline.TextDecorationsProperty, func, expression);
public static Inline TextDecorations(this Inline control, TextDecorationCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.TextDecorationsProperty, ps, () => control.TextDecorations = value, bindingMode, converter, bindingSource);
public static Inline TextDecorations<TValue>(this Inline control, TValue value, FuncValueConverter<TValue, TextDecorationCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.TextDecorationsProperty, ps, () => control.TextDecorations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Inline BaselineAlignment(this Inline control, IBinding binding)
   => control._set(Inline.BaselineAlignmentProperty, binding);
public static Inline BaselineAlignment(this Inline control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Inline.BaselineAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static Inline BaselineAlignment(this Inline control, Func<BaselineAlignment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Inline.BaselineAlignmentProperty, func, expression);
public static Inline BaselineAlignment(this Inline control, BaselineAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = value, bindingMode, converter, bindingSource);
public static Inline BaselineAlignment<TValue>(this Inline control, TValue value, FuncValueConverter<TValue, BaselineAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Inline.BaselineAlignmentProperty, ps, () => control.BaselineAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class InlineUIContainerExtensions
{
public static InlineUIContainer Child(this InlineUIContainer control, IBinding binding)
   => control._set(InlineUIContainer.ChildProperty, binding);
public static InlineUIContainer Child(this InlineUIContainer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(InlineUIContainer.ChildProperty, avaloniaProperty, bindingMode, converter);
public static InlineUIContainer Child(this InlineUIContainer control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(InlineUIContainer.ChildProperty, func, expression);
public static InlineUIContainer Child(this InlineUIContainer control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static InlineUIContainer Child<TValue>(this InlineUIContainer control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(InlineUIContainer.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RunExtensions
{
public static Run Text(this Run control, IBinding binding)
   => control._set(Run.TextProperty, binding);
public static Run Text(this Run control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Run.TextProperty, avaloniaProperty, bindingMode, converter);
public static Run Text(this Run control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Run.TextProperty, func, expression);
public static Run Text(this Run control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Run.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);
public static Run Text<TValue>(this Run control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Run.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SpanExtensions
{
public static Span Inlines(this Span control, IBinding binding)
   => control._set(Span.InlinesProperty, binding);
public static Span Inlines(this Span control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Span.InlinesProperty, avaloniaProperty, bindingMode, converter);
public static Span Inlines(this Span control, Func<InlineCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Span.InlinesProperty, func, expression);
public static Span Inlines(this Span control, InlineCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = value, bindingMode, converter, bindingSource);
public static Span Inlines<TValue>(this Span control, TValue value, FuncValueConverter<TValue, InlineCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Span.InlinesProperty, ps, () => control.Inlines = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TextElementExtensions
{
public static TextElement Background(this TextElement control, IBinding binding)
   => control._set(TextElement.BackgroundProperty, binding);
public static TextElement Background(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static TextElement Background(this TextElement control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.BackgroundProperty, func, expression);
public static TextElement Background(this TextElement control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static TextElement Background<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontFamily(this TextElement control, IBinding binding)
   => control._set(TextElement.FontFamilyProperty, binding);
public static TextElement FontFamily(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.FontFamilyProperty, avaloniaProperty, bindingMode, converter);
public static TextElement FontFamily(this TextElement control, Func<FontFamily> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontFamilyProperty, func, expression);
public static TextElement FontFamily(this TextElement control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static TextElement FontFamily<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontSize(this TextElement control, IBinding binding)
   => control._set(TextElement.FontSizeProperty, binding);
public static TextElement FontSize(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.FontSizeProperty, avaloniaProperty, bindingMode, converter);
public static TextElement FontSize(this TextElement control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontSizeProperty, func, expression);
public static TextElement FontSize(this TextElement control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static TextElement FontSize<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontStyle(this TextElement control, IBinding binding)
   => control._set(TextElement.FontStyleProperty, binding);
public static TextElement FontStyle(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.FontStyleProperty, avaloniaProperty, bindingMode, converter);
public static TextElement FontStyle(this TextElement control, Func<FontStyle> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontStyleProperty, func, expression);
public static TextElement FontStyle(this TextElement control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static TextElement FontStyle<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontWeight(this TextElement control, IBinding binding)
   => control._set(TextElement.FontWeightProperty, binding);
public static TextElement FontWeight(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.FontWeightProperty, avaloniaProperty, bindingMode, converter);
public static TextElement FontWeight(this TextElement control, Func<FontWeight> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontWeightProperty, func, expression);
public static TextElement FontWeight(this TextElement control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static TextElement FontWeight<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement FontStretch(this TextElement control, IBinding binding)
   => control._set(TextElement.FontStretchProperty, binding);
public static TextElement FontStretch(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.FontStretchProperty, avaloniaProperty, bindingMode, converter);
public static TextElement FontStretch(this TextElement control, Func<FontStretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.FontStretchProperty, func, expression);
public static TextElement FontStretch(this TextElement control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static TextElement FontStretch<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextElement Foreground(this TextElement control, IBinding binding)
   => control._set(TextElement.ForegroundProperty, binding);
public static TextElement Foreground(this TextElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextElement.ForegroundProperty, avaloniaProperty, bindingMode, converter);
public static TextElement Foreground(this TextElement control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextElement.ForegroundProperty, func, expression);
public static TextElement Foreground(this TextElement control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static TextElement Foreground<TValue>(this TextElement control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextElement.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CalendarItemExtensions
{
public static CalendarItem HeaderBackground(this CalendarItem control, IBinding binding)
   => control._set(CalendarItem.HeaderBackgroundProperty, binding);
public static CalendarItem HeaderBackground(this CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarItem.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter);
public static CalendarItem HeaderBackground(this CalendarItem control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarItem.HeaderBackgroundProperty, func, expression);
public static CalendarItem HeaderBackground(this CalendarItem control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);
public static CalendarItem HeaderBackground<TValue>(this CalendarItem control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CalendarItem DayTitleTemplate(this CalendarItem control, IBinding binding)
   => control._set(CalendarItem.DayTitleTemplateProperty, binding);
public static CalendarItem DayTitleTemplate(this CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CalendarItem.DayTitleTemplateProperty, avaloniaProperty, bindingMode, converter);
public static CalendarItem DayTitleTemplate(this CalendarItem control, Func<ITemplate<Control>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CalendarItem.DayTitleTemplateProperty, func, expression);
public static CalendarItem DayTitleTemplate(this CalendarItem control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = value, bindingMode, converter, bindingSource);
public static CalendarItem DayTitleTemplate<TValue>(this CalendarItem control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DateTimePickerPanelExtensions
{
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ItemHeightProperty, binding);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DateTimePickerPanel.ItemHeightProperty, avaloniaProperty, bindingMode, converter);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ItemHeightProperty, func, expression);
public static DateTimePickerPanel ItemHeight(this DateTimePickerPanel control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemHeight<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemHeightProperty, ps, () => control.ItemHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.PanelTypeProperty, binding);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DateTimePickerPanel.PanelTypeProperty, avaloniaProperty, bindingMode, converter);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, Func<DateTimePickerPanelType> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.PanelTypeProperty, func, expression);
public static DateTimePickerPanel PanelType(this DateTimePickerPanel control, DateTimePickerPanelType value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel PanelType<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, DateTimePickerPanelType> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.PanelTypeProperty, ps, () => control.PanelType = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ItemFormatProperty, binding);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DateTimePickerPanel.ItemFormatProperty, avaloniaProperty, bindingMode, converter);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ItemFormatProperty, func, expression);
public static DateTimePickerPanel ItemFormat(this DateTimePickerPanel control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ItemFormat<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ItemFormatProperty, ps, () => control.ItemFormat = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, IBinding binding)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, binding);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, avaloniaProperty, bindingMode, converter);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DateTimePickerPanel.ShouldLoopProperty, func, expression);
public static DateTimePickerPanel ShouldLoop(this DateTimePickerPanel control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = value, bindingMode, converter, bindingSource);
public static DateTimePickerPanel ShouldLoop<TValue>(this DateTimePickerPanel control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DateTimePickerPanel.ShouldLoopProperty, ps, () => control.ShouldLoop = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PopupFlyoutBaseExtensions
{
public static T Placement<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, binding);
public static T Placement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, avaloniaProperty, bindingMode, converter);
public static T Placement<T>(this T control, Func<PlacementMode> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementProperty, func, expression);
public static T Placement<T>(this T control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static T Placement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T HorizontalOffset<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, binding);
public static T HorizontalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static T HorizontalOffset<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.HorizontalOffsetProperty, func, expression);
public static T HorizontalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static T HorizontalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalOffset<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, binding);
public static T VerticalOffset<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static T VerticalOffset<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.VerticalOffsetProperty, func, expression);
public static T VerticalOffset<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static T VerticalOffset<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementAnchor<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, binding);
public static T PlacementAnchor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter);
public static T PlacementAnchor<T>(this T control, Func<PopupAnchor> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementAnchorProperty, func, expression);
public static T PlacementAnchor<T>(this T control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static T PlacementAnchor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T PlacementGravity<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, binding);
public static T PlacementGravity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, avaloniaProperty, bindingMode, converter);
public static T PlacementGravity<T>(this T control, Func<PopupGravity> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.PlacementGravityProperty, func, expression);
public static T PlacementGravity<T>(this T control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static T PlacementGravity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ShowMode<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, binding);
public static T ShowMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, avaloniaProperty, bindingMode, converter);
public static T ShowMode<T>(this T control, Func<FlyoutShowMode> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.ShowModeProperty, func, expression);
public static T ShowMode<T>(this T control, FlyoutShowMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = value, bindingMode, converter, bindingSource);
public static T ShowMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlyoutShowMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.ShowModeProperty, ps, () => control.ShowMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T>(this T control, IBinding binding) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, binding);
public static T OverlayInputPassThroughElement<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter);
public static T OverlayInputPassThroughElement<T>(this T control, Func<IInputElement> func, [CallerArgumentExpression("func")] string? expression = null) where T : PopupFlyoutBase
   => control._set(PopupFlyoutBase.OverlayInputPassThroughElementProperty, func, expression);
public static T OverlayInputPassThroughElement<T>(this T control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static T OverlayInputPassThroughElement<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : PopupFlyoutBase
=> control._setEx(PopupFlyoutBase.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class AccessTextExtensions
{
public static AccessText ShowAccessKey(this AccessText control, IBinding binding)
   => control._set(AccessText.ShowAccessKeyProperty, binding);
public static AccessText ShowAccessKey(this AccessText control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AccessText.ShowAccessKeyProperty, avaloniaProperty, bindingMode, converter);
public static AccessText ShowAccessKey(this AccessText control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AccessText.ShowAccessKeyProperty, func, expression);
public static AccessText ShowAccessKey(this AccessText control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = value, bindingMode, converter, bindingSource);
public static AccessText ShowAccessKey<TValue>(this AccessText control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AccessText.ShowAccessKeyProperty, ps, () => control.ShowAccessKey = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class AdornerLayerExtensions
{
public static AdornerLayer DefaultFocusAdorner(this AdornerLayer control, IBinding binding)
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, binding);
public static AdornerLayer DefaultFocusAdorner(this AdornerLayer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, avaloniaProperty, bindingMode, converter);
public static AdornerLayer DefaultFocusAdorner(this AdornerLayer control, Func<ITemplate<Control>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(AdornerLayer.DefaultFocusAdornerProperty, func, expression);
public static AdornerLayer DefaultFocusAdorner(this AdornerLayer control, ITemplate<Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = value, bindingMode, converter, bindingSource);
public static AdornerLayer DefaultFocusAdorner<TValue>(this AdornerLayer control, TValue value, FuncValueConverter<TValue, ITemplate<Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(AdornerLayer.DefaultFocusAdornerProperty, ps, () => control.DefaultFocusAdorner = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class HeaderedContentControlExtensions
{
public static HeaderedContentControl Header(this HeaderedContentControl control, IBinding binding)
   => control._set(HeaderedContentControl.HeaderProperty, binding);
public static HeaderedContentControl Header(this HeaderedContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedContentControl.HeaderProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedContentControl Header(this HeaderedContentControl control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedContentControl.HeaderProperty, func, expression);
public static HeaderedContentControl Header(this HeaderedContentControl control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static HeaderedContentControl Header<TValue>(this HeaderedContentControl control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IBinding binding)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, binding);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedContentControl.HeaderTemplateProperty, func, expression);
public static HeaderedContentControl HeaderTemplate(this HeaderedContentControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static HeaderedContentControl HeaderTemplate<TValue>(this HeaderedContentControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedContentControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class HeaderedItemsControlExtensions
{
public static HeaderedItemsControl Header(this HeaderedItemsControl control, IBinding binding)
   => control._set(HeaderedItemsControl.HeaderProperty, binding);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedItemsControl.HeaderProperty, func, expression);
public static HeaderedItemsControl Header(this HeaderedItemsControl control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static HeaderedItemsControl Header<TValue>(this HeaderedItemsControl control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, IBinding binding)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, binding);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedItemsControl.HeaderTemplateProperty, func, expression);
public static HeaderedItemsControl HeaderTemplate(this HeaderedItemsControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static HeaderedItemsControl HeaderTemplate<TValue>(this HeaderedItemsControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class HeaderedSelectingItemsControlExtensions
{
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, IBinding binding)
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, binding);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedSelectingItemsControl.HeaderProperty, func, expression);
public static HeaderedSelectingItemsControl Header(this HeaderedSelectingItemsControl control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = value, bindingMode, converter, bindingSource);
public static HeaderedSelectingItemsControl Header<TValue>(this HeaderedSelectingItemsControl control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedSelectingItemsControl.HeaderProperty, ps, () => control.Header = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static HeaderedSelectingItemsControl HeaderTemplate(this HeaderedSelectingItemsControl control, IBinding binding)
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, binding);
public static HeaderedSelectingItemsControl HeaderTemplate(this HeaderedSelectingItemsControl control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, avaloniaProperty, bindingMode, converter);
public static HeaderedSelectingItemsControl HeaderTemplate(this HeaderedSelectingItemsControl control, Func<IDataTemplate> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(HeaderedSelectingItemsControl.HeaderTemplateProperty, func, expression);
public static HeaderedSelectingItemsControl HeaderTemplate(this HeaderedSelectingItemsControl control, IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = value, bindingMode, converter, bindingSource);
public static HeaderedSelectingItemsControl HeaderTemplate<TValue>(this HeaderedSelectingItemsControl control, TValue value, FuncValueConverter<TValue, IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(HeaderedSelectingItemsControl.HeaderTemplateProperty, ps, () => control.HeaderTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class OverlayPopupHostExtensions
{
public static OverlayPopupHost Transform(this OverlayPopupHost control, IBinding binding)
   => control._set(OverlayPopupHost.TransformProperty, binding);
public static OverlayPopupHost Transform(this OverlayPopupHost control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(OverlayPopupHost.TransformProperty, avaloniaProperty, bindingMode, converter);
public static OverlayPopupHost Transform(this OverlayPopupHost control, Func<Transform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(OverlayPopupHost.TransformProperty, func, expression);
public static OverlayPopupHost Transform(this OverlayPopupHost control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(OverlayPopupHost.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static OverlayPopupHost Transform<TValue>(this OverlayPopupHost control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(OverlayPopupHost.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PopupExtensions
{
public static Popup WindowManagerAddShadowHint(this Popup control, IBinding binding)
   => control._set(Popup.WindowManagerAddShadowHintProperty, binding);
public static Popup WindowManagerAddShadowHint(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.WindowManagerAddShadowHintProperty, avaloniaProperty, bindingMode, converter);
public static Popup WindowManagerAddShadowHint(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.WindowManagerAddShadowHintProperty, func, expression);
public static Popup WindowManagerAddShadowHint(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = value, bindingMode, converter, bindingSource);
public static Popup WindowManagerAddShadowHint<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.WindowManagerAddShadowHintProperty, ps, () => control.WindowManagerAddShadowHint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Child(this Popup control, IBinding binding)
   => control._set(Popup.ChildProperty, binding);
public static Popup Child(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.ChildProperty, avaloniaProperty, bindingMode, converter);
public static Popup Child(this Popup control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.ChildProperty, func, expression);
public static Popup Child(this Popup control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.ChildProperty, ps, () => control.Child = value, bindingMode, converter, bindingSource);
public static Popup Child<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.ChildProperty, ps, () => control.Child = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup InheritsTransform(this Popup control, IBinding binding)
   => control._set(Popup.InheritsTransformProperty, binding);
public static Popup InheritsTransform(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.InheritsTransformProperty, avaloniaProperty, bindingMode, converter);
public static Popup InheritsTransform(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.InheritsTransformProperty, func, expression);
public static Popup InheritsTransform(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = value, bindingMode, converter, bindingSource);
public static Popup InheritsTransform<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.InheritsTransformProperty, ps, () => control.InheritsTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup IsOpen(this Popup control, IBinding binding)
   => control._set(Popup.IsOpenProperty, binding);
public static Popup IsOpen(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.IsOpenProperty, avaloniaProperty, bindingMode, converter);
public static Popup IsOpen(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.IsOpenProperty, func, expression);
public static Popup IsOpen(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = value, bindingMode, converter, bindingSource);
public static Popup IsOpen<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsOpenProperty, ps, () => control.IsOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementAnchor(this Popup control, IBinding binding)
   => control._set(Popup.PlacementAnchorProperty, binding);
public static Popup PlacementAnchor(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementAnchorProperty, avaloniaProperty, bindingMode, converter);
public static Popup PlacementAnchor(this Popup control, Func<PopupAnchor> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementAnchorProperty, func, expression);
public static Popup PlacementAnchor(this Popup control, PopupAnchor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = value, bindingMode, converter, bindingSource);
public static Popup PlacementAnchor<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupAnchor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementAnchorProperty, ps, () => control.PlacementAnchor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementConstraintAdjustment(this Popup control, IBinding binding)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, binding);
public static Popup PlacementConstraintAdjustment(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, avaloniaProperty, bindingMode, converter);
public static Popup PlacementConstraintAdjustment(this Popup control, Func<PopupPositionerConstraintAdjustment> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementConstraintAdjustmentProperty, func, expression);
public static Popup PlacementConstraintAdjustment(this Popup control, PopupPositionerConstraintAdjustment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = value, bindingMode, converter, bindingSource);
public static Popup PlacementConstraintAdjustment<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupPositionerConstraintAdjustment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementConstraintAdjustmentProperty, ps, () => control.PlacementConstraintAdjustment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementGravity(this Popup control, IBinding binding)
   => control._set(Popup.PlacementGravityProperty, binding);
public static Popup PlacementGravity(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementGravityProperty, avaloniaProperty, bindingMode, converter);
public static Popup PlacementGravity(this Popup control, Func<PopupGravity> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementGravityProperty, func, expression);
public static Popup PlacementGravity(this Popup control, PopupGravity value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = value, bindingMode, converter, bindingSource);
public static Popup PlacementGravity<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PopupGravity> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementGravityProperty, ps, () => control.PlacementGravity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Placement(this Popup control, IBinding binding)
   => control._set(Popup.PlacementProperty, binding);
public static Popup Placement(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementProperty, avaloniaProperty, bindingMode, converter);
public static Popup Placement(this Popup control, Func<PlacementMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementProperty, func, expression);
public static Popup Placement(this Popup control, PlacementMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = value, bindingMode, converter, bindingSource);
public static Popup Placement<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, PlacementMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementProperty, ps, () => control.Placement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementRect(this Popup control, IBinding binding)
   => control._set(Popup.PlacementRectProperty, binding);
public static Popup PlacementRect(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementRectProperty, avaloniaProperty, bindingMode, converter);
public static Popup PlacementRect(this Popup control, Func<Nullable<Rect>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementRectProperty, func, expression);
public static Popup PlacementRect(this Popup control, Nullable<Rect> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = value, bindingMode, converter, bindingSource);
public static Popup PlacementRect<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Nullable<Rect>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementRectProperty, ps, () => control.PlacementRect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup PlacementTarget(this Popup control, IBinding binding)
   => control._set(Popup.PlacementTargetProperty, binding);
public static Popup PlacementTarget(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.PlacementTargetProperty, avaloniaProperty, bindingMode, converter);
public static Popup PlacementTarget(this Popup control, Func<Control> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.PlacementTargetProperty, func, expression);
public static Popup PlacementTarget(this Popup control, Control value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = value, bindingMode, converter, bindingSource);
public static Popup PlacementTarget<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Control> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.PlacementTargetProperty, ps, () => control.PlacementTarget = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup OverlayDismissEventPassThrough(this Popup control, IBinding binding)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, binding);
public static Popup OverlayDismissEventPassThrough(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, avaloniaProperty, bindingMode, converter);
public static Popup OverlayDismissEventPassThrough(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.OverlayDismissEventPassThroughProperty, func, expression);
public static Popup OverlayDismissEventPassThrough(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = value, bindingMode, converter, bindingSource);
public static Popup OverlayDismissEventPassThrough<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayDismissEventPassThroughProperty, ps, () => control.OverlayDismissEventPassThrough = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup OverlayInputPassThroughElement(this Popup control, IBinding binding)
   => control._set(Popup.OverlayInputPassThroughElementProperty, binding);
public static Popup OverlayInputPassThroughElement(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.OverlayInputPassThroughElementProperty, avaloniaProperty, bindingMode, converter);
public static Popup OverlayInputPassThroughElement(this Popup control, Func<IInputElement> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.OverlayInputPassThroughElementProperty, func, expression);
public static Popup OverlayInputPassThroughElement(this Popup control, IInputElement value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = value, bindingMode, converter, bindingSource);
public static Popup OverlayInputPassThroughElement<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, IInputElement> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.OverlayInputPassThroughElementProperty, ps, () => control.OverlayInputPassThroughElement = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup HorizontalOffset(this Popup control, IBinding binding)
   => control._set(Popup.HorizontalOffsetProperty, binding);
public static Popup HorizontalOffset(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.HorizontalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static Popup HorizontalOffset(this Popup control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.HorizontalOffsetProperty, func, expression);
public static Popup HorizontalOffset(this Popup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = value, bindingMode, converter, bindingSource);
public static Popup HorizontalOffset<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.HorizontalOffsetProperty, ps, () => control.HorizontalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup IsLightDismissEnabled(this Popup control, IBinding binding)
   => control._set(Popup.IsLightDismissEnabledProperty, binding);
public static Popup IsLightDismissEnabled(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.IsLightDismissEnabledProperty, avaloniaProperty, bindingMode, converter);
public static Popup IsLightDismissEnabled(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.IsLightDismissEnabledProperty, func, expression);
public static Popup IsLightDismissEnabled(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = value, bindingMode, converter, bindingSource);
public static Popup IsLightDismissEnabled<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.IsLightDismissEnabledProperty, ps, () => control.IsLightDismissEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup VerticalOffset(this Popup control, IBinding binding)
   => control._set(Popup.VerticalOffsetProperty, binding);
public static Popup VerticalOffset(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.VerticalOffsetProperty, avaloniaProperty, bindingMode, converter);
public static Popup VerticalOffset(this Popup control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.VerticalOffsetProperty, func, expression);
public static Popup VerticalOffset(this Popup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = value, bindingMode, converter, bindingSource);
public static Popup VerticalOffset<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.VerticalOffsetProperty, ps, () => control.VerticalOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Popup Topmost(this Popup control, IBinding binding)
   => control._set(Popup.TopmostProperty, binding);
public static Popup Topmost(this Popup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Popup.TopmostProperty, avaloniaProperty, bindingMode, converter);
public static Popup Topmost(this Popup control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Popup.TopmostProperty, func, expression);
public static Popup Topmost(this Popup control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = value, bindingMode, converter, bindingSource);
public static Popup Topmost<TValue>(this Popup control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Popup.TopmostProperty, ps, () => control.Topmost = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PopupRootExtensions
{
public static PopupRoot Transform(this PopupRoot control, IBinding binding)
   => control._set(PopupRoot.TransformProperty, binding);
public static PopupRoot Transform(this PopupRoot control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PopupRoot.TransformProperty, avaloniaProperty, bindingMode, converter);
public static PopupRoot Transform(this PopupRoot control, Func<Transform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PopupRoot.TransformProperty, func, expression);
public static PopupRoot Transform(this PopupRoot control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static PopupRoot Transform<TValue>(this PopupRoot control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PopupRoot.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RangeBaseExtensions
{
public static RangeBase Minimum(this RangeBase control, IBinding binding)
   => control._set(RangeBase.MinimumProperty, binding);
public static RangeBase Minimum(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RangeBase.MinimumProperty, avaloniaProperty, bindingMode, converter);
public static RangeBase Minimum(this RangeBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.MinimumProperty, func, expression);
public static RangeBase Minimum(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static RangeBase Minimum<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase Maximum(this RangeBase control, IBinding binding)
   => control._set(RangeBase.MaximumProperty, binding);
public static RangeBase Maximum(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RangeBase.MaximumProperty, avaloniaProperty, bindingMode, converter);
public static RangeBase Maximum(this RangeBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.MaximumProperty, func, expression);
public static RangeBase Maximum(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static RangeBase Maximum<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase Value(this RangeBase control, IBinding binding)
   => control._set(RangeBase.ValueProperty, binding);
public static RangeBase Value(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RangeBase.ValueProperty, avaloniaProperty, bindingMode, converter);
public static RangeBase Value(this RangeBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.ValueProperty, func, expression);
public static RangeBase Value(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static RangeBase Value<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase SmallChange(this RangeBase control, IBinding binding)
   => control._set(RangeBase.SmallChangeProperty, binding);
public static RangeBase SmallChange(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RangeBase.SmallChangeProperty, avaloniaProperty, bindingMode, converter);
public static RangeBase SmallChange(this RangeBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.SmallChangeProperty, func, expression);
public static RangeBase SmallChange(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.SmallChangeProperty, ps, () => control.SmallChange = value, bindingMode, converter, bindingSource);
public static RangeBase SmallChange<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.SmallChangeProperty, ps, () => control.SmallChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RangeBase LargeChange(this RangeBase control, IBinding binding)
   => control._set(RangeBase.LargeChangeProperty, binding);
public static RangeBase LargeChange(this RangeBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RangeBase.LargeChangeProperty, avaloniaProperty, bindingMode, converter);
public static RangeBase LargeChange(this RangeBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RangeBase.LargeChangeProperty, func, expression);
public static RangeBase LargeChange(this RangeBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.LargeChangeProperty, ps, () => control.LargeChange = value, bindingMode, converter, bindingSource);
public static RangeBase LargeChange<TValue>(this RangeBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RangeBase.LargeChangeProperty, ps, () => control.LargeChange = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ScrollBarExtensions
{
public static ScrollBar ViewportSize(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.ViewportSizeProperty, binding);
public static ScrollBar ViewportSize(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.ViewportSizeProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar ViewportSize(this ScrollBar control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.ViewportSizeProperty, func, expression);
public static ScrollBar ViewportSize(this ScrollBar control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static ScrollBar ViewportSize<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar Visibility(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.VisibilityProperty, binding);
public static ScrollBar Visibility(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.VisibilityProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar Visibility(this ScrollBar control, Func<ScrollBarVisibility> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.VisibilityProperty, func, expression);
public static ScrollBar Visibility(this ScrollBar control, ScrollBarVisibility value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = value, bindingMode, converter, bindingSource);
public static ScrollBar Visibility<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, ScrollBarVisibility> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.VisibilityProperty, ps, () => control.Visibility = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar Orientation(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.OrientationProperty, binding);
public static ScrollBar Orientation(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar Orientation(this ScrollBar control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.OrientationProperty, func, expression);
public static ScrollBar Orientation(this ScrollBar control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static ScrollBar Orientation<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar AllowAutoHide(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.AllowAutoHideProperty, binding);
public static ScrollBar AllowAutoHide(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.AllowAutoHideProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar AllowAutoHide(this ScrollBar control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.AllowAutoHideProperty, func, expression);
public static ScrollBar AllowAutoHide(this ScrollBar control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = value, bindingMode, converter, bindingSource);
public static ScrollBar AllowAutoHide<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.AllowAutoHideProperty, ps, () => control.AllowAutoHide = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar HideDelay(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.HideDelayProperty, binding);
public static ScrollBar HideDelay(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.HideDelayProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar HideDelay(this ScrollBar control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.HideDelayProperty, func, expression);
public static ScrollBar HideDelay(this ScrollBar control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = value, bindingMode, converter, bindingSource);
public static ScrollBar HideDelay<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.HideDelayProperty, ps, () => control.HideDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollBar ShowDelay(this ScrollBar control, IBinding binding)
   => control._set(ScrollBar.ShowDelayProperty, binding);
public static ScrollBar ShowDelay(this ScrollBar control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollBar.ShowDelayProperty, avaloniaProperty, bindingMode, converter);
public static ScrollBar ShowDelay(this ScrollBar control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollBar.ShowDelayProperty, func, expression);
public static ScrollBar ShowDelay(this ScrollBar control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = value, bindingMode, converter, bindingSource);
public static ScrollBar ShowDelay<TValue>(this ScrollBar control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollBar.ShowDelayProperty, ps, () => control.ShowDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SelectingItemsControlExtensions
{
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter);
public static T AutoScrollToSelectedItem<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.AutoScrollToSelectedItemProperty, func, expression);
public static T AutoScrollToSelectedItem<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);
public static T AutoScrollToSelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedIndex<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, binding);
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, avaloniaProperty, bindingMode, converter);
public static T SelectedIndex<T>(this T control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedIndexProperty, func, expression);
public static T SelectedIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = value, bindingMode, converter, bindingSource);
public static T SelectedIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedItem<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, binding);
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, avaloniaProperty, bindingMode, converter);
public static T SelectedItem<T>(this T control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedItemProperty, func, expression);
public static T SelectedItem<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValue<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, binding);
public static T SelectedValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, avaloniaProperty, bindingMode, converter);
public static T SelectedValue<T>(this T control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueProperty, func, expression);
public static T SelectedValue<T>(this T control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = value, bindingMode, converter, bindingSource);
public static T SelectedValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, binding);
public static T SelectedValueBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, avaloniaProperty, bindingMode, converter);
public static T SelectedValueBinding<T>(this T control, Func<IBinding> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.SelectedValueBindingProperty, func, expression);
public static T SelectedValueBinding<T>(this T control, IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = value, bindingMode, converter, bindingSource);
public static T SelectedValueBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, binding);
public static T IsTextSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, avaloniaProperty, bindingMode, converter);
public static T IsTextSearchEnabled<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.IsTextSearchEnabledProperty, func, expression);
public static T IsTextSearchEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = value, bindingMode, converter, bindingSource);
public static T IsTextSearchEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T WrapSelection<T>(this T control, IBinding binding) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, binding);
public static T WrapSelection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, avaloniaProperty, bindingMode, converter);
public static T WrapSelection<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : SelectingItemsControl
   => control._set(SelectingItemsControl.WrapSelectionProperty, func, expression);
public static T WrapSelection<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = value, bindingMode, converter, bindingSource);
public static T WrapSelection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : SelectingItemsControl
=> control._setEx(SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TemplatedControlExtensions
{
public static T Background<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, binding);
public static T Background<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, avaloniaProperty, bindingMode, converter);
public static T Background<T>(this T control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BackgroundProperty, func, expression);
public static T Background<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundProperty, ps, () => control.Background = value, bindingMode, converter, bindingSource);
public static T Background<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BackgroundProperty, ps, () => control.Background = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderBrush<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, binding);
public static T BorderBrush<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, avaloniaProperty, bindingMode, converter);
public static T BorderBrush<T>(this T control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderBrushProperty, func, expression);
public static T BorderBrush<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = value, bindingMode, converter, bindingSource);
public static T BorderBrush<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderBrushProperty, ps, () => control.BorderBrush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T BorderThickness<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, binding);
public static T BorderThickness<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, avaloniaProperty, bindingMode, converter);
public static T BorderThickness<T>(this T control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.BorderThicknessProperty, func, expression);
public static T BorderThickness<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = value, bindingMode, converter, bindingSource);
public static T BorderThickness<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.BorderThicknessProperty, ps, () => control.BorderThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T BorderThickness<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(uniformLength));
public static T BorderThickness<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(horizontal, vertical));
public static T BorderThickness<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.BorderThickness = new Thickness(left, top, right, bottom));
public static T CornerRadius<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, binding);
public static T CornerRadius<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, avaloniaProperty, bindingMode, converter);
public static T CornerRadius<T>(this T control, Func<CornerRadius> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.CornerRadiusProperty, func, expression);
public static T CornerRadius<T>(this T control, CornerRadius value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = value, bindingMode, converter, bindingSource);
public static T CornerRadius<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, CornerRadius> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.CornerRadiusProperty, ps, () => control.CornerRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T CornerRadius<T>(this T control, Double uniformRadius) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(uniformRadius));
public static T CornerRadius<T>(this T control, Double top, Double bottom) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(top, bottom));
public static T CornerRadius<T>(this T control, Double topLeft, Double topRight, Double bottomRight, Double bottomLeft) where T : TemplatedControl
   => control._set(() => control.CornerRadius = new CornerRadius(topLeft, topRight, bottomRight, bottomLeft));
public static T FontFamily<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, binding);
public static T FontFamily<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, avaloniaProperty, bindingMode, converter);
public static T FontFamily<T>(this T control, Func<FontFamily> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontFamilyProperty, func, expression);
public static T FontFamily<T>(this T control, FontFamily value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = value, bindingMode, converter, bindingSource);
public static T FontFamily<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontFamily> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontFamilyProperty, ps, () => control.FontFamily = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontSize<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, binding);
public static T FontSize<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, avaloniaProperty, bindingMode, converter);
public static T FontSize<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontSizeProperty, func, expression);
public static T FontSize<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontSizeProperty, ps, () => control.FontSize = value, bindingMode, converter, bindingSource);
public static T FontSize<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontSizeProperty, ps, () => control.FontSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStyle<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, binding);
public static T FontStyle<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, avaloniaProperty, bindingMode, converter);
public static T FontStyle<T>(this T control, Func<FontStyle> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStyleProperty, func, expression);
public static T FontStyle<T>(this T control, FontStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = value, bindingMode, converter, bindingSource);
public static T FontStyle<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStyleProperty, ps, () => control.FontStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontWeight<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, binding);
public static T FontWeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, avaloniaProperty, bindingMode, converter);
public static T FontWeight<T>(this T control, Func<FontWeight> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontWeightProperty, func, expression);
public static T FontWeight<T>(this T control, FontWeight value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = value, bindingMode, converter, bindingSource);
public static T FontWeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontWeight> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontWeightProperty, ps, () => control.FontWeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T FontStretch<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, binding);
public static T FontStretch<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, avaloniaProperty, bindingMode, converter);
public static T FontStretch<T>(this T control, Func<FontStretch> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.FontStretchProperty, func, expression);
public static T FontStretch<T>(this T control, FontStretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = value, bindingMode, converter, bindingSource);
public static T FontStretch<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FontStretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.FontStretchProperty, ps, () => control.FontStretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Foreground<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, binding);
public static T Foreground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, avaloniaProperty, bindingMode, converter);
public static T Foreground<T>(this T control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.ForegroundProperty, func, expression);
public static T Foreground<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static T Foreground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Padding<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, binding);
public static T Padding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, avaloniaProperty, bindingMode, converter);
public static T Padding<T>(this T control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.PaddingProperty, func, expression);
public static T Padding<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.PaddingProperty, ps, () => control.Padding = value, bindingMode, converter, bindingSource);
public static T Padding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.PaddingProperty, ps, () => control.Padding = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Padding<T>(this T control, Double uniformLength) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(uniformLength));
public static T Padding<T>(this T control, Double horizontal, Double vertical) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(horizontal, vertical));
public static T Padding<T>(this T control, Double left, Double top, Double right, Double bottom) where T : TemplatedControl
   => control._set(() => control.Padding = new Thickness(left, top, right, bottom));
public static T Template<T>(this T control, IBinding binding) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, binding);
public static T Template<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, avaloniaProperty, bindingMode, converter);
public static T Template<T>(this T control, Func<IControlTemplate> func, [CallerArgumentExpression("func")] string? expression = null) where T : TemplatedControl
   => control._set(TemplatedControl.TemplateProperty, func, expression);
public static T Template<T>(this T control, IControlTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.TemplateProperty, ps, () => control.Template = value, bindingMode, converter, bindingSource);
public static T Template<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IControlTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : TemplatedControl
=> control._setEx(TemplatedControl.TemplateProperty, ps, () => control.Template = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ToggleButtonExtensions
{
public static ToggleButton IsChecked(this ToggleButton control, IBinding binding)
   => control._set(ToggleButton.IsCheckedProperty, binding);
public static ToggleButton IsChecked(this ToggleButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleButton.IsCheckedProperty, avaloniaProperty, bindingMode, converter);
public static ToggleButton IsChecked(this ToggleButton control, Func<Nullable<Boolean>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleButton.IsCheckedProperty, func, expression);
public static ToggleButton IsChecked(this ToggleButton control, Nullable<Boolean> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = value, bindingMode, converter, bindingSource);
public static ToggleButton IsChecked<TValue>(this ToggleButton control, TValue value, FuncValueConverter<TValue, Nullable<Boolean>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsCheckedProperty, ps, () => control.IsChecked = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ToggleButton IsThreeState(this ToggleButton control, IBinding binding)
   => control._set(ToggleButton.IsThreeStateProperty, binding);
public static ToggleButton IsThreeState(this ToggleButton control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ToggleButton.IsThreeStateProperty, avaloniaProperty, bindingMode, converter);
public static ToggleButton IsThreeState(this ToggleButton control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ToggleButton.IsThreeStateProperty, func, expression);
public static ToggleButton IsThreeState(this ToggleButton control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = value, bindingMode, converter, bindingSource);
public static ToggleButton IsThreeState<TValue>(this ToggleButton control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ToggleButton.IsThreeStateProperty, ps, () => control.IsThreeState = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TrackExtensions
{
public static Track Minimum(this Track control, IBinding binding)
   => control._set(Track.MinimumProperty, binding);
public static Track Minimum(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.MinimumProperty, avaloniaProperty, bindingMode, converter);
public static Track Minimum(this Track control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.MinimumProperty, func, expression);
public static Track Minimum(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = value, bindingMode, converter, bindingSource);
public static Track Minimum<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MinimumProperty, ps, () => control.Minimum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Maximum(this Track control, IBinding binding)
   => control._set(Track.MaximumProperty, binding);
public static Track Maximum(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.MaximumProperty, avaloniaProperty, bindingMode, converter);
public static Track Maximum(this Track control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.MaximumProperty, func, expression);
public static Track Maximum(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = value, bindingMode, converter, bindingSource);
public static Track Maximum<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.MaximumProperty, ps, () => control.Maximum = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Value(this Track control, IBinding binding)
   => control._set(Track.ValueProperty, binding);
public static Track Value(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.ValueProperty, avaloniaProperty, bindingMode, converter);
public static Track Value(this Track control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ValueProperty, func, expression);
public static Track Value(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ValueProperty, ps, () => control.Value = value, bindingMode, converter, bindingSource);
public static Track Value<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ValueProperty, ps, () => control.Value = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track ViewportSize(this Track control, IBinding binding)
   => control._set(Track.ViewportSizeProperty, binding);
public static Track ViewportSize(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.ViewportSizeProperty, avaloniaProperty, bindingMode, converter);
public static Track ViewportSize(this Track control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ViewportSizeProperty, func, expression);
public static Track ViewportSize(this Track control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = value, bindingMode, converter, bindingSource);
public static Track ViewportSize<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ViewportSizeProperty, ps, () => control.ViewportSize = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Orientation(this Track control, IBinding binding)
   => control._set(Track.OrientationProperty, binding);
public static Track Orientation(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.OrientationProperty, avaloniaProperty, bindingMode, converter);
public static Track Orientation(this Track control, Func<Orientation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.OrientationProperty, func, expression);
public static Track Orientation(this Track control, Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);
public static Track Orientation<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track Thumb(this Track control, IBinding binding)
   => control._set(Track.ThumbProperty, binding);
public static Track Thumb(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.ThumbProperty, avaloniaProperty, bindingMode, converter);
public static Track Thumb(this Track control, Func<Thumb> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.ThumbProperty, func, expression);
public static Track Thumb(this Track control, Thumb value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = value, bindingMode, converter, bindingSource);
public static Track Thumb<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Thumb> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.ThumbProperty, ps, () => control.Thumb = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IncreaseButton(this Track control, IBinding binding)
   => control._set(Track.IncreaseButtonProperty, binding);
public static Track IncreaseButton(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.IncreaseButtonProperty, avaloniaProperty, bindingMode, converter);
public static Track IncreaseButton(this Track control, Func<Button> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IncreaseButtonProperty, func, expression);
public static Track IncreaseButton(this Track control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = value, bindingMode, converter, bindingSource);
public static Track IncreaseButton<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IncreaseButtonProperty, ps, () => control.IncreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track DecreaseButton(this Track control, IBinding binding)
   => control._set(Track.DecreaseButtonProperty, binding);
public static Track DecreaseButton(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.DecreaseButtonProperty, avaloniaProperty, bindingMode, converter);
public static Track DecreaseButton(this Track control, Func<Button> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.DecreaseButtonProperty, func, expression);
public static Track DecreaseButton(this Track control, Button value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = value, bindingMode, converter, bindingSource);
public static Track DecreaseButton<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Button> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.DecreaseButtonProperty, ps, () => control.DecreaseButton = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IsDirectionReversed(this Track control, IBinding binding)
   => control._set(Track.IsDirectionReversedProperty, binding);
public static Track IsDirectionReversed(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.IsDirectionReversedProperty, avaloniaProperty, bindingMode, converter);
public static Track IsDirectionReversed(this Track control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IsDirectionReversedProperty, func, expression);
public static Track IsDirectionReversed(this Track control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = value, bindingMode, converter, bindingSource);
public static Track IsDirectionReversed<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IsDirectionReversedProperty, ps, () => control.IsDirectionReversed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Track IgnoreThumbDrag(this Track control, IBinding binding)
   => control._set(Track.IgnoreThumbDragProperty, binding);
public static Track IgnoreThumbDrag(this Track control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Track.IgnoreThumbDragProperty, avaloniaProperty, bindingMode, converter);
public static Track IgnoreThumbDrag(this Track control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Track.IgnoreThumbDragProperty, func, expression);
public static Track IgnoreThumbDrag(this Track control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = value, bindingMode, converter, bindingSource);
public static Track IgnoreThumbDrag<TValue>(this Track control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Track.IgnoreThumbDragProperty, ps, () => control.IgnoreThumbDrag = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class UniformGridExtensions
{
public static UniformGrid Rows(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.RowsProperty, binding);
public static UniformGrid Rows(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(UniformGrid.RowsProperty, avaloniaProperty, bindingMode, converter);
public static UniformGrid Rows(this UniformGrid control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.RowsProperty, func, expression);
public static UniformGrid Rows(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.RowsProperty, ps, () => control.Rows = value, bindingMode, converter, bindingSource);
public static UniformGrid Rows<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.RowsProperty, ps, () => control.Rows = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static UniformGrid Columns(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.ColumnsProperty, binding);
public static UniformGrid Columns(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(UniformGrid.ColumnsProperty, avaloniaProperty, bindingMode, converter);
public static UniformGrid Columns(this UniformGrid control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.ColumnsProperty, func, expression);
public static UniformGrid Columns(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.ColumnsProperty, ps, () => control.Columns = value, bindingMode, converter, bindingSource);
public static UniformGrid Columns<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.ColumnsProperty, ps, () => control.Columns = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static UniformGrid FirstColumn(this UniformGrid control, IBinding binding)
   => control._set(UniformGrid.FirstColumnProperty, binding);
public static UniformGrid FirstColumn(this UniformGrid control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(UniformGrid.FirstColumnProperty, avaloniaProperty, bindingMode, converter);
public static UniformGrid FirstColumn(this UniformGrid control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(UniformGrid.FirstColumnProperty, func, expression);
public static UniformGrid FirstColumn(this UniformGrid control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = value, bindingMode, converter, bindingSource);
public static UniformGrid FirstColumn<TValue>(this UniformGrid control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(UniformGrid.FirstColumnProperty, ps, () => control.FirstColumn = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class StyledElementExtensions
{
public static StyledElement DataContext(this StyledElement control, IBinding binding)
   => control._set(StyledElement.DataContextProperty, binding);
public static StyledElement DataContext(this StyledElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StyledElement.DataContextProperty, avaloniaProperty, bindingMode, converter);
public static StyledElement DataContext(this StyledElement control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StyledElement.DataContextProperty, func, expression);
public static StyledElement DataContext(this StyledElement control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = value, bindingMode, converter, bindingSource);
public static StyledElement DataContext<TValue>(this StyledElement control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.DataContextProperty, ps, () => control.DataContext = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StyledElement Name(this StyledElement control, IBinding binding)
   => control._set(StyledElement.NameProperty, binding);
public static StyledElement Name(this StyledElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StyledElement.NameProperty, avaloniaProperty, bindingMode, converter);
public static StyledElement Name(this StyledElement control, Func<String> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StyledElement.NameProperty, func, expression);
public static StyledElement Name(this StyledElement control, String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.NameProperty, ps, () => control.Name = value, bindingMode, converter, bindingSource);
public static StyledElement Name<TValue>(this StyledElement control, TValue value, FuncValueConverter<TValue, String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.NameProperty, ps, () => control.Name = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static StyledElement Theme(this StyledElement control, IBinding binding)
   => control._set(StyledElement.ThemeProperty, binding);
public static StyledElement Theme(this StyledElement control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(StyledElement.ThemeProperty, avaloniaProperty, bindingMode, converter);
public static StyledElement Theme(this StyledElement control, Func<ControlTheme> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(StyledElement.ThemeProperty, func, expression);
public static StyledElement Theme(this StyledElement control, ControlTheme value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.ThemeProperty, ps, () => control.Theme = value, bindingMode, converter, bindingSource);
public static StyledElement Theme<TValue>(this StyledElement control, TValue value, FuncValueConverter<TValue, ControlTheme> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(StyledElement.ThemeProperty, ps, () => control.Theme = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class VisualExtensions
{
public static T ClipToBounds<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, binding);
public static T ClipToBounds<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, avaloniaProperty, bindingMode, converter);
public static T ClipToBounds<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ClipToBoundsProperty, func, expression);
public static T ClipToBounds<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = value, bindingMode, converter, bindingSource);
public static T ClipToBounds<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipToBoundsProperty, ps, () => control.ClipToBounds = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Clip<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ClipProperty, binding);
public static T Clip<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.ClipProperty, avaloniaProperty, bindingMode, converter);
public static T Clip<T>(this T control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ClipProperty, func, expression);
public static T Clip<T>(this T control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipProperty, ps, () => control.Clip = value, bindingMode, converter, bindingSource);
public static T Clip<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ClipProperty, ps, () => control.Clip = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsVisible<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.IsVisibleProperty, binding);
public static T IsVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.IsVisibleProperty, avaloniaProperty, bindingMode, converter);
public static T IsVisible<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.IsVisibleProperty, func, expression);
public static T IsVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.IsVisibleProperty, ps, () => control.IsVisible = value, bindingMode, converter, bindingSource);
public static T IsVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.IsVisibleProperty, ps, () => control.IsVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Opacity<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.OpacityProperty, binding);
public static T Opacity<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.OpacityProperty, avaloniaProperty, bindingMode, converter);
public static T Opacity<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.OpacityProperty, func, expression);
public static T Opacity<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static T Opacity<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T OpacityMask<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.OpacityMaskProperty, binding);
public static T OpacityMask<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.OpacityMaskProperty, avaloniaProperty, bindingMode, converter);
public static T OpacityMask<T>(this T control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.OpacityMaskProperty, func, expression);
public static T OpacityMask<T>(this T control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static T OpacityMask<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Effect<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.EffectProperty, binding);
public static T Effect<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.EffectProperty, avaloniaProperty, bindingMode, converter);
public static T Effect<T>(this T control, Func<IEffect> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.EffectProperty, func, expression);
public static T Effect<T>(this T control, IEffect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.EffectProperty, ps, () => control.Effect = value, bindingMode, converter, bindingSource);
public static T Effect<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, IEffect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.EffectProperty, ps, () => control.Effect = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransform<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.RenderTransformProperty, binding);
public static T RenderTransform<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.RenderTransformProperty, avaloniaProperty, bindingMode, converter);
public static T RenderTransform<T>(this T control, Func<ITransform> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.RenderTransformProperty, func, expression);
public static T RenderTransform<T>(this T control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformProperty, ps, () => control.RenderTransform = value, bindingMode, converter, bindingSource);
public static T RenderTransform<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformProperty, ps, () => control.RenderTransform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, binding);
public static T RenderTransformOrigin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, avaloniaProperty, bindingMode, converter);
public static T RenderTransformOrigin<T>(this T control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.RenderTransformOriginProperty, func, expression);
public static T RenderTransformOrigin<T>(this T control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = value, bindingMode, converter, bindingSource);
public static T RenderTransformOrigin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.RenderTransformOriginProperty, ps, () => control.RenderTransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T RenderTransformOrigin<T>(this T control, Double x, Double y, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(x, y, unit));
public static T RenderTransformOrigin<T>(this T control, Point point, RelativeUnit unit) where T : Visual
   => control._set(() => control.RenderTransformOrigin = new RelativePoint(point, unit));
public static T FlowDirection<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.FlowDirectionProperty, binding);
public static T FlowDirection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.FlowDirectionProperty, avaloniaProperty, bindingMode, converter);
public static T FlowDirection<T>(this T control, Func<FlowDirection> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.FlowDirectionProperty, func, expression);
public static T FlowDirection<T>(this T control, FlowDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.FlowDirectionProperty, ps, () => control.FlowDirection = value, bindingMode, converter, bindingSource);
public static T FlowDirection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, FlowDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.FlowDirectionProperty, ps, () => control.FlowDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T ZIndex<T>(this T control, IBinding binding) where T : Visual
   => control._set(Visual.ZIndexProperty, binding);
public static T ZIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Visual
   => control._set(Visual.ZIndexProperty, avaloniaProperty, bindingMode, converter);
public static T ZIndex<T>(this T control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null) where T : Visual
   => control._set(Visual.ZIndexProperty, func, expression);
public static T ZIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ZIndexProperty, ps, () => control.ZIndex = value, bindingMode, converter, bindingSource);
public static T ZIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Visual
=> control._setEx(Visual.ZIndexProperty, ps, () => control.ZIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class LayoutableExtensions
{
public static T Width<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.WidthProperty, binding);
public static T Width<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.WidthProperty, avaloniaProperty, bindingMode, converter);
public static T Width<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.WidthProperty, func, expression);
public static T Width<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.WidthProperty, ps, () => control.Width = value, bindingMode, converter, bindingSource);
public static T Width<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.WidthProperty, ps, () => control.Width = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Height<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.HeightProperty, binding);
public static T Height<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.HeightProperty, avaloniaProperty, bindingMode, converter);
public static T Height<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.HeightProperty, func, expression);
public static T Height<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HeightProperty, ps, () => control.Height = value, bindingMode, converter, bindingSource);
public static T Height<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HeightProperty, ps, () => control.Height = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, binding);
public static T MinWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, avaloniaProperty, bindingMode, converter);
public static T MinWidth<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MinWidthProperty, func, expression);
public static T MinWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinWidthProperty, ps, () => control.MinWidth = value, bindingMode, converter, bindingSource);
public static T MinWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinWidthProperty, ps, () => control.MinWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxWidth<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, binding);
public static T MaxWidth<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, avaloniaProperty, bindingMode, converter);
public static T MaxWidth<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MaxWidthProperty, func, expression);
public static T MaxWidth<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = value, bindingMode, converter, bindingSource);
public static T MaxWidth<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxWidthProperty, ps, () => control.MaxWidth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MinHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, binding);
public static T MinHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, avaloniaProperty, bindingMode, converter);
public static T MinHeight<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MinHeightProperty, func, expression);
public static T MinHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinHeightProperty, ps, () => control.MinHeight = value, bindingMode, converter, bindingSource);
public static T MinHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MinHeightProperty, ps, () => control.MinHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T MaxHeight<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, binding);
public static T MaxHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, avaloniaProperty, bindingMode, converter);
public static T MaxHeight<T>(this T control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MaxHeightProperty, func, expression);
public static T MaxHeight<T>(this T control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = value, bindingMode, converter, bindingSource);
public static T MaxHeight<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MaxHeightProperty, ps, () => control.MaxHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Margin<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.MarginProperty, binding);
public static T Margin<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.MarginProperty, avaloniaProperty, bindingMode, converter);
public static T Margin<T>(this T control, Func<Thickness> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.MarginProperty, func, expression);
public static T Margin<T>(this T control, Thickness value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MarginProperty, ps, () => control.Margin = value, bindingMode, converter, bindingSource);
public static T Margin<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Thickness> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.MarginProperty, ps, () => control.Margin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static T Margin<T>(this T control, Double uniformLength) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(uniformLength));
public static T Margin<T>(this T control, Double horizontal, Double vertical) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(horizontal, vertical));
public static T Margin<T>(this T control, Double left, Double top, Double right, Double bottom) where T : Layoutable
   => control._set(() => control.Margin = new Thickness(left, top, right, bottom));
public static T HorizontalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, binding);
public static T HorizontalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static T HorizontalAlignment<T>(this T control, Func<HorizontalAlignment> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.HorizontalAlignmentProperty, func, expression);
public static T HorizontalAlignment<T>(this T control, HorizontalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = value, bindingMode, converter, bindingSource);
public static T HorizontalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, HorizontalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.HorizontalAlignmentProperty, ps, () => control.HorizontalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T VerticalAlignment<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, binding);
public static T VerticalAlignment<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, avaloniaProperty, bindingMode, converter);
public static T VerticalAlignment<T>(this T control, Func<VerticalAlignment> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.VerticalAlignmentProperty, func, expression);
public static T VerticalAlignment<T>(this T control, VerticalAlignment value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = value, bindingMode, converter, bindingSource);
public static T VerticalAlignment<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, VerticalAlignment> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.VerticalAlignmentProperty, ps, () => control.VerticalAlignment = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T>(this T control, IBinding binding) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, binding);
public static T UseLayoutRounding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, avaloniaProperty, bindingMode, converter);
public static T UseLayoutRounding<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : Layoutable
   => control._set(Layoutable.UseLayoutRoundingProperty, func, expression);
public static T UseLayoutRounding<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = value, bindingMode, converter, bindingSource);
public static T UseLayoutRounding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Layoutable
=> control._setEx(Layoutable.UseLayoutRoundingProperty, ps, () => control.UseLayoutRounding = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PullGestureRecognizerExtensions
{
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, IBinding binding)
   => control._set(PullGestureRecognizer.PullDirectionProperty, binding);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PullGestureRecognizer.PullDirectionProperty, avaloniaProperty, bindingMode, converter);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, Func<PullDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PullGestureRecognizer.PullDirectionProperty, func, expression);
public static PullGestureRecognizer PullDirection(this PullGestureRecognizer control, PullDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = value, bindingMode, converter, bindingSource);
public static PullGestureRecognizer PullDirection<TValue>(this PullGestureRecognizer control, TValue value, FuncValueConverter<TValue, PullDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PullGestureRecognizer.PullDirectionProperty, ps, () => control.PullDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class InputElementExtensions
{
public static T Focusable<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.FocusableProperty, binding);
public static T Focusable<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.FocusableProperty, avaloniaProperty, bindingMode, converter);
public static T Focusable<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.FocusableProperty, func, expression);
public static T Focusable<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = value, bindingMode, converter, bindingSource);
public static T Focusable<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.FocusableProperty, ps, () => control.Focusable = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsEnabled<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, binding);
public static T IsEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, avaloniaProperty, bindingMode, converter);
public static T IsEnabled<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsEnabledProperty, func, expression);
public static T IsEnabled<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = value, bindingMode, converter, bindingSource);
public static T IsEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsEnabledProperty, ps, () => control.IsEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T Cursor<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.CursorProperty, binding);
public static T Cursor<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.CursorProperty, avaloniaProperty, bindingMode, converter);
public static T Cursor<T>(this T control, Func<Cursor> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.CursorProperty, func, expression);
public static T Cursor<T>(this T control, Cursor value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = value, bindingMode, converter, bindingSource);
public static T Cursor<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Cursor> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.CursorProperty, ps, () => control.Cursor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, binding);
public static T IsHitTestVisible<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, avaloniaProperty, bindingMode, converter);
public static T IsHitTestVisible<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsHitTestVisibleProperty, func, expression);
public static T IsHitTestVisible<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = value, bindingMode, converter, bindingSource);
public static T IsHitTestVisible<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsHitTestVisibleProperty, ps, () => control.IsHitTestVisible = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T IsTabStop<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, binding);
public static T IsTabStop<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, avaloniaProperty, bindingMode, converter);
public static T IsTabStop<T>(this T control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.IsTabStopProperty, func, expression);
public static T IsTabStop<T>(this T control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = value, bindingMode, converter, bindingSource);
public static T IsTabStop<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.IsTabStopProperty, ps, () => control.IsTabStop = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static T TabIndex<T>(this T control, IBinding binding) where T : InputElement
   => control._set(InputElement.TabIndexProperty, binding);
public static T TabIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null) where T : InputElement
   => control._set(InputElement.TabIndexProperty, avaloniaProperty, bindingMode, converter);
public static T TabIndex<T>(this T control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null) where T : InputElement
   => control._set(InputElement.TabIndexProperty, func, expression);
public static T TabIndex<T>(this T control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = value, bindingMode, converter, bindingSource);
public static T TabIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : InputElement
=> control._setEx(InputElement.TabIndexProperty, ps, () => control.TabIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class KeyBindingExtensions
{
public static KeyBinding Command(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.CommandProperty, binding);
public static KeyBinding Command(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(KeyBinding.CommandProperty, avaloniaProperty, bindingMode, converter);
public static KeyBinding Command(this KeyBinding control, Func<ICommand> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.CommandProperty, func, expression);
public static KeyBinding Command(this KeyBinding control, ICommand value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = value, bindingMode, converter, bindingSource);
public static KeyBinding Command<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, ICommand> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandProperty, ps, () => control.Command = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static KeyBinding CommandParameter(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.CommandParameterProperty, binding);
public static KeyBinding CommandParameter(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(KeyBinding.CommandParameterProperty, avaloniaProperty, bindingMode, converter);
public static KeyBinding CommandParameter(this KeyBinding control, Func<Object> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.CommandParameterProperty, func, expression);
public static KeyBinding CommandParameter(this KeyBinding control, Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = value, bindingMode, converter, bindingSource);
public static KeyBinding CommandParameter<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.CommandParameterProperty, ps, () => control.CommandParameter = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static KeyBinding Gesture(this KeyBinding control, IBinding binding)
   => control._set(KeyBinding.GestureProperty, binding);
public static KeyBinding Gesture(this KeyBinding control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(KeyBinding.GestureProperty, avaloniaProperty, bindingMode, converter);
public static KeyBinding Gesture(this KeyBinding control, Func<KeyGesture> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(KeyBinding.GestureProperty, func, expression);
public static KeyBinding Gesture(this KeyBinding control, KeyGesture value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = value, bindingMode, converter, bindingSource);
public static KeyBinding Gesture<TValue>(this KeyBinding control, TValue value, FuncValueConverter<TValue, KeyGesture> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(KeyBinding.GestureProperty, ps, () => control.Gesture = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ScrollGestureRecognizerExtensions
{
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, binding);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, avaloniaProperty, bindingMode, converter);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.CanHorizontallyScrollProperty, func, expression);
public static ScrollGestureRecognizer CanHorizontallyScroll(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanHorizontallyScroll<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanHorizontallyScrollProperty, ps, () => control.CanHorizontallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, binding);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, avaloniaProperty, bindingMode, converter);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.CanVerticallyScrollProperty, func, expression);
public static ScrollGestureRecognizer CanVerticallyScroll(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer CanVerticallyScroll<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.CanVerticallyScrollProperty, ps, () => control.CanVerticallyScroll = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, binding);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, avaloniaProperty, bindingMode, converter);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, func, expression);
public static ScrollGestureRecognizer IsScrollInertiaEnabled(this ScrollGestureRecognizer control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer IsScrollInertiaEnabled<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.IsScrollInertiaEnabledProperty, ps, () => control.IsScrollInertiaEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, IBinding binding)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, binding);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, avaloniaProperty, bindingMode, converter);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, Func<Int32> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScrollGestureRecognizer.ScrollStartDistanceProperty, func, expression);
public static ScrollGestureRecognizer ScrollStartDistance(this ScrollGestureRecognizer control, Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = value, bindingMode, converter, bindingSource);
public static ScrollGestureRecognizer ScrollStartDistance<TValue>(this ScrollGestureRecognizer control, TValue value, FuncValueConverter<TValue, Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScrollGestureRecognizer.ScrollStartDistanceProperty, ps, () => control.ScrollStartDistance = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CombinedGeometryExtensions
{
public static CombinedGeometry Geometry1(this CombinedGeometry control, IBinding binding)
   => control._set(CombinedGeometry.Geometry1Property, binding);
public static CombinedGeometry Geometry1(this CombinedGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CombinedGeometry.Geometry1Property, avaloniaProperty, bindingMode, converter);
public static CombinedGeometry Geometry1(this CombinedGeometry control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CombinedGeometry.Geometry1Property, func, expression);
public static CombinedGeometry Geometry1(this CombinedGeometry control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.Geometry1Property, ps, () => control.Geometry1 = value, bindingMode, converter, bindingSource);
public static CombinedGeometry Geometry1<TValue>(this CombinedGeometry control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.Geometry1Property, ps, () => control.Geometry1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CombinedGeometry Geometry2(this CombinedGeometry control, IBinding binding)
   => control._set(CombinedGeometry.Geometry2Property, binding);
public static CombinedGeometry Geometry2(this CombinedGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CombinedGeometry.Geometry2Property, avaloniaProperty, bindingMode, converter);
public static CombinedGeometry Geometry2(this CombinedGeometry control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CombinedGeometry.Geometry2Property, func, expression);
public static CombinedGeometry Geometry2(this CombinedGeometry control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.Geometry2Property, ps, () => control.Geometry2 = value, bindingMode, converter, bindingSource);
public static CombinedGeometry Geometry2<TValue>(this CombinedGeometry control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.Geometry2Property, ps, () => control.Geometry2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CombinedGeometry GeometryCombineMode(this CombinedGeometry control, IBinding binding)
   => control._set(CombinedGeometry.GeometryCombineModeProperty, binding);
public static CombinedGeometry GeometryCombineMode(this CombinedGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CombinedGeometry.GeometryCombineModeProperty, avaloniaProperty, bindingMode, converter);
public static CombinedGeometry GeometryCombineMode(this CombinedGeometry control, Func<GeometryCombineMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CombinedGeometry.GeometryCombineModeProperty, func, expression);
public static CombinedGeometry GeometryCombineMode(this CombinedGeometry control, GeometryCombineMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.GeometryCombineModeProperty, ps, () => control.GeometryCombineMode = value, bindingMode, converter, bindingSource);
public static CombinedGeometry GeometryCombineMode<TValue>(this CombinedGeometry control, TValue value, FuncValueConverter<TValue, GeometryCombineMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CombinedGeometry.GeometryCombineModeProperty, ps, () => control.GeometryCombineMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ArcSegmentExtensions
{
public static ArcSegment IsLargeArc(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.IsLargeArcProperty, binding);
public static ArcSegment IsLargeArc(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ArcSegment.IsLargeArcProperty, avaloniaProperty, bindingMode, converter);
public static ArcSegment IsLargeArc(this ArcSegment control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.IsLargeArcProperty, func, expression);
public static ArcSegment IsLargeArc(this ArcSegment control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = value, bindingMode, converter, bindingSource);
public static ArcSegment IsLargeArc<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.IsLargeArcProperty, ps, () => control.IsLargeArc = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment Point(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.PointProperty, binding);
public static ArcSegment Point(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ArcSegment.PointProperty, avaloniaProperty, bindingMode, converter);
public static ArcSegment Point(this ArcSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.PointProperty, func, expression);
public static ArcSegment Point(this ArcSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);
public static ArcSegment Point<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment RotationAngle(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.RotationAngleProperty, binding);
public static ArcSegment RotationAngle(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ArcSegment.RotationAngleProperty, avaloniaProperty, bindingMode, converter);
public static ArcSegment RotationAngle(this ArcSegment control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.RotationAngleProperty, func, expression);
public static ArcSegment RotationAngle(this ArcSegment control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = value, bindingMode, converter, bindingSource);
public static ArcSegment RotationAngle<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.RotationAngleProperty, ps, () => control.RotationAngle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ArcSegment Size(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.SizeProperty, binding);
public static ArcSegment Size(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ArcSegment.SizeProperty, avaloniaProperty, bindingMode, converter);
public static ArcSegment Size(this ArcSegment control, Func<Size> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.SizeProperty, func, expression);
public static ArcSegment Size(this ArcSegment control, Size value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SizeProperty, ps, () => control.Size = value, bindingMode, converter, bindingSource);
public static ArcSegment Size<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, Size> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SizeProperty, ps, () => control.Size = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ArcSegment Size(this ArcSegment control, Double width, Double height)
   => control._set(() => control.Size = new Size(width, height));
public static ArcSegment Size(this ArcSegment control, Vector2 vector2)
   => control._set(() => control.Size = new Size(vector2));
public static ArcSegment SweepDirection(this ArcSegment control, IBinding binding)
   => control._set(ArcSegment.SweepDirectionProperty, binding);
public static ArcSegment SweepDirection(this ArcSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ArcSegment.SweepDirectionProperty, avaloniaProperty, bindingMode, converter);
public static ArcSegment SweepDirection(this ArcSegment control, Func<SweepDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ArcSegment.SweepDirectionProperty, func, expression);
public static ArcSegment SweepDirection(this ArcSegment control, SweepDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = value, bindingMode, converter, bindingSource);
public static ArcSegment SweepDirection<TValue>(this ArcSegment control, TValue value, FuncValueConverter<TValue, SweepDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ArcSegment.SweepDirectionProperty, ps, () => control.SweepDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class BezierSegmentExtensions
{
public static BezierSegment Point1(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point1Property, binding);
public static BezierSegment Point1(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(BezierSegment.Point1Property, avaloniaProperty, bindingMode, converter);
public static BezierSegment Point1(this BezierSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point1Property, func, expression);
public static BezierSegment Point1(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point1<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static BezierSegment Point2(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point2Property, binding);
public static BezierSegment Point2(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(BezierSegment.Point2Property, avaloniaProperty, bindingMode, converter);
public static BezierSegment Point2(this BezierSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point2Property, func, expression);
public static BezierSegment Point2(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point2<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static BezierSegment Point3(this BezierSegment control, IBinding binding)
   => control._set(BezierSegment.Point3Property, binding);
public static BezierSegment Point3(this BezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(BezierSegment.Point3Property, avaloniaProperty, bindingMode, converter);
public static BezierSegment Point3(this BezierSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BezierSegment.Point3Property, func, expression);
public static BezierSegment Point3(this BezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point3Property, ps, () => control.Point3 = value, bindingMode, converter, bindingSource);
public static BezierSegment Point3<TValue>(this BezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BezierSegment.Point3Property, ps, () => control.Point3 = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class BrushExtensions
{
public static Brush Opacity(this Brush control, IBinding binding)
   => control._set(Brush.OpacityProperty, binding);
public static Brush Opacity(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Brush.OpacityProperty, avaloniaProperty, bindingMode, converter);
public static Brush Opacity(this Brush control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.OpacityProperty, func, expression);
public static Brush Opacity(this Brush control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static Brush Opacity<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Brush Transform(this Brush control, IBinding binding)
   => control._set(Brush.TransformProperty, binding);
public static Brush Transform(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Brush.TransformProperty, avaloniaProperty, bindingMode, converter);
public static Brush Transform(this Brush control, Func<ITransform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.TransformProperty, func, expression);
public static Brush Transform(this Brush control, ITransform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Brush Transform<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, ITransform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Brush TransformOrigin(this Brush control, IBinding binding)
   => control._set(Brush.TransformOriginProperty, binding);
public static Brush TransformOrigin(this Brush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Brush.TransformOriginProperty, avaloniaProperty, bindingMode, converter);
public static Brush TransformOrigin(this Brush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Brush.TransformOriginProperty, func, expression);
public static Brush TransformOrigin(this Brush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = value, bindingMode, converter, bindingSource);
public static Brush TransformOrigin<TValue>(this Brush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Brush.TransformOriginProperty, ps, () => control.TransformOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Brush TransformOrigin(this Brush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.TransformOrigin = new RelativePoint(x, y, unit));
public static Brush TransformOrigin(this Brush control, Point point, RelativeUnit unit)
   => control._set(() => control.TransformOrigin = new RelativePoint(point, unit));
}
public static partial class ConicGradientBrushExtensions
{
public static ConicGradientBrush Center(this ConicGradientBrush control, IBinding binding)
   => control._set(ConicGradientBrush.CenterProperty, binding);
public static ConicGradientBrush Center(this ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ConicGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter);
public static ConicGradientBrush Center(this ConicGradientBrush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ConicGradientBrush.CenterProperty, func, expression);
public static ConicGradientBrush Center(this ConicGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static ConicGradientBrush Center<TValue>(this ConicGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ConicGradientBrush Center(this ConicGradientBrush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.Center = new RelativePoint(x, y, unit));
public static ConicGradientBrush Center(this ConicGradientBrush control, Point point, RelativeUnit unit)
   => control._set(() => control.Center = new RelativePoint(point, unit));
public static ConicGradientBrush Angle(this ConicGradientBrush control, IBinding binding)
   => control._set(ConicGradientBrush.AngleProperty, binding);
public static ConicGradientBrush Angle(this ConicGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ConicGradientBrush.AngleProperty, avaloniaProperty, bindingMode, converter);
public static ConicGradientBrush Angle(this ConicGradientBrush control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ConicGradientBrush.AngleProperty, func, expression);
public static ConicGradientBrush Angle(this ConicGradientBrush control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static ConicGradientBrush Angle<TValue>(this ConicGradientBrush control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ConicGradientBrush.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DashStyleExtensions
{
public static DashStyle Dashes(this DashStyle control, IBinding binding)
   => control._set(DashStyle.DashesProperty, binding);
public static DashStyle Dashes(this DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DashStyle.DashesProperty, avaloniaProperty, bindingMode, converter);
public static DashStyle Dashes(this DashStyle control, Func<AvaloniaList<Double>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DashStyle.DashesProperty, func, expression);
public static DashStyle Dashes(this DashStyle control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.DashesProperty, ps, () => control.Dashes = value, bindingMode, converter, bindingSource);
public static DashStyle Dashes<TValue>(this DashStyle control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.DashesProperty, ps, () => control.Dashes = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DashStyle Offset(this DashStyle control, IBinding binding)
   => control._set(DashStyle.OffsetProperty, binding);
public static DashStyle Offset(this DashStyle control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DashStyle.OffsetProperty, avaloniaProperty, bindingMode, converter);
public static DashStyle Offset(this DashStyle control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DashStyle.OffsetProperty, func, expression);
public static DashStyle Offset(this DashStyle control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static DashStyle Offset<TValue>(this DashStyle control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DashStyle.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DrawingBrushExtensions
{
public static DrawingBrush Drawing(this DrawingBrush control, IBinding binding)
   => control._set(DrawingBrush.DrawingProperty, binding);
public static DrawingBrush Drawing(this DrawingBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingBrush.DrawingProperty, avaloniaProperty, bindingMode, converter);
public static DrawingBrush Drawing(this DrawingBrush control, Func<Drawing> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingBrush.DrawingProperty, func, expression);
public static DrawingBrush Drawing(this DrawingBrush control, Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingBrush.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static DrawingBrush Drawing<TValue>(this DrawingBrush control, TValue value, FuncValueConverter<TValue, Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingBrush.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DrawingGroupExtensions
{
public static DrawingGroup Opacity(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.OpacityProperty, binding);
public static DrawingGroup Opacity(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingGroup.OpacityProperty, avaloniaProperty, bindingMode, converter);
public static DrawingGroup Opacity(this DrawingGroup control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.OpacityProperty, func, expression);
public static DrawingGroup Opacity(this DrawingGroup control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static DrawingGroup Opacity<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup Transform(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.TransformProperty, binding);
public static DrawingGroup Transform(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingGroup.TransformProperty, avaloniaProperty, bindingMode, converter);
public static DrawingGroup Transform(this DrawingGroup control, Func<Transform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.TransformProperty, func, expression);
public static DrawingGroup Transform(this DrawingGroup control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static DrawingGroup Transform<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup ClipGeometry(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.ClipGeometryProperty, binding);
public static DrawingGroup ClipGeometry(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingGroup.ClipGeometryProperty, avaloniaProperty, bindingMode, converter);
public static DrawingGroup ClipGeometry(this DrawingGroup control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.ClipGeometryProperty, func, expression);
public static DrawingGroup ClipGeometry(this DrawingGroup control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = value, bindingMode, converter, bindingSource);
public static DrawingGroup ClipGeometry<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ClipGeometryProperty, ps, () => control.ClipGeometry = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup OpacityMask(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.OpacityMaskProperty, binding);
public static DrawingGroup OpacityMask(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingGroup.OpacityMaskProperty, avaloniaProperty, bindingMode, converter);
public static DrawingGroup OpacityMask(this DrawingGroup control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.OpacityMaskProperty, func, expression);
public static DrawingGroup OpacityMask(this DrawingGroup control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = value, bindingMode, converter, bindingSource);
public static DrawingGroup OpacityMask<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.OpacityMaskProperty, ps, () => control.OpacityMask = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DrawingGroup Children(this DrawingGroup control, IBinding binding)
   => control._set(DrawingGroup.ChildrenProperty, binding);
public static DrawingGroup Children(this DrawingGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter);
public static DrawingGroup Children(this DrawingGroup control, Func<DrawingCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingGroup.ChildrenProperty, func, expression);
public static DrawingGroup Children(this DrawingGroup control, DrawingCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static DrawingGroup Children<TValue>(this DrawingGroup control, TValue value, FuncValueConverter<TValue, DrawingCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DrawingImageExtensions
{
public static DrawingImage Drawing(this DrawingImage control, IBinding binding)
   => control._set(DrawingImage.DrawingProperty, binding);
public static DrawingImage Drawing(this DrawingImage control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DrawingImage.DrawingProperty, avaloniaProperty, bindingMode, converter);
public static DrawingImage Drawing(this DrawingImage control, Func<Drawing> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DrawingImage.DrawingProperty, func, expression);
public static DrawingImage Drawing(this DrawingImage control, Drawing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = value, bindingMode, converter, bindingSource);
public static DrawingImage Drawing<TValue>(this DrawingImage control, TValue value, FuncValueConverter<TValue, Drawing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DrawingImage.DrawingProperty, ps, () => control.Drawing = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class BlurEffectExtensions
{
public static BlurEffect Radius(this BlurEffect control, IBinding binding)
   => control._set(BlurEffect.RadiusProperty, binding);
public static BlurEffect Radius(this BlurEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(BlurEffect.RadiusProperty, avaloniaProperty, bindingMode, converter);
public static BlurEffect Radius(this BlurEffect control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(BlurEffect.RadiusProperty, func, expression);
public static BlurEffect Radius(this BlurEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BlurEffect.RadiusProperty, ps, () => control.Radius = value, bindingMode, converter, bindingSource);
public static BlurEffect Radius<TValue>(this BlurEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(BlurEffect.RadiusProperty, ps, () => control.Radius = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DropShadowEffectBaseExtensions
{
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, binding);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.BlurRadiusProperty, func, expression);
public static DropShadowEffectBase BlurRadius(this DropShadowEffectBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase BlurRadius<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.BlurRadiusProperty, ps, () => control.BlurRadius = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.ColorProperty, binding);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowEffectBase.ColorProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, Func<Color> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.ColorProperty, func, expression);
public static DropShadowEffectBase Color(this DropShadowEffectBase control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase Color<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, IBinding binding)
   => control._set(DropShadowEffectBase.OpacityProperty, binding);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowEffectBase.OpacityProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffectBase.OpacityProperty, func, expression);
public static DropShadowEffectBase Opacity(this DropShadowEffectBase control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = value, bindingMode, converter, bindingSource);
public static DropShadowEffectBase Opacity<TValue>(this DropShadowEffectBase control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffectBase.OpacityProperty, ps, () => control.Opacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DropShadowEffectExtensions
{
public static DropShadowEffect OffsetX(this DropShadowEffect control, IBinding binding)
   => control._set(DropShadowEffect.OffsetXProperty, binding);
public static DropShadowEffect OffsetX(this DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowEffect.OffsetXProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowEffect OffsetX(this DropShadowEffect control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffect.OffsetXProperty, func, expression);
public static DropShadowEffect OffsetX(this DropShadowEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = value, bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetX<TValue>(this DropShadowEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetXProperty, ps, () => control.OffsetX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetY(this DropShadowEffect control, IBinding binding)
   => control._set(DropShadowEffect.OffsetYProperty, binding);
public static DropShadowEffect OffsetY(this DropShadowEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowEffect.OffsetYProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowEffect OffsetY(this DropShadowEffect control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowEffect.OffsetYProperty, func, expression);
public static DropShadowEffect OffsetY(this DropShadowEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = value, bindingMode, converter, bindingSource);
public static DropShadowEffect OffsetY<TValue>(this DropShadowEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowEffect.OffsetYProperty, ps, () => control.OffsetY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class DropShadowDirectionEffectExtensions
{
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, IBinding binding)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, binding);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowDirectionEffect.ShadowDepthProperty, func, expression);
public static DropShadowDirectionEffect ShadowDepth(this DropShadowDirectionEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = value, bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect ShadowDepth<TValue>(this DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.ShadowDepthProperty, ps, () => control.ShadowDepth = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, IBinding binding)
   => control._set(DropShadowDirectionEffect.DirectionProperty, binding);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(DropShadowDirectionEffect.DirectionProperty, avaloniaProperty, bindingMode, converter);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(DropShadowDirectionEffect.DirectionProperty, func, expression);
public static DropShadowDirectionEffect Direction(this DropShadowDirectionEffect control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = value, bindingMode, converter, bindingSource);
public static DropShadowDirectionEffect Direction<TValue>(this DropShadowDirectionEffect control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(DropShadowDirectionEffect.DirectionProperty, ps, () => control.Direction = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class EllipseGeometryExtensions
{
public static EllipseGeometry Rect(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RectProperty, binding);
public static EllipseGeometry Rect(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(EllipseGeometry.RectProperty, avaloniaProperty, bindingMode, converter);
public static EllipseGeometry Rect(this EllipseGeometry control, Func<Rect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RectProperty, func, expression);
public static EllipseGeometry Rect(this EllipseGeometry control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static EllipseGeometry Rect<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static EllipseGeometry Rect(this EllipseGeometry control, Double x, Double y, Double width, Double height)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static EllipseGeometry Rect(this EllipseGeometry control, Size size)
   => control._set(() => control.Rect = new Rect(size));
public static EllipseGeometry Rect(this EllipseGeometry control, Point position, Size size)
   => control._set(() => control.Rect = new Rect(position, size));
public static EllipseGeometry Rect(this EllipseGeometry control, Point topLeft, Point bottomRight)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
public static EllipseGeometry RadiusX(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RadiusXProperty, binding);
public static EllipseGeometry RadiusX(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(EllipseGeometry.RadiusXProperty, avaloniaProperty, bindingMode, converter);
public static EllipseGeometry RadiusX(this EllipseGeometry control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RadiusXProperty, func, expression);
public static EllipseGeometry RadiusX(this EllipseGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = value, bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusX<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusXProperty, ps, () => control.RadiusX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusY(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.RadiusYProperty, binding);
public static EllipseGeometry RadiusY(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(EllipseGeometry.RadiusYProperty, avaloniaProperty, bindingMode, converter);
public static EllipseGeometry RadiusY(this EllipseGeometry control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.RadiusYProperty, func, expression);
public static EllipseGeometry RadiusY(this EllipseGeometry control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = value, bindingMode, converter, bindingSource);
public static EllipseGeometry RadiusY<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.RadiusYProperty, ps, () => control.RadiusY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static EllipseGeometry Center(this EllipseGeometry control, IBinding binding)
   => control._set(EllipseGeometry.CenterProperty, binding);
public static EllipseGeometry Center(this EllipseGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(EllipseGeometry.CenterProperty, avaloniaProperty, bindingMode, converter);
public static EllipseGeometry Center(this EllipseGeometry control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(EllipseGeometry.CenterProperty, func, expression);
public static EllipseGeometry Center(this EllipseGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static EllipseGeometry Center<TValue>(this EllipseGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(EllipseGeometry.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ExperimentalAcrylicMaterialExtensions
{
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, binding);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, Func<Color> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.TintColorProperty, func, expression);
public static ExperimentalAcrylicMaterial TintColor(this ExperimentalAcrylicMaterial control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintColor<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintColorProperty, ps, () => control.TintColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, binding);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, Func<AcrylicBackgroundSource> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.BackgroundSourceProperty, func, expression);
public static ExperimentalAcrylicMaterial BackgroundSource(this ExperimentalAcrylicMaterial control, AcrylicBackgroundSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial BackgroundSource<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, AcrylicBackgroundSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.BackgroundSourceProperty, ps, () => control.BackgroundSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, binding);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.TintOpacityProperty, func, expression);
public static ExperimentalAcrylicMaterial TintOpacity(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial TintOpacity<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.TintOpacityProperty, ps, () => control.TintOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, binding);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.MaterialOpacityProperty, func, expression);
public static ExperimentalAcrylicMaterial MaterialOpacity(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial MaterialOpacity<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.MaterialOpacityProperty, ps, () => control.MaterialOpacity = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, binding);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, func, expression);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel(this ExperimentalAcrylicMaterial control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial PlatformTransparencyCompensationLevel<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.PlatformTransparencyCompensationLevelProperty, ps, () => control.PlatformTransparencyCompensationLevel = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, IBinding binding)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, binding);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, avaloniaProperty, bindingMode, converter);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, Func<Color> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ExperimentalAcrylicMaterial.FallbackColorProperty, func, expression);
public static ExperimentalAcrylicMaterial FallbackColor(this ExperimentalAcrylicMaterial control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = value, bindingMode, converter, bindingSource);
public static ExperimentalAcrylicMaterial FallbackColor<TValue>(this ExperimentalAcrylicMaterial control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ExperimentalAcrylicMaterial.FallbackColorProperty, ps, () => control.FallbackColor = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GeometryExtensions
{
public static Geometry Transform(this Geometry control, IBinding binding)
   => control._set(Geometry.TransformProperty, binding);
public static Geometry Transform(this Geometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Geometry.TransformProperty, avaloniaProperty, bindingMode, converter);
public static Geometry Transform(this Geometry control, Func<Transform> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Geometry.TransformProperty, func, expression);
public static Geometry Transform(this Geometry control, Transform value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Geometry.TransformProperty, ps, () => control.Transform = value, bindingMode, converter, bindingSource);
public static Geometry Transform<TValue>(this Geometry control, TValue value, FuncValueConverter<TValue, Transform> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Geometry.TransformProperty, ps, () => control.Transform = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GeometryDrawingExtensions
{
public static GeometryDrawing Geometry(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.GeometryProperty, binding);
public static GeometryDrawing Geometry(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GeometryDrawing.GeometryProperty, avaloniaProperty, bindingMode, converter);
public static GeometryDrawing Geometry(this GeometryDrawing control, Func<Geometry> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.GeometryProperty, func, expression);
public static GeometryDrawing Geometry(this GeometryDrawing control, Geometry value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.GeometryProperty, ps, () => control.Geometry = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Geometry<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, Geometry> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.GeometryProperty, ps, () => control.Geometry = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeometryDrawing Brush(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.BrushProperty, binding);
public static GeometryDrawing Brush(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GeometryDrawing.BrushProperty, avaloniaProperty, bindingMode, converter);
public static GeometryDrawing Brush(this GeometryDrawing control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.BrushProperty, func, expression);
public static GeometryDrawing Brush(this GeometryDrawing control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.BrushProperty, ps, () => control.Brush = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Brush<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.BrushProperty, ps, () => control.Brush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeometryDrawing Pen(this GeometryDrawing control, IBinding binding)
   => control._set(GeometryDrawing.PenProperty, binding);
public static GeometryDrawing Pen(this GeometryDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GeometryDrawing.PenProperty, avaloniaProperty, bindingMode, converter);
public static GeometryDrawing Pen(this GeometryDrawing control, Func<IPen> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryDrawing.PenProperty, func, expression);
public static GeometryDrawing Pen(this GeometryDrawing control, IPen value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.PenProperty, ps, () => control.Pen = value, bindingMode, converter, bindingSource);
public static GeometryDrawing Pen<TValue>(this GeometryDrawing control, TValue value, FuncValueConverter<TValue, IPen> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryDrawing.PenProperty, ps, () => control.Pen = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GeometryGroupExtensions
{
public static GeometryGroup Children(this GeometryGroup control, IBinding binding)
   => control._set(GeometryGroup.ChildrenProperty, binding);
public static GeometryGroup Children(this GeometryGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GeometryGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter);
public static GeometryGroup Children(this GeometryGroup control, Func<GeometryCollection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryGroup.ChildrenProperty, func, expression);
public static GeometryGroup Children(this GeometryGroup control, GeometryCollection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static GeometryGroup Children<TValue>(this GeometryGroup control, TValue value, FuncValueConverter<TValue, GeometryCollection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GeometryGroup FillRule(this GeometryGroup control, IBinding binding)
   => control._set(GeometryGroup.FillRuleProperty, binding);
public static GeometryGroup FillRule(this GeometryGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GeometryGroup.FillRuleProperty, avaloniaProperty, bindingMode, converter);
public static GeometryGroup FillRule(this GeometryGroup control, Func<FillRule> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GeometryGroup.FillRuleProperty, func, expression);
public static GeometryGroup FillRule(this GeometryGroup control, FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryGroup.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);
public static GeometryGroup FillRule<TValue>(this GeometryGroup control, TValue value, FuncValueConverter<TValue, FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GeometryGroup.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GlyphRunDrawingExtensions
{
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, IBinding binding)
   => control._set(GlyphRunDrawing.ForegroundProperty, binding);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GlyphRunDrawing.ForegroundProperty, avaloniaProperty, bindingMode, converter);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GlyphRunDrawing.ForegroundProperty, func, expression);
public static GlyphRunDrawing Foreground(this GlyphRunDrawing control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = value, bindingMode, converter, bindingSource);
public static GlyphRunDrawing Foreground<TValue>(this GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.ForegroundProperty, ps, () => control.Foreground = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, IBinding binding)
   => control._set(GlyphRunDrawing.GlyphRunProperty, binding);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GlyphRunDrawing.GlyphRunProperty, avaloniaProperty, bindingMode, converter);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, Func<GlyphRun> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GlyphRunDrawing.GlyphRunProperty, func, expression);
public static GlyphRunDrawing GlyphRun(this GlyphRunDrawing control, GlyphRun value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = value, bindingMode, converter, bindingSource);
public static GlyphRunDrawing GlyphRun<TValue>(this GlyphRunDrawing control, TValue value, FuncValueConverter<TValue, GlyphRun> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GlyphRunDrawing.GlyphRunProperty, ps, () => control.GlyphRun = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GradientBrushExtensions
{
public static GradientBrush SpreadMethod(this GradientBrush control, IBinding binding)
   => control._set(GradientBrush.SpreadMethodProperty, binding);
public static GradientBrush SpreadMethod(this GradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GradientBrush.SpreadMethodProperty, avaloniaProperty, bindingMode, converter);
public static GradientBrush SpreadMethod(this GradientBrush control, Func<GradientSpreadMethod> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientBrush.SpreadMethodProperty, func, expression);
public static GradientBrush SpreadMethod(this GradientBrush control, GradientSpreadMethod value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientBrush.SpreadMethodProperty, ps, () => control.SpreadMethod = value, bindingMode, converter, bindingSource);
public static GradientBrush SpreadMethod<TValue>(this GradientBrush control, TValue value, FuncValueConverter<TValue, GradientSpreadMethod> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientBrush.SpreadMethodProperty, ps, () => control.SpreadMethod = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GradientBrush GradientStops(this GradientBrush control, IBinding binding)
   => control._set(GradientBrush.GradientStopsProperty, binding);
public static GradientBrush GradientStops(this GradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GradientBrush.GradientStopsProperty, avaloniaProperty, bindingMode, converter);
public static GradientBrush GradientStops(this GradientBrush control, Func<GradientStops> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientBrush.GradientStopsProperty, func, expression);
public static GradientBrush GradientStops(this GradientBrush control, GradientStops value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientBrush.GradientStopsProperty, ps, () => control.GradientStops = value, bindingMode, converter, bindingSource);
public static GradientBrush GradientStops<TValue>(this GradientBrush control, TValue value, FuncValueConverter<TValue, GradientStops> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientBrush.GradientStopsProperty, ps, () => control.GradientStops = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class GradientStopExtensions
{
public static GradientStop Offset(this GradientStop control, IBinding binding)
   => control._set(GradientStop.OffsetProperty, binding);
public static GradientStop Offset(this GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GradientStop.OffsetProperty, avaloniaProperty, bindingMode, converter);
public static GradientStop Offset(this GradientStop control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientStop.OffsetProperty, func, expression);
public static GradientStop Offset(this GradientStop control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.OffsetProperty, ps, () => control.Offset = value, bindingMode, converter, bindingSource);
public static GradientStop Offset<TValue>(this GradientStop control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.OffsetProperty, ps, () => control.Offset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static GradientStop Color(this GradientStop control, IBinding binding)
   => control._set(GradientStop.ColorProperty, binding);
public static GradientStop Color(this GradientStop control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(GradientStop.ColorProperty, avaloniaProperty, bindingMode, converter);
public static GradientStop Color(this GradientStop control, Func<Color> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(GradientStop.ColorProperty, func, expression);
public static GradientStop Color(this GradientStop control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static GradientStop Color<TValue>(this GradientStop control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(GradientStop.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ImageBrushExtensions
{
public static ImageBrush Source(this ImageBrush control, IBinding binding)
   => control._set(ImageBrush.SourceProperty, binding);
public static ImageBrush Source(this ImageBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ImageBrush.SourceProperty, avaloniaProperty, bindingMode, converter);
public static ImageBrush Source(this ImageBrush control, Func<IImageBrushSource> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageBrush.SourceProperty, func, expression);
public static ImageBrush Source(this ImageBrush control, IImageBrushSource value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageBrush.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static ImageBrush Source<TValue>(this ImageBrush control, TValue value, FuncValueConverter<TValue, IImageBrushSource> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageBrush.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ImageDrawingExtensions
{
public static ImageDrawing ImageSource(this ImageDrawing control, IBinding binding)
   => control._set(ImageDrawing.ImageSourceProperty, binding);
public static ImageDrawing ImageSource(this ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ImageDrawing.ImageSourceProperty, avaloniaProperty, bindingMode, converter);
public static ImageDrawing ImageSource(this ImageDrawing control, Func<IImage> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageDrawing.ImageSourceProperty, func, expression);
public static ImageDrawing ImageSource(this ImageDrawing control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = value, bindingMode, converter, bindingSource);
public static ImageDrawing ImageSource<TValue>(this ImageDrawing control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.ImageSourceProperty, ps, () => control.ImageSource = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ImageDrawing Rect(this ImageDrawing control, IBinding binding)
   => control._set(ImageDrawing.RectProperty, binding);
public static ImageDrawing Rect(this ImageDrawing control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ImageDrawing.RectProperty, avaloniaProperty, bindingMode, converter);
public static ImageDrawing Rect(this ImageDrawing control, Func<Rect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ImageDrawing.RectProperty, func, expression);
public static ImageDrawing Rect(this ImageDrawing control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static ImageDrawing Rect<TValue>(this ImageDrawing control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ImageDrawing.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static ImageDrawing Rect(this ImageDrawing control, Double x, Double y, Double width, Double height)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static ImageDrawing Rect(this ImageDrawing control, Size size)
   => control._set(() => control.Rect = new Rect(size));
public static ImageDrawing Rect(this ImageDrawing control, Point position, Size size)
   => control._set(() => control.Rect = new Rect(position, size));
public static ImageDrawing Rect(this ImageDrawing control, Point topLeft, Point bottomRight)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
}
public static partial class LinearGradientBrushExtensions
{
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, IBinding binding)
   => control._set(LinearGradientBrush.StartPointProperty, binding);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LinearGradientBrush.StartPointProperty, avaloniaProperty, bindingMode, converter);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LinearGradientBrush.StartPointProperty, func, expression);
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static LinearGradientBrush StartPoint<TValue>(this LinearGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.StartPoint = new RelativePoint(x, y, unit));
public static LinearGradientBrush StartPoint(this LinearGradientBrush control, Point point, RelativeUnit unit)
   => control._set(() => control.StartPoint = new RelativePoint(point, unit));
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, IBinding binding)
   => control._set(LinearGradientBrush.EndPointProperty, binding);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LinearGradientBrush.EndPointProperty, avaloniaProperty, bindingMode, converter);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LinearGradientBrush.EndPointProperty, func, expression);
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static LinearGradientBrush EndPoint<TValue>(this LinearGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LinearGradientBrush.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.EndPoint = new RelativePoint(x, y, unit));
public static LinearGradientBrush EndPoint(this LinearGradientBrush control, Point point, RelativeUnit unit)
   => control._set(() => control.EndPoint = new RelativePoint(point, unit));
}
public static partial class LineGeometryExtensions
{
public static LineGeometry StartPoint(this LineGeometry control, IBinding binding)
   => control._set(LineGeometry.StartPointProperty, binding);
public static LineGeometry StartPoint(this LineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LineGeometry.StartPointProperty, avaloniaProperty, bindingMode, converter);
public static LineGeometry StartPoint(this LineGeometry control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineGeometry.StartPointProperty, func, expression);
public static LineGeometry StartPoint(this LineGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static LineGeometry StartPoint<TValue>(this LineGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static LineGeometry EndPoint(this LineGeometry control, IBinding binding)
   => control._set(LineGeometry.EndPointProperty, binding);
public static LineGeometry EndPoint(this LineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LineGeometry.EndPointProperty, avaloniaProperty, bindingMode, converter);
public static LineGeometry EndPoint(this LineGeometry control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineGeometry.EndPointProperty, func, expression);
public static LineGeometry EndPoint(this LineGeometry control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.EndPointProperty, ps, () => control.EndPoint = value, bindingMode, converter, bindingSource);
public static LineGeometry EndPoint<TValue>(this LineGeometry control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineGeometry.EndPointProperty, ps, () => control.EndPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class LineSegmentExtensions
{
public static LineSegment Point(this LineSegment control, IBinding binding)
   => control._set(LineSegment.PointProperty, binding);
public static LineSegment Point(this LineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(LineSegment.PointProperty, avaloniaProperty, bindingMode, converter);
public static LineSegment Point(this LineSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(LineSegment.PointProperty, func, expression);
public static LineSegment Point(this LineSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineSegment.PointProperty, ps, () => control.Point = value, bindingMode, converter, bindingSource);
public static LineSegment Point<TValue>(this LineSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(LineSegment.PointProperty, ps, () => control.Point = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class MatrixTransformExtensions
{
public static MatrixTransform Matrix(this MatrixTransform control, IBinding binding)
   => control._set(MatrixTransform.MatrixProperty, binding);
public static MatrixTransform Matrix(this MatrixTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(MatrixTransform.MatrixProperty, avaloniaProperty, bindingMode, converter);
public static MatrixTransform Matrix(this MatrixTransform control, Func<Matrix> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(MatrixTransform.MatrixProperty, func, expression);
public static MatrixTransform Matrix(this MatrixTransform control, Matrix value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MatrixTransform.MatrixProperty, ps, () => control.Matrix = value, bindingMode, converter, bindingSource);
public static MatrixTransform Matrix<TValue>(this MatrixTransform control, TValue value, FuncValueConverter<TValue, Matrix> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(MatrixTransform.MatrixProperty, ps, () => control.Matrix = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static MatrixTransform Matrix(this MatrixTransform control, Double scaleX, Double skewY, Double skewX, Double scaleY, Double offsetX, Double offsetY)
   => control._set(() => control.Matrix = new Matrix(scaleX, skewY, skewX, scaleY, offsetX, offsetY));
public static MatrixTransform Matrix(this MatrixTransform control, Double scaleX, Double skewY, Double perspX, Double skewX, Double scaleY, Double perspY, Double offsetX, Double offsetY, Double perspZ)
   => control._set(() => control.Matrix = new Matrix(scaleX, skewY, perspX, skewX, scaleY, perspY, offsetX, offsetY, perspZ));
}
public static partial class PathFigureExtensions
{
public static PathFigure IsClosed(this PathFigure control, IBinding binding)
   => control._set(PathFigure.IsClosedProperty, binding);
public static PathFigure IsClosed(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathFigure.IsClosedProperty, avaloniaProperty, bindingMode, converter);
public static PathFigure IsClosed(this PathFigure control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.IsClosedProperty, func, expression);
public static PathFigure IsClosed(this PathFigure control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsClosedProperty, ps, () => control.IsClosed = value, bindingMode, converter, bindingSource);
public static PathFigure IsClosed<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsClosedProperty, ps, () => control.IsClosed = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure IsFilled(this PathFigure control, IBinding binding)
   => control._set(PathFigure.IsFilledProperty, binding);
public static PathFigure IsFilled(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathFigure.IsFilledProperty, avaloniaProperty, bindingMode, converter);
public static PathFigure IsFilled(this PathFigure control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.IsFilledProperty, func, expression);
public static PathFigure IsFilled(this PathFigure control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static PathFigure IsFilled<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure Segments(this PathFigure control, IBinding binding)
   => control._set(PathFigure.SegmentsProperty, binding);
public static PathFigure Segments(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathFigure.SegmentsProperty, avaloniaProperty, bindingMode, converter);
public static PathFigure Segments(this PathFigure control, Func<PathSegments> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.SegmentsProperty, func, expression);
public static PathFigure Segments(this PathFigure control, PathSegments value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.SegmentsProperty, ps, () => control.Segments = value, bindingMode, converter, bindingSource);
public static PathFigure Segments<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, PathSegments> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.SegmentsProperty, ps, () => control.Segments = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathFigure StartPoint(this PathFigure control, IBinding binding)
   => control._set(PathFigure.StartPointProperty, binding);
public static PathFigure StartPoint(this PathFigure control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathFigure.StartPointProperty, avaloniaProperty, bindingMode, converter);
public static PathFigure StartPoint(this PathFigure control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathFigure.StartPointProperty, func, expression);
public static PathFigure StartPoint(this PathFigure control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.StartPointProperty, ps, () => control.StartPoint = value, bindingMode, converter, bindingSource);
public static PathFigure StartPoint<TValue>(this PathFigure control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathFigure.StartPointProperty, ps, () => control.StartPoint = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PathGeometryExtensions
{
public static PathGeometry Figures(this PathGeometry control, IBinding binding)
   => control._set(PathGeometry.FiguresProperty, binding);
public static PathGeometry Figures(this PathGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathGeometry.FiguresProperty, avaloniaProperty, bindingMode, converter);
public static PathGeometry Figures(this PathGeometry control, Func<PathFigures> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathGeometry.FiguresProperty, func, expression);
public static PathGeometry Figures(this PathGeometry control, PathFigures value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathGeometry.FiguresProperty, ps, () => control.Figures = value, bindingMode, converter, bindingSource);
public static PathGeometry Figures<TValue>(this PathGeometry control, TValue value, FuncValueConverter<TValue, PathFigures> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathGeometry.FiguresProperty, ps, () => control.Figures = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PathGeometry FillRule(this PathGeometry control, IBinding binding)
   => control._set(PathGeometry.FillRuleProperty, binding);
public static PathGeometry FillRule(this PathGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PathGeometry.FillRuleProperty, avaloniaProperty, bindingMode, converter);
public static PathGeometry FillRule(this PathGeometry control, Func<FillRule> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PathGeometry.FillRuleProperty, func, expression);
public static PathGeometry FillRule(this PathGeometry control, FillRule value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathGeometry.FillRuleProperty, ps, () => control.FillRule = value, bindingMode, converter, bindingSource);
public static PathGeometry FillRule<TValue>(this PathGeometry control, TValue value, FuncValueConverter<TValue, FillRule> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PathGeometry.FillRuleProperty, ps, () => control.FillRule = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PenExtensions
{
public static Pen Brush(this Pen control, IBinding binding)
   => control._set(Pen.BrushProperty, binding);
public static Pen Brush(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.BrushProperty, avaloniaProperty, bindingMode, converter);
public static Pen Brush(this Pen control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.BrushProperty, func, expression);
public static Pen Brush(this Pen control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.BrushProperty, ps, () => control.Brush = value, bindingMode, converter, bindingSource);
public static Pen Brush<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.BrushProperty, ps, () => control.Brush = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen Thickness(this Pen control, IBinding binding)
   => control._set(Pen.ThicknessProperty, binding);
public static Pen Thickness(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.ThicknessProperty, avaloniaProperty, bindingMode, converter);
public static Pen Thickness(this Pen control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.ThicknessProperty, func, expression);
public static Pen Thickness(this Pen control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.ThicknessProperty, ps, () => control.Thickness = value, bindingMode, converter, bindingSource);
public static Pen Thickness<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.ThicknessProperty, ps, () => control.Thickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen DashStyle(this Pen control, IBinding binding)
   => control._set(Pen.DashStyleProperty, binding);
public static Pen DashStyle(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.DashStyleProperty, avaloniaProperty, bindingMode, converter);
public static Pen DashStyle(this Pen control, Func<IDashStyle> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.DashStyleProperty, func, expression);
public static Pen DashStyle(this Pen control, IDashStyle value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.DashStyleProperty, ps, () => control.DashStyle = value, bindingMode, converter, bindingSource);
public static Pen DashStyle<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, IDashStyle> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.DashStyleProperty, ps, () => control.DashStyle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen LineCap(this Pen control, IBinding binding)
   => control._set(Pen.LineCapProperty, binding);
public static Pen LineCap(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.LineCapProperty, avaloniaProperty, bindingMode, converter);
public static Pen LineCap(this Pen control, Func<PenLineCap> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.LineCapProperty, func, expression);
public static Pen LineCap(this Pen control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineCapProperty, ps, () => control.LineCap = value, bindingMode, converter, bindingSource);
public static Pen LineCap<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineCapProperty, ps, () => control.LineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen LineJoin(this Pen control, IBinding binding)
   => control._set(Pen.LineJoinProperty, binding);
public static Pen LineJoin(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.LineJoinProperty, avaloniaProperty, bindingMode, converter);
public static Pen LineJoin(this Pen control, Func<PenLineJoin> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.LineJoinProperty, func, expression);
public static Pen LineJoin(this Pen control, PenLineJoin value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineJoinProperty, ps, () => control.LineJoin = value, bindingMode, converter, bindingSource);
public static Pen LineJoin<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, PenLineJoin> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.LineJoinProperty, ps, () => control.LineJoin = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Pen MiterLimit(this Pen control, IBinding binding)
   => control._set(Pen.MiterLimitProperty, binding);
public static Pen MiterLimit(this Pen control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Pen.MiterLimitProperty, avaloniaProperty, bindingMode, converter);
public static Pen MiterLimit(this Pen control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Pen.MiterLimitProperty, func, expression);
public static Pen MiterLimit(this Pen control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.MiterLimitProperty, ps, () => control.MiterLimit = value, bindingMode, converter, bindingSource);
public static Pen MiterLimit<TValue>(this Pen control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Pen.MiterLimitProperty, ps, () => control.MiterLimit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PolylineGeometryExtensions
{
public static PolylineGeometry Points(this PolylineGeometry control, IBinding binding)
   => control._set(PolylineGeometry.PointsProperty, binding);
public static PolylineGeometry Points(this PolylineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PolylineGeometry.PointsProperty, avaloniaProperty, bindingMode, converter);
public static PolylineGeometry Points(this PolylineGeometry control, Func<IList<Point>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolylineGeometry.PointsProperty, func, expression);
public static PolylineGeometry Points(this PolylineGeometry control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static PolylineGeometry Points<TValue>(this PolylineGeometry control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static PolylineGeometry IsFilled(this PolylineGeometry control, IBinding binding)
   => control._set(PolylineGeometry.IsFilledProperty, binding);
public static PolylineGeometry IsFilled(this PolylineGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PolylineGeometry.IsFilledProperty, avaloniaProperty, bindingMode, converter);
public static PolylineGeometry IsFilled(this PolylineGeometry control, Func<Boolean> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolylineGeometry.IsFilledProperty, func, expression);
public static PolylineGeometry IsFilled(this PolylineGeometry control, Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = value, bindingMode, converter, bindingSource);
public static PolylineGeometry IsFilled<TValue>(this PolylineGeometry control, TValue value, FuncValueConverter<TValue, Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolylineGeometry.IsFilledProperty, ps, () => control.IsFilled = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class PolyLineSegmentExtensions
{
public static PolyLineSegment Points(this PolyLineSegment control, IBinding binding)
   => control._set(PolyLineSegment.PointsProperty, binding);
public static PolyLineSegment Points(this PolyLineSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(PolyLineSegment.PointsProperty, avaloniaProperty, bindingMode, converter);
public static PolyLineSegment Points(this PolyLineSegment control, Func<IList<Point>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(PolyLineSegment.PointsProperty, func, expression);
public static PolyLineSegment Points(this PolyLineSegment control, IList<Point> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolyLineSegment.PointsProperty, ps, () => control.Points = value, bindingMode, converter, bindingSource);
public static PolyLineSegment Points<TValue>(this PolyLineSegment control, TValue value, FuncValueConverter<TValue, IList<Point>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(PolyLineSegment.PointsProperty, ps, () => control.Points = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class QuadraticBezierSegmentExtensions
{
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, IBinding binding)
   => control._set(QuadraticBezierSegment.Point1Property, binding);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(QuadraticBezierSegment.Point1Property, avaloniaProperty, bindingMode, converter);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(QuadraticBezierSegment.Point1Property, func, expression);
public static QuadraticBezierSegment Point1(this QuadraticBezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = value, bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point1<TValue>(this QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point1Property, ps, () => control.Point1 = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, IBinding binding)
   => control._set(QuadraticBezierSegment.Point2Property, binding);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(QuadraticBezierSegment.Point2Property, avaloniaProperty, bindingMode, converter);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, Func<Point> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(QuadraticBezierSegment.Point2Property, func, expression);
public static QuadraticBezierSegment Point2(this QuadraticBezierSegment control, Point value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = value, bindingMode, converter, bindingSource);
public static QuadraticBezierSegment Point2<TValue>(this QuadraticBezierSegment control, TValue value, FuncValueConverter<TValue, Point> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(QuadraticBezierSegment.Point2Property, ps, () => control.Point2 = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RadialGradientBrushExtensions
{
public static RadialGradientBrush Center(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.CenterProperty, binding);
public static RadialGradientBrush Center(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RadialGradientBrush.CenterProperty, avaloniaProperty, bindingMode, converter);
public static RadialGradientBrush Center(this RadialGradientBrush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.CenterProperty, func, expression);
public static RadialGradientBrush Center(this RadialGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.CenterProperty, ps, () => control.Center = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush Center<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.CenterProperty, ps, () => control.Center = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RadialGradientBrush Center(this RadialGradientBrush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.Center = new RelativePoint(x, y, unit));
public static RadialGradientBrush Center(this RadialGradientBrush control, Point point, RelativeUnit unit)
   => control._set(() => control.Center = new RelativePoint(point, unit));
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.GradientOriginProperty, binding);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RadialGradientBrush.GradientOriginProperty, avaloniaProperty, bindingMode, converter);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Func<RelativePoint> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.GradientOriginProperty, func, expression);
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, RelativePoint value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush GradientOrigin<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, RelativePoint> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.GradientOriginProperty, ps, () => control.GradientOrigin = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Double x, Double y, RelativeUnit unit)
   => control._set(() => control.GradientOrigin = new RelativePoint(x, y, unit));
public static RadialGradientBrush GradientOrigin(this RadialGradientBrush control, Point point, RelativeUnit unit)
   => control._set(() => control.GradientOrigin = new RelativePoint(point, unit));
public static RadialGradientBrush Radius(this RadialGradientBrush control, IBinding binding)
   => control._set(RadialGradientBrush.RadiusProperty, binding);
public static RadialGradientBrush Radius(this RadialGradientBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RadialGradientBrush.RadiusProperty, avaloniaProperty, bindingMode, converter);
public static RadialGradientBrush Radius(this RadialGradientBrush control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RadialGradientBrush.RadiusProperty, func, expression);
public static RadialGradientBrush Radius(this RadialGradientBrush control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusProperty, ps, () => control.Radius = value, bindingMode, converter, bindingSource);
public static RadialGradientBrush Radius<TValue>(this RadialGradientBrush control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RadialGradientBrush.RadiusProperty, ps, () => control.Radius = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class RectangleGeometryExtensions
{
public static RectangleGeometry Rect(this RectangleGeometry control, IBinding binding)
   => control._set(RectangleGeometry.RectProperty, binding);
public static RectangleGeometry Rect(this RectangleGeometry control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RectangleGeometry.RectProperty, avaloniaProperty, bindingMode, converter);
public static RectangleGeometry Rect(this RectangleGeometry control, Func<Rect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RectangleGeometry.RectProperty, func, expression);
public static RectangleGeometry Rect(this RectangleGeometry control, Rect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RectProperty, ps, () => control.Rect = value, bindingMode, converter, bindingSource);
public static RectangleGeometry Rect<TValue>(this RectangleGeometry control, TValue value, FuncValueConverter<TValue, Rect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RectangleGeometry.RectProperty, ps, () => control.Rect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static RectangleGeometry Rect(this RectangleGeometry control, Double x, Double y, Double width, Double height)
   => control._set(() => control.Rect = new Rect(x, y, width, height));
public static RectangleGeometry Rect(this RectangleGeometry control, Size size)
   => control._set(() => control.Rect = new Rect(size));
public static RectangleGeometry Rect(this RectangleGeometry control, Point position, Size size)
   => control._set(() => control.Rect = new Rect(position, size));
public static RectangleGeometry Rect(this RectangleGeometry control, Point topLeft, Point bottomRight)
   => control._set(() => control.Rect = new Rect(topLeft, bottomRight));
}
public static partial class RotateTransformExtensions
{
public static RotateTransform Angle(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.AngleProperty, binding);
public static RotateTransform Angle(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RotateTransform.AngleProperty, avaloniaProperty, bindingMode, converter);
public static RotateTransform Angle(this RotateTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.AngleProperty, func, expression);
public static RotateTransform Angle(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.AngleProperty, ps, () => control.Angle = value, bindingMode, converter, bindingSource);
public static RotateTransform Angle<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.AngleProperty, ps, () => control.Angle = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RotateTransform CenterX(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.CenterXProperty, binding);
public static RotateTransform CenterX(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RotateTransform.CenterXProperty, avaloniaProperty, bindingMode, converter);
public static RotateTransform CenterX(this RotateTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.CenterXProperty, func, expression);
public static RotateTransform CenterX(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterXProperty, ps, () => control.CenterX = value, bindingMode, converter, bindingSource);
public static RotateTransform CenterX<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static RotateTransform CenterY(this RotateTransform control, IBinding binding)
   => control._set(RotateTransform.CenterYProperty, binding);
public static RotateTransform CenterY(this RotateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(RotateTransform.CenterYProperty, avaloniaProperty, bindingMode, converter);
public static RotateTransform CenterY(this RotateTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(RotateTransform.CenterYProperty, func, expression);
public static RotateTransform CenterY(this RotateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterYProperty, ps, () => control.CenterY = value, bindingMode, converter, bindingSource);
public static RotateTransform CenterY<TValue>(this RotateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(RotateTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class ScaleTransformExtensions
{
public static ScaleTransform ScaleX(this ScaleTransform control, IBinding binding)
   => control._set(ScaleTransform.ScaleXProperty, binding);
public static ScaleTransform ScaleX(this ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScaleTransform.ScaleXProperty, avaloniaProperty, bindingMode, converter);
public static ScaleTransform ScaleX(this ScaleTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScaleTransform.ScaleXProperty, func, expression);
public static ScaleTransform ScaleX(this ScaleTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = value, bindingMode, converter, bindingSource);
public static ScaleTransform ScaleX<TValue>(this ScaleTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleXProperty, ps, () => control.ScaleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static ScaleTransform ScaleY(this ScaleTransform control, IBinding binding)
   => control._set(ScaleTransform.ScaleYProperty, binding);
public static ScaleTransform ScaleY(this ScaleTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(ScaleTransform.ScaleYProperty, avaloniaProperty, bindingMode, converter);
public static ScaleTransform ScaleY(this ScaleTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(ScaleTransform.ScaleYProperty, func, expression);
public static ScaleTransform ScaleY(this ScaleTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = value, bindingMode, converter, bindingSource);
public static ScaleTransform ScaleY<TValue>(this ScaleTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(ScaleTransform.ScaleYProperty, ps, () => control.ScaleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SkewTransformExtensions
{
public static SkewTransform AngleX(this SkewTransform control, IBinding binding)
   => control._set(SkewTransform.AngleXProperty, binding);
public static SkewTransform AngleX(this SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SkewTransform.AngleXProperty, avaloniaProperty, bindingMode, converter);
public static SkewTransform AngleX(this SkewTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SkewTransform.AngleXProperty, func, expression);
public static SkewTransform AngleX(this SkewTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);
public static SkewTransform AngleX<TValue>(this SkewTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static SkewTransform AngleY(this SkewTransform control, IBinding binding)
   => control._set(SkewTransform.AngleYProperty, binding);
public static SkewTransform AngleY(this SkewTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SkewTransform.AngleYProperty, avaloniaProperty, bindingMode, converter);
public static SkewTransform AngleY(this SkewTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SkewTransform.AngleYProperty, func, expression);
public static SkewTransform AngleY(this SkewTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);
public static SkewTransform AngleY<TValue>(this SkewTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SkewTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class SolidColorBrushExtensions
{
public static SolidColorBrush Color(this SolidColorBrush control, IBinding binding)
   => control._set(SolidColorBrush.ColorProperty, binding);
public static SolidColorBrush Color(this SolidColorBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(SolidColorBrush.ColorProperty, avaloniaProperty, bindingMode, converter);
public static SolidColorBrush Color(this SolidColorBrush control, Func<Color> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(SolidColorBrush.ColorProperty, func, expression);
public static SolidColorBrush Color(this SolidColorBrush control, Color value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SolidColorBrush.ColorProperty, ps, () => control.Color = value, bindingMode, converter, bindingSource);
public static SolidColorBrush Color<TValue>(this SolidColorBrush control, TValue value, FuncValueConverter<TValue, Color> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(SolidColorBrush.ColorProperty, ps, () => control.Color = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TextDecorationExtensions
{
public static TextDecoration Location(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.LocationProperty, binding);
public static TextDecoration Location(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.LocationProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration Location(this TextDecoration control, Func<TextDecorationLocation> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.LocationProperty, func, expression);
public static TextDecoration Location(this TextDecoration control, TextDecorationLocation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = value, bindingMode, converter, bindingSource);
public static TextDecoration Location<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationLocation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.LocationProperty, ps, () => control.Location = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration Stroke(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeProperty, binding);
public static TextDecoration Stroke(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration Stroke(this TextDecoration control, Func<IBrush> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeProperty, func, expression);
public static TextDecoration Stroke(this TextDecoration control, IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = value, bindingMode, converter, bindingSource);
public static TextDecoration Stroke<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeProperty, ps, () => control.Stroke = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, binding);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, Func<TextDecorationUnit> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeThicknessUnitProperty, func, expression);
public static TextDecoration StrokeThicknessUnit(this TextDecoration control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeThicknessUnit<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessUnitProperty, ps, () => control.StrokeThicknessUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashArray(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeDashArrayProperty, binding);
public static TextDecoration StrokeDashArray(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeDashArrayProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeDashArray(this TextDecoration control, Func<AvaloniaList<Double>> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeDashArrayProperty, func, expression);
public static TextDecoration StrokeDashArray(this TextDecoration control, AvaloniaList<Double> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashArray<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, AvaloniaList<Double>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashArrayProperty, ps, () => control.StrokeDashArray = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashOffset(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeDashOffsetProperty, binding);
public static TextDecoration StrokeDashOffset(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeDashOffsetProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeDashOffset(this TextDecoration control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeDashOffsetProperty, func, expression);
public static TextDecoration StrokeDashOffset(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeDashOffset<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeDashOffsetProperty, ps, () => control.StrokeDashOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeThickness(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeThicknessProperty, binding);
public static TextDecoration StrokeThickness(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeThicknessProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeThickness(this TextDecoration control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeThicknessProperty, func, expression);
public static TextDecoration StrokeThickness(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeThickness<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeThicknessProperty, ps, () => control.StrokeThickness = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeLineCap(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeLineCapProperty, binding);
public static TextDecoration StrokeLineCap(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeLineCapProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeLineCap(this TextDecoration control, Func<PenLineCap> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeLineCapProperty, func, expression);
public static TextDecoration StrokeLineCap(this TextDecoration control, PenLineCap value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeLineCap<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, PenLineCap> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeLineCapProperty, ps, () => control.StrokeLineCap = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffset(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeOffsetProperty, binding);
public static TextDecoration StrokeOffset(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeOffsetProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeOffset(this TextDecoration control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeOffsetProperty, func, expression);
public static TextDecoration StrokeOffset(this TextDecoration control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffset<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetProperty, ps, () => control.StrokeOffset = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, IBinding binding)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, binding);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, avaloniaProperty, bindingMode, converter);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, Func<TextDecorationUnit> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TextDecoration.StrokeOffsetUnitProperty, func, expression);
public static TextDecoration StrokeOffsetUnit(this TextDecoration control, TextDecorationUnit value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = value, bindingMode, converter, bindingSource);
public static TextDecoration StrokeOffsetUnit<TValue>(this TextDecoration control, TValue value, FuncValueConverter<TValue, TextDecorationUnit> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TextDecoration.StrokeOffsetUnitProperty, ps, () => control.StrokeOffsetUnit = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TileBrushExtensions
{
public static TileBrush AlignmentX(this TileBrush control, IBinding binding)
   => control._set(TileBrush.AlignmentXProperty, binding);
public static TileBrush AlignmentX(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.AlignmentXProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush AlignmentX(this TileBrush control, Func<AlignmentX> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.AlignmentXProperty, func, expression);
public static TileBrush AlignmentX(this TileBrush control, AlignmentX value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = value, bindingMode, converter, bindingSource);
public static TileBrush AlignmentX<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, AlignmentX> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentXProperty, ps, () => control.AlignmentX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush AlignmentY(this TileBrush control, IBinding binding)
   => control._set(TileBrush.AlignmentYProperty, binding);
public static TileBrush AlignmentY(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.AlignmentYProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush AlignmentY(this TileBrush control, Func<AlignmentY> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.AlignmentYProperty, func, expression);
public static TileBrush AlignmentY(this TileBrush control, AlignmentY value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = value, bindingMode, converter, bindingSource);
public static TileBrush AlignmentY<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, AlignmentY> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.AlignmentYProperty, ps, () => control.AlignmentY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush DestinationRect(this TileBrush control, IBinding binding)
   => control._set(TileBrush.DestinationRectProperty, binding);
public static TileBrush DestinationRect(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.DestinationRectProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush DestinationRect(this TileBrush control, Func<RelativeRect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.DestinationRectProperty, func, expression);
public static TileBrush DestinationRect(this TileBrush control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = value, bindingMode, converter, bindingSource);
public static TileBrush DestinationRect<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.DestinationRectProperty, ps, () => control.DestinationRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TileBrush DestinationRect(this TileBrush control, Double x, Double y, Double width, Double height, RelativeUnit unit)
   => control._set(() => control.DestinationRect = new RelativeRect(x, y, width, height, unit));
public static TileBrush DestinationRect(this TileBrush control, Rect rect, RelativeUnit unit)
   => control._set(() => control.DestinationRect = new RelativeRect(rect, unit));
public static TileBrush DestinationRect(this TileBrush control, Size size, RelativeUnit unit)
   => control._set(() => control.DestinationRect = new RelativeRect(size, unit));
public static TileBrush DestinationRect(this TileBrush control, Point position, Size size, RelativeUnit unit)
   => control._set(() => control.DestinationRect = new RelativeRect(position, size, unit));
public static TileBrush DestinationRect(this TileBrush control, Point topLeft, Point bottomRight, RelativeUnit unit)
   => control._set(() => control.DestinationRect = new RelativeRect(topLeft, bottomRight, unit));
public static TileBrush SourceRect(this TileBrush control, IBinding binding)
   => control._set(TileBrush.SourceRectProperty, binding);
public static TileBrush SourceRect(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.SourceRectProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush SourceRect(this TileBrush control, Func<RelativeRect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.SourceRectProperty, func, expression);
public static TileBrush SourceRect(this TileBrush control, RelativeRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static TileBrush SourceRect<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, RelativeRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static TileBrush SourceRect(this TileBrush control, Double x, Double y, Double width, Double height, RelativeUnit unit)
   => control._set(() => control.SourceRect = new RelativeRect(x, y, width, height, unit));
public static TileBrush SourceRect(this TileBrush control, Rect rect, RelativeUnit unit)
   => control._set(() => control.SourceRect = new RelativeRect(rect, unit));
public static TileBrush SourceRect(this TileBrush control, Size size, RelativeUnit unit)
   => control._set(() => control.SourceRect = new RelativeRect(size, unit));
public static TileBrush SourceRect(this TileBrush control, Point position, Size size, RelativeUnit unit)
   => control._set(() => control.SourceRect = new RelativeRect(position, size, unit));
public static TileBrush SourceRect(this TileBrush control, Point topLeft, Point bottomRight, RelativeUnit unit)
   => control._set(() => control.SourceRect = new RelativeRect(topLeft, bottomRight, unit));
public static TileBrush Stretch(this TileBrush control, IBinding binding)
   => control._set(TileBrush.StretchProperty, binding);
public static TileBrush Stretch(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.StretchProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush Stretch(this TileBrush control, Func<Stretch> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.StretchProperty, func, expression);
public static TileBrush Stretch(this TileBrush control, Stretch value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = value, bindingMode, converter, bindingSource);
public static TileBrush Stretch<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, Stretch> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.StretchProperty, ps, () => control.Stretch = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TileBrush TileMode(this TileBrush control, IBinding binding)
   => control._set(TileBrush.TileModeProperty, binding);
public static TileBrush TileMode(this TileBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TileBrush.TileModeProperty, avaloniaProperty, bindingMode, converter);
public static TileBrush TileMode(this TileBrush control, Func<TileMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TileBrush.TileModeProperty, func, expression);
public static TileBrush TileMode(this TileBrush control, TileMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = value, bindingMode, converter, bindingSource);
public static TileBrush TileMode<TValue>(this TileBrush control, TValue value, FuncValueConverter<TValue, TileMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TileBrush.TileModeProperty, ps, () => control.TileMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TransformGroupExtensions
{
public static TransformGroup Children(this TransformGroup control, IBinding binding)
   => control._set(TransformGroup.ChildrenProperty, binding);
public static TransformGroup Children(this TransformGroup control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TransformGroup.ChildrenProperty, avaloniaProperty, bindingMode, converter);
public static TransformGroup Children(this TransformGroup control, Func<Transforms> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TransformGroup.ChildrenProperty, func, expression);
public static TransformGroup Children(this TransformGroup control, Transforms value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransformGroup.ChildrenProperty, ps, () => control.Children = value, bindingMode, converter, bindingSource);
public static TransformGroup Children<TValue>(this TransformGroup control, TValue value, FuncValueConverter<TValue, Transforms> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TransformGroup.ChildrenProperty, ps, () => control.Children = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class TranslateTransformExtensions
{
public static TranslateTransform X(this TranslateTransform control, IBinding binding)
   => control._set(TranslateTransform.XProperty, binding);
public static TranslateTransform X(this TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TranslateTransform.XProperty, avaloniaProperty, bindingMode, converter);
public static TranslateTransform X(this TranslateTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TranslateTransform.XProperty, func, expression);
public static TranslateTransform X(this TranslateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.XProperty, ps, () => control.X = value, bindingMode, converter, bindingSource);
public static TranslateTransform X<TValue>(this TranslateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.XProperty, ps, () => control.X = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static TranslateTransform Y(this TranslateTransform control, IBinding binding)
   => control._set(TranslateTransform.YProperty, binding);
public static TranslateTransform Y(this TranslateTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(TranslateTransform.YProperty, avaloniaProperty, bindingMode, converter);
public static TranslateTransform Y(this TranslateTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(TranslateTransform.YProperty, func, expression);
public static TranslateTransform Y(this TranslateTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.YProperty, ps, () => control.Y = value, bindingMode, converter, bindingSource);
public static TranslateTransform Y<TValue>(this TranslateTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(TranslateTransform.YProperty, ps, () => control.Y = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class VisualBrushExtensions
{
public static VisualBrush Visual(this VisualBrush control, IBinding binding)
   => control._set(VisualBrush.VisualProperty, binding);
public static VisualBrush Visual(this VisualBrush control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(VisualBrush.VisualProperty, avaloniaProperty, bindingMode, converter);
public static VisualBrush Visual(this VisualBrush control, Func<Visual> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(VisualBrush.VisualProperty, func, expression);
public static VisualBrush Visual(this VisualBrush control, Visual value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VisualBrush.VisualProperty, ps, () => control.Visual = value, bindingMode, converter, bindingSource);
public static VisualBrush Visual<TValue>(this VisualBrush control, TValue value, FuncValueConverter<TValue, Visual> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(VisualBrush.VisualProperty, ps, () => control.Visual = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class Rotate3DTransformExtensions
{
public static Rotate3DTransform AngleX(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleXProperty, binding);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.AngleXProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleXProperty, func, expression);
public static Rotate3DTransform AngleX(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleXProperty, ps, () => control.AngleX = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleX<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleXProperty, ps, () => control.AngleX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleYProperty, binding);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.AngleYProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleYProperty, func, expression);
public static Rotate3DTransform AngleY(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleYProperty, ps, () => control.AngleY = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleY<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleYProperty, ps, () => control.AngleY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.AngleZProperty, binding);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.AngleZProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.AngleZProperty, func, expression);
public static Rotate3DTransform AngleZ(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleZProperty, ps, () => control.AngleZ = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform AngleZ<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.AngleZProperty, ps, () => control.AngleZ = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterXProperty, binding);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.CenterXProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterXProperty, func, expression);
public static Rotate3DTransform CenterX(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterXProperty, ps, () => control.CenterX = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterX<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterXProperty, ps, () => control.CenterX = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterYProperty, binding);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.CenterYProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterYProperty, func, expression);
public static Rotate3DTransform CenterY(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterYProperty, ps, () => control.CenterY = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterY<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterYProperty, ps, () => control.CenterY = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.CenterZProperty, binding);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.CenterZProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.CenterZProperty, func, expression);
public static Rotate3DTransform CenterZ(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterZProperty, ps, () => control.CenterZ = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform CenterZ<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.CenterZProperty, ps, () => control.CenterZ = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Rotate3DTransform Depth(this Rotate3DTransform control, IBinding binding)
   => control._set(Rotate3DTransform.DepthProperty, binding);
public static Rotate3DTransform Depth(this Rotate3DTransform control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Rotate3DTransform.DepthProperty, avaloniaProperty, bindingMode, converter);
public static Rotate3DTransform Depth(this Rotate3DTransform control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Rotate3DTransform.DepthProperty, func, expression);
public static Rotate3DTransform Depth(this Rotate3DTransform control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.DepthProperty, ps, () => control.Depth = value, bindingMode, converter, bindingSource);
public static Rotate3DTransform Depth<TValue>(this Rotate3DTransform control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Rotate3DTransform.DepthProperty, ps, () => control.Depth = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class CroppedBitmapExtensions
{
public static CroppedBitmap Source(this CroppedBitmap control, IBinding binding)
   => control._set(CroppedBitmap.SourceProperty, binding);
public static CroppedBitmap Source(this CroppedBitmap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CroppedBitmap.SourceProperty, avaloniaProperty, bindingMode, converter);
public static CroppedBitmap Source(this CroppedBitmap control, Func<IImage> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CroppedBitmap.SourceProperty, func, expression);
public static CroppedBitmap Source(this CroppedBitmap control, IImage value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = value, bindingMode, converter, bindingSource);
public static CroppedBitmap Source<TValue>(this CroppedBitmap control, TValue value, FuncValueConverter<TValue, IImage> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceProperty, ps, () => control.Source = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static CroppedBitmap SourceRect(this CroppedBitmap control, IBinding binding)
   => control._set(CroppedBitmap.SourceRectProperty, binding);
public static CroppedBitmap SourceRect(this CroppedBitmap control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(CroppedBitmap.SourceRectProperty, avaloniaProperty, bindingMode, converter);
public static CroppedBitmap SourceRect(this CroppedBitmap control, Func<PixelRect> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(CroppedBitmap.SourceRectProperty, func, expression);
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelRect value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = value, bindingMode, converter, bindingSource);
public static CroppedBitmap SourceRect<TValue>(this CroppedBitmap control, TValue value, FuncValueConverter<TValue, PixelRect> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(CroppedBitmap.SourceRectProperty, ps, () => control.SourceRect = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static CroppedBitmap SourceRect(this CroppedBitmap control, Int32 x, Int32 y, Int32 width, Int32 height)
   => control._set(() => control.SourceRect = new PixelRect(x, y, width, height));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelSize size)
   => control._set(() => control.SourceRect = new PixelRect(size));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelPoint position, PixelSize size)
   => control._set(() => control.SourceRect = new PixelRect(position, size));
public static CroppedBitmap SourceRect(this CroppedBitmap control, PixelPoint topLeft, PixelPoint bottomRight)
   => control._set(() => control.SourceRect = new PixelRect(topLeft, bottomRight));
}
public static partial class AnimatableExtensions
{
public static Animatable Transitions(this Animatable control, IBinding binding)
   => control._set(Animatable.TransitionsProperty, binding);
public static Animatable Transitions(this Animatable control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Animatable.TransitionsProperty, avaloniaProperty, bindingMode, converter);
public static Animatable Transitions(this Animatable control, Func<Transitions> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Animatable.TransitionsProperty, func, expression);
public static Animatable Transitions(this Animatable control, Transitions value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = value, bindingMode, converter, bindingSource);
public static Animatable Transitions<TValue>(this Animatable control, TValue value, FuncValueConverter<TValue, Transitions> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Animatable.TransitionsProperty, ps, () => control.Transitions = converter.TryConvert(value), bindingMode, converter, bindingSource);
}
public static partial class AnimationExtensions
{
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DurationProperty, binding);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.DurationProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DurationProperty, func, expression);
public static Avalonia.Animation.Animation Duration(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DurationProperty, ps, () => control.Duration = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Duration<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DurationProperty, ps, () => control.Duration = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, binding);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, Func<IterationCount> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.IterationCountProperty, func, expression);
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, IterationCount value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.IterationCountProperty, ps, () => control.IterationCount = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation IterationCount<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, IterationCount> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.IterationCountProperty, ps, () => control.IterationCount = converter.TryConvert(value), bindingMode, converter, bindingSource);

public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, UInt64 value)
   => control._set(() => control.IterationCount = new IterationCount(value));
public static Avalonia.Animation.Animation IterationCount(this Avalonia.Animation.Animation control, UInt64 value, IterationType type)
   => control._set(() => control.IterationCount = new IterationCount(value, type));
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, binding);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, Func<PlaybackDirection> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.PlaybackDirectionProperty, func, expression);
public static Avalonia.Animation.Animation PlaybackDirection(this Avalonia.Animation.Animation control, PlaybackDirection value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.PlaybackDirectionProperty, ps, () => control.PlaybackDirection = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation PlaybackDirection<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, PlaybackDirection> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.PlaybackDirectionProperty, ps, () => control.PlaybackDirection = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, binding);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, Func<FillMode> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.FillModeProperty, func, expression);
public static Avalonia.Animation.Animation FillMode(this Avalonia.Animation.Animation control, FillMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.FillModeProperty, ps, () => control.FillMode = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation FillMode<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, FillMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.FillModeProperty, ps, () => control.FillMode = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.EasingProperty, binding);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.EasingProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Func<Easing> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.EasingProperty, func, expression);
public static Avalonia.Animation.Animation Easing(this Avalonia.Animation.Animation control, Easing value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.EasingProperty, ps, () => control.Easing = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Easing<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, Easing> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.EasingProperty, ps, () => control.Easing = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DelayProperty, binding);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.DelayProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DelayProperty, func, expression);
public static Avalonia.Animation.Animation Delay(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayProperty, ps, () => control.Delay = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation Delay<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayProperty, ps, () => control.Delay = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, binding);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, Func<TimeSpan> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, func, expression);
public static Avalonia.Animation.Animation DelayBetweenIterations(this Avalonia.Animation.Animation control, TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, ps, () => control.DelayBetweenIterations = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation DelayBetweenIterations<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.DelayBetweenIterationsProperty, ps, () => control.DelayBetweenIterations = converter.TryConvert(value), bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, IBinding binding)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, binding);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, avaloniaProperty, bindingMode, converter);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Func<Double> func, [CallerArgumentExpression("func")] string? expression = null)
   => control._set(Avalonia.Animation.Animation.SpeedRatioProperty, func, expression);
public static Avalonia.Animation.Animation SpeedRatio(this Avalonia.Animation.Animation control, Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.SpeedRatioProperty, ps, () => control.SpeedRatio = value, bindingMode, converter, bindingSource);
public static Avalonia.Animation.Animation SpeedRatio<TValue>(this Avalonia.Animation.Animation control, TValue value, FuncValueConverter<TValue, Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)=> control._setEx(Avalonia.Animation.Animation.SpeedRatioProperty, ps, () => control.SpeedRatio = converter.TryConvert(value), bindingMode, converter, bindingSource);
}

