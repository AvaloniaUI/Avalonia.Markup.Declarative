#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class SelectingItemsControl_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItemProperty

/*BindFromExpressionSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AutoScrollToSelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedIndexProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedIndex<T>(this T control, Func<System.Int32> func, Action<System.Int32>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedIndex<T>(this T control, System.Int32 value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedIndex<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedIndex<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedIndex<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Int32> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedIndexProperty, ps, () => control.SelectedIndex = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedItemProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedItem<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedItem<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedValueProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedValue<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedValue<T>(this T control, System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedValue<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedValue<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedValue<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, ps, () => control.SelectedValue = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedValueBindingProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Func<Avalonia.Data.IBinding> func, Action<Avalonia.Data.IBinding>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, Avalonia.Data.IBinding value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedValueBinding<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedValueBinding<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Data.IBinding> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, ps, () => control.SelectedValueBinding = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTextSearchEnabledProperty

/*BindFromExpressionSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTextSearchEnabled<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTextSearchEnabled<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, ps, () => control.IsTextSearchEnabled = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // WrapSelectionProperty

/*BindFromExpressionSetterGenerator*/
public static T WrapSelection<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T WrapSelection<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T WrapSelection<T>(this T control, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T WrapSelection<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
   => control._set(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T WrapSelection<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> control._setEx(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, ps, () => control.WrapSelection = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
    public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.Primitives.SelectingItemsControl => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // AutoScrollToSelectedItemProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.AutoScrollToSelectedItemProperty, binding);


 // SelectedValueProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, System.Object value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedValue<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueProperty, binding);


 // SelectedValueBindingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedValueBinding<T>(this Style<T> style, Avalonia.Data.IBinding value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.SelectedValueBindingProperty, value);

/*BindingStyleSetterGenerator*/
//Skipped SelectedValueBinding because already exist in value setters


 // IsTextSearchEnabledProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTextSearchEnabled<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.IsTextSearchEnabledProperty, binding);


 // WrapSelectionProperty

/*ValueStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> WrapSelection<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Primitives.SelectingItemsControl
=> style._addSetter(Avalonia.Controls.Primitives.SelectingItemsControl.WrapSelectionProperty, binding);



}
