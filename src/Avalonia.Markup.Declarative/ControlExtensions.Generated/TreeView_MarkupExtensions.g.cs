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
public static partial class TreeView_MarkupExtensions
{
//================= Properties ======================//
 // AutoScrollToSelectedItem

/*BindFromExpressionSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AutoScrollToSelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AutoScrollToSelectedItem<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, ps, () => control.AutoScrollToSelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedItem

/*BindFromExpressionSetterGenerator*/
public static T SelectedItem<T>(this T control, Func<System.Object> func, Action<System.Object>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedItem<T>(this T control,System.Object value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectedItemProperty, ps, () => control.SelectedItem = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItem<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItem<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedItem<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Object> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectedItemProperty, ps, () => control.SelectedItem = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedItems

/*BindFromExpressionSetterGenerator*/
public static T SelectedItems<T>(this T control, Func<System.Collections.IList> func, Action<System.Collections.IList>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedItems<T>(this T control,System.Collections.IList value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedItems<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedItems<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectedItemsProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedItems<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Collections.IList> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectedItemsProperty, ps, () => control.SelectedItems = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionMode

/*BindFromExpressionSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.SelectionMode> func, Action<Avalonia.Controls.SelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionMode<T>(this T control,Avalonia.Controls.SelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.TreeView 
   => control._set(Avalonia.Controls.TreeView.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionMode<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.SelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.TreeView 
=> control._setEx(Avalonia.Controls.TreeView.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectionChanged

/*ActionToEventGenerator*/
    public static T OnSelectionChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.TreeView => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectionChanged += h);



//================= Styles ======================//
 // AutoScrollToSelectedItem

/*ValueStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AutoScrollToSelectedItem<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.AutoScrollToSelectedItemProperty, binding);


 // SelectionMode

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.SelectionMode value) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.TreeView 
=> style._addSetter(Avalonia.Controls.TreeView.SelectionModeProperty, binding);



}
