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
public static partial class AutoCompleteBox_MarkupExtensions
{
//================= Properties ======================//
 // CaretIndex

/*BindFromExpressionSetterGenerator*/
public static T CaretIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T CaretIndex<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T CaretIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T CaretIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T CaretIndex<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, ps, () => control.CaretIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Watermark

/*BindFromExpressionSetterGenerator*/
public static T Watermark<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Watermark<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Watermark<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Watermark<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Watermark<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, ps, () => control.Watermark = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinimumPrefixLength

/*BindFromExpressionSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinimumPrefixLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinimumPrefixLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, ps, () => control.MinimumPrefixLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MinimumPopulateDelay

/*BindFromExpressionSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, Func<System.TimeSpan> func, Action<System.TimeSpan>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control,System.TimeSpan value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MinimumPopulateDelay<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MinimumPopulateDelay<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.TimeSpan> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, ps, () => control.MinimumPopulateDelay = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxDropDownHeight

/*BindFromExpressionSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control,System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxDropDownHeight<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxDropDownHeight<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, ps, () => control.MaxDropDownHeight = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTextCompletionEnabled

/*BindFromExpressionSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTextCompletionEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTextCompletionEnabled<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, ps, () => control.IsTextCompletionEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemTemplate

/*BindFromExpressionSetterGenerator*/
public static T ItemTemplate<T>(this T control, Func<Avalonia.Controls.Templates.IDataTemplate> func, Action<Avalonia.Controls.Templates.IDataTemplate>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemTemplate<T>(this T control,Avalonia.Controls.Templates.IDataTemplate value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemTemplate<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemTemplate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemTemplate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.Templates.IDataTemplate> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, ps, () => control.ItemTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsDropDownOpen

/*BindFromExpressionSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsDropDownOpen<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsDropDownOpen<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsDropDownOpen<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, ps, () => control.IsDropDownOpen = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedItem

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedItem<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedItem<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // Text

/*BindFromExpressionSetterGenerator*/
public static T Text<T>(this T control, Func<System.String> func, Action<System.String>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Text<T>(this T control,System.String value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextProperty, ps, () => control.Text = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Text<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Text<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Text<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.String> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextProperty, ps, () => control.Text = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // FilterMode

/*BindFromExpressionSetterGenerator*/
public static T FilterMode<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterMode> func, Action<Avalonia.Controls.AutoCompleteFilterMode>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FilterMode<T>(this T control,Avalonia.Controls.AutoCompleteFilterMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FilterMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FilterMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FilterMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, ps, () => control.FilterMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemFilter

/*BindFromExpressionSetterGenerator*/
public static T ItemFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemFilter<T>(this T control,Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemFilter<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemFilter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, ps, () => control.ItemFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextFilter

/*BindFromExpressionSetterGenerator*/
public static T TextFilter<T>(this T control, Func<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> func, Action<Avalonia.Controls.AutoCompleteFilterPredicate<System.String>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextFilter<T>(this T control,Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextFilter<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextFilter<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextFilter<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteFilterPredicate<System.String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, ps, () => control.TextFilter = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemSelector

/*BindFromExpressionSetterGenerator*/
public static T ItemSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.Object>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.Object>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemSelector<T>(this T control,Avalonia.Controls.AutoCompleteSelector<System.Object> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemSelector<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemSelector<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteSelector<System.Object>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, ps, () => control.ItemSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // TextSelector

/*BindFromExpressionSetterGenerator*/
public static T TextSelector<T>(this T control, Func<Avalonia.Controls.AutoCompleteSelector<System.String>> func, Action<Avalonia.Controls.AutoCompleteSelector<System.String>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T TextSelector<T>(this T control,Avalonia.Controls.AutoCompleteSelector<System.String> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T TextSelector<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T TextSelector<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T TextSelector<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.AutoCompleteSelector<System.String>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, ps, () => control.TextSelector = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // ItemsSource

/*BindFromExpressionSetterGenerator*/
public static T ItemsSource<T>(this T control, Func<System.Collections.IEnumerable> func, Action<System.Collections.IEnumerable>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T ItemsSource<T>(this T control,System.Collections.IEnumerable value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T ItemsSource<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T ItemsSource<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T ItemsSource<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IEnumerable> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, ps, () => control.ItemsSource = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AsyncPopulator

/*BindFromExpressionSetterGenerator*/
public static T AsyncPopulator<T>(this T control, Func<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> func, Action<System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AsyncPopulator<T>(this T control,System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AsyncPopulator<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AsyncPopulator<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AsyncPopulator<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, ps, () => control.AsyncPopulator = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // MaxLength

/*BindFromExpressionSetterGenerator*/
public static T MaxLength<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T MaxLength<T>(this T control,System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T MaxLength<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T MaxLength<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T MaxLength<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, ps, () => control.MaxLength = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerLeftContent

/*BindFromExpressionSetterGenerator*/
public static T InnerLeftContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerLeftContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerLeftContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerLeftContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, ps, () => control.InnerLeftContent = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // InnerRightContent

/*BindFromExpressionSetterGenerator*/
public static T InnerRightContent<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T InnerRightContent<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T InnerRightContent<T>(this T control, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T InnerRightContent<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.AutoCompleteBox 
   => control._set(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T InnerRightContent<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Avalonia.Controls.AutoCompleteBox 
=> control._setEx(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, ps, () => control.InnerRightContent = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // TextChanged

/*ActionToEventGenerator*/
public static T OnTextChanged<T>(this T control, Action<Avalonia.Controls.TextChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.AutoCompleteBox 
{
  if (routes == 0) routes = Avalonia.Controls.AutoCompleteBox.TextChangedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.TextChangedEvent, (_, args) => action(args), routes);
  return control; 
}



 // Populating

/*ActionToEventGenerator*/
public static T OnPopulating<T>(this T control, Action<Avalonia.Controls.PopulatingEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatingEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populating += h);


 // Populated

/*ActionToEventGenerator*/
public static T OnPopulated<T>(this T control, Action<Avalonia.Controls.PopulatedEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<Avalonia.Controls.PopulatedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.Populated += h);


 // DropDownOpening

/*ActionToEventGenerator*/
public static T OnDropDownOpening<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownOpening += h);


 // DropDownOpened

/*ActionToEventGenerator*/
public static T OnDropDownOpened<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownOpened += h);


 // DropDownClosing

/*ActionToEventGenerator*/
public static T OnDropDownClosing<T>(this T control, Action<System.ComponentModel.CancelEventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler<System.ComponentModel.CancelEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DropDownClosing += h);


 // DropDownClosed

/*ActionToEventGenerator*/
public static T OnDropDownClosed<T>(this T control, Action<System.EventArgs> action) where T : Avalonia.Controls.AutoCompleteBox  => 
 control._setEvent((System.EventHandler) ((arg0, arg1) => action(arg1)), h => control.DropDownClosed += h);


 // SelectionChanged

/*ActionToEventGenerator*/
public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action, Avalonia.Interactivity.RoutingStrategies routes = 0) where T : Avalonia.Controls.AutoCompleteBox 
{
  if (routes == 0) routes = Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent.RoutingStrategies;
  control.AddHandler(Avalonia.Controls.AutoCompleteBox.SelectionChangedEvent, (_, args) => action(args), routes);
  return control; 
}




//================= Styles ======================//
 // CaretIndex

/*ValueStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> CaretIndex<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.CaretIndexProperty, binding);


 // Watermark

/*ValueStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Watermark<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.WatermarkProperty, binding);


 // MinimumPrefixLength

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPrefixLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPrefixLengthProperty, binding);


 // MinimumPopulateDelay

/*ValueStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, System.TimeSpan value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MinimumPopulateDelay<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MinimumPopulateDelayProperty, binding);


 // MaxDropDownHeight

/*ValueStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxDropDownHeight<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxDropDownHeightProperty, binding);


 // IsTextCompletionEnabled

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextCompletionEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsTextCompletionEnabledProperty, binding);


 // ItemTemplate

/*ValueStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, Avalonia.Controls.Templates.IDataTemplate value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemTemplate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemTemplateProperty, binding);


 // IsDropDownOpen

/*ValueStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsDropDownOpen<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.IsDropDownOpenProperty, binding);


 // SelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.SelectedItemProperty, binding);


 // Text

/*ValueStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, System.String value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Text<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextProperty, binding);


 // FilterMode

/*ValueStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterMode value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FilterMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.FilterModeProperty, binding);


 // ItemFilter

/*ValueStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemFilterProperty, binding);


 // TextFilter

/*ValueStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, Avalonia.Controls.AutoCompleteFilterPredicate<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextFilter<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextFilterProperty, binding);


 // ItemSelector

/*ValueStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.Object> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemSelectorProperty, binding);


 // TextSelector

/*ValueStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, Avalonia.Controls.AutoCompleteSelector<System.String> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> TextSelector<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.TextSelectorProperty, binding);


 // ItemsSource

/*ValueStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, System.Collections.IEnumerable value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> ItemsSource<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.ItemsSourceProperty, binding);


 // AsyncPopulator

/*ValueStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, System.Func<System.String,System.Threading.CancellationToken,System.Threading.Tasks.Task<System.Collections.Generic.IEnumerable<System.Object>>> value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AsyncPopulator<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.AsyncPopulatorProperty, binding);


 // MaxLength

/*ValueStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, System.Int32 value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> MaxLength<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.MaxLengthProperty, binding);


 // InnerLeftContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerLeftContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerLeftContentProperty, binding);


 // InnerRightContent

/*ValueStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> InnerRightContent<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.AutoCompleteBox 
=> style._addSetter(Avalonia.Controls.AutoCompleteBox.InnerRightContentProperty, binding);



}
