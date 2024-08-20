#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class StackPanel_MarkupExtensions
{
//================= Properties ======================//
 // SpacingProperty

/*BindFromExpressionSetterGenerator*/
public static T Spacing<T>(this T control, Func<System.Double> func, Action<System.Double>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Spacing<T>(this T control, System.Double value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.SpacingProperty, ps, () => control.Spacing = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Spacing<T>(this T control, IBinding binding) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Spacing<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.SpacingProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Spacing<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Double> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.SpacingProperty, ps, () => control.Spacing = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // OrientationProperty

/*BindFromExpressionSetterGenerator*/
public static T Orientation<T>(this T control, Func<Avalonia.Layout.Orientation> func, Action<Avalonia.Layout.Orientation>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T Orientation<T>(this T control, Avalonia.Layout.Orientation value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.OrientationProperty, ps, () => control.Orientation = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T Orientation<T>(this T control, IBinding binding) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T Orientation<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.OrientationProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T Orientation<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Layout.Orientation> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.OrientationProperty, ps, () => control.Orientation = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AreHorizontalSnapPointsRegularProperty

/*BindFromExpressionSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AreHorizontalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AreHorizontalSnapPointsRegular<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, ps, () => control.AreHorizontalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // AreVerticalSnapPointsRegularProperty

/*BindFromExpressionSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, IBinding binding) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T AreVerticalSnapPointsRegular<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.StackPanel
   => control._set(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T AreVerticalSnapPointsRegular<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.StackPanel
=> control._setEx(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, ps, () => control.AreVerticalSnapPointsRegular = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // HorizontalSnapPointsChanged

/*ActionToEventGenerator*/
    public static T OnHorizontalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.StackPanel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.HorizontalSnapPointsChanged += h);


 // VerticalSnapPointsChanged

/*ActionToEventGenerator*/
    public static T OnVerticalSnapPointsChanged<T>(this T control, Action<Avalonia.Interactivity.RoutedEventArgs> action) where T : Avalonia.Controls.StackPanel => 
        control._setEvent((System.EventHandler<Avalonia.Interactivity.RoutedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.VerticalSnapPointsChanged += h);



//================= Styles ======================//
 // SpacingProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, System.Double value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Spacing<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.SpacingProperty, binding);


 // OrientationProperty

/*ValueStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, Avalonia.Layout.Orientation value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> Orientation<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.OrientationProperty, binding);


 // AreHorizontalSnapPointsRegularProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AreHorizontalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreHorizontalSnapPointsRegularProperty, binding);


 // AreVerticalSnapPointsRegularProperty

/*ValueStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> AreVerticalSnapPointsRegular<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.StackPanel
=> style._addSetter(Avalonia.Controls.StackPanel.AreVerticalSnapPointsRegularProperty, binding);



}
