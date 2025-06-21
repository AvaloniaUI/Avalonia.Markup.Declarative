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
public static partial class DateRangePicker_MarkupExtensions
{
//================= Properties ======================//
 // SelectedStartDate

/*ValueSetterGenerator*/
public static T SelectedStartDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateRangePicker 
=> control._set(() => control.SelectedStartDate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedStartDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedStartDateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedStartDate<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.SelectedStartDateProperty, ps, () => control.SelectedStartDate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedStartDate<T>(this T control, IBinding binding) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedStartDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedStartDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedStartDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedStartDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.SelectedStartDateProperty, ps, () => control.SelectedStartDate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // SelectedEndDate

/*ValueSetterGenerator*/
public static T SelectedEndDate<T>(this T control, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateRangePicker 
=> control._set(() => control.SelectedEndDate = value!);

/*BindFromExpressionSetterGenerator*/
public static T SelectedEndDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedEndDateProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T SelectedEndDate<T>(this T control,System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.SelectedEndDateProperty, ps, () => control.SelectedEndDate = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedEndDate<T>(this T control, IBinding binding) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedEndDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedEndDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.SelectedEndDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T SelectedEndDate<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.SelectedEndDateProperty, ps, () => control.SelectedEndDate = converter.TryConvert(value)!, bindingMode, converter, bindingSource);


 // EnableMonthSync

/*ValueSetterGenerator*/
public static T EnableMonthSync<T>(this T control, System.Boolean value) where T : Ursa.Controls.DateRangePicker 
=> control._set(() => control.EnableMonthSync = value!);

/*BindFromExpressionSetterGenerator*/
public static T EnableMonthSync<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression(nameof(func))] string? expression = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty!, func, onChanged, expression);

/*MagicalSetterGenerator*/
[Obsolete]
public static T EnableMonthSync<T>(this T control,System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty, ps, () => control.EnableMonthSync = value!, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T EnableMonthSync<T>(this T control, IBinding binding) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T EnableMonthSync<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Ursa.Controls.DateRangePicker 
   => control._set(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
[Obsolete]
public static T EnableMonthSync<TValue,T>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression(nameof(value))] string? ps = null) where T : Ursa.Controls.DateRangePicker 
=> control._setEx(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty, ps, () => control.EnableMonthSync = converter.TryConvert(value)!, bindingMode, converter, bindingSource);



//================= Styles ======================//
 // SelectedStartDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedStartDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.SelectedStartDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedStartDate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.SelectedStartDateProperty, binding);


 // SelectedEndDate

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedEndDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.SelectedEndDateProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedEndDate<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.SelectedEndDateProperty, binding);


 // EnableMonthSync

/*ValueStyleSetterGenerator*/
public static Style<T> EnableMonthSync<T>(this Style<T> style, System.Boolean value) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty!, value!);

/*BindingStyleSetterGenerator*/
public static Style<T> EnableMonthSync<T>(this Style<T> style, IBinding binding) where T : Ursa.Controls.DateRangePicker 
=> style._addSetter(Ursa.Controls.DateRangePicker.EnableMonthSyncProperty, binding);



}
