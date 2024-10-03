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
public static partial class CalendarItem_MarkupExtensions
{
//================= Properties ======================//
 // HeaderBackground

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control,Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem HeaderBackground<TValue>(this Avalonia.Controls.Primitives.CalendarItem control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DayTitleTemplate

/*BindFromExpressionSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, Func<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> func, Action<Avalonia.Controls.ITemplate<Avalonia.Controls.Control>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control,Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, IBinding binding)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate(this Avalonia.Controls.Primitives.CalendarItem control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null)  
   => control._set(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static Avalonia.Controls.Primitives.CalendarItem DayTitleTemplate<TValue>(this Avalonia.Controls.Primitives.CalendarItem control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.ITemplate<Avalonia.Controls.Control>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null)  
=> control._setEx(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, ps, () => control.DayTitleTemplate = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Styles ======================//
 // HeaderBackground

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Media.IBrush value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> HeaderBackground(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.HeaderBackgroundProperty, binding);


 // DayTitleTemplate

/*ValueStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, Avalonia.Controls.ITemplate<Avalonia.Controls.Control> value)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<Avalonia.Controls.Primitives.CalendarItem> DayTitleTemplate(this Style<Avalonia.Controls.Primitives.CalendarItem> style, IBinding binding)  
=> style._addSetter(Avalonia.Controls.Primitives.CalendarItem.DayTitleTemplateProperty, binding);



}
